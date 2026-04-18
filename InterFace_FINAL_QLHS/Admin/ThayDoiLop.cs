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
            string sql = "SELECT * FROM GiaoVien WHERE TrangThai = N'Chưa Phân Công'";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            
            DataRow row = dt.NewRow();
            row["GiaoVienID"] = DBNull.Value;
            row["HoTen"] = "-- Chọn giáo viên --";
            dt.Rows.InsertAt(row, 0);

            cbGVCN.DataSource = dt;
            cbGVCN.DisplayMember = "HoTen";
            cbGVCN.ValueMember = "GiaoVienID";

            cbGVCN.SelectedIndex = 0; 
        }
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtTenLop.Text) || string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Tên lớp không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtSiSoToiDa.Text, out int sisomax) || sisomax <= 0)
            {
                MessageBox.Show("Nhập lỗi định dạng sĩ số, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            string sql = "SELECT COUNT(*) FROM Lop WHERE MaLop = @malop OR TenLop = @tenlop";

            SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@malop", txtMaLop.Text),
            new SqlParameter("@tenlop", txtTenLop.Text)
                };

            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, sp);

            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Mã lớp hoặc tên lớp đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                string sql = $"INSERT INTO Lop (MaLop,TenLop, SiSoToiDa, GiaoVienID) " +
                    $"VALUES (@malop, @tenlop, @sisomax, @gvcn)";
                string sql2 = $"UPDATE GiaoVien SET TrangThai = N'Đã Phân Công GVCN' WHERE GiaoVienID = @gvcn";

                SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@malop",txtMaLop.Text),
                new SqlParameter("@tenlop", txtTenLop.Text),
                new SqlParameter("@sisomax", txtSiSoToiDa.Text),
                new SqlParameter("@gvcn", cbGVCN.SelectedValue)
                };

                bool kq = DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0;
                if (kq)
                {
                    MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataProvider.ExcuteNonQuery(sql2, CommandType.Text, sp);
                    Load_ds();
                    txtMaLop.Text =null;
                    txtSiSoToiDa.Text = null;
                    txtTenLop.Text = null;
                    LayDuLieuGV();
                }
                else
                {
                    MessageBox.Show("Thêm lớp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string sqlGet = "SELECT GiaoVienID FROM Lop WHERE MaLop = @malop";
            SqlParameter[] spGet = {
        new SqlParameter("@malop", maLop)
    };

            DataTable dt = DataProvider.SelectData(sqlGet, CommandType.Text, spGet);
            string gvID = null;

            if (dt.Rows.Count > 0)
                gvID = dt.Rows[0]["GiaoVienID"]?.ToString();


            string sqlDelete = "DELETE FROM Lop WHERE MaLop = @malop";
            SqlParameter[] spDelete = {
        new SqlParameter("@malop", maLop)
    };

            if (MessageBox.Show("Bạn có chắc muốn xóa lớp này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool kq = DataProvider.ExcuteNonQuery(sqlDelete, CommandType.Text, spDelete) > 0;

                if (kq)
                {
                    
                    if (!string.IsNullOrEmpty(gvID))
                    {
                        string sqlUpdate = "UPDATE GiaoVien SET TrangThai = N'Chưa Phân Công' WHERE GiaoVienID = @id";
                        SqlParameter[] spUpdate = {
                    new SqlParameter("@id", gvID)
                };

                        DataProvider.ExcuteNonQuery(sqlUpdate, CommandType.Text, spUpdate);
                    }

                    MessageBox.Show("Xóa lớp thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Load_ds();
                    txtMaLop.Text = null;
                    txtSiSoToiDa.Text = null;
                    txtTenLop.Text = null;
                    LayDuLieuGV();
                }
                else
                {
                    MessageBox.Show("Xóa lớp thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string gvMoi = cbGVCN.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    
                    string sqlGet = "SELECT GiaoVienID FROM Lop WHERE MaLop = @malop";
                    SqlCommand cmdGet = new SqlCommand(sqlGet, conn, tran);
                    cmdGet.Parameters.AddWithValue("@malop", maLop);

                    string gvCu = cmdGet.ExecuteScalar()?.ToString();

                    
                    if (!string.IsNullOrEmpty(gvCu) && gvCu != gvMoi)
                    {
                 
                        string sqlOld = "UPDATE GiaoVien SET TrangThai = N'Chưa Phân Công' WHERE GiaoVienID = @id";
                        DataProvider.ExcuteNonQuery_trans(sqlOld, CommandType.Text,
                            new SqlParameter[] { new SqlParameter("@id", gvCu) }, conn, tran);

                       
                        string sqlNew = "UPDATE GiaoVien SET TrangThai = N'Đã Phân Công' WHERE GiaoVienID = @id";
                        DataProvider.ExcuteNonQuery_trans(sqlNew, CommandType.Text,
                            new SqlParameter[] { new SqlParameter("@id", gvMoi) }, conn, tran);
                    }

                   
                    string sqlUpdate = @"UPDATE Lop 
                                SET TenLop = @tenlop, 
                                    SiSoToiDa = @sisomax, 
                                    GiaoVienID = @gvcn 
                                WHERE MaLop = @malop";

                    SqlParameter[] sp = {
                new SqlParameter("@tenlop", txtTenLop.Text),
                new SqlParameter("@sisomax", txtSiSoToiDa.Text),
                new SqlParameter("@gvcn", gvMoi),
                new SqlParameter("@malop", maLop)
            };

                    DataProvider.ExcuteNonQuery_trans(sqlUpdate, CommandType.Text, sp, conn, tran);

                    tran.Commit();
                    MessageBox.Show("Cập nhật thành công!");
                    txtMaLop.Text = null;
                    txtSiSoToiDa.Text = null;
                    txtTenLop.Text = null;
                    Load_ds();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
