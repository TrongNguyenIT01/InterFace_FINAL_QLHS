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
            string sql = @"SELECT * FROM Lop";

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

        private void LamMoiGiaoDien()
        {
            txtMaLop.Text = "";
            txtSiSoToiDa.Text = "";
            txtTenLop.Text = "";
            Load_ds();
            LayDuLieuGV();
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

        const string TrangThai_1 = "Chưa Phân Công";
        const string TrangThai_2 = "Đã Phân Công GVCN";

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;
            //if (cbGVCN.SelectedIndex == 0)
            //{
            //    MessageBox.Show($"Vui lòng chọn giáo viên!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {

                    string sqlLop = "INSERT INTO Lop (MaLop, TenLop, SiSoToiDa, GiaoVienID) VALUES (@malop, @tenlop, @sisomax, @gvcn)";
                    SqlParameter[] spLop = {
                new SqlParameter("@malop", txtMaLop.Text.Trim()),
                new SqlParameter("@tenlop", txtTenLop.Text.Trim()),
                new SqlParameter("@sisomax", txtSiSoToiDa.Text.Trim()),
                new SqlParameter("@gvcn", cbGVCN.SelectedValue)
            };
                    DataProvider.ExcuteNonQuery_trans(sqlLop, CommandType.Text, spLop, conn, tran);

                    //update gv
                    string sqlGV = $"UPDATE GiaoVien SET TrangThai = @tt WHERE GiaoVienID = @id";
                    DataProvider.ExcuteNonQuery_trans(sqlGV, CommandType.Text,
                        new SqlParameter[] {
                    new SqlParameter("@tt", TrangThai_2),
                    new SqlParameter("@id", cbGVCN.SelectedValue)
                        }, conn, tran);

                    tran.Commit();
                    MessageBox.Show("Thêm lớp thành công!");
                    LamMoiGiaoDien();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi thêm lớp: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            if (string.IsNullOrEmpty(maLop)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        // lấy gv cũ
                        string sqlGetGV = "SELECT GiaoVienID FROM Lop WHERE MaLop = @malop";
                        SqlCommand cmd = new SqlCommand(sqlGetGV, conn, tran);
                        cmd.Parameters.AddWithValue("@malop", maLop);
                        object result = cmd.ExecuteScalar();
                        string gvID = result != DBNull.Value ? result?.ToString() : null;

                        // xóa
                        string sqlDel = "DELETE FROM Lop WHERE MaLop = @malop";
                        DataProvider.ExcuteNonQuery_trans(sqlDel, CommandType.Text,
                            new SqlParameter[] { new SqlParameter("@malop", maLop) }, conn, tran);

                        // nhả phân công
                        if (!string.IsNullOrEmpty(gvID))
                        {
                            string sqlUpdateGV = "UPDATE GiaoVien SET TrangThai = @tt WHERE GiaoVienID = @id";
                            DataProvider.ExcuteNonQuery_trans(sqlUpdateGV, CommandType.Text,
                                new SqlParameter[] {
                            new SqlParameter("@tt", TrangThai_1),
                            new SqlParameter("@id", gvID)
                                }, conn, tran);
                        }

                        tran.Commit();
                        MessageBox.Show("Xóa thành công!");
                        LamMoiGiaoDien();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            if (string.IsNullOrEmpty(maLop)) return;

   
            string gvMoiID = cbGVCN.SelectedValue?.ToString();

            using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // Lấy GV cũ 
                    string sqlCheck = "SELECT GiaoVienID FROM Lop WHERE MaLop = @malop";
                    SqlCommand cmd = new SqlCommand(sqlCheck, conn, tran);
                    cmd.Parameters.AddWithValue("@malop", maLop);
                    string gvCuID = cmd.ExecuteScalar()?.ToString();

                
                    if (gvCuID != gvMoiID)
                    {
                      
                        if (!string.IsNullOrEmpty(gvCuID))
                        {
                            DataProvider.ExcuteNonQuery_trans("UPDATE GiaoVien SET TrangThai = @tt WHERE GiaoVienID = @id",
                                CommandType.Text, new SqlParameter[] {
                            new SqlParameter("@tt", TrangThai_1),
                            new SqlParameter("@id", gvCuID)
                                }, conn, tran);
                        }

                        // update trạng thái
                        if (!string.IsNullOrEmpty(gvMoiID))
                        {
                            DataProvider.ExcuteNonQuery_trans("UPDATE GiaoVien SET TrangThai = @tt WHERE GiaoVienID = @id",
                                CommandType.Text, new SqlParameter[] {
                            new SqlParameter("@tt", TrangThai_2),
                            new SqlParameter("@id", gvMoiID)
                                }, conn, tran);
                        }
                    }

                    
                    string sqlUpdateLop = "UPDATE Lop SET TenLop = @ten, SiSoToiDa = @siso, GiaoVienID = @gvid WHERE MaLop = @malop";
                    SqlParameter[] spLop = {
                new SqlParameter("@ten", txtTenLop.Text.Trim()),
                new SqlParameter("@siso", txtSiSoToiDa.Text.Trim()),
                new SqlParameter("@gvid", string.IsNullOrEmpty(gvMoiID) ? DBNull.Value : (object)gvMoiID),
                new SqlParameter("@malop", maLop)
            };
                    DataProvider.ExcuteNonQuery_trans(sqlUpdateLop, CommandType.Text, spLop, conn, tran);

                    tran.Commit();
                    MessageBox.Show("Cập nhật thành công!");
                    LamMoiGiaoDien();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                }
            }
        }
    }



}
        