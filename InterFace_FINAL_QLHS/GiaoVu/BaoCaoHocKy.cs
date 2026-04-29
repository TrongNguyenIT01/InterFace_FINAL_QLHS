using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class BaoCaoHocKy : Form
    {
        public BaoCaoHocKy()
        {
            InitializeComponent();
        }

        private void LoadHocKyTheoNam(string maNamHoc)
        {
            // Chỉ lấy những Học kỳ có MaNamHoc tương ứng
            string sql = $"SELECT MaHK, HocKy FROM HocKy WHERE MaNamHoc = '{maNamHoc}'";
            DataTable dtHK = DataProvider.TruyVan_LayDuLieu(sql);

            cbHocKyBaoCaoHocKy.DataSource = dtHK;
            cbHocKyBaoCaoHocKy.DisplayMember = "HocKy";
            cbHocKyBaoCaoHocKy.ValueMember = "MaHK";
        }

        private void BaoCaoHocKy_Load(object sender, EventArgs e)
        {
            // 1. Đổ dữ liệu Năm Học
            DataTable dtNH = DataProvider.TruyVan_LayDuLieu("SELECT MaNamHoc, TenNamHoc FROM NamHoc");
            cbNamHoc.DataSource = dtNH;
            cbNamHoc.DisplayMember = "TenNamHoc";
            cbNamHoc.ValueMember = "MaNamHoc";

            // 2. Gọi hàm nạp Học kỳ cho năm học đang hiển thị mặc định
            if (cbNamHoc.SelectedValue != null)
            {
                LoadHocKyTheoNam(cbNamHoc.SelectedValue.ToString());
            }
        }



        private void btnTaoBaoCaoHocKy_Click(object sender, EventArgs e)
        {
            if (cbHocKyBaoCaoHocKy.SelectedValue == null || cbNamHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo");
                return;
            }

            try
            {
                string maHK = cbHocKyBaoCaoHocKy.SelectedValue.ToString();
                string maNH = cbNamHoc.SelectedValue.ToString();

                // Viết lại logic của Procedure nhưng có thêm điều kiện Năm Học (MaNamHoc)
                // SQL này sẽ join bảng Lop với QuaTrinhHocTap để lọc chính xác học sinh theo năm
                string sql = $@"
            SELECT 
                ROW_NUMBER() OVER (ORDER BY L.TenLop) AS STT,
                L.MaLop AS [Mã Lớp],
                L.TenLop AS [Tên Lớp],
                L.SiSo AS [Sỉ Số],
                (
                    SELECT COUNT(*) 
                    FROM (
                        SELECT qtht.MaHS
                        FROM QuaTrinhHocTap qtht
                        WHERE qtht.MaLop = L.MaLop AND qtht.MaNamHoc = '{maNH}'
                        GROUP BY qtht.MaHS
                    ) AS DSHS
                    WHERE NOT EXISTS (
                        SELECT 1 
                        FROM MonHoc mh
                        WHERE ISNULL(dbo.fn_TinhDiemTBMon(DSHS.MaHS, mh.MaMon, '{maHK}'), 0) < mh.DiemChuan
                    )
                ) AS [Số Lượng Đạt]
            INTO #TempBaoCao
            FROM Lop L;

            SELECT 
                STT, [Mã Lớp], [Tên Lớp], [Sỉ Số], [Số Lượng Đạt],
                CASE 
                    WHEN [Sỉ Số] > 0 THEN ROUND((CAST([Số Lượng Đạt] AS FLOAT) / [Sỉ Số]) * 100, 2)
                    ELSE 0 
                END AS [Tỷ Lệ]
            FROM #TempBaoCao;

            DROP TABLE #TempBaoCao;";

                // Gọi DataProvider để lấy dữ liệu với câu SQL thuần
                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

                if (dt != null)
                {
                    dgvBaoCaoHocKy.DataSource = dt;

                    // Định dạng cột Tỷ lệ (nếu có)
                    if (dgvBaoCaoHocKy.Columns.Contains("Tỷ Lệ"))
                    {
                        dgvBaoCaoHocKy.Columns["Tỷ Lệ"].DefaultCellStyle.Format = "0.00'%'";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXuatFileBaoCaoHocKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu trên lưới trước khi xuất
            if (dgvBaoCaoHocKy.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Tạo Báo Cáo' để có dữ liệu trước khi xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Cấu hình bản quyền EPPlus (Bắt buộc cho phiên bản mới)
            ExcelPackage.License.SetNonCommercialPersonal("Nguyen Cao Hoang Phu");

            // 3. Khởi tạo hộp thoại lưu file
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                // Tự động gợi ý tên file theo Học kỳ đã chọn
                sfd.FileName = $"Bao_Cao_Tong_Ket_{cbHocKyBaoCaoHocKy.Text.Replace(" ", "_")}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo file = new FileInfo(sfd.FileName);
                        using (ExcelPackage package = new ExcelPackage(file))
                        {
                            // Tạo một Sheet mới tên là "Báo Cáo"
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("BaoCao");

                            // 4. TIÊU ĐỀ BÁO CÁO (Merge từ cột A đến F - 6 cột)
                            ws.Cells["A1:F1"].Merge = true;
                            ws.Cells["A1"].Value = "BÁO CÁO TỔNG KẾT HỌC KỲ";
                            ws.Cells["A1"].Style.Font.Size = 18;
                            ws.Cells["A1"].Style.Font.Bold = true;
                            ws.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.DarkGreen);
                            ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            ws.Cells["A2:F2"].Merge = true;
                            ws.Cells["A2"].Value = "Học kỳ: " + cbHocKyBaoCaoHocKy.Text;
                            ws.Cells["A2"].Style.Font.Size = 13;
                            ws.Cells["A2"].Style.Font.Italic = true;
                            ws.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // 5. ĐỔ HEADER (Dòng số 4)
                            for (int i = 0; i < dgvBaoCaoHocKy.Columns.Count; i++)
                            {
                                var cell = ws.Cells[4, i + 1];
                                cell.Value = dgvBaoCaoHocKy.Columns[i].HeaderText;

                                // Định dạng Header: Chữ đậm, nền xám, căn giữa, có khung
                                cell.Style.Font.Bold = true;
                                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(220, 220, 220));
                                cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }

                            // 6. ĐỔ DỮ LIỆU TỪ GRIDVIEW (Từ dòng số 5)
                            for (int i = 0; i < dgvBaoCaoHocKy.Rows.Count; i++)
                            {
                                // Bỏ qua dòng trống cuối cùng nếu có
                                if (dgvBaoCaoHocKy.Rows[i].IsNewRow) continue;

                                for (int j = 0; j < dgvBaoCaoHocKy.Columns.Count; j++)
                                {
                                    var cell = ws.Cells[i + 5, j + 1];
                                    var value = dgvBaoCaoHocKy.Rows[i].Cells[j].Value;

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
                                    if (dgvBaoCaoHocKy.Columns[j].HeaderText == "Tỷ Lệ")
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

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem đã có giá trị chọn chưa để tránh lỗi lúc khởi tạo
            if (cbNamHoc.SelectedValue != null && cbNamHoc.ValueMember != "")
            {
                string maNamChon = cbNamHoc.SelectedValue.ToString();
                LoadHocKyTheoNam(maNamChon);
            }
        }
    }
}
