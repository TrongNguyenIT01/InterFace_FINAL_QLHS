using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class BangDiemMon : Form
    {
        public BangDiemMon()
        {
            InitializeComponent();
        }

        private void load_cb()
        {
            string sql_Lop = $"Select MaLop From Lop";
            string sql_HK = $"Select HocKy + ' - ' + MaNamHoc AS HienThi, MaNamHoc, MaHK, MaNamHoc From HocKy";
            string sql_MH = $"Select MaMon, TenMon From MonHoc";


            DataTable Lop = DataProvider.TruyVan_LayDuLieu(sql_Lop);
            DataTable HK = DataProvider.TruyVan_LayDuLieu(sql_HK);
            DataTable MH = DataProvider.TruyVan_LayDuLieu(sql_MH);

            cbNhapLop.DataSource = Lop;
            cbNhapLop.DisplayMember = "MaLop";
            cbNhapLop.ValueMember = "MaLop";
            cbNhapLop.SelectedIndex = -1; 

            cbHocKy.DataSource = HK;
            cbHocKy.DisplayMember = "HienThi";
            cbHocKy.ValueMember = "MaHK";
            cbHocKy.SelectedIndex = -1;

            cbMon.DataSource = MH;
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
            cbMon.SelectedIndex = -1;


        }
        private void HienThiBangDiem()
        {
            try
            {
                // 1. Lấy giá trị từ các ComboBox
                if (cbNhapLop.SelectedValue == null || cbHocKy.SelectedValue == null || cbMon.SelectedValue == null)
                {
                    MessageBox.Show($"Vui lòng chọn đầy đủ Lớp, Học Kỳ và Môn học!","Cảnh Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                string maLop = cbNhapLop.SelectedValue.ToString();
                string maHK = cbHocKy.SelectedValue.ToString();
                string maMon = cbMon.SelectedValue.ToString();

                DataRowView drvHK = (DataRowView)cbHocKy.SelectedItem;
                string maNamHoc = drvHK["MaNamHoc"].ToString();

                // Khởi tạo DataTable 
                DataTable dtBangDiem = new DataTable();
                dtBangDiem.Columns.Add("MaHS", typeof(string));
                dtBangDiem.Columns.Add("HoTen", typeof(string));

                // Truy vấn kết hợp QuyDinhDiem và LoaiDiem để lấy trực tiếp TenLoaiDiem
                string sqlQuyDinh = $@"
            SELECT q.MaLoaiDiem, l.TenLoaiDiem, q.SoLanKT 
            FROM QuyDinhDiem q
            JOIN LoaiDiem l ON q.MaLoaiDiem = l.MaLoaiDiem
            WHERE q.MaMon = '{maMon}'";
                DataTable dtQuyDinh = DataProvider.TruyVan_LayDuLieu(sqlQuyDinh);

                // Dùng Dictionary để map tên cột trong DataTable với tên Header muốn hiển thị
                Dictionary<string, string> dictHeaders = new Dictionary<string, string>();

                foreach (DataRow row in dtQuyDinh.Rows)
                {
                    string maLoaiDiem = row["MaLoaiDiem"].ToString();
                    string tenLoaiDiem = row["TenLoaiDiem"].ToString();
                    int soLan = Convert.ToInt32(row["SoLanKT"]);
                    if (tenLoaiDiem.ToLower().Contains("cuối kỳ"))
                    {
                        continue;
                    }

                    for (int i = 1; i <= soLan; i++)
                    {
                        string colName = $"{maLoaiDiem}_L{i}"; // Tên cột hệ thống
                        dtBangDiem.Columns.Add(colName, typeof(string));

                        // Tên hiển thị (VD: Điểm 15 phút lần 1)
                        dictHeaders.Add(colName, $"{tenLoaiDiem} lần {i}");
                    }
                }
                // Thêm cột điểm cuối kỳ
                dtBangDiem.Columns.Add("DiemCK", typeof(string));
                dtBangDiem.Columns.Add("DiemTB", typeof(string));

                // 3. Lấy danh sách Học sinh
                string sqlHocSinh = $@"
                    SELECT hs.MaHS, hs.HoTen,
                           dbo.fn_TinhDiemTBMon(hs.MaHS, '{maMon}', '{maHK}') AS DiemTB
                    FROM HocSinh hs 
                    JOIN QuaTrinhHocTap qt ON hs.MaHS = qt.MaHS 
                    WHERE qt.MaLop = '{maLop}' AND qt.MaNamHoc = '{maNamHoc}' AND qt.TrangThai = N'Đang Học'";

                DataTable dtHocSinh = DataProvider.TruyVan_LayDuLieu(sqlHocSinh);

                // 4. Lấy dữ liệu điểm thành phần và cuối kỳ
                string sqlDiemTP = $"SELECT MaHS, MaLoaiDiem, LanKiemTra, GiaTriDiem FROM DiemThanhPhan WHERE MaMon = '{maMon}' AND MaHK = '{maHK}'";
                DataTable dtDiemTP = DataProvider.TruyVan_LayDuLieu(sqlDiemTP);

                string sqlDiemCK = $"SELECT MaHS, Diem FROM DiemCk WHERE MaLop = '{maLop}' AND MaHK = '{maHK}' AND MaMon = '{maMon}'";
                DataTable dtDiemCK = DataProvider.TruyVan_LayDuLieu(sqlDiemCK);

                // 5. Ráp dữ liệu vào DataTable
                foreach (DataRow hs in dtHocSinh.Rows)
                {
                    DataRow newRow = dtBangDiem.NewRow();
                    string hsMa = hs["MaHS"].ToString();
                    newRow["MaHS"] = hsMa;
                    newRow["HoTen"] = hs["HoTen"].ToString();
                    newRow["DiemTB"] = hs["DiemTB"].ToString();

                    // Ráp Điểm Thành Phần
                    DataRow[] diemTP_cuaHS = dtDiemTP.Select($"MaHS = '{hsMa}'");
                    foreach (DataRow diem in diemTP_cuaHS)
                    {
                        string maLoai = diem["MaLoaiDiem"].ToString();
                        string lan = diem["LanKiemTra"].ToString();
                        string colCheck = $"{maLoai}_L{lan}";

                        if (dtBangDiem.Columns.Contains(colCheck))
                        {
                            newRow[colCheck] = diem["GiaTriDiem"].ToString();
                        }
                    }

                    // Ráp Điểm Cuối Kỳ
                    DataRow[] diemCK_cuaHS = dtDiemCK.Select($"MaHS = '{hsMa}'");
                    if (diemCK_cuaHS.Length > 0)
                    {
                        newRow["DiemCK"] = diemCK_cuaHS[0]["Diem"].ToString();
                    }

                    dtBangDiem.Rows.Add(newRow);
                }

                // 6. Gán lên DataGridView và đổi tên Header đẹp mắt
                dgvBangDiemMon.DataSource = dtBangDiem;

                dgvBangDiemMon.Columns["MaHS"].HeaderText = "Mã Học Sinh";
                dgvBangDiemMon.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvBangDiemMon.Columns["DiemCK"].HeaderText = "Điểm Thi Cuối Kỳ";
                dgvBangDiemMon.Columns["DiemTB"].HeaderText = "Trung Bình Môn";

                dgvBangDiemMon.Columns["DiemCK"].DisplayIndex = dgvBangDiemMon.Columns.Count - 2;
                dgvBangDiemMon.Columns["DiemTB"].DisplayIndex = dgvBangDiemMon.Columns.Count - 1;

                // Gán Header cho các cột điểm động dựa vào Dictionary
                foreach (var header in dictHeaders)
                {
                    if (dgvBangDiemMon.Columns.Contains(header.Key))
                    {
                        dgvBangDiemMon.Columns[header.Key].HeaderText = header.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"lỗi : " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BangDiemMon_Load(object sender, EventArgs e)
        {
            load_cb();
        }

        private void btnTimBangDiemMon_Click(object sender, EventArgs e)
        {
            HienThiBangDiem();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvBangDiemMon.Rows.Count == 0 || dgvBangDiemMon.Columns.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExcelPackage.License.SetNonCommercialPersonal("My Name");

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx", FileName = $"Bang_Diem_Mon_{cbMon.Text}_Lop_{cbNhapLop.SelectedValue.ToString()}.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo file = new FileInfo(sfd.FileName);
                        using (ExcelPackage package = new ExcelPackage(file))
                        {
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("NhapDiem");

                            //  dòng 1 làm dòng CHỨA TÊN CỘT THẬT 
                            for (int i = 0; i < dgvBangDiemMon.Columns.Count; i++)
                            {
                                ws.Cells[1, i + 1].Value = dgvBangDiemMon.Columns[i].Name; // VD: Diem_TP_1
                            }
                            ws.Row(1).Hidden = true; // Ẩn dòng mã cột 

                            //  Dùng dòng 2 làm HEADER TEXT 
                            for (int i = 0; i < dgvBangDiemMon.Columns.Count; i++)
                            {
                                ws.Cells[2, i + 1].Value = dgvBangDiemMon.Columns[i].HeaderText;
                                ws.Cells[2, i + 1].Style.Font.Bold = true;
                            }

                            //  Đổ dữ liệu từ DGV xuống - từ dòng 3
                            for (int i = 0; i < dgvBangDiemMon.Rows.Count; i++)
                            {
                                if (dgvBangDiemMon.Rows[i].IsNewRow) continue;
                                for (int j = 0; j < dgvBangDiemMon.Columns.Count; j++)
                                {
                                    ws.Cells[i + 3, j + 1].Value = dgvBangDiemMon.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // AutoFit các cột 
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            package.Save();
                            MessageBox.Show("Xuất file điểm thành công!.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
