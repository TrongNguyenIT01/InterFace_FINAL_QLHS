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

namespace InterFace_FINAL_QLHS.Admin
{
    public partial class ThayDoiThongTinChuyenMon : Form
    {
        public ThayDoiThongTinChuyenMon()
        {
            InitializeComponent();
        }

        private void Load_ds()
        {
            string sql = @"SELECT * FROM ChuyenMon";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            dtgChuyenMon.DataSource = dt;

            dtgChuyenMon.Columns[0].HeaderText = "Mã Chuyên Môn";
            dtgChuyenMon.Columns[1].HeaderText = "Tên Chuyên Môn";

        }
        private void Clear_from()
        {
            txtMaCM.Clear();
            txtTenCM.Clear();
            Load_ds();
        }
        private void ThayDoiThongTinChuyenMon_Load(object sender, EventArgs e)
        {
            Load_ds();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaCM.Text) || string.IsNullOrWhiteSpace(txtTenCM.Text))
            {
                MessageBox.Show("Mã chuyên môn hoặc tên chuyên môn không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string sql = "SELECT COUNT(*) FROM ChuyenMon WHERE MaCM = @macm OR TenCM = @tencm";

            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@macm", txtMaCM.Text),
            new SqlParameter("@tencm", txtTenCM.Text)
                };

            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, sp);

            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Chuyên môn đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO ChuyenMon (MaCM, TenCM) VALUES (@MaChuyenMon, @TenChuyenMon)";

            if (!KiemTraDuLieu())
            {
                return;
            }

            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@MaChuyenMon", txtMaCM.Text),
                new SqlParameter("@TenChuyenMon", txtTenCM.Text)
            };
            if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0)
            {
                MessageBox.Show("Thêm chuyên môn thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_from();
            }
            else
            {
                MessageBox.Show("Thêm chuyên môn thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM ChuyenMon WHERE MaCM = @MaChuyenMon";
            string maCM = txtMaCM.Text;
            if (string.IsNullOrWhiteSpace(maCM))
            {
                MessageBox.Show("Vui lòng nhập mã chuyên môn cần xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@MaChuyenMon", maCM)
            };
            if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0)
            {
                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_from();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE ChuyenMon SET TenCM = @TenChuyenMon WHERE MaCM = @MaChuyenMon";

    

            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@MaChuyenMon", txtMaCM.Text),
                new SqlParameter("@TenChuyenMon", txtTenCM.Text)
            };
            if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0)
            {
                MessageBox.Show("Cập nhật chuyên môn thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_from();
            }
            else
            {
                MessageBox.Show("Cập nhật chuyên môn thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
