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

namespace InterFace_FINAL_QLHS.Admin
{
    public partial class QuyDinhKiemTra : Form
    {
        public QuyDinhKiemTra()
        {
            InitializeComponent();
        }
        private void Load_CB()
        {
            string sql1 = "Select * from LoaiDiem";
            string sql2 = "Select * from MonHoc";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql1);
            DataTable dt2 = DataProvider.TruyVan_LayDuLieu(sql2);

            cbLoaiDiem.DataSource = dt;
            DataRow loaidiem =dt.NewRow();
            loaidiem["TenLoaiDiem"] = "--Chọn loại điểm--";
            loaidiem["MaLoaiDiem"]=DBNull.Value;
            dt.Rows.InsertAt(loaidiem, 0);
            cbLoaiDiem.DisplayMember = "TenLoaiDiem";
            cbLoaiDiem.ValueMember = "MaLoaiDiem";
            cbLoaiDiem.SelectedIndex = 0;

            //--
            cbMonHoc.DataSource = dt2;
            DataRow monHoc =dt2.NewRow();
            monHoc["TenMon"]= "--Chọn Môn--";
            monHoc["MaMon"]= DBNull.Value;
            dt2.Rows.InsertAt(monHoc, 0);
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMon";
            cbMonHoc.SelectedIndex = 0; 
        }

        private void Load_DGV()
        {
            string sql = "Select * From QuyDinhDiem";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            dgvQuyDinhKT.DataSource = dt;
            dgvQuyDinhKT.Columns[0].HeaderText = "Mã Môn Học";
            dgvQuyDinhKT.Columns[1].HeaderText = "Mã Loại Điểm";
            dgvQuyDinhKT.Columns[2].HeaderText = "Số Lần Kiểm Tra";
        }
        private void QuyDinhKiemTra_Load(object sender, EventArgs e)
        {
            Load_CB();
            Load_DGV();
        }

        private bool Kiemtra()
        {
            if (cbLoaiDiem.SelectedValue == DBNull.Value || cbMonHoc.SelectedValue == DBNull.Value) {
                MessageBox.Show("Loại Điểm Hoặc Môn Học KHÔNG Được Để trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning;
              return false;
            }
            string maloai = cbLoaiDiem.SelectedValue.ToString();
            string mamon = cbMonHoc.SelectedValue.ToString();

       
            string sql = @"SELECT 1 
                   FROM QuyDinhDiem
                   WHERE MaLoaiDiem = @maloai AND MaMon = @mamon";

            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@maloai", maloai),
                new SqlParameter("@mamon", mamon)
            };

      

            if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp)>0)
            {
                MessageBox.Show("Quy định kiểm tra này đã tồn tại!","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                MessageBox.Show("ok");

            }
        }
    }
}
