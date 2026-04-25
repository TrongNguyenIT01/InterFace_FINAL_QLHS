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

        private void LoadComboBoxLop()
        {
            string sql = "SELECT MaLop, TenLop FROM Lop";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            // Thêm một lựa chọn "Tất cả lớp"
            DataRow dr = dt.NewRow();
            dr["MaLop"] = "";
            dr["TenLop"] = "--- Chọn Lớp ---";
            dt.Rows.InsertAt(dr, 0);

            cbKhoiLop.DataSource = dt;
            cbKhoiLop.DisplayMember = "TenLop";
            cbKhoiLop.ValueMember = "MaLop";
        }

        private void LoadData()
        {
            string searchKeyword = "%" + txtTimHS.Text.Trim() + "%";
            string maLop = cbKhoiLop.SelectedValue?.ToString() ?? "";

            string sql = @"
                SELECT 
                    hs.MaHS AS [Mã HS], 
                    hs.HoTen AS [Họ Tên], 
                    l.TenLop AS [Lớp],
                    CAST(ISNULL((SELECT AVG(Diem) FROM DiemCK d WHERE d.MaHS = hs.MaHS AND d.MaHK = 'HK1'), 0) AS DECIMAL(4,2)) AS [TB Học Kỳ I],
                    CAST(ISNULL((SELECT AVG(Diem) FROM DiemCK d WHERE d.MaHS = hs.MaHS AND d.MaHK = 'HK2'), 0) AS DECIMAL(4,2)) AS [TB Học Kỳ II]
                FROM HocSinh hs
                JOIN QuaTrinhHocTap qtht ON hs.MaHS = qtht.MaHS
                JOIN Lop l ON qtht.MaLop = l.MaLop
                WHERE (hs.MaHS LIKE @Search OR hs.HoTen LIKE @Search)";

            // Nếu người dùng chọn lớp cụ thể thì thêm điều kiện lọc
            if (!string.IsNullOrEmpty(maLop))
            {
                sql += " AND l.MaLop = @MaLop";
            }

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@Search", searchKeyword),
                new SqlParameter("@MaLop", maLop)
            };

            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, paras);
            dgvDanhSachHocSinh.DataSource = dt;

            // Tùy chỉnh giao diện Grid cho đẹp giống Figma
            dgvDanhSachHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnTimHS_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TraCuuHocSinh_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();
            LoadData();
        }
    }
}
