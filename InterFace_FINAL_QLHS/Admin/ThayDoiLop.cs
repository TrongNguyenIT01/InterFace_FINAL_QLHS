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
    public partial class ThayDoiLop : Form
    {
        public ThayDoiLop()
        {
            InitializeComponent();
        }
        private void ThayDoiLop_Load(object sender, EventArgs e)
        {
            Load_ds();
            LayDuLieuGV();
        }

        private void Load_ds() {
            string sql= @"SELECT * FROM Lop";

           DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            
            dataGridViewDanhSachLop.DataSource = dt;

            dataGridViewDanhSachLop.Columns[0].HeaderText = "Mã Lớp";
            dataGridViewDanhSachLop.Columns[1].HeaderText = "Tên Lớp";
            dataGridViewDanhSachLop.Columns[2].HeaderText = "Sỉ Số";
            dataGridViewDanhSachLop.Columns[3].HeaderText = "Sỉ Số Tối Đa";
            dataGridViewDanhSachLop.Columns[4].HeaderText = "GVCN";
        }

        private void LayDuLieuGV()
        {
            string sql = "SELECT * FROM GiaoVien WHERE TrangThai =N'Chưa Phân Công' ";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            cbGVCN.DataSource = dt;
            cbGVCN.DisplayMember = "HoTen";
            cbGVCN.ValueMember = "GiaoVienID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
