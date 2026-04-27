using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class BaoCaoMon : Form
    {
        public BaoCaoMon()
        {
            InitializeComponent();
        }

        private void load_CB()
        {
          
            string sql_HK = $"Select HocKy + ' - ' + MaNamHoc AS HienThi, MaNamHoc, MaHK, MaNamHoc From HocKy";
            string sql_MH = $"Select MaMon, TenMon From MonHoc";


      
            DataTable HK = DataProvider.TruyVan_LayDuLieu(sql_HK);
            DataTable MH = DataProvider.TruyVan_LayDuLieu(sql_MH);


            cbHocKy.DataSource = HK;
            cbHocKy.DisplayMember = "HienThi";
            cbHocKy.ValueMember = "MaHK";
            cbHocKy.SelectedIndex = -1;

            cbMon.DataSource = MH;
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
            cbMon.SelectedIndex = -1;


        }

        private void BaoCaoMon_Load(object sender, EventArgs e)
        {
            load_CB();
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
       
            if (cbHocKy.SelectedValue == null || cbMon.SelectedValue == null)
            {
                MessageBox.Show($"Vui lòng chọn đầy đủ Học kỳ và môn học muốn tạo báo cáo!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            string maHK = cbHocKy.SelectedValue.ToString();
            string maMon = cbMon.SelectedValue.ToString();

            // Lấy MaNamHoc từ dòng đang chọn trong ComboBox Học Kỳ
            DataRowView rowHK = (DataRowView)cbHocKy.SelectedItem;
            string maNamHoc = rowHK["MaNamHoc"].ToString();

          
            //Join bảng LopHoc, QuaTrinhHocTap và MonHoc
            string sql = $@"
        SELECT 
            L.MaLop AS [Lớp],
            COUNT(Q.MaHS) AS [Sĩ số],
            SUM(CASE WHEN dbo.fn_TinhDiemTBMon(Q.MaHS, '{maMon}', '{maHK}') >= M.DiemChuan THEN 1 ELSE 0 END) AS [Số Lượng Đạt]
        FROM Lop L
        JOIN QuaTrinhHocTap Q ON L.MaLop = Q.MaLop
        CROSS JOIN MonHoc M -- Lấy điểm chuẩn của môn đang chọn
        WHERE M.MaMon = '{maMon}' 
          AND Q.MaNamHoc = '{maNamHoc}'
          AND Q.TrangThai = N'Đang học' -- Chỉ tính học sinh đang học
        GROUP BY L.MaLop, M.DiemChuan";

            // Lấy dữ liệu và xử lý hiển thị
            DataTable dtResult = DataProvider.TruyVan_LayDuLieu(sql);

           
            DataTable dtFinal = new DataTable();
            dtFinal.Columns.Add("STT", typeof(int));
            dtFinal.Columns.Add("Lớp", typeof(string));
            dtFinal.Columns.Add("Sĩ số", typeof(int));
            dtFinal.Columns.Add("Số Lượng Đạt", typeof(int));
            dtFinal.Columns.Add("Tỉ Lệ Đạt", typeof(string));
            dtFinal.Columns.Add("Tỉ Lệ Rớt", typeof(string));


            int stt = 1;
            foreach (DataRow row in dtResult.Rows)
            {
                int siSo = Convert.ToInt32(row["Sĩ số"]);
                int soLuongDat = Convert.ToInt32(row["Số Lượng Đạt"]);
                double tiLe = siSo > 0 ? (double)soLuongDat / siSo * 100 : 0;
                double tileTruot = 100- tiLe; 

                dtFinal.Rows.Add(
                    stt++,
                    row["Lớp"],
                    siSo,
                    soLuongDat,
                    Math.Round(tiLe, 2).ToString() + "%",
                    Math.Round(tileTruot, 2).ToString() + "%"
                   

                );
            }

          
            dgvBaoCaoMon.DataSource = dtFinal;

         
            dgvBaoCaoMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXuatFileBaoCaoMon_Click(object sender, EventArgs e)
        {
   

   
            // 1. Kiểm tra dữ liệu trên lưới trước khi xuất
            if (dgvBaoCaoMon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Tạo Báo Cáo' để có dữ liệu trước khi xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            ExcelPackage.License.SetNonCommercialPersonal("MyName");

            // 3. Khởi tạo hộp thoại lưu file
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
            
                sfd.FileName = $"Bao_Cao_Mon_{cbMon.Text.Replace(" ", "_")}_{cbHocKy.Text}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo file = new FileInfo(sfd.FileName);
                        using (ExcelPackage package = new ExcelPackage(file))
                        {
                            // Tạo một Sheet mới tên là "Báo Cáo "
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("BaoCaoMon");

                            // 4. TIÊU ĐỀ BÁO CÁO (Merge từ cột A đến F - 6 cột)
                            ws.Cells["A1:F1"].Merge = true;
                            ws.Cells["A1"].Value = $"BÁO CÁO TỔNG KẾT Môn {cbMon.Text}";
                            ws.Cells["A1"].Style.Font.Size = 18;
                            ws.Cells["A1"].Style.Font.Bold = true;
                            ws.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.DarkGreen);
                            ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            ws.Cells["A2:F2"].Merge = true;
                            ws.Cells["A2"].Value = "Học kỳ: " + cbHocKy.Text;
                            ws.Cells["A2"].Style.Font.Size = 13;
                            ws.Cells["A2"].Style.Font.Italic = true;
                            ws.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // 5. ĐỔ HEADER (Dòng số 4)
                            for (int i = 0; i < dgvBaoCaoMon.Columns.Count; i++)
                            {
                                var cell = ws.Cells[4, i + 1];
                                cell.Value = dgvBaoCaoMon.Columns[i].HeaderText;

                                // Định dạng Header: Chữ đậm, nền xám, căn giữa, có khung
                                cell.Style.Font.Bold = true;
                                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(220, 220, 220));
                                cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }

                            // 6. ĐỔ DỮ LIỆU TỪ GRIDVIEW (Từ dòng số 5)
                            for (int i = 0; i < dgvBaoCaoMon.Rows.Count; i++)
                            {
                                // Bỏ qua dòng trống cuối cùng nếu có
                                if (dgvBaoCaoMon.Rows[i].IsNewRow) continue;

                                for (int j = 0; j < dgvBaoCaoMon.Columns.Count; j++)
                                {
                                    var cell = ws.Cells[i + 5, j + 1];
                                    var value = dgvBaoCaoMon.Rows[i].Cells[j].Value;

                                    // Điền giá trị vào cell
                                    cell.Value = value;

                                    // Kẻ khung cho từng ô dữ liệu
                                    cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);

                                    // Định dạng căn giữa cho các cột số lượng và STT
                                    if (j != 2) // Trừ cột Tên Lớp (thường để căn trái cho dễ đọc)
                                    {
                                        cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    }

                                    // Định dạng riêng cho cột Tỷ Lệ (Cột thứ 6 - index 5)
                                    if (dgvBaoCaoMon.Columns[j].HeaderText == "Tỷ Lệ")
                                    {
                                        cell.Style.Numberformat.Format = "0.00\"%\"";
                                    }
                                }
                            }

                            // 7. CĂN CHỈNH TỰ ĐỘNG ĐỘ RỘNG CỘT
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            // 8. LƯU FILE
                            package.Save();
                            MessageBox.Show("Xuất file Excel báo cáo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    
    }
}
