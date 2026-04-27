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

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class LenLop : Form
    {
        public LenLop()
        {
            InitializeComponent();
        }

        private void LenLop_Load(object sender, EventArgs e)
        {
            string sql = "SELECT DISTINCT MaNamHoc FROM HocKy ORDER BY MaNamHoc";
            DataTable dtNamHoc = DataProvider.TruyVan_LayDuLieu(sql);

            // Dùng .Copy() để 2 ComboBox không bị dính chung một nguồn dữ liệu (chọn cái này tự nhảy cái kia)
            cbNamHocHienTai.DataSource = dtNamHoc.Copy();
            cbNamHocHienTai.DisplayMember = "MaNamHoc";
            cbNamHocHienTai.ValueMember = "MaNamHoc";
            cbNamHocHienTai.SelectedIndex = -1;

            cbNamHocMoi.DataSource = dtNamHoc.Copy();
            cbNamHocMoi.DisplayMember = "MaNamHoc";
            cbNamHocMoi.ValueMember = "MaNamHoc";
            cbNamHocMoi.SelectedIndex = -1;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào
            if (cbNamHocHienTai.SelectedValue == null || cbNamHocMoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Năm học hiện tại và Năm học mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNamHienTai = cbNamHocHienTai.SelectedValue.ToString();
            string maNamMoi = cbNamHocMoi.SelectedValue.ToString();

            if (maNamHienTai == maNamMoi)
            {
                MessageBox.Show("Năm học mới phải khác năm học hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Xác nhận trước khi chạy rủi ro
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn thực hiện Lên Lớp từ năm {maNamHienTai} sang năm {maNamMoi} không?\nLưu ý: Học sinh đủ điểm sẽ lên khối tiếp theo, học sinh khối 12 vào trạng thái tốt nghiệp.",
                                              "Xác nhận Lên Lớp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    // 3. Chạy Procedure lên lớp
                    string sql = "sp_XuLyLenLop";
                    SqlParameter[] sp = new SqlParameter[]
                        {
        new SqlParameter("@MaNamHocHienTai", maNamHienTai),
        new SqlParameter("@MaNamHocMoi", maNamMoi),
        
        // Khai báo tham số Output
        new SqlParameter("@SoTotNghiep", SqlDbType.Int) { Direction = ParameterDirection.Output },
        new SqlParameter("@SoLenLop", SqlDbType.Int) { Direction = ParameterDirection.Output },
        new SqlParameter("@SoLuuBan", SqlDbType.Int) { Direction = ParameterDirection.Output }
                        };

                    using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                    {
                        conn.Open();
                        SqlTransaction tran = conn.BeginTransaction();
                        try
                        {
                            // Gọi hàm thực thi
                            DataProvider.ExcuteNonQuery_trans(sql, CommandType.StoredProcedure, sp, conn, tran);
                            tran.Commit();

                            // MÓC KẾT QUẢ OUTPUT TỪ SQL TRẢ VỀ C#
                            int soTotNghiep = Convert.ToInt32(sp[2].Value);
                            int soLenLop = Convert.ToInt32(sp[3].Value);
                            int soLuuBan = Convert.ToInt32(sp[4].Value);

                            // TẠO THÔNG BÁO THỐNG KÊ HOÀNH TRÁNG
                            string thongBao = $"Đã hoàn tất quá trình tổng kết năm học {maNamHienTai}!\n\n" +
                                              $"BÁO CÁO KẾT QUẢ:\n" +
                                              $" Tốt nghiệp (Khối 12): {soTotNghiep} học sinh\n" +
                                              $" Lên lớp thành công: {soLenLop} học sinh\n" +
                                              $" Không đủ điều kiện (Ở lại): {soLuuBan} học sinh\n\n";

                            MessageBox.Show(thongBao, "Thống Kê Tổng Kết", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Lỗi khi xử lý lên lớp: \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
