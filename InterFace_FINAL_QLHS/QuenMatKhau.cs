using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InterFace_FINAL_QLHS.QuenMK;

namespace InterFace_FINAL_QLHS
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        public void GuiMailOTP(string emailNguoiNhan, string maOTP)
        {
            try
            {
                // 1. Cấu hình thông tin người gửi
                string fromEmail = "hoangphu24122005@gmail.com";
                string appPassword = "ifld orqp paqo oqei";

                // 2. Nội dung thư
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail, "Hệ thống Quản lý Học sinh");
                mail.To.Add(emailNguoiNhan);
                mail.Subject = "Mã xác thực đổi mật khẩu";
                mail.Body = $"Mã OTP của bạn là: {maOTP}. Mã này có hiệu lực trong 10 phút. Vui lòng không cung cấp mã này cho bất kỳ ai.";
                mail.IsBodyHtml = false; // Nếu muốn gửi dạng HTML thì để true

                // 3. Cấu hình SMTP Server của Gmail
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587; // Cổng chuẩn của Gmail
                smtp.EnableSsl = true; // Bắt buộc dùng SSL/TLS
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromEmail, appPassword);

                // 4. Gửi thư
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi mail thất bại: " + ex.Message);
            }
        }

        
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            // 1. Kiểm tra Email có tồn tại trong hệ thống không
            string sql = "SELECT COUNT(*) FROM Users WHERE Email = @email";
            SqlParameter[] paras = { new SqlParameter("@email", email) };
            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, paras);
            bool emailTonTai = dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
            if (emailTonTai)
            {
                timeLeft = 600;
                lblTimer.ForeColor = Color.Black;
                // Tạo mã và lưu vào Session
                string otp = new Random().Next(100000, 999999).ToString();
                QuenMK_Session.MaOTP = otp;
                QuenMK_Session.HanSuDung = DateTime.Now.AddMinutes(10);
                QuenMK_Session.EmailDangXuLy = email;

                // GỌI HÀM GỬI MAIL Ở ĐÂY
                this.Cursor = Cursors.WaitCursor; // Đổi con trỏ chuột sang chờ
                GuiMailOTP(email, otp);
                this.Cursor = Cursors.Default; // Trả lại con trỏ bình thường

                MessageBox.Show("Đã gửi mã OTP!");
                timerOTP.Start();
            }
            else
            {
                MessageBox.Show("Email không tồn tại trong hệ thống!");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOTP.Text)) return;

            // Kiểm tra thời gian
            if (DateTime.Now > QuenMK_Session.HanSuDung)
            {
                MessageBox.Show("Mã OTP đã hết hạn (quá 10 phút). Vui lòng nhấn gửi lại mã!", "Thông báo");
                return;
            }

            // Kiểm tra khớp mã
            if (txtOTP.Text.Trim() == QuenMK_Session.MaOTP)
            {
                // Chuyển sang Form đổi mật khẩu
                DoiMatKhau fDoiPass = new DoiMatKhau();
                fDoiPass.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác!", "Lỗi");
            }
        }

        int timeLeft = 600;
        private void timerOTP_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--; // Trừ đi 1 giây

                // Chuyển đổi số giây thành định dạng Phút:Giây (00:00)
                TimeSpan t = TimeSpan.FromSeconds(timeLeft);
                lblTimer.Text = string.Format("Mã hết hạn sau: {0:D2}:{1:D2}", t.Minutes, t.Seconds);

                // (Tùy chọn) Đổi màu label sang đỏ khi còn dưới 30 giây để cảnh báo
                if (timeLeft <= 30)
                {
                    lblTimer.ForeColor = Color.Red;
                }
            }
            else
            {
                // Khi hết thời gian
                timerOTP.Stop();
                lblTimer.Text = "Mã OTP đã hết hiệu lực!";
                btnXacNhan.Enabled = false; // Khóa nút xác nhận

                // Xóa mã OTP trong Session để đảm bảo an toàn
                QuenMK_Session.MaOTP = "";
            }
        }
    }
}
