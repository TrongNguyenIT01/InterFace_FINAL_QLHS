using InterFace_FINAL_QLHS.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OfficeOpenXml;
using System.IO;

namespace InterFace_FINAL_QLHS.GiaoVien
{
    public partial class NhapDiem : Form
    {
        string IDGV = Session.UserName;

        string TenGV = "";
        public NhapDiem()
        {
            InitializeComponent();

           
            string sql = $"Select HoTen From GiaoVien Where GiaoVienID='{IDGV}'";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                TenGV = dt.Rows[0]["HoTen"].ToString();
            }
            else
            {
                TenGV = "Không xác định";
               
                MessageBox.Show($"Không tìm thấy giáo viên có mã: '{IDGV}' trong CSDL.", "Thông báo lỗi");
            }
        }

        private void load_CB()
        {
            string sql = @"
                SELECT pc.*, mh.TenMon
                FROM PhanCongGiangDay pc
                JOIN MonHoc mh ON pc.MaMon = mh.MaMon
                WHERE pc.GiaoVienID = @IDGV";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@IDGV", IDGV)
            };

   
            DataTable dtPhanCong = DataProvider.SelectData(sql, CommandType.Text, parameters);

            if (dtPhanCong != null && dtPhanCong.Rows.Count > 0)
            {
                
                DataView viewLop = new DataView(dtPhanCong);
                cbChonLop.DataSource = viewLop.ToTable(true, "MaLop");
                cbChonLop.DisplayMember = "MaLop";
                cbChonLop.ValueMember = "MaLop";

                DataView viewHocKy = new DataView(dtPhanCong);
                cbChonHocKy.DataSource = viewHocKy.ToTable(true, "MaHK");
                cbChonHocKy.DisplayMember = "MaHK";
                cbChonHocKy.ValueMember = "MaHK";

                DataView viewMonHoc = new DataView(dtPhanCong);
                cbMonHoc.DataSource = viewMonHoc.ToTable(true, "MaMon", "TenMon");
                cbMonHoc.DisplayMember = "TenMon";
                cbMonHoc.ValueMember = "MaMon";
            }
        }
        private void LoadDiemLopHoc()
        {
            string MaLop = cbChonLop.SelectedValue?.ToString() ?? "";
            string MaMon = cbMonHoc.SelectedValue?.ToString() ?? "";
            string MaHK = cbChonHocKy.SelectedValue?.ToString() ?? ""; 

            if (string.IsNullOrEmpty(MaLop) || string.IsNullOrEmpty(MaMon) || string.IsNullOrEmpty(MaHK))
            {
                MessageBox.Show(@"Vui lòng nhập đầy đủ thông tin Lớp, Môn, Học Kỳ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtDiem = new DataTable();

           
            dtDiem.Columns.Add("MaHS", typeof(string));
            dtDiem.Columns.Add("HoTen", typeof(string));
            dtDiem.Columns.Add("MaLop", typeof(string));

            //sinh cột động
            string sqlCauTruc = @"
                    SELECT qd.MaLoaiDiem, ld.TenLoaiDiem, qd.SoLanKT 
                    FROM QuyDinhDiem qd
                    JOIN LoaiDiem ld ON qd.MaLoaiDiem = ld.MaLoaiDiem
                    WHERE qd.MaMon = @MaMon";

            SqlParameter[] paraCauTruc = { new SqlParameter("@MaMon", MaMon) };
            DataTable dtCauTruc = DataProvider.SelectData(sqlCauTruc, CommandType.Text, paraCauTruc);

            if (dtCauTruc != null && dtCauTruc.Rows.Count > 0)
            {
                foreach (DataRow row in dtCauTruc.Rows)
                {
                    string maLoaiDiem = row["MaLoaiDiem"].ToString().Trim();
                    int soLanKT = Convert.ToInt32(row["SoLanKT"]);

                    for (int i = 1; i <= soLanKT; i++)
                    {
                        string colName = $"Diem_{maLoaiDiem}_{i}";
                        dtDiem.Columns.Add(colName, typeof(string));
                    }
                }
            }

            //lấy danh sách Học Sinh đưa vào bảng
            string sqlHocSinh = @"
                SELECT hs.MaHS, hs.HoTen, qt.MaLop
                FROM HocSinh hs
                JOIN QuaTrinhHocTap qt ON hs.MaHS = qt.MaHS
                WHERE qt.MaLop = @MaLop";

            SqlParameter[] paraHocSinh = { new SqlParameter("@MaLop", MaLop) };
            DataTable dtHocSinh = DataProvider.SelectData(sqlHocSinh, CommandType.Text, paraHocSinh);

            if (dtHocSinh != null)
            {
                foreach (DataRow hs in dtHocSinh.Rows)
                {
                    DataRow newRow = dtDiem.Rows.Add();
                    newRow["MaHS"] = hs["MaHS"];
                    newRow["HoTen"] = hs["HoTen"];
                    newRow["MaLop"] = hs["MaLop"];
                }
            }

          //lấy điểm cũ
            string sqlDiemTP = @"
                SELECT dtp.MaHS, dtp.MaLoaiDiem, dtp.LanKiemTra, dtp.GiaTriDiem
                FROM DiemThanhPhan dtp
                WHERE dtp.MaMon = @MaMon AND dtp.MaHK = @MaHK AND dtp.MaHS IN (
                    SELECT MaHS FROM QuaTrinhHocTap WHERE MaLop = @MaLop
                )";
            SqlParameter[] paraDiemTP = {
                new SqlParameter("@MaMon", MaMon),
                new SqlParameter("@MaHK", MaHK),
                new SqlParameter("@MaLop", MaLop)
            };
            DataTable dtDiemTP = DataProvider.SelectData(sqlDiemTP, CommandType.Text, paraDiemTP);

            if (dtDiemTP != null && dtDiemTP.Rows.Count > 0)
            {
                foreach (DataRow rowDiem in dtDiemTP.Rows)
                {
                    string maHS = rowDiem["MaHS"].ToString();
                    string maLoai = rowDiem["MaLoaiDiem"].ToString().Trim();
                    string lanKT = rowDiem["LanKiemTra"].ToString();
                    string diem = rowDiem["GiaTriDiem"].ToString();

                    string colName = $"Diem_{maLoai}_{lanKT}";

                    // Tìm học sinh tương ứng trong dtDiem và điền điểm
                    DataRow[] hsRows = dtDiem.Select($"MaHS = '{maHS}'");
                    if (hsRows.Length > 0 && dtDiem.Columns.Contains(colName))
                    {
                        hsRows[0][colName] = diem;
                    }
                }
            }

            // Tải và đắp Điểm Cuối Kỳ
            string sqlDiemCK = @"
                SELECT MaHS, Diem
                FROM DiemCK
                WHERE MaLop = @MaLop AND MaMon = @MaMon AND MaHK = @MaHK";
            SqlParameter[] paraDiemCK = {
                new SqlParameter("@MaLop", MaLop),
                new SqlParameter("@MaMon", MaMon),
                new SqlParameter("@MaHK", MaHK)
            };
            DataTable dtDiemCK = DataProvider.SelectData(sqlDiemCK, CommandType.Text, paraDiemCK);

            if (dtDiemCK != null && dtDiemCK.Rows.Count > 0)
            {
                foreach (DataRow rowDiem in dtDiemCK.Rows)
                {
                    string maHS = rowDiem["MaHS"].ToString();
                    string diem = rowDiem["Diem"].ToString();

                    // Vì bạn quy ước mã điểm CK là DCK và có 1 lần thi, nên cột là Diem_DCK_1
                    string colName = "Diem_DCK_1";

                    DataRow[] hsRows = dtDiem.Select($"MaHS = '{maHS}'");
                    if (hsRows.Length > 0 && dtDiem.Columns.Contains(colName))
                    {
                        hsRows[0][colName] = diem;
                    }
                }
            }
          
            dgvDanhSachHS.DataSource = null;
            dgvDanhSachHS.Columns.Clear();
            dgvDanhSachHS.AutoGenerateColumns = true;
            dgvDanhSachHS.ColumnHeadersVisible = true;
            dgvDanhSachHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvDanhSachHS.DataSource = dtDiem;
            dgvDanhSachHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Khóa không cho sửa thông tin cứng
            if (dgvDanhSachHS.Columns.Contains("MaHS"))
            {
                dgvDanhSachHS.Columns["MaHS"].ReadOnly = true;
                dgvDanhSachHS.Columns["MaHS"].HeaderText = "Mã Học Sinh";
            }
            if (dgvDanhSachHS.Columns.Contains("HoTen"))
            {
                dgvDanhSachHS.Columns["HoTen"].ReadOnly = true;
                dgvDanhSachHS.Columns["HoTen"].HeaderText = "Tên Học Sinh";
            }
            if (dgvDanhSachHS.Columns.Contains("MaLop"))
            {
                dgvDanhSachHS.Columns["MaLop"].ReadOnly = true;
                dgvDanhSachHS.Columns["MaLop"].HeaderText = "Mã Lớp";
            }

            // Đổi HeaderText đẹp mắt cho các cột điểm
            if (dtCauTruc != null)
            {
                foreach (DataRow row in dtCauTruc.Rows)
                {
                    string maLoaiDiem = row["MaLoaiDiem"].ToString().Trim();
                    string tenLoaiDiem = row["TenLoaiDiem"].ToString().Trim();
                    int soLanKT = Convert.ToInt32(row["SoLanKT"]);

                    for (int i = 1; i <= soLanKT; i++)
                    {
                        string colName = $"Diem_{maLoaiDiem}_{i}";
                        if (dgvDanhSachHS.Columns.Contains(colName))
                        {
                            dgvDanhSachHS.Columns[colName].HeaderText = $"{tenLoaiDiem} (Lần {i})";
                        }
                    }
                }
            }
        }
        private void NhapDiem_Load(object sender, EventArgs e)
        {
            load_CB();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDiemLopHoc();
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            string MaLop = cbChonLop.SelectedValue?.ToString() ?? "";
            string MaMon = cbMonHoc.SelectedValue?.ToString() ?? "";
            string MaHK = cbChonHocKy.SelectedValue?.ToString() ?? "";
            if (MessageBox.Show("Thực Hiện Lưu Điểm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }


            if (string.IsNullOrEmpty(MaLop) || string.IsNullOrEmpty(MaMon) || string.IsNullOrEmpty(MaHK))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Lớp, Môn, Học kỳ trước khi lưu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int countSaved = 0; 

            using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                   
                    foreach (DataGridViewRow row in dgvDanhSachHS.Rows)
                    {
                        if (row.IsNewRow) continue; 

                        string maHS = row.Cells["MaHS"].Value?.ToString() ?? "";
                        if (string.IsNullOrEmpty(maHS)) continue;

                        // Quét từng cột trong dòng
                        foreach (DataGridViewColumn col in dgvDanhSachHS.Columns)
                        {
                            string colName = col.Name;

                            // quét các cột Diem
                            if (colName.StartsWith("Diem_"))
                            {
                                string diemStr = row.Cells[colName].Value?.ToString() ?? "";

                                // Nếu ô có điểm hợp lệ (Convert sang double thành công)
                                if (!string.IsNullOrEmpty(diemStr) && double.TryParse(diemStr, out double diem))
                                {
                                    string[] parts = colName.Split('_');
                                    if (parts.Length >= 3)
                                    {
                                        string maLoaiDiem = parts[1];
                                        int lanKiemTra = Convert.ToInt32(parts[2]);

                                        
                                        if (maLoaiDiem.ToUpper() == "DCK")
                                        {
                                            LuuDiemCuoiKi_Trans(maHS, MaLop, MaHK, MaMon, diem, conn, tran);
                                        }
                                        else
                                        {
                                            LuuDiemThanhPhan_Trans(maHS, MaMon, MaHK, maLoaiDiem, lanKiemTra, diem, conn, tran);
                                        }
                                        countSaved++;
                                    }
                                }
                            }
                        }
                    }

                   
                    tran.Commit();

                    if (countSaved > 0)
                    {
                        MessageBox.Show($"Lưu thành công {countSaved}  điểm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDiemLopHoc();
                    }
                    else
                        MessageBox.Show("Không có điểm nào được nhập để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    
                    tran.Rollback();
                    MessageBox.Show("Lỗi! Lưu điểm thất bại.\nError:: " + ex.Message, "Lỗi Nghiêm Trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
        //lưu điểm T.Phan
        private void LuuDiemThanhPhan_Trans(string maHS, string maMon, string maHK, string maLoaiDiem, int lanKiemTra, double diem, SqlConnection conn, SqlTransaction tran)
        {
            string sql = @"
                IF EXISTS (SELECT 1 FROM DiemThanhPhan WHERE MaHS = @MaHS AND MaMon = @MaMon AND MaHK = @MaHK AND MaLoaiDiem = @MaLoaiDiem AND LanKiemTra = @LanKiemTra)
                BEGIN
                    UPDATE DiemThanhPhan 
                    SET GiaTriDiem = @Diem 
                    WHERE MaHS = @MaHS AND MaMon = @MaMon AND MaHK = @MaHK AND MaLoaiDiem = @MaLoaiDiem AND LanKiemTra = @LanKiemTra
                END
                ELSE
                BEGIN
                    INSERT INTO DiemThanhPhan (MaHS, MaMon, MaHK, MaLoaiDiem, LanKiemTra, GiaTriDiem) 
                    VALUES (@MaHS, @MaMon, @MaHK, @MaLoaiDiem, @LanKiemTra, @Diem)
                END";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@MaHS", maHS),
                new SqlParameter("@MaMon", maMon),
                new SqlParameter("@MaHK", maHK),
                new SqlParameter("@MaLoaiDiem", maLoaiDiem),
                new SqlParameter("@LanKiemTra", lanKiemTra),
                new SqlParameter("@Diem", diem)
            };

           
            DataProvider.ExcuteNonQuery_trans(sql, CommandType.Text, paras, conn, tran);
        }

       //lưu ĐCK
        private void LuuDiemCuoiKi_Trans(string maHS, string maLop, string maHK, string maMon, double diem, SqlConnection conn, SqlTransaction tran)
        {
            string sql = @"
                IF EXISTS (SELECT 1 FROM DiemCK WHERE MaHS = @MaHS AND MaLop = @MaLop AND MaHK = @MaHK AND MaMon = @MaMon)
                BEGIN
                    UPDATE DiemCK 
                    SET Diem = @Diem 
                    WHERE MaHS = @MaHS AND MaLop = @MaLop AND MaHK = @MaHK AND MaMon = @MaMon
                END
                ELSE
                BEGIN
                    INSERT INTO DiemCK (MaDiemCK,MaHS, MaLop, MaHK, MaMon, Diem) 
                    VALUES (@Madiem,@MaHS, @MaLop, @MaHK, @MaMon, @Diem)
                END";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@Madiem",maHS +"_CK"),
                new SqlParameter("@MaHS", maHS),
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@MaHK", maHK),
                new SqlParameter("@MaMon", maMon),
                new SqlParameter("@Diem", diem)
            };

            DataProvider.ExcuteNonQuery_trans(sql, CommandType.Text, paras, conn, tran);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            if (dgvDanhSachHS.Rows.Count == 0 || dgvDanhSachHS.Columns.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExcelPackage.License.SetNonCommercialPersonal("My Name");

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx", FileName = $"Bang_Diem_Mon_{cbMonHoc.Text}_Lop_{cbChonLop.SelectedValue.ToString()}.xlsx" })
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
                            for (int i = 0; i < dgvDanhSachHS.Columns.Count; i++)
                            {
                                ws.Cells[1, i + 1].Value = dgvDanhSachHS.Columns[i].Name; // VD: Diem_TP_1
                            }
                            ws.Row(1).Hidden = true; // Ẩn dòng mã cột 

                            //  Dùng dòng 2 làm HEADER TEXT 
                            for (int i = 0; i < dgvDanhSachHS.Columns.Count; i++)
                            {
                                ws.Cells[2, i + 1].Value = dgvDanhSachHS.Columns[i].HeaderText;
                                ws.Cells[2, i + 1].Style.Font.Bold = true;
                            }

                            //  Đổ dữ liệu từ DGV xuống - từ dòng 3
                            for (int i = 0; i < dgvDanhSachHS.Rows.Count; i++)
                            {
                                if (dgvDanhSachHS.Rows[i].IsNewRow) continue;
                                for (int j = 0; j < dgvDanhSachHS.Columns.Count; j++)
                                {
                                    ws.Cells[i + 3, j + 1].Value = dgvDanhSachHS.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // AutoFit các cột 
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            package.Save();
                            MessageBox.Show("Xuất file Excel mẫu thành công! Giáo viên có thể mở file này để nhập điểm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHS.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng Chọn Lớp/Môn và bấm TÌM để tạo khung điểm trước khi Import!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExcelPackage.License.SetNonCommercialPersonal("My Name");

            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo file = new FileInfo(ofd.FileName);
                        using (ExcelPackage package = new ExcelPackage(file))
                        {
                            ExcelWorksheet ws = package.Workbook.Worksheets.FirstOrDefault();
                            if (ws == null) return;

                            int rowCount = ws.Dimension.Rows;
                            int colCount = ws.Dimension.Columns;

                            // Bắt đầu đọc từ dòng 3 
                            for (int row = 3; row <= rowCount; row++)
                            {
                                // Lấy Mã HS ở cột đầu tiên 
                                string maHS_Excel = ws.Cells[row, 1].Value?.ToString() ?? "";
                                if (string.IsNullOrEmpty(maHS_Excel)) continue;

                                // Tìm dòng trên DGV có khớp Mã HS này không
                                foreach (DataGridViewRow dgvRow in dgvDanhSachHS.Rows)
                                {
                                    if (dgvRow.IsNewRow) continue;
                                    string maHS_DGV = dgvRow.Cells["MaHS"].Value?.ToString() ?? "";

                                    if (maHS_Excel == maHS_DGV)
                                    {
                                        // Nếu khớp học sinh, lặp qua các cột điểm để lấy dữ liệu đắp vào DGV
                                        for (int col = 1; col <= colCount; col++)
                                        {
                                            // Lấy cái tên cột thật (Diem_TP_1) ở dòng số 1 đang bị ẩn
                                            string colName = ws.Cells[1, col].Value?.ToString() ?? "";

                                            // Chỉ lấy những cột bắt đầu bằng Diem_
                                            if (colName.StartsWith("Diem_") && dgvDanhSachHS.Columns.Contains(colName))
                                            {
                                                dgvRow.Cells[colName].Value = ws.Cells[row, col].Value?.ToString() ?? "";
                                            }
                                        }
                                        break; // Đã tìm thấy và điền xong HS này, thoát vòng lặp tìm HS để sang HS tiếp theo của Excel
                                    }
                                }
                            }

                            MessageBox.Show("Đã tải dữ liệu từ Excel lên màn hình!\nVui lòng kiểm tra lại và bấm LƯU để ghi vào Cơ sở dữ liệu.", "Hoàn tất Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
