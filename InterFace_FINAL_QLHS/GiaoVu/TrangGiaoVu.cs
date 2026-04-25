using InterFace_FINAL_QLHS.GiaoVu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS
{
    public partial class TrangGiaoVu : Form
    {
        public TrangGiaoVu()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true; // Trạng thái ban đầu là mở
        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Nếu đang mở thì thu nhỏ lại
                panelSidebar.Width -= 10;
                if (panelSidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();

                    foreach (Control c in panelSidebar.Controls)
                    {
                        if (c is Button btn) btn.Text = "";
                    }
                }
            }
            else
            {
                // Nếu đang đóng thì mở rộng ra
                panelSidebar.Width += 10;
                if (panelSidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                    btnTongQuan.Text = "Tổng Quan";
                    btnDanhSachLop.Text = "Lập danh sách lớp";
                    btnTraCuuHocSinh.Text = "Tra cứu học sinh";
                    btnTiepNhanHocSinh.Text = "Tiếp nhận học sinh";
                    btnSapXepGV.Text = "Sắp xếp giáo viên";
                    btnXemBaoCaoHK.Text = "Báo cáo tổng kết học kỳ";
                    btnXemBaoCaoMon.Text = "Báo cáo tổng kết môn";
                    btnXemDiem.Text = "Xem bảng điểm môn";
                    btnDoiPass.Text = "Đổi mật khẩu";
                    btnLogout.Text = "Đăng xuất";
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            // Bắt đầu chạy hiệu ứng khi bấm nút
            timerSidebar.Start();
        }

        private void OpenChildForm(Form childForm)
        {
            // 1. Kiểm tra xem loại Form này đã mở chưa
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == childForm.GetType())
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized; // Ép full màn hình khi kích hoạt lại
                    return;
                }
            }

            // 2. Thiết lập cho form mới
            childForm.MdiParent = this;
            
            // Thêm sự kiện FormClosed để xử lý khi đóng form này thì form khác tự to lên (nếu cần)
            childForm.FormClosed += (s, e) => {
                if (this.MdiChildren.Length > 0)
                {
                    this.MdiChildren[0].WindowState = FormWindowState.Maximized;
                }
            };

            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized; // Ép full màn hình ngay khi mở
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TongQuan());
        }

        private void btnTiepNhanHocSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TiepNhanHocSinh());
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

        private void btnTraCuuHocSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TraCuuHocSinh());
        }

        private void btnDanhSachLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LapDanhSachLop());
        }


        private void TrangGiaoVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BangDiemMon());
        }

        private void btnXemBaoCaoMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoCaoMon());
        }

        private void btnXemBaoCaoHK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoCaoHocKy());
        }

        private void btnSapXepGV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanCongGV());
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoiPassSauDangNhap());
        }
    }
}
