using InterFace_FINAL_QLHS.Config;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;


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
            if (cbKhoiTN.SelectedIndex == -1 || cbKhoiTN.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khối lớp để xếp lớp tự động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string khoiChon = cbKhoiTN.SelectedValue.ToString();
            string soKhoi = new string(khoiChon.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(soKhoi))
            {
                MessageBox.Show("Không thể xác định số khối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Lấy danh sách học sinh
            string sqlHS = "SELECT * FROM TiepNhanHS WHERE TrangThai = N'Chưa Phân Lớp' AND KhoiLop = @Khoi";
            SqlParameter[] p1 = { new SqlParameter("@Khoi", khoiChon) };
            DataTable dtHS = DataProvider.SelectData(sqlHS, CommandType.Text, p1);

            if (dtHS.Rows.Count == 0)
            {
                MessageBox.Show("Không còn học sinh nào cần phân lớp ở khối này.", "Thông báo");
                return;
            }

            // 2. Lấy danh sách lớp
            string sqlLop = "SELECT MaLop, TenLop, ISNULL(SiSo, 0) as SiSo, SiSoToiDa FROM Lop WHERE MaLop LIKE @SoKhoi + '%' ORDER BY SiSo ASC";
            SqlParameter[] p2 = { new SqlParameter("@SoKhoi", soKhoi) };
            DataTable dtLop = DataProvider.SelectData(sqlLop, CommandType.Text, p2);

            if (dtLop.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy lớp nào có Mã Lớp bắt đầu bằng '{soKhoi}'!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    int lopIndex = 0;
                    int count = 0;

                    if (cbNamHoc.SelectedIndex == 0 || cbNamHoc.SelectedValue == null)
                    {
                        MessageBox.Show("Chọn năm học để xếp lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string maNamHocHienTai = cbNamHoc.SelectedValue.ToString();

                    foreach (DataRow hs in dtHS.Rows)
                    {
                        bool daXep = false;
                        int thuLai = 0;

                        while (!daXep && thuLai < dtLop.Rows.Count)
                        {
                            DataRow currentLop = dtLop.Rows[lopIndex];
                            int siSoHienTai = Convert.ToInt32(currentLop["SiSo"]);
                            int siSoMax = Convert.ToInt32(currentLop["SiSoToiDa"]);

                            if (siSoHienTai < siSoMax)
                            {
                                string maLop = currentLop["MaLop"].ToString();
                                string maTN = hs["MaTiepNhan"].ToString();

                                string sqlGetSeq = "SELECT NEXT VALUE FOR Seq_HocSinh";
                                int seqValue;
                                using (SqlCommand cmdSeq = new SqlCommand(sqlGetSeq, conn, trans)) // Dùng biến 'trans' của nút tự động
                                {
                                    seqValue = Convert.ToInt32(cmdSeq.ExecuteScalar());
                                }
                                string maHS_Moi = "HS" + seqValue.ToString("D4");

                                // ạo mã quá trình giống thủ công luôn (Mã HS + Mã Năm Học) cho gọn và nhất quán, bỏ Guid đi
                                string maQT = maHS_Moi + maNamHocHienTai;
                            


                                string sqlInsHS = "INSERT INTO HocSinh (MaHS, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, TenPh) " +
                                                  "VALUES (@MaHS, @Ten, @NS, @GT, @DC, @Mail, @Sdt, @PH)";
                                DataProvider.ExcuteNonQuery_trans(sqlInsHS, CommandType.Text, new SqlParameter[] {
                                            new SqlParameter("@MaHS", maHS_Moi),
                                            new SqlParameter("@Ten", hs["HoTen"]),
                                            new SqlParameter("@NS", hs["NgaySinh"]),
                                            new SqlParameter("@GT", hs["GioiTinh"]),
                                            new SqlParameter("@DC", hs["DiaChi"]),
                                            new SqlParameter("@Mail", hs["Email"] ?? (object)DBNull.Value),
                                            new SqlParameter("@Sdt", hs["SoDienThoai"] ?? (object)DBNull.Value),
                                            new SqlParameter("@PH", hs["TenPH"] ?? (object)DBNull.Value)
                                        }, conn, trans);

                                // B. Thêm QuaTrinhHocTap 
                                string sqlInsQT = "INSERT INTO QuaTrinhHocTap (MaQuaTrinh, MaHS, MaNamHoc, MaLop, TrangThai) " +
                                                  "VALUES (@QT, @MaHS, @MaNH, @Lop, N'Đang Học')";
                                DataProvider.ExcuteNonQuery_trans(sqlInsQT, CommandType.Text, new SqlParameter[] {
                                        new SqlParameter("@QT", maQT),           // Dùng mã QT mới
                                        new SqlParameter("@MaHS", maHS_Moi),
                                        new SqlParameter("@MaNH", maNamHocHienTai),
                                        new SqlParameter("@Lop", maLop)
                                    }, conn, trans);

                                // C. Cập nhật trạng thái Tiếp nhận
                                string sqlUpTN = "UPDATE TiepNhanHS SET TrangThai = N'Đã Phân Lớp' WHERE MaTiepNhan = @MaTN";
                                DataProvider.ExcuteNonQuery_trans(sqlUpTN, CommandType.Text, new SqlParameter[] { new SqlParameter("@MaTN", maTN) }, conn, trans);

                                // D. Cập nhật Sĩ số
                                string sqlUpLop = "UPDATE Lop SET SiSo = ISNULL(SiSo, 0) + 1 WHERE MaLop = @MaLop";
                                DataProvider.ExcuteNonQuery_trans(sqlUpLop, CommandType.Text, new SqlParameter[] { new SqlParameter("@MaLop", maLop) }, conn, trans);

                                currentLop["SiSo"] = siSoHienTai + 1;
                                daXep = true;
                                count++;
                            }
                            lopIndex = (lopIndex + 1) % dtLop.Rows.Count;
                            thuLai++;
                        }
                    }

                    trans.Commit();
                    MessageBox.Show($"Đã phân lớp thành công cho {count} học sinh!", "Thành công");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    // Show lỗi chi tiết để dễ xử lý
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    Load_DS_TN(khoiChon);
                }
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
            new SqlParameter("@TrangThai", "Đã Phân Lớp"),
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

        private void Rut_HS() {
            if (cbLop.SelectedIndex == 0 || cbLop.SelectedValue == null || cbLop.SelectedValue.ToString() == "--Chọn Lớp--")
            {
                MessageBox.Show("Chọn lớp cụ thể để rút học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvLop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một học sinh trong danh sách lớp để rút!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = cbLop.SelectedValue.ToString();
            string maNamHoc = cbNamHoc.SelectedValue.ToString();

            // 2. Hiển thị cảnh báo xác nhận
            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn rút {dgvLop.SelectedRows.Count} học sinh khỏi lớp {maLop}?\nThao tác này sẽ đưa học sinh trở lại danh sách Tiếp nhận và chờ phân lớp.\n Hãy đảm bảo rằng hành động này được thực hiện ở vào đầu năm học và học sinh chưa có bất kì điểm gì trong quá trình học tập",
                "Cảnh báo rút học sinh",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int soLuongThanhCong = 0;

                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvLop.SelectedRows)
                    {
                        string maHS = row.Cells["MaHs"].Value.ToString();
                        string hoTen = row.Cells["HoTen"].Value.ToString();
                        DateTime ngaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                        SqlTransaction tran = conn.BeginTransaction();
                        try
                        {
                            // Xóa  QuaTrinhHocTap
                            string sqlDelQT = "DELETE FROM QuaTrinhHocTap WHERE MaHs = @MaHS";
                            DataProvider.ExcuteNonQuery_trans(sqlDelQT, CommandType.Text, new SqlParameter[] {
                                new SqlParameter("@MaHS", maHS)
                            }, conn, tran);

                            // Trả trạng thái trong TiepNhanHS về 'Chưa Phân Lớp'

                            string sqlUpdateTN = "UPDATE TiepNhanHS SET TrangThai = N'Chưa Phân Lớp' WHERE HoTen = @HoTen AND NgaySinh = @NgaySinh";
                            DataProvider.ExcuteNonQuery_trans(sqlUpdateTN, CommandType.Text, new SqlParameter[] {
                                    new SqlParameter("@HoTen", hoTen),
                                    new SqlParameter("@NgaySinh", ngaySinh) 
                                }, conn, tran);

                            //  Xóa học sinh khỏi bảng HocSinh 
                            string sqlDelHS = "DELETE FROM HocSinh WHERE MaHs = @MaHS";
                            DataProvider.ExcuteNonQuery_trans(sqlDelHS, CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@MaHS", maHS)
                    }, conn, tran);

                            // Bước D: Giảm Sĩ số của Lớp
                            string sqlUpdLop = "UPDATE Lop SET SiSo = ISNULL(SiSo, 1) - 1 WHERE MaLop = @MaLop";
                            DataProvider.ExcuteNonQuery_trans(sqlUpdLop, CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@MaLop", maLop)
                    }, conn, tran);

                            // Commit transaction
                            tran.Commit();
                            soLuongThanhCong++;
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show($"Lỗi khi rút học sinh {hoTen}: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } // Đóng connection

                // 3. Thông báo và Load lại dữ liệu
                if (soLuongThanhCong > 0)
                {
                    MessageBox.Show($"Đã rút thành công {soLuongThanhCong} học sinh khỏi lớp {maLop}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload lại GridView lớp và lưới Tiếp Nhận
                    LoadThongTinLop(maLop);
                    string khoiLopDangChon = cbKhoiTN.SelectedValue != null ? cbKhoiTN.SelectedValue.ToString() : "--Chọn Khối Lớp--";
                    Load_DS_TN(khoiLopDangChon);
                }
            }
        
    }

        private void btnRutKhoiLop_Click(object sender, EventArgs e)
        {
            Rut_HS();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu trên DataGridView
            // Giả sử tên lưới của bạn là dgvDanhSachLop (thay đổi nếu tên khác)
            if (dgvLop.Rows.Count == 0 || (dgvLop.Rows.Count == 1 && dgvLop.Rows[0].IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu trong danh sách để xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Cấu hình bản quyền EPPlus (Cách này giải quyết triệt để lỗi gạch đỏ/read-only)
            // Bạn có thể thay "Hệ thống QLHS" bằng biến chứa tên người dùng nếu muốn
            OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("Hệ thống Quản lý Học sinh");

            // 3. Khởi tạo hộp thoại lưu file
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Chọn nơi lưu danh sách lớp";
                sfd.FileName = "Danh_Sach_Lop_" + cbLop.Text + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo file = new FileInfo(sfd.FileName);

                        // Nếu file đã tồn tại thì xóa đi để tạo mới hoàn toàn
                        if (file.Exists) file.Delete();

                        using (ExcelPackage package = new ExcelPackage(file))
                        {
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("DanhSachLop");

                            // 1. TRANG TRÍ TIÊU ĐỀ CHÍNH (Dòng 1)
                            // Giả sử bảng có khoảng 6 cột (từ A đến F)
                            ws.Cells["A1:F1"].Merge = true;
                            ws.Cells["A1"].Value = "DANH SÁCH HỌC SINH";
                            ws.Cells["A1"].Style.Font.Size = 16;
                            ws.Cells["A1"].Style.Font.Bold = true;
                            ws.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                            // 2. HIỂN THỊ MÃ LỚP (Dòng 2)
                            // Lấy giá trị từ ComboBox lớp của bạn (ví dụ: cbLop)
                            ws.Cells["A2:F2"].Merge = true;
                            ws.Cells["A2"].Value = "Lớp: " + (cbLop.Text ?? "........");
                            ws.Cells["A2"].Style.Font.Italic = true;
                            ws.Cells["A2"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                            // 3. ĐỔ HEADER (Dòng 4 - Chừa khoảng trống cho đẹp)
                            int columnCount = dgvLop.Columns.Count;
                            for (int i = 0; i < columnCount; i++)
                            {
                                var cell = ws.Cells[4, i + 1];
                                cell.Value = dgvLop.Columns[i].HeaderText;

                                // Style cho Header
                                cell.Style.Font.Bold = true;
                                cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightSkyBlue);
                                cell.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            }

                            // 4. ĐỔ DỮ LIỆU VÀ XỬ LÝ ĐỊNH DẠNG NGÀY THÁNG (Bắt đầu dòng 5)
                            int rowIndex = 5;
                            for (int i = 0; i < dgvLop.Rows.Count; i++)
                            {
                                if (dgvLop.Rows[i].IsNewRow) continue;

                                for (int j = 0; j < columnCount; j++)
                                {
                                    var cell = ws.Cells[rowIndex, j + 1];
                                    var value = dgvLop.Rows[i].Cells[j].Value;

                                    cell.Value = value;
                                    cell.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                                    // FIX LỖI CÓ GIỜ: Kiểm tra nếu là cột "Ngày Sinh"
                                    if (dgvLop.Columns[j].HeaderText.Contains("Ngày Sinh"))
                                    {
                                        // Định dạng chuẩn VN: Ngày/Tháng/Năm
                                        cell.Style.Numberformat.Format = "dd/mm/yyyy";
                                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                                    }
                                }
                                rowIndex++;
                            }

                            ws.Cells[ws.Dimension.Address].AutoFitColumns();
                            MessageBox.Show("Xuất file Excel danh sách lớp thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            package.Save();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
