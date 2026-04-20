using InterFace_FINAL_QLHS.Admin;
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

namespace InterFace_FINAL_QLHS
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            string pass = txtNewPass.Text;
            string confirm = txtKiemLaiPass.Text;

            if (pass != confirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi");
                return;
            }

            // Sử dụng lại hàm HashPassword mà bạn đã dùng trong phần Đăng nhập
            string hashedPass = Cap_TaiKhoan.HashPassword(pass);
            string email = QuenMK_Session.EmailDangXuLy;

            // Cập nhật CSDL
            string sql = "UPDATE Users SET Pass_word = @pass WHERE Email = @email";
            SqlParameter[] paras = {
                new SqlParameter("@pass", hashedPass),
                new SqlParameter("@email", email)
            };

            int result = DataProvider.ExcuteNonQuery(sql, CommandType.Text, paras);

            if (result > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại.", "Thành công");
                this.Close();
                // Có thể mở lại Form Đăng nhập tại đây
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau.", "Lỗi");
            }
        }
        private bool isPasswordVisible1 = false;
        private bool isPasswordVisible2 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            isPasswordVisible1 = !isPasswordVisible1;

            txtNewPass.UseSystemPasswordChar = !isPasswordVisible1;
            if (isPasswordVisible1)
            {
                button1.Image = Properties.Resources.eye_line;
            }
            else
            {
                button1.Image = Properties.Resources.eye_off_line;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isPasswordVisible2 = !isPasswordVisible2;

            txtKiemLaiPass.UseSystemPasswordChar = !isPasswordVisible2;
            if (isPasswordVisible2)
            {
                button2.Image = Properties.Resources.eye_line;
            }
            else
            {
                button2.Image = Properties.Resources.eye_off_line;
            }
        }
    }
}
