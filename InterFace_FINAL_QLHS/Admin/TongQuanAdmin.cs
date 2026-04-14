using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS.Admin
{
    public partial class TongQuanAdmin : Form
    {
        private bool sidebarExpand = true; // Mặc định là mở

        public TongQuanAdmin()
        {
            InitializeComponent();
        }

        // Hàm xử lý sự kiện khi Timer chạy
        private void Timesidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Nếu sidebar đang mở, thu nhỏ lại
                panel1.Width -= 10;
                if (panel1.Width <= 50)
                {
                    sidebarExpand = false; 
                    Timesidebar.Stop(); 

                    // Ẩn chữ trên các nút
                    foreach (Control c in panel1.Controls)
                    {
                        if (c is Button btn) btn.Text = "";
                    }
                }
            }
            else
            {
                // Nếu sidebar đang đóng, mở rộng ra
                panel1.Width += 10;
                if (panel1.Width >= 270)
                {
                    sidebarExpand = true; 
                    Timesidebar.Stop(); 
                    btnSideBar.Text = "";
                    btnCapTaiKhoan.Text = "Cấp Tài Khoản";
                    btnThayDoiQuyDinhDoTuoi.Text = "Thay đổi độ tuổi";
                    btnThayDoiQuyDinhThongTinLopHoc.Text = "Thay đổi thông tin lớp học";
                    btnThayDoiThongTinMonHoc.Text = "Thay đổi thông tin môn học";
                    btnChuyenMon.Text = "Chuyên môn";
                    btnDangXuat.Text = "Đăng xuất";
                }
            }
        }

        // Hàm xử lý sự kiện khi nhấn nút btnSideBar
        private void btnSideBar_Click(object sender, EventArgs e)
        {
            Timesidebar.Start();
        }
        private void OpenChildForm(Form childForm)
        {
            // 1. Kiểm tra xem loại Form này đã mở chưa
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == childForm.GetType())
                {
                    f.Activate(); // Nếu mở rồi thì chỉ cần hiện nó lên trên cùng
                    f.WindowState = FormWindowState.Normal; // Đưa về kích thước bình thường nếu đang thu nhỏ
                    return;
                }
            }

            // 2. Nếu chưa có, thiết lập để nó nằm trong Form cha
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnCapTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cap_TaiKhoan());
        }

        private void btnThayDoiQuyDinhDoTuoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thaydoidotuoi());
        }

        private void btnXepChong_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void btnChiaNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void btnChiaDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnThayDoiQuyDinhThongTinLopHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThayDoiLop());
        }

        private void btnThayDoiThongTinMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThayDoiMonHoc());
        }

        private void btnChuyenMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThayDoiThongTinChuyenMon());
        }
        private void TongQuanAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
