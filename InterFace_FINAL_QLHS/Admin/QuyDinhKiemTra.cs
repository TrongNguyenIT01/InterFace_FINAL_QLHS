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
            DataRow loaidiem = dt.NewRow();
            loaidiem["TenLoaiDiem"] = "--Chọn loại điểm--";
            loaidiem["MaLoaiDiem"] = DBNull.Value;
            dt.Rows.InsertAt(loaidiem, 0);
            cbLoaiDiem.DisplayMember = "TenLoaiDiem";
            cbLoaiDiem.ValueMember = "MaLoaiDiem";
            cbLoaiDiem.SelectedIndex = 0;

            //--
            cbMonHoc.DataSource = dt2;
            DataRow monHoc = dt2.NewRow();
            monHoc["TenMon"] = "--Chọn Môn--";
            monHoc["MaMon"] = DBNull.Value;
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
            if (cbLoaiDiem.SelectedValue == DBNull.Value || cbMonHoc.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Loại Điểm Hoặc Môn Học KHÔNG Được Để trống", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string maloai = cbLoaiDiem.SelectedValue.ToString();
            string mamon = cbMonHoc.SelectedValue.ToString();

            
            string sql = @"SELECT 1 FROM QuyDinhDiem WHERE MaLoaiDiem = @maloai AND MaMon = @mamon";

            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@maloai", maloai),
                new SqlParameter("@mamon", mamon)
                    };

           
            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, sp);

           
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Quy định kiểm tra này đã tồn tại!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        string sql = "INSERT INTO QuyDinhDiem (MaMon, MaLoaiDiem, SoLanKT) VALUES (@MaMon, @MaLoai, @SoLan)";
                        SqlParameter[] paras = new SqlParameter[]
                        {
                            new SqlParameter("@MaMon", cbMonHoc.SelectedValue.ToString()),
                            new SqlParameter("@MaLoai", cbLoaiDiem.SelectedValue.ToString()),
                            new SqlParameter("@SoLan", (int)numSL.Value)
                            };

                        DataProvider.ExcuteNonQuery_trans(sql, CommandType.Text, paras, conn, tran);
                        tran.Commit();
                        MessageBox.Show("Thêm quy định thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Load_DGV();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Thêm quy định thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM QuyDinhDiem WHERE MaMon=@MaMon AND MaLoaiDiem =@MaLoai";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaLoai", cbLoaiDiem.SelectedValue.ToString()),
                new SqlParameter("@MaMon",cbMonHoc.SelectedValue.ToString())
            };
            if (MessageBox.Show("Bạn có chắc muốn xóa quy định điểm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0)
                {
                    MessageBox.Show("Đã xóa loại điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DGV();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
            if (cbLoaiDiem.SelectedValue == null || cbLoaiDiem.SelectedValue == DBNull.Value ||
                cbMonHoc.SelectedValue == null || cbMonHoc.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Môn Học và Loại Điểm!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

       
            string sql = "UPDATE QuyDinhDiem SET SoLanKT = @SoLan WHERE MaMon = @MaMon AND MaLoaiDiem = @MaLoai";

            SqlParameter[] sp = new SqlParameter[]
            {
        new SqlParameter("@SoLan", (int)numSL.Value),
        new SqlParameter("@MaMon", cbMonHoc.SelectedValue.ToString()),
        new SqlParameter("@MaLoai", cbLoaiDiem.SelectedValue.ToString())
            };

           
            try
            {
                if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, sp) > 0)
                {
                    MessageBox.Show("Cập nhật quy định điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DGV();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quy định này để cập nhật (Có thể chưa tồn tại)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
