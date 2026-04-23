using OfficeOpenXml;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InterFace_FINAL_QLHS
{
    public partial class TiepNhanHocSinh : Form
    {
        public TiepNhanHocSinh()
        {
            InitializeComponent();
        }

        // [THÊM MỚI] Hàm lấy quy định tuổi từ bảng ThamSo
        private void LayQuyDinhTuoi(out int tuoiTT, out int tuoiTD)
        {
            tuoiTT = 15;
            tuoiTD = 20;

            string sql = "SELECT MaThamSo, GiaTri FROM ThamSo WHERE MaThamSo IN ('TuoiTT', 'TuoiTD')";
            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maTS = reader["MaThamSo"].ToString();
                            int giaTri = Convert.ToInt32(reader["GiaTri"]);
                            if (maTS == "TuoiTT") tuoiTT = giaTri;
                            if (maTS == "TuoiTD") tuoiTD = giaTri;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy quy định tuổi từ CSDL: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaiMau_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.FileName = "Mau_Import_HS.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string souceFile = Path.Combine(Application.StartupPath, "Template", "Mau_Import_HS.xlsx");

                    File.Copy(souceFile, sfd.FileName, true);
                    MessageBox.Show("Tải file mẫu import thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Import_data(string filePath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("My Name");

            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;

                    int Success = 0;
                    int Failed = 0;

                    LayQuyDinhTuoi(out int tuoiTT, out int tuoiTD);

                    using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                    {
                        conn.Open();

                        for (int row = 2; row <= rowCount; row++)
                        {
                            try
                            {
                                string HoTen = worksheet.Cells[row, 1].Value?.ToString().Trim();
                                DateTime NgaySinh = worksheet.Cells[row, 2].GetValue<DateTime>();
                                string GioiTinh = worksheet.Cells[row, 3].Value?.ToString().Trim();
                                string DiaChi = worksheet.Cells[row, 4].Value?.ToString().Trim();
                                string Email = worksheet.Cells[row, 5].Value?.ToString().Trim();
                                string SDT = worksheet.Cells[row, 6].Value?.ToString().Trim();
                                string Khoi = worksheet.Cells[row, 7].Value?.ToString().Trim();
                                string TenPH = worksheet.Cells[row, 8].Value?.ToString().Trim();
                                DateTime NgayTiepNhan = worksheet.Cells[row, 9].GetValue<DateTime>();

                               
                                int tuoiHS = NgayTiepNhan.Year - NgaySinh.Year;
                                if (tuoiHS < tuoiTT || tuoiHS > tuoiTD)
                                {
                                    // Ghi nhận thất bại và báo lỗi cho dòng này, sau đó bỏ qua để chạy dòng tiếp theo
                                    MessageBox.Show($"Import thất bại dòng {row}: Tuổi học sinh '{HoTen}' ({tuoiHS} tuổi) không hợp lệ.\nQuy định: Từ {tuoiTT} đến {tuoiTD} tuổi.", "Lỗi quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Failed++;
                                    continue;
                                }

                                SqlTransaction tran = conn.BeginTransaction();
                                try
                                {
                                    string sql = @"INSERT INTO TiepNhanHS(MaTiepNhan, HoTen, NgaySinh," +
                                    $"GioiTinh,DiaChi, Email, SoDienThoai, KhoiLop, TenPH,NgayTiepNhan,TrangThai) VALUES" +
                                    $"('TN'+ RIGHT('0000' + CAST(NEXT VALUE FOR Seq_TiepNhan AS Varchar),4), @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SoDienThoai, @KhoiLop, @TenPH, @NgayTiepNhan,@TrangThai)";

                                    SqlParameter[] sp = new SqlParameter[] {
                                        new SqlParameter("@HoTen", HoTen),
                                        new SqlParameter("@NgaySinh", NgaySinh),
                                        new SqlParameter("@GioiTinh", GioiTinh),
                                        new SqlParameter("@DiaChi", DiaChi),
                                        new SqlParameter("@Email", Email),
                                        new SqlParameter("@SoDienThoai", SDT),
                                        new SqlParameter("@KhoiLop", Khoi),
                                        new SqlParameter("@TenPH", TenPH),
                                        new SqlParameter("@NgayTiepNhan", NgayTiepNhan),
                                        new SqlParameter("@TrangThai", "Chưa Phân Lớp")
                                    };

                                    DataProvider.ExcuteNonQuery_trans(sql, CommandType.Text, sp, conn, tran);
                                    tran.Commit();
                                    Success++;
                                }
                                catch (Exception ex)
                                {
                                    tran.Rollback();
                                    MessageBox.Show($"Import dữ liệu thất bại tại dòng {row} (Lỗi DB): {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Failed++;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi định dạng dữ liệu Excel tại dòng {row}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Failed++;
                            }
                        }
                    }

                    MessageBox.Show($"Quá trình Import hoàn tất!\n- Thành công: {Success} dòng.\n- Thất bại: {Failed} dòng.", "Thông báo kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đọc file Excel - Import thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files (*.xlsx; *.xls)|*.xlsx;*.xls";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Import_data(ofd.FileName);
            }
        }

        private bool kiemtradulieu()
        {
            if (string.IsNullOrWhiteSpace(txtHoTenHS.Text) || (!rbtnNam.Checked && !rbtnNu.Checked)
                || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtHoTenPH.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                if (addr.Address != txtEmail.Text) return false;
            }
            catch
            {
                MessageBox.Show("Định dạng email không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // [THÊM MỚI] Kiểm tra quy định tuổi
            LayQuyDinhTuoi(out int tuoiTT, out int tuoiTD);
            int tuoiHS = dtpNgayTN.Value.Year - dtpNgaySinh.Value.Year;

            if (tuoiHS < tuoiTT || tuoiHS > tuoiTD)
            {
                MessageBox.Show($"Độ tuổi học sinh không hợp lệ!\nTuổi hiện tại: {tuoiHS} tuổi.\nQuy định cho phép: Từ {tuoiTT} đến {tuoiTD} tuổi.", "Cảnh báo quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (kiemtradulieu())
            {
                string sql = @"INSERT INTO TiepNhanHS(MaTiepNhan, HoTen, NgaySinh," +
                                     $"GioiTinh,DiaChi, Email, SoDienThoai, KhoiLop, TenPH,NgayTiepNhan,TrangThai) VALUES" +
                                     $"('TN'+ RIGHT('0000' + CAST(NEXT VALUE FOR Seq_TiepNhan AS Varchar),4), @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SoDienThoai, @KhoiLop, @TenPH, @NgayTiepNhan,@TrangThai)";
                SqlParameter[] sp = new SqlParameter[] {
                                new SqlParameter("@HoTen", txtHoTenHS.Text.Trim()),
                                new SqlParameter("@NgaySinh", dtpNgaySinh.Value),
                                new SqlParameter("@GioiTinh", rbtnNam.Checked ? "Nam" : "Nữ"),
                                new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                                new SqlParameter("@Email", txtEmail.Text.Trim()),
                                new SqlParameter("@SoDienThoai", txtSDT.Text.Trim()),
                                new SqlParameter("@KhoiLop", nudKhoiLop.Value  ),
                                new SqlParameter("@TenPH", txtHoTenPH.Text.Trim()),
                                new SqlParameter("@NgayTiepNhan", dtpNgayTN.Value),
                                new SqlParameter("@TrangThai", "Chưa Phân Lớp")
                            };

                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        DataProvider.ExcuteNonQuery_trans(sql, CommandType.Text, sp, conn, tran);
                        tran.Commit();
                        MessageBox.Show("Tiếp nhận học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Tiếp nhận học sinh thất bại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        
    }
}