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
    public partial class ThongTinHocKy : Form
    {
        public ThongTinHocKy()
        {
            InitializeComponent();
        }

        private void LayDuLieuHK()
        {
            string sql = "SELECT * FROM NamHoc";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            DataRow row = dt.NewRow();
            row["MaNamHoc"] = DBNull.Value;
            row["TenNamHoc"] = "--Chọn Năm Học--";
            dt.Rows.InsertAt(row, 0);

            cbMaNH.DataSource = dt;
            cbMaNH.DisplayMember = "TenNamHoc";
            cbMaNH.ValueMember = "MaNamHoc";

            cbMaNH.SelectedIndex = 0;
        }

        private void load_DS_HK()
        {
            string sql = "SELECT * FROM HocKy";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            dgvDSHocKy.DataSource = dt;




            dgvDSHocKy.Columns[0].HeaderText = "Mã Học Kỳ";
            dgvDSHocKy.Columns[1].HeaderText = "Tên Học Kỳ";
            dgvDSHocKy.Columns[2].HeaderText = "Năm Học";
        }

        private void Cls_form()
        {
            txtMaHK.Text = "";
            txtHK.Text = "";
            cbMaNH.SelectedIndex = -1;

            LayDuLieuHK();
            load_DS_HK();
        }

        private void ThongTinHocKy_Load(object sender, EventArgs e)
        {
            Cls_form();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrEmpty(txtMaHK.Text))
            {
                MessageBox.Show("Vui lòng nhập mã học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtHK.Text))
            {
                MessageBox.Show("Vui lòng nhập tên học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbMaNH.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO HocKy (MaHK, HocKy, MaNamHoc) VALUES (@MaHK, @HocKy, @MaNamHoc)";

            // check trùng dữ liệu
            string sql2= $"SELECT COUNT(*) FROM HocKy WHERE MaHK = @MaHK";
            SqlParameter[] sp2 = new SqlParameter[]
            {
                new SqlParameter("@MaHK", txtMaHK.Text)
            };
            if(Convert.ToInt32(DataProvider.SelectData(sql2, CommandType.Text, sp2).Rows[0][0]) > 0)
            {
                MessageBox.Show("Học kỳ đã tồn tại. Vui lòng chọn mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (KiemTraDuLieu())
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@MaHK", txtMaHK.Text),
                    new SqlParameter("@HocKy", txtHK.Text),
                    new SqlParameter("@MaNamHoc", cbMaNH.SelectedValue)
                };

                int kq = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm học kỳ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cls_form();
                }
                else
                {
                    MessageBox.Show("Thêm học kỳ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cls_form();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM HocKy WHERE MaHK =@MaHK";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaHK", txtMaHK.Text)
            };

            if(MessageBox.Show("Bạn có chắc muốn xóa học kỳ này?Hành động này có thể gây ra lỗi hệ thống do mã học kỳ đã được liên kết đến các mục khác", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            int kq = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);
            if (kq > 0)
            {
                MessageBox.Show("Xóa học kỳ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cls_form();
            }
            else
            {
                MessageBox.Show("Xóa học kỳ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cls_form();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE HocKy SET HocKy = @HocKy, MaNamHoc = @MaNamHoc WHERE MaHK = @MaHK";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaHK", txtMaHK.Text),
                new SqlParameter("@HocKy", txtHK.Text),
                new SqlParameter("@MaNamHoc", cbMaNH.SelectedValue)
            };
            int kq = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật học kỳ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cls_form();
            }
            else
            {
                MessageBox.Show("Cập nhật học kỳ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cls_form();
            }
        
        }
    }


}
