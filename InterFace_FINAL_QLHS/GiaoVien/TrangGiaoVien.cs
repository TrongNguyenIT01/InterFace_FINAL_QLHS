using InterFace_FINAL_QLHS.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS.GiaoVien
{
    public partial class TrangGiaoVien : Form
    {
        private bool sidebarExpand = true;
        public TrangGiaoVien()
        {
            InitializeComponent();
        }
        private void Timesidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Nếu sidebar đang mở, thu nhỏ lại
                panel1.Width -= 10;
                if (panel1.Width <= 50)
                {
                    sidebarExpand = false;
                    timesidebar.Stop();

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
                    timesidebar.Stop();
                    btnDashBoard.Text = "";
                    btnTongQuan.Text = "Cấp Tài Khoản";
                    btnNhapDiem.Text = "Thay đổi độ tuổi";
                    btnTraCuuHS.Text = "Thay đổi thông tin lớp học";
                    btnTTGV.Text = "Thay đổi thông tin môn học";
                    btnDoiMK.Text = "Chuyên môn";
                    btnDangXuat.Text = "Đăng xuất";
                }
            }
        }

        // Hàm xử lý sự kiện khi nhấn nút btnSideBar
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            timesidebar.Start();
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

        private void stXepChong_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void stChiaNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void stChiadoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TongQuan());
        }
    }
}
