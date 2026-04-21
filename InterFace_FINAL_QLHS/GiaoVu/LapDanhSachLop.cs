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

        private void Load_DS_TN(string khoiLop) {
            string kl = khoiLop;
            string sql = "";
            if (kl=="--Chọn Khối Lớp--")
            {
                 sql = $"SELECT * From TiepNhanHS Where TrangThai=N'Chưa Phân Lớp'";
            }
            else
            {
                    sql = $"SELECT * From TiepNhanHS Where TrangThai=N'Chưa Phân Lớp' AND KhoiLop=N'{kl}'";
            }
           

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

            string sql2 = "SELECT DISTINCT KhoiLop From TiepNhanHS ORDER BY KhoiLop";
            DataTable dt2 = DataProvider.TruyVan_LayDuLieu(sql2);
            
            DataRow dtr = dt2.NewRow();
            dtr[0] = "--Chọn Khối Lớp--";
            dt2.Rows.InsertAt(dtr, 0);
            cbKhoiTN.DataSource = dt2;
            cbKhoiTN.DisplayMember = "KhoiLop";
            cbKhoiTN.ValueMember = "KhoiLop";

        }

        private void Load_Lop(string lop) {
            string sql = "";
            if (lop == "--Chọn Lớp--")
            {
                sql = $"SELECT l.* , gv.HoTen From Lop l " +
                $"LEFT JOIN GiaoVien gv on l.GiaoVienID = gv.GiaoVienID";
            }
            else
            {
                 sql = $"SELECT l.* , gv.HoTen From Lop l " +
                    $"LEFT JOIN GiaoVien gv on l.GiaoVienID = gv.GiaoVienID Where l.MaLop=N'{lop}'";
            }
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            txtGVCN.Text = dt.Rows[0]["HoTen"] == DBNull.Value ? "" : dt.Rows[0]["HoTen"].ToString();
            txtSiSo.Text = dt.Rows[0]["SiSo"]==DBNull.Value ? "" : dt.Rows[0]["SiSo"].ToString();

            DataRow row = dt.NewRow();
            row["MaLop"] = "--Chọn Lớp--";
            dt.Rows.InsertAt(row, 0);

            cbLop.DataSource = dt;
            cbLop.DisplayMember = "MaLop";
            cbLop.ValueMember = "MaLop";
            cbLop.SelectedIndex = 0;
        }

        private void LoadThongTinLop(string lop)
        {
            if (lop == "--Chọn Lớp--") return;

            string sql = $"SELECT l.*, gv.HoTen FROM Lop l LEFT JOIN GiaoVien gv ON l.GiaoVienID = gv.GiaoVienID WHERE l.MaLop = '{lop}'";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                txtGVCN.Text = row["HoTen"] == DBNull.Value
                    ? "Chưa có GVCN"
                    :"Giáo viên chủ nhiệm: "+ row["HoTen"].ToString();

                txtSiSo.Text = row["SiSo"] == DBNull.Value
                    ? "Sỉ số: " + "0" + "/" + row["SiSoToiDa"].ToString()
                    : "Sỉ số: " + row["SiSo"].ToString() + "/" +row["SiSoToiDa"].ToString();
            }
        }

        private void LapDanhSachLop_Load(object sender, EventArgs e)
        {
            Load_DS_TN("--Chọn Khối Lớp--");
            Load_Lop("--Chọn Lớp--");
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            if(cbKhoiTN.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn khối lớp để xếp lớp tự động.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTimHSTN_Click(object sender, EventArgs e)
        {
            Load_DS_TN(cbKhoiTN.SelectedValue.ToString());
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            LoadThongTinLop(cbLop.SelectedValue.ToString());
        }
    }
}
