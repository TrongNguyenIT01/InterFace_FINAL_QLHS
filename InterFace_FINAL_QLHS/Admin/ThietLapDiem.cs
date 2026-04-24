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
    public partial class ThietLapDiem : Form
    {
        public ThietLapDiem()
        {
            InitializeComponent();
        }

        private void Load_DSDiem()
        {
            string sql = "SELECT * FROM LoaiDiem";
            
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            dgvLoaiDiem.DataSource = dt;

            dgvLoaiDiem.Columns[0].HeaderText = "Mã loại điểm";
            dgvLoaiDiem.Columns[1].HeaderText = "Tên loại điểm";
            dgvLoaiDiem.Columns[2].HeaderText = "Hệ số";
            txtHeSo.Clear();
            txtMaLoaiDiem.Clear();
            txtTenLoai.Clear();
        }

        private bool KiemTraDuLieu()
        {
            if (txtMaLoaiDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã loại điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiDiem.Focus();
                return false;
            }
            string sql = $"SELECT * FROM LoaiDiem WHERE MaLoaiDiem = '{txtMaLoaiDiem.Text}'";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã điểm này đã tồn tại vui lòng nhập mã mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiDiem.Focus();
                return false;
            }
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return false;
            }
            if (txtHeSo.Text == "" || !int.TryParse(txtHeSo.Text, out int heSo) || heSo < 0)
            {
                MessageBox.Show("Vui lòng nhập hệ số hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeSo.Focus();
                return false;
            }
            return true;
        }

        private void ThietLapDiem_Load(object sender, EventArgs e)
        {
            Load_DSDiem();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi)) {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string sql = "INSERT INTO LoaiDiem (MaLoaiDiem, TenLoaiDiem, HeSo) VALUES (@MaLoaiDiem, @TenLoaiDiem, @HeSo)";
                        SqlParameter[] paras = new SqlParameter[]
                        {
                            new SqlParameter("@MaLoaiDiem", txtMaLoaiDiem.Text),
                            new SqlParameter("@TenLoaiDiem", txtTenLoai.Text),
                            new SqlParameter("@HeSo", int.Parse(txtHeSo.Text))
                            };

                        DataProvider.ExcuteNonQuery_trans(sql, CommandType.Text, paras, conn, tran);
                        tran.Commit();
                        MessageBox.Show("Thêm loại điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Thêm loại điểm thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    };
                    Load_DSDiem();


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM LoaiDiem WHERE MaLoaiDiem =@MaLoai";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaLoai", txtMaLoaiDiem.Text)
            };
            if (MessageBox.Show("Bạn có chắc muốn xóa loại điểm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(DataProvider.ExcuteNonQuery(sql,CommandType.Text,sp)>0)
                {
                    MessageBox.Show("Đã xóa loại điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DSDiem();  
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //update
            string sql = "UPDATE LoaiDiem SET HeSo=@heso,  TenLoaiDiem=@tenloai Where MaLoaiDiem=@maloai";
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }
            if (txtHeSo.Text == "" || !int.TryParse(txtHeSo.Text, out int heso) || heso < 0)
            {
                MessageBox.Show("Vui lòng nhập hệ số hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeSo.Focus();
                return ;
            }
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@heso",heso),
                new SqlParameter("@tenloai", txtTenLoai.Text),
                new SqlParameter("@maloai",txtMaLoaiDiem.Text)
            };
            if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0) {
                MessageBox.Show("Cập nhật loại điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_DSDiem();
            }
            else
            {
                MessageBox.Show("Cập nhật loại điểm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_DSDiem();
            }
        }
    }
}
