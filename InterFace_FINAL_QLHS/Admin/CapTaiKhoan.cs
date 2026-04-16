using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterFace_FINAL_QLHS.Config;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace InterFace_FINAL_QLHS.Admin
{
    public partial class Cap_TaiKhoan : Form
    {

       private void LayDuLieuChuyenMon()
        {
            string sql = "SELECT * FROM ChuyenMon";
            
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            cbChuyenMon.DataSource = dt;
            cbChuyenMon.DisplayMember = "TenCM";
            cbChuyenMon.ValueMember = "MaCM";
        }
        //Mã hóa mk  
        internal static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //cấp id tự động
        private string capID(string vaitro)
        {
            string prefix = "";

            string tableName = "Users";
            string id = "UserID";

            switch (vaitro)
            {
                case "Admin":
                    prefix = "AD";
                    break;
                case "Giáo Viên":
                    prefix = "GV";
                    break;
                case "Giáo Vụ":
                    prefix = "GVU";
                    break;
                default: return "";
            }

            string sql = $"SELECT TOP 1 {id} FROM {tableName} WHERE {id} LIKE @prefix ORDER BY {id} DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@prefix", prefix + "%")
            };
            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, parameters);

            if (dt != null && dt.Rows.Count > 0) { 
                string lastID = dt.Rows[0][id].ToString();
                string numberPart = lastID.Substring(prefix.Length);

                if(int .TryParse(numberPart, out int number))
                {
                    number++;
                    return prefix + number.ToString("D4");
                }
            }



            return prefix + "0001";
        }

        //check định dạng email và check trùng email
       private bool IsValidEmail(string email)
        {
          string sql = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", email)
            };
            int count = Convert.ToInt32(DataProvider.SelectData(sql, CommandType.Text, parameters).Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Email đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("Định dạng email không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Cap_TaiKhoan()
        {
            InitializeComponent();
        }

        private void Cap_TaiKhoan_Load(object sender, EventArgs e)
        {
            LayDuLieuChuyenMon();
        }

        private void btnCapTK_Click(object sender, EventArgs e)
        {
            string sql="";
            string sql2 = "";
            SqlParameter[] sp = null;
            string Hoten = txtHoTen.Text;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string Password = "123456";
            string GioiTinh = "";
            if (rabtnNam.Checked) {
                GioiTinh = "Nam";
            } else GioiTinh = "Nữ";
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            if (!IsValidEmail(Email))
            {
                return;
            }
            string SodienThoai = txtSDT.Text;
            string ChucVu = cbChucVu.Text;
            string ChuyenMon = cbChuyenMon.Text;

            if (string.IsNullOrWhiteSpace(Hoten) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(SodienThoai) || string.IsNullOrWhiteSpace(ChucVu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ChucVu != "Giáo Viên") {
             
                sql = "INSERT INTO Users(UserID,UserName,Pass_word,Email,Quyen) VALUES (@UserID, @UserName, @Pass_word, @Email, @Quyen)";
                 sql2 = $"INSERT INTO NhanVien(NhanVienID, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, ChucVu) " +
                    $"VALUES (@UserID, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SodienThoai, @ChucVu)";

                string userID = capID(ChucVu);
                     sp = new SqlParameter[] {
                    new SqlParameter("@UserID", userID),
                    new SqlParameter("@UserName", userID),
                    new SqlParameter("@Pass_word", HashPassword(Password)),
                    new SqlParameter("@Email", Email),
                    new SqlParameter("@Quyen", ChucVu == "Admin" ? 0 : 2),
                    new SqlParameter("@HoTen", Hoten),
                    new SqlParameter("@NgaySinh", NgaySinh),
                    new SqlParameter("@GioiTinh", GioiTinh),
                    new SqlParameter("@DiaChi", DiaChi),
                    new SqlParameter("@SoDienThoai", SodienThoai),
                    new SqlParameter("@ChucVu", ChucVu),
                };
            }
            else
            {
                if (string.IsNullOrWhiteSpace(ChuyenMon))
                {
                    MessageBox.Show("Vui lòng chọn chuyên môn cho giáo viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {
                     sql = "INSERT INTO Users(UserID,UserName,Pass_word,Email,Quyen) VALUES (@UserID, @UserName, @Pass_word, @Email, @Quyen)";

                     sql2 = $"INSERT INTO GiaoVien(GiaoVienID, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, MaCM, TrangThai) " +
                        $"VALUES (@UserID, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Email, @SodienThoai, @MaCM, @trangthai)";

                    string userID = capID(ChucVu);
                    sp = new SqlParameter[] {
                    new SqlParameter("@UserID", userID),
                    new SqlParameter("@UserName", userID),
                    new SqlParameter("@Pass_word", HashPassword(Password)),
                    new SqlParameter("@Email", Email),
                    new SqlParameter("@Quyen", 1),
                    new SqlParameter("@HoTen", Hoten),
                    new SqlParameter("@NgaySinh", NgaySinh),
                    new SqlParameter("@GioiTinh", GioiTinh),
                    new SqlParameter("@DiaChi", DiaChi),
                    new SqlParameter("@SoDienThoai", SodienThoai),
                    new SqlParameter("@MaCM", cbChuyenMon.SelectedValue.ToString()),
                    new SqlParameter("@trangthai","Chưa Phân Công")
                    };
                }
            }
            //dua du lieu vao sql
            if (MessageBox.Show("Bạn có chắc chắn muốn cấp tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0 && DataProvider.ExcuteNonQuery(sql2, CommandType.Text, sp) > 0)
                {
                  
                   MessageBox.Show($"Cấp tài khoản thành công!\nUsername: {sp[0].Value}\nPassword mặc định: 123456", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Cấp tài khoản thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            




        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChucVu.Text == "Giáo Viên")
            {
                cbChuyenMon.Visible = true;
                lblChuyenMon.Visible = true;
            }
            else
            {
                cbChuyenMon.Visible = false;
                lblChuyenMon.Visible = false;
            }
        }
    }
}
