using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterFace_FINAL_QLHS.Admin
{
    public partial class ThongTinNamHoc : Form
    {
        public ThongTinNamHoc()
        {
            InitializeComponent();
        }

        private void Load_NH()
        {
            string sql = "SELECT * FROM NamHoc";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            dgvDSNamHoc.DataSource = dt;

            dgvDSNamHoc.Columns[0].HeaderText = "Mã năm học";
            dgvDSNamHoc.Columns[1].HeaderText = "Tên năm học";
        }

        private void Clear_from()
        {
            txtMaNH.Clear();
            txtTenNH.Clear();
            Load_NH();
        }

        private void ThongTinNamHoc_Load(object sender, EventArgs e)
        {
            Load_NH();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaNH.Text) || string.IsNullOrWhiteSpace(txtTenNH.Text))
            {
                MessageBox.Show("Mã năm học hoặc tên năm học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        } 

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO NamHoc (MaNamHoc, TenNamHoc) VALUES (@MaNH, @TenNH)";

            string sql2 = "SELECT COUNT(*) FROM NamHoc WHERE MaNamHoc = @MaNH OR TenNamHoc = @TenNH";
            SqlParameter[] sp2 = new SqlParameter[] {
                new SqlParameter("@MaNH", txtMaNH.Text),
                new SqlParameter("@TenNH", txtTenNH.Text)
            };
            DataTable dt = DataProvider.SelectData(sql2, CommandType.Text, sp2 );
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Mã năm học hoặc tên năm học đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            if (KiemTraDuLieu()) {
                SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaNH", txtMaNH.Text),
                new SqlParameter("@TenNH", txtTenNH.Text)
            };

                int count = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);

                if (count > 0)
                {
                    MessageBox.Show($"Thêm năm học thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_from();
                }
                else
                {
                    MessageBox.Show($"Thêm năm học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql= "DELETE FROM NamHoc WHERE MaNamHoc = @MaNH";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaNH", txtMaNH.Text)
            };

            if (string.IsNullOrWhiteSpace(txtMaNH.Text)|| !string.IsNullOrWhiteSpace(txtTenNH.Text))
            {
                MessageBox.Show("Chỉ nhập mã năm học để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);

            if (count > 0)
            {
                MessageBox.Show($"Xóa năm học thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_from();
            }
            else
            {
                MessageBox.Show($"Xóa năm học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NamHoc SET TenNamHoc = @TenNH WHERE MaNamHoc = @MaNH";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaNH", txtMaNH.Text),
                new SqlParameter("@TenNH", txtTenNH.Text)
            };

            if (string.IsNullOrWhiteSpace(txtMaNH.Text) || string.IsNullOrWhiteSpace(txtTenNH.Text))
            {
                MessageBox.Show("Mã năm học và tên năm học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("Bạn có chắc muốn cập nhật tên năm học này? ", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int count = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);

            if (count > 0)
            {
                MessageBox.Show($"Cập nhật năm học thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_from();
            }
            else
            {
                MessageBox.Show($"Cập nhật năm học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
