using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class LapDanhSachLop : Form
    {
        public LapDanhSachLop()
        {
            InitializeComponent();
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

        private void Load_DS_TN() { 
            string sql= "SELECT * From TiepNhanHS Where TrangThai=N'Chưa Phân Lớp'";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            dgvTN.DataSource = dt;

            dgvTN.Columns[0].HeaderText = "Mã Tiếp Nhận";
            dgvTN.Columns[1].HeaderText = "Họ Tên";
            dgvTN.Columns[2].HeaderText = "Ngày Sinh"; 
            dgvTN.Columns[3].HeaderText = "Giới Tính";
            dgvTN.Columns[4].HeaderText = "Địa Chỉ";
            dgvTN.Columns[5].HeaderText = "Email";
            dgvTN.Columns[6].HeaderText = "Số Điện Thoại";
            dgvTN.Columns[7].HeaderText = "Khối Lớp";
            dgvTN.Columns[8].HeaderText = "Tên Phụ Huynh";
            dgvTN.Columns[9].HeaderText = "Ngày Tiếp Nhận";

            cbKhoiTN.SelectedIndex = 0;
        }

        private void LapDanhSachLop_Load(object sender, EventArgs e)
        {
            Load_DS_TN();
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            if(cbKhoiTN.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn khối lớp để xếp lớp tự động.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
