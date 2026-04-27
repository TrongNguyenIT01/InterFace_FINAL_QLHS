using InterFace_FINAL_QLHS.Config;
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

namespace InterFace_FINAL_QLHS.GiaoVien
{
    public partial class TraCuuHocSinh : Form
    {
        public TraCuuHocSinh()
        {
            InitializeComponent();
        }

        private void TraCuuHocSinh_Load(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtNhapTenHoacMaHS.Text.Trim();
                string maLop = cbChonLop.SelectedValue?.ToString();

                // Chỉ cần 3 tham số, không cần bận tâm về Năm học nữa
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@Username", Session.UserName),
                    new SqlParameter("@SearchTerm", string.IsNullOrEmpty(searchText) ? (object)DBNull.Value : searchText),
                    new SqlParameter("@MaLop", (maLop == "TatCa" || string.IsNullOrEmpty(maLop)) ? (object)DBNull.Value : maLop)
                };

                // Gọi Procedure (Nó sẽ tự biết lấy năm học mới nhất để tính điểm)
                DataTable dt = DataProvider.SelectData("sp_TraCuuHocSinh_ChoGiaoVien", CommandType.StoredProcedure, paras);

                dgvDanhSachHocSinh.DataSource = dt;
                dgvDanhSachHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        void LoadLop()
        {
            // Query này lồng thêm một câu SELECT để tìm GiaoVienID từ UserName trong Session
            string query = @"SELECT DISTINCT l.MaLop, l.TenLop 
                     FROM Lop l
                     JOIN PhanCongGiangDay pc ON l.MaLop = pc.MaLop
                     WHERE pc.GiaoVienID = (SELECT UserID FROM Users WHERE UserName = @Username)";

            SqlParameter[] paras = new SqlParameter[]
            {
                // Sử dụng Session.UserName mà bạn đã gán ở code đăng nhập cũ
                new SqlParameter("@Username", Session.UserName)
            };

            DataTable dt = DataProvider.SelectData(query, CommandType.Text, paras);

            // Phần code đổ vào ComboBox giữ nguyên như cũ
            DataRow dr = dt.NewRow();
            dr["MaLop"] = "TatCa";
            dr["TenLop"] = "--- Các lớp đang dạy ---";
            dt.Rows.InsertAt(dr, 0);

            cbChonLop.DataSource = dt;
            cbChonLop.DisplayMember = "TenLop";
            cbChonLop.ValueMember = "MaLop";
        }
    }
}
