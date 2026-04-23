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
            string searchText = txtNhapTenHoacMaHS.Text.Trim();
            string maLop = cbChonLop.SelectedValue?.ToString() ?? "TatCa";

            string query = @"
                WITH DiemMonTable AS (
                    SELECT dtp.MaHS, dtp.MaHK, dtp.MaMon,
                    (SUM(dtp.GiaTriDiem * ld.HeSo) + MAX(ISNULL(dck.Diem, 0)) * 3) / (SUM(ld.HeSo) + 3) as DiemTBMon
                    FROM DiemThanhPhan dtp
                    JOIN LoaiDiem ld ON dtp.MaLoaiDiem = ld.MaLoaiDiem
                    LEFT JOIN DiemCK dck ON dtp.MaHS = dck.MaHS AND dtp.MaMon = dck.MaMon AND dtp.MaHK = dck.MaHK
                    GROUP BY dtp.MaHS, dtp.MaHK, dtp.MaMon
                ),
                DiemHocKy AS (
                    SELECT MaHS, MaHK, AVG(DiemTBMon) as TBHK
                    FROM DiemMonTable
                    GROUP BY MaHS, MaHK
                )
                SELECT DISTINCT
                    hs.MaHS AS [Mã HS],
                    hs.HoTen AS [Họ Tên],
                    l.TenLop AS [Lớp],
                    FORMAT(ISNULL((SELECT TBHK FROM DiemHocKy WHERE MaHS = hs.MaHS AND MaHK = 'HK1'), 0), 'N2') AS [TB HK I],
                    FORMAT(ISNULL((SELECT TBHK FROM DiemHocKy WHERE MaHS = hs.MaHS AND MaHK = 'HK2'), 0), 'N2') AS [TB HK II]
                FROM HocSinh hs
                JOIN QuaTrinhHocTap qt ON hs.MaHS = qt.MaHS
                JOIN Lop l ON qt.MaLop = l.MaLop
                JOIN PhanCongGiangDay pc ON l.MaLop = pc.MaLop
                WHERE pc.GiaoVienID = (SELECT UserID FROM Users WHERE UserName = @Username)";

            if (!string.IsNullOrEmpty(searchText))
            {
                query += " AND (hs.HoTen LIKE N'%' + @search + '%' OR hs.MaHS LIKE '%' + @search + '%')";
            }

            if (maLop != "TatCa")
            {
                query += " AND l.MaLop = @maLop";
            }

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@Username", Session.UserName),
                new SqlParameter("@search", searchText),
                new SqlParameter("@maLop", maLop)
            };

            DataTable dt = DataProvider.SelectData(query, CommandType.Text, paras);
            dgvDanhSachHocSinh.DataSource = dt;
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
