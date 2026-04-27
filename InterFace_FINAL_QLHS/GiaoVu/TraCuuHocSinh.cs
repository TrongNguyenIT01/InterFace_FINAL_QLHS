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
using System.Windows.Media;

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class TraCuuHocSinh : Form
    {
        public TraCuuHocSinh()
        {
            InitializeComponent();
        }


        private void btnTimHS_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtTimHS.Text.Trim();
                string maLop = cbKhoiLop.SelectedValue?.ToString();

                // KHÔNG viết chết NH2526 nữa, mà lấy từ ComboBox
                if (cbNamHoc.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn năm học!");
                    return;
                }
                string maNamHoc = cbNamHoc.SelectedValue.ToString();

                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@SearchTerm", string.IsNullOrEmpty(search) ? (object)DBNull.Value : search),
                    new SqlParameter("@MaLop", string.IsNullOrEmpty(maLop) ? (object)DBNull.Value : maLop),
                    new SqlParameter("@MaNamHoc", maNamHoc)
                };

                DataTable dt = DataProvider.SelectData("sp_TraCuuHocSinh_Dynamic", CommandType.StoredProcedure, paras);
                dgvDanhSachHocSinh.DataSource = dt;

                // Tùy chỉnh cột nếu cần (Đảm bảo đã chạy ALTER PROCEDURE để có tiêu đề tiếng Việt)
                dgvDanhSachHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void TraCuuHocSinh_Load(object sender, EventArgs e)
        {
            // 1. Lấy danh sách Lớp
            DataTable dtLop = DataProvider.TruyVan_LayDuLieu("SELECT MaLop, TenLop FROM Lop");
            DataRow drLop = dtLop.NewRow();
            drLop["MaLop"] = "";
            drLop["TenLop"] = "--- Tất cả lớp ---";
            dtLop.Rows.InsertAt(drLop, 0);

            cbKhoiLop.DataSource = dtLop;
            cbKhoiLop.DisplayMember = "TenLop";
            cbKhoiLop.ValueMember = "MaLop";

            // 2. Lấy danh sách Năm Học (Mới thêm)
            DataTable dtNamHoc = DataProvider.TruyVan_LayDuLieu("SELECT MaNamHoc, TenNamHoc FROM NamHoc ORDER BY TenNamHoc DESC");
            cbNamHoc.DataSource = dtNamHoc;
            cbNamHoc.DisplayMember = "TenNamHoc";
            cbNamHoc.ValueMember = "MaNamHoc";
        }
    }
}
