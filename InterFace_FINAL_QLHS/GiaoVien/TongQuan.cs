using InterFace_FINAL_QLHS.Config;
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
using static InterFace_FINAL_QLHS.QuenMK;

namespace InterFace_FINAL_QLHS.GiaoVien
{
    public partial class TongQuan : Form
    {
        public TongQuan()
        {
            InitializeComponent();
        }

        private void TongQuan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Hàm dùng chung cho cả Load dữ liệu và Tìm kiếm
        private void LoadData(string keyword = "")
        {
            try
            {
                // Lấy IDUser từ Session đã có sẵn
                string maGV = UserSession.CurrentUsername;

                // Câu lệnh SQL kết nối các bảng để lấy: Tên lớp, Tên môn, Sĩ số
                string sql = @"
                    SELECT 
                        L.MaLop AS [Mã Lớp],
                        L.TenLop AS [Tên Lớp], 
                        MH.TenMon AS [Môn Giảng Dạy], 
                        (SELECT COUNT(*) FROM QuaTrinhHocTap qt WHERE qt.MaLop = L.MaLop) AS [Sỉ Số],
                        HK.HocKy AS [Học Kỳ]
                    FROM PhanCongGiangDay PC
                    INNER JOIN Lop L ON PC.MaLop = L.MaLop
                    INNER JOIN MonHoc MH ON PC.MaMon = MH.MaMon
                    INNER JOIN HocKy HK ON PC.MaHK = HK.MaHK
                    WHERE PC.GiaoVienID = @maGV";

                // Nếu người dùng có nhập từ khóa tìm kiếm
                if (!string.IsNullOrEmpty(keyword))
                {
                    // Thêm điều kiện tìm theo L.MaLop
                    sql += " AND (L.TenLop LIKE @key OR MH.TenMon LIKE @key OR L.MaLop LIKE @key)";
                }

                // Tạo tham số
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@maGV", maGV),
                    new SqlParameter("@key", "%" + keyword + "%")
                };

                // Gọi DataProvider để lấy dữ liệu
                DataTable dt = DataProvider.SelectData(sql, CommandType.Text, paras);

                // Đổ vào DataGridView (giả sử tên là dgvDSLopDangDay)
                dgvDSLopDangDay.DataSource = dt;

                // Tùy chỉnh giao diện DataGridView một chút
                if (dgvDSLopDangDay.Columns.Count > 0)
                {
                    dgvDSLopDangDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // txtTimLop là ô TextBox nhập tên lớp
            LoadData(txtTimKiem.Text.Trim());
        }
    }
}
