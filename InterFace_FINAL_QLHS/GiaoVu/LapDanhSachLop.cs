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
using System.Security.AccessControl;

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class LapDanhSachLop : Form
    {
        public LapDanhSachLop()
        {
            InitializeComponent();
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

        private void Load_DS_TN(string khoiLop) {
            string kl = khoiLop;
            string selected_VL = cbKhoiTN.SelectedValue != null ? cbKhoiTN.SelectedValue.ToString() : "--Chọn Khối Lớp--";
            string sql = "";
            if (kl == "--Chọn Khối Lớp--")
            {
                sql = $"SELECT * From TiepNhanHS Where TrangThai=N'Chưa Phân Lớp'";
            }
            else
            {
                sql = $"SELECT * From TiepNhanHS Where TrangThai=N'Chưa Phân Lớp' AND KhoiLop=N'{kl}'";
            }


            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            dgvTN.DataSource = dt;

            dgvTN.Columns[0].HeaderText = "Mã Tiếp Nhận";
            dgvTN.Columns[1].HeaderText = "Họ Tên";
            dgvTN.Columns[2].HeaderText = "Ngày Sinh";
            dgvTN.Columns[3].HeaderText = "Giới Tính";
            dgvTN.Columns[4].HeaderText = "Địa Chỉ";
            dgvTN.Columns[5].HeaderText = "Email";
            dgvTN.Columns[6].HeaderText = "Số Điện Thoại";
            dgvTN.Columns[7].HeaderText = "Khối Lớp";
            dgvTN.Columns[8].HeaderText = "Tên Phụ Huynh";
            dgvTN.Columns[9].HeaderText = "Ngày Tiếp Nhận";

            string sql2 = "SELECT DISTINCT KhoiLop From TiepNhanHS ORDER BY KhoiLop";
            DataTable dt2 = DataProvider.TruyVan_LayDuLieu(sql2);

            DataRow dtr = dt2.NewRow();
            dtr[0] = "--Chọn Khối Lớp--";
            dt2.Rows.InsertAt(dtr, 0);
            cbKhoiTN.DataSource = dt2;
            cbKhoiTN.DisplayMember = "KhoiLop";
            cbKhoiTN.ValueMember = "KhoiLop";

            if (selected_VL != null && dt2.AsEnumerable().Any(r => r[0].ToString() == selected_VL))
            {
                cbKhoiTN.SelectedValue = selected_VL;
            }

        }

        private void Load_Lop(string lop) {
            string sql = "";
            if (lop == "--Chọn Lớp--")
            {
                sql = $"SELECT l.* , gv.HoTen From Lop l " +
                $"LEFT JOIN GiaoVien gv on l.GiaoVienID = gv.GiaoVienID";
            }
            else
            {
                sql = $"SELECT l.* , gv.HoTen From Lop l " +
                   $"LEFT JOIN GiaoVien gv on l.GiaoVienID = gv.GiaoVienID Where l.MaLop=N'{lop}'";
            }
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            txtGVCN.Text = dt.Rows[0]["HoTen"] == DBNull.Value ? "" : dt.Rows[0]["HoTen"].ToString();
            txtSiSo.Text = dt.Rows[0]["SiSo"] == DBNull.Value ? "" : dt.Rows[0]["SiSo"].ToString();

            DataRow row = dt.NewRow();
            row["MaLop"] = "--Chọn Lớp--";
            dt.Rows.InsertAt(row, 0);

            cbLop.DataSource = dt;
            cbLop.DisplayMember = "MaLop";
            cbLop.ValueMember = "MaLop";


        }

        private void LoadThongTinLop(string lop)
        {
            if (lop == "--Chọn Lớp--") return;

            string sql = $"SELECT l.*, gv.HoTen FROM Lop l LEFT JOIN GiaoVien gv ON l.GiaoVienID = gv.GiaoVienID WHERE l.MaLop = '{lop}'";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                txtGVCN.Text = row["HoTen"] == DBNull.Value
                    ? "Chưa có GVCN"
                    : "Giáo viên chủ nhiệm: " + row["HoTen"].ToString();

                txtSiSo.Text = row["SiSo"] == DBNull.Value
                    ? "Sỉ số: " + "0" + "/" + row["SiSoToiDa"].ToString()
                    : "Sỉ số: " + row["SiSo"].ToString() + "/" + row["SiSoToiDa"].ToString();

                dgvLop.DataSource = dt;
            }

            string lopNew = cbLop.SelectedValue != null ? cbLop.SelectedValue.ToString() : "--Chọn Lớp--";

            string sql2 = $@"
                    SELECT hs.*
                    FROM HocSinh hs
                    INNER JOIN QuaTrinhHocTap qt ON hs.MaHs = qt.MaHs
                    INNER JOIN Lop l ON qt.MaLop = l.MaLop
                    WHERE l.MaLop = '{lopNew}'
                    ";

            DataTable dt2 = DataProvider.TruyVan_LayDuLieu(sql2);
            dgvLop.DataSource = dt2;
            dgvLop.Columns[0].HeaderText = "Mã Học Sinh";
            dgvLop.Columns[1].HeaderText = "Họ Tên";
            dgvLop.Columns[2].HeaderText = "Ngày Sinh";
            dgvLop.Columns[3].HeaderText = "Giới Tính";
            dgvLop.Columns[4].HeaderText = "Địa Chỉ";
            dgvLop.Columns[5].HeaderText = "Email";
            dgvLop.Columns[6].HeaderText = "Số Điện Thoại";
            dgvLop.Columns[7].HeaderText = "Tên Phụ Huynh";

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];

                txtGVCN.Text = row["HoTen"] == DBNull.Value
                    ? "Chưa có GVCN"
                    : "Giáo viên chủ nhiệm: " + row["HoTen"].ToString();

                
                string siSoToiDa = row["SiSoToiDa"] != DBNull.Value ? row["SiSoToiDa"].ToString() : "40";

                
                int siSoHienTai = dt2.Rows.Count;

                txtSiSo.Text = $"Sỉ số: {siSoHienTai}/{siSoToiDa}";
            }
        }

        private void Load_NH()
        {
            string sql = "SELECT * From NamHoc";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            cbNamHoc.DataSource = dt;

            DataRow row = dt.NewRow();
            row["MaNamHoc"] = DBNull.Value;
            row["TenNamHoc"] = "--Chọn Năm Học--";
            dt.Rows.InsertAt(row, 0);
            cbNamHoc.DisplayMember = "TenNamHoc";
            cbNamHoc.ValueMember = "MaNamHoc";

            cbNamHoc.SelectedIndex = 0;
        }

        private void LapDanhSachLop_Load(object sender, EventArgs e)
        {
            Load_DS_TN("--Chọn Khối Lớp--");
            Load_Lop("--Chọn Lớp--");
            Load_NH();


        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            if (cbKhoiTN.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn khối lớp để xếp lớp tự động.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTimHSTN_Click(object sender, EventArgs e)
        {
            Load_DS_TN(cbKhoiTN.SelectedValue.ToString());
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            LoadThongTinLop(cbLop.SelectedValue.ToString());
        }

        private void btnThemVaoLop_Click(object sender, EventArgs e)
        {
            XepLop_TC();
        }

        private void XepLop_TC()
        {
            // kiểm tra đk
            if (cbNamHoc.SelectedIndex == 0 || cbNamHoc.SelectedValue == null)
            {
                MessageBox.Show("Chọn năm học để xếp lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbLop.SelectedIndex == 0 || cbLop.SelectedValue == null || cbLop.SelectedValue.ToString() == "--Chọn Lớp--")
            {
                MessageBox.Show("Cần chọn một lớp cụ thể để xếp học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check dgv
            if (dgvTN.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cần chọn ít nhất một học sinh từ danh sách tiếp nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = cbLop.SelectedValue.ToString();
            string maNamHoc = cbNamHoc.SelectedValue.ToString(); // VD: "NH2526"


            string sqlTuoiMin = "SELECT GiaTri FROM ThamSo WHERE MaThamSo = 'TuoiTT'";
            string sqlTuoiMax = "SELECT GiaTri FROM ThamSo WHERE MaThamSo = 'TuoiTD'";

            DataTable dtTuoiMin = DataProvider.TruyVan_LayDuLieu(sqlTuoiMin);
            DataTable dtTuoiMax = DataProvider.TruyVan_LayDuLieu(sqlTuoiMax);

            if (dtTuoiMin.Rows.Count == 0 || dtTuoiMax.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu tuổi trong CSDL!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tuoiMin = Convert.ToInt32(dtTuoiMin.Rows[0]["GiaTri"]);
            int tuoiMax = Convert.ToInt32(dtTuoiMax.Rows[0]["GiaTri"]);
            int namHienTai = DateTime.Now.Year;
            int soLuongThanhCong = 0;

            // --- THÊM MỚI: LẤY THÔNG TIN SĨ SỐ LỚP ---
            string sqlCheckSiSo = $@"
        SELECT SiSoToiDa, 
        (SELECT COUNT(*) FROM QuaTrinhHocTap WHERE MaLop = '{maLop}' AND MaNamHoc = '{maNamHoc}') as SiSoHienTai
        FROM Lop WHERE MaLop = '{maLop}'";
            DataTable dtSiSo = DataProvider.TruyVan_LayDuLieu(sqlCheckSiSo);
            int siSoToiDa = 40;
            int siSoHienTai = 0;
            if (dtSiSo.Rows.Count > 0)
            {
                siSoToiDa = dtSiSo.Rows[0]["SiSoToiDa"] != DBNull.Value ? Convert.ToInt32(dtSiSo.Rows[0]["SiSoToiDa"]) : 40;
                siSoHienTai = dtSiSo.Rows[0]["SiSoHienTai"] != DBNull.Value ? Convert.ToInt32(dtSiSo.Rows[0]["SiSoHienTai"]) : 0;
            }
    

            //Mở transaction -- xếp lớp chỗ này nha quý dị
            using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvTN.SelectedRows)
                {
                    //check sỉ số
                    if (siSoHienTai >= siSoToiDa)
                    {
                        MessageBox.Show($"Lớp {maLop} đã đầy (Tối đa {siSoToiDa} HS). Không thể thêm tiếp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    

                    string maTN = row.Cells["MaTiepNhan"].Value.ToString();
                    string hoTen = row.Cells["HoTen"].Value.ToString();
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                    string khoiLop = row.Cells["KhoiLop"].Value.ToString();

                    // Kiểm tra tuổi
                    int tuoiHocSinh = namHienTai - ngaySinh.Year;
                    if (tuoiHocSinh < tuoiMin || tuoiHocSinh > tuoiMax)
                    {
                        MessageBox.Show($"Học sinh {hoTen} ({tuoiHocSinh} tuổi) không đủ điều kiện độ tuổi ({tuoiMin} - {tuoiMax}). Sẽ bị bỏ qua.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    // Kiểm tra khối
                    if (!maLop.StartsWith(khoiLop))
                    {
                        MessageBox.Show($"Học sinh {hoTen} (Khối {khoiLop}) không thể xếp vào lớp {maLop}. Sẽ bị bỏ qua.", "Cảnh báo logic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        // Tạo mã hs theo Sql Sequence
                        string sqlGetSeq = "SELECT NEXT VALUE FOR Seq_HocSinh";
                        using (SqlCommand cmdSeq = new SqlCommand(sqlGetSeq, conn, tran))
                        {
                            int seqValue = Convert.ToInt32(cmdSeq.ExecuteScalar());

                            string maHSMoi = "HS" + seqValue.ToString("D4");

                            // Tạo mã quá trình: mhs + MNH = HS0001NH2526
                            string maQuaTrinh = maHSMoi + maNamHoc;

                            // insert HS
                            string sqlInsertHS = @"INSERT INTO HocSinh (MaHs, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, TenPh)                 
                                    SELECT @MaHS, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, TenPh                 FROM TiepNhanHS WHERE MaTiepNhan = @MaTN";
                            SqlParameter[] pHS = {
                new SqlParameter("@MaHS", maHSMoi),
                new SqlParameter("@MaTN", maTN)
            };
                            DataProvider.ExcuteNonQuery_trans(sqlInsertHS, CommandType.Text, pHS, conn, tran);

                            // insert QuaTrinhHocTap
                            string sqlInsertQT = @"                INSERT INTO QuaTrinhHocTap (MaQuaTrinh, MaHs, MaNamHoc, MaLop, TrangThai)               
                                            VALUES (@MaQuaTrinh, @MaHS, @MaNamHoc, @MaLop, @TrangThai)";
                            SqlParameter[] pQT = {
                new SqlParameter("@MaQuaTrinh", maQuaTrinh),
                new SqlParameter("@MaHS", maHSMoi),
                new SqlParameter("@MaNamHoc", maNamHoc),
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@TrangThai", "Đang học") 
            };
                            DataProvider.ExcuteNonQuery_trans(sqlInsertQT, CommandType.Text, pQT, conn, tran);
                        }

                        //  Cập nhật trạng thái bảng TiepNhanHS
                        string sqlUpdateTN = @"UPDATE TiepNhanHS SET TrangThai = @TrangThai WHERE MaTiepNhan = @MaTN";
                        SqlParameter[] pTN = {
            new SqlParameter("@TrangThai", "Đang Học Lớp " + maLop),
            new SqlParameter("@MaTN", maTN)
        };
                        DataProvider.ExcuteNonQuery_trans(sqlUpdateTN, CommandType.Text, pTN, conn, tran);

                        //Uodate SiSo 
                        string sqlUpdateSiSoLop = @"UPDATE Lop SET SiSo = @SiSoMoi WHERE MaLop = @MaLop";
                        SqlParameter[] pUpdSiSo = { new SqlParameter("@SiSoMoi", siSoHienTai + 1), new SqlParameter("@MaLop", maLop) };
                        DataProvider.ExcuteNonQuery_trans(sqlUpdateSiSoLop, CommandType.Text, pUpdSiSo, conn, tran);
                        

                        // Commit transaction 
                        tran.Commit();
                        soLuongThanhCong++;
                        siSoHienTai++; 
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show($"Gặp lỗi CSDL khi xếp học sinh {hoTen}: \n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } // Đóng connection

            //
            if (soLuongThanhCong > 0)
            {
                MessageBox.Show($"Xếp lớp thành công cho {soLuongThanhCong} học sinh!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string khoiLopDangChon = cbKhoiTN.SelectedValue != null ? cbKhoiTN.SelectedValue.ToString() : "--Chọn Khối Lớp--";
                Load_DS_TN(khoiLopDangChon);
                LoadThongTinLop(maLop);
            }
        }

    }
}
