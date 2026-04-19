using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterFace_FINAL_QLHS.Admin;
using InterFace_FINAL_QLHS.Config;
using InterFace_FINAL_QLHS.GiaoVien;

namespace InterFace_FINAL_QLHS
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

       private bool validate()
        {
            if(txtMatkhau.Text == "" || txtDangnhap.Text == "" || cbVaitro.Text == "")
            {
                
                return false;
            }
            return true;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                bool dn = false;
                Form f = null;
                if (cbVaitro.Text == "Admin")
                {
                    dn = Dang_Nhap.checkDN(txtDangnhap.Text, txtMatkhau.Text, 0);
                    
                    f = new TongQuanAdmin();
                }
                else if (cbVaitro.Text == "Giáo Viên")
                {
                    dn = Dang_Nhap.checkDN(txtDangnhap.Text, txtMatkhau.Text, 1);
                    f = new TrangGiaoVien();
                }
                else if (cbVaitro.Text == "Giáo Vụ")
                {
                    dn = Dang_Nhap.checkDN(txtDangnhap.Text, txtMatkhau.Text, 2);
                    f = new TrangGiaoVu();
                   
                }

                if (dn)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    f.Owner = this;
                    f.Show();
                }
                else
                {
                    MessageBox.Show($"Đăng nhập thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDangnhap.Clear();
                    txtMatkhau.Clear();
                    cbVaitro.SelectedIndex = -1;

                }
            }else { MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }




        }


        private bool isPasswordVisible = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            isPasswordVisible = !isPasswordVisible;

            txtMatkhau.UseSystemPasswordChar = !isPasswordVisible;

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = true;
        }
    }
}
