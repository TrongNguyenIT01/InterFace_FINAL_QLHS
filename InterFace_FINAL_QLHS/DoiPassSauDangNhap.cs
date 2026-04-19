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
    public partial class DoiPassSauDangNhap : Form
    {
        public DoiPassSauDangNhap()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string passCu = txtPassCu.Text;
            string passMoi = txtPassMoi.Text;
            string xacNhan = txtXacNhanPass.Text;

            if (string.IsNullOrEmpty(passCu) || string.IsNullOrEmpty(passMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (passMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu mới không khớp!");
                return;
            }

            // 1. Kiểm tra mật khẩu cũ có đúng không
            string user = UserSession.CurrentUsername;
            string hashPassCu = Cap_TaiKhoan.HashPassword(passCu);

            string sqlCheck = "SELECT COUNT(*) FROM Users WHERE (UserName = @user OR Email = @user) AND Pass_word = @pass";
            SqlParameter[] pCheck = {
                new SqlParameter("@user", user),
                new SqlParameter("@pass", hashPassCu)
            };

            DataTable dt = DataProvider.SelectData(sqlCheck, CommandType.Text, pCheck);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                // 2. Nếu đúng thì cập nhật mật khẩu mới
                string hashPassMoi = Cap_TaiKhoan.HashPassword(passMoi);
                string sqlUpdate = "UPDATE Users SET Pass_word = @newPass WHERE UserName = @user OR Email = @user";
                SqlParameter[] pUpdate = {
                    new SqlParameter("@newPass", hashPassMoi),
                    new SqlParameter("@user", user)
                };

                if (DataProvider.ExcuteNonQuery(sqlUpdate, CommandType.Text, pUpdate) > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác!");
            }
        }
    }
}
