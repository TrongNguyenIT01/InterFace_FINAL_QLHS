using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS.Admin
{
    public partial class ThayDoiMonHoc : Form
    {
        public ThayDoiMonHoc()
        {
            InitializeComponent();
        }

        private void Load_ds()
        {
            string sql = @"SELECT * FROM MonHoc";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            dtgDanhSachMon.DataSource = dt;

            dtgDanhSachMon.Columns[0].HeaderText = "Mã Môn";
            dtgDanhSachMon.Columns[1].HeaderText = "Tên Môn";
            dtgDanhSachMon.Columns[2].HeaderText = "Điểm Chuẩn";
        }

        private void Clear_from()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtDiemChuan.Clear();
            Load_ds();
        }
        private void ThayDoiMonHoc_Load(object sender, EventArgs e)
        {
            Load_ds();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text) || string.IsNullOrWhiteSpace(txtDiemChuan.Text))
            {
                MessageBox.Show("Mã môn hoặc tên môn học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!float.TryParse(txtDiemChuan.Text, out float diemChuan) || diemChuan <= 0)
            {
                MessageBox.Show("Nhập lỗi định dạng điểm chuẩn, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            string sql = "SELECT COUNT(*) FROM MonHoc WHERE MaMon = @mamon OR TenMon = @tenmon";

            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@mamon", txtMaMon.Text),
            new SqlParameter("@tenmon", txtTenMon.Text)
                };

            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, sp);

            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Mã môn hoặc tên môn đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO MonHoc (MaMon, TenMon, DiemChuan) VALUES (@MaMon, @TenMon, @DiemChuan)";


            if (KiemTraDuLieu())
            {
                SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@MaMon", txtMaMon.Text),
                new SqlParameter("@TenMon", txtTenMon.Text),
                new SqlParameter("@DiemChuan", float.Parse(txtDiemChuan.Text)) };
                int kq = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_from();
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM MonHoc WHERE MaMon = @MaMon";
            string maMon = txtMaMon.Text;
            if (string.IsNullOrWhiteSpace(maMon))
            {
                MessageBox.Show("Vui lòng nhập mã môn học cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@MaMon", maMon)
            };
            int kq = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);
            if (kq > 0)
            {
                MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_from();
            }
            else
            {
                MessageBox.Show("Xóa môn học thất bại! Vui lòng kiểm tra lại mã môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE MonHoc SET TenMon = @TenMon, DiemChuan = @DiemChuan WHERE MaMon = @MaMon";

            if(string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text) || string.IsNullOrWhiteSpace(txtDiemChuan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@MaMon", txtMaMon.Text),
            new SqlParameter("@TenMon", txtTenMon.Text),
            new SqlParameter("@DiemChuan", float.Parse(txtDiemChuan.Text)) };
            int kq = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_from();
            }
            else
            {
                   
                MessageBox.Show("Cập nhật môn học thất bại! Vui lòng kiểm tra lại thông tin môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_from();
            }
            
        }
    }


}
