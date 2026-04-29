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
    public partial class PhanCongGV : Form
    {
        public PhanCongGV()
        {
            InitializeComponent();
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

        public string TaoMaTuDong(string table, string column, string prefix)
        {
            string sql = $"SELECT TOP 1 {column} FROM {table} ORDER BY {column} DESC";
            DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                string maCu = dt.Rows[0][0].ToString(); // VD: PC005
                int so = int.Parse(maCu.Replace(prefix, "")) + 1;
                return prefix + so.ToString("D3"); // Kết quả: PC006
            }
            return prefix + "001";
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ giao diện
                if (dgvChonGV.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn giáo viên!");
                    return;
                }

                string maGV = dgvChonGV.CurrentRow.Cells["GiaoVienID"].Value.ToString();
                string maLop = cbChonLop.SelectedValue.ToString();
                string maMon = cbMon.SelectedValue.ToString();
                string maHK = cbHocKy.SelectedValue.ToString();

                // --- BẮT ĐẦU ĐOẠN KIỂM TRA TRÙNG LẶP ---
                string sqlCheck = "SELECT COUNT(*) FROM PhanCongGiangDay WHERE MaLop = @MaLop AND MaMon = @MaMon AND MaHK = @MaHK";
                SqlParameter[] checkParas = {
                    new SqlParameter("@MaLop", maLop),
                    new SqlParameter("@MaMon", maMon),
                    new SqlParameter("@MaHK", maHK)
                };

                // Giả sử DataProvider của bạn có hàm ExecuteScalar hoặc bạn có thể dùng tạm DataTable
                DataTable dtCheck = DataProvider.SelectData(sqlCheck, CommandType.Text, checkParas);
                int count = int.Parse(dtCheck.Rows[0][0].ToString());

                if (count > 0)
                {
                    MessageBox.Show("Môn học này trong học kỳ này đã có giáo viên giảng dạy cho lớp này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng thực hiện lệnh INSERT
                }
                // --- KẾT THÚC ĐOẠN KIỂM TRA TRÙNG LẶP ---

                string maPC = TaoMaTuDong("PhanCongGiangDay", "MaPC", "PC");

                // 2. Câu lệnh SQL INSERT (Giữ nguyên code cũ của bạn)
                string sql = "INSERT INTO PhanCongGiangDay (MaPC, GiaoVienID, MaLop, MaMon, MaHK) " +
                             "VALUES (@MaPC, @MaGV, @MaLop, @MaMon, @MaHK)";

                SqlParameter[] paras = {
                    new SqlParameter("@MaPC", maPC),
                    new SqlParameter("@MaGV", maGV),
                    new SqlParameter("@MaLop", maLop),
                    new SqlParameter("@MaMon", maMon),
                    new SqlParameter("@MaHK", maHK)
                };

                // 3. Thực thi
                if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, paras) > 0)
                {
                    MessageBox.Show("Phân công giảng dạy thành công!");
                    LoadDanhSachPhanCong(maLop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnChonLopChuNhiem_Click(object sender, EventArgs e)
        {
            if (dgvChonLopGV.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi phân công ở bảng bên phải trước!");
                return;
            }

            string maGV = dgvChonLopGV.CurrentRow.Cells["GiaoVienID"].Value.ToString();
            string tenGVChon = dgvChonLopGV.CurrentRow.Cells["HoTen"].Value.ToString();
            string maLop = cbChonLop.SelectedValue.ToString();
            string tenLop = cbChonLop.Text;

            using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
            {
                conn.Open();

                // --- BƯỚC 1: KIỂM TRA XEM GIÁO VIÊN ĐANG CHỌN ĐÃ CHỦ NHIỆM LỚP NÀO CHƯA ---
                // Chúng ta kiểm tra cột TrangThai hoặc truy vấn trực tiếp bảng Lop
                string sqlCheckGVBận = "SELECT TenLop FROM Lop WHERE GiaoVienID = @MaGV";
                SqlCommand cmdCheckGV = new SqlCommand(sqlCheckGVBận, conn);
                cmdCheckGV.Parameters.AddWithValue("@MaGV", maGV);
                object lopHienTai = cmdCheckGV.ExecuteScalar();

                if (lopHienTai != null)
                {
                    // Nếu tìm thấy lớp mà GV này đang chủ nhiệm, thông báo và chặn lại
                    MessageBox.Show($"Giáo viên {tenGVChon} hiện đang là chủ nhiệm của lớp {lopHienTai}. \nMột giáo viên chỉ có thể chủ nhiệm một lớp!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- BƯỚC 2: KIỂM TRA LỚP ĐỊNH PHÂN CÔNG ĐÃ CÓ CHỦ NHIỆM CHƯA (Dùng lại logic cũ) ---
                string sqlCheckCN = @"SELECT GiaoVienID, (SELECT HoTen FROM GiaoVien WHERE GiaoVienID = Lop.GiaoVienID) as HoTen 
                             FROM Lop WHERE MaLop = @MaLop";

                SqlCommand cmdCheckLop = new SqlCommand(sqlCheckCN, conn);
                cmdCheckLop.Parameters.AddWithValue("@MaLop", maLop);
                DataTable dtCN = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmdCheckLop)) { da.Fill(dtCN); }

                string maGVCu = "";
                if (dtCN.Rows.Count > 0 && dtCN.Rows[0]["GiaoVienID"] != DBNull.Value)
                {
                    maGVCu = dtCN.Rows[0]["GiaoVienID"].ToString();
                    string tenGVChuNhiemCu = dtCN.Rows[0]["HoTen"].ToString();

                    DialogResult result = MessageBox.Show(
                        $"Lớp {tenLop} đã có giáo viên chủ nhiệm là: {tenGVChuNhiemCu}.\n\n" +
                        $"Bạn có muốn thay thế bằng giáo viên {tenGVChon} không?",
                        "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No) return;
                }

                // --- BƯỚC 3: THỰC HIỆN CẬP NHẬT TRONG TRANSACTION ---
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // A. Trả trạng thái GV cũ (nếu có)
                    if (!string.IsNullOrEmpty(maGVCu))
                    {
                        string sqlUpdateGVCu = "UPDATE GiaoVien SET TrangThai = N'Chưa Phân Công' WHERE GiaoVienID = @MaGVCu";
                        SqlParameter[] pOld = { new SqlParameter("@MaGVCu", maGVCu) };
                        DataProvider.ExcuteNonQuery_trans(sqlUpdateGVCu, CommandType.Text, pOld, conn, tran);
                    }

                    // B. Cập nhật mã GV mới vào bảng Lop
                    string sqlLop = "UPDATE Lop SET GiaoVienID = @MaGV WHERE MaLop = @MaLop";
                    SqlParameter[] p1 = { new SqlParameter("@MaGV", maGV), new SqlParameter("@MaLop", maLop) };
                    DataProvider.ExcuteNonQuery_trans(sqlLop, CommandType.Text, p1, conn, tran);

                    // C. Cập nhật trạng thái GV mới thành 'Đã Phân Công GVCN'
                    string sqlGVNew = "UPDATE GiaoVien SET TrangThai = N'Đã Phân Công GVCN' WHERE GiaoVienID = @MaGV";
                    SqlParameter[] p2 = { new SqlParameter("@MaGV", maGV) };
                    DataProvider.ExcuteNonQuery_trans(sqlGVNew, CommandType.Text, p2, conn, tran);

                    tran.Commit();
                    MessageBox.Show($"Phân công {tenGVChon} chủ nhiệm lớp {tenLop} thành công!");

                    FilterGiaoVien();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            }
        }

        public void LoadDanhSachPhanCong(string maLop)
        {
            string sql = @"SELECT PC.MaPC, GV.HoTen, Mon.TenMon, HK.HocKy, GV.GiaoVienID 
                   FROM PhanCongGiangDay PC
                   JOIN GiaoVien GV ON PC.GiaoVienID = GV.GiaoVienID
                   JOIN MonHoc Mon ON PC.MaMon = Mon.MaMon
                   JOIN HocKy HK ON PC.MaHK = HK.MaHK
                   WHERE PC.MaLop = @MaLop";

            SqlParameter[] paras = { new SqlParameter("@MaLop", maLop) };
            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, paras);
            dgvChonLopGV.DataSource = dt; // dgvDaphancong là DataGridView bên phải
        }

        private void btnHuyChuNhiem_Click(object sender, EventArgs e)
        {
            string maLop = cbChonLop.SelectedValue.ToString();

            // 1. Lấy mã GV đang là chủ nhiệm hiện tại của lớp đó
            string sqlCheck = "SELECT GiaoVienID FROM Lop WHERE MaLop = @MaLop";
            SqlParameter[] pCheck = { new SqlParameter("@MaLop", maLop) };
            DataTable dt = DataProvider.SelectData(sqlCheck, CommandType.Text, pCheck);

            if (dt.Rows.Count > 0 && dt.Rows[0]["GiaoVienID"] != DBNull.Value)
            {
                string maGVCu = dt.Rows[0]["GiaoVienID"].ToString();

                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        // Gỡ mã GV khỏi bảng Lop
                        string sql1 = "UPDATE Lop SET GiaoVienID = NULL WHERE MaLop = @MaLop";
                        DataProvider.ExcuteNonQuery_trans(sql1, CommandType.Text, pCheck, conn, tran);

                        // Trả lại trạng thái cho GV
                        string sql2 = "UPDATE GiaoVien SET TrangThai = N'Chưa Phân Công' WHERE GiaoVienID = @MaGV";
                        DataProvider.ExcuteNonQuery_trans(sql2, CommandType.Text, new SqlParameter[] { new SqlParameter("@MaGV", maGVCu) }, conn, tran);

                        tran.Commit();
                        MessageBox.Show("Đã hủy vai trò chủ nhiệm của lớp!");

                        // --- BỔ SUNG: Cập nhật lại danh sách GV bên trái ---
                        FilterGiaoVien();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuyLop_Click(object sender, EventArgs e)
        {
            if (dgvChonLopGV.CurrentRow == null) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy phân công môn học này? \n(Lưu ý: Nếu giáo viên này đang chủ nhiệm lớp, vai trò chủ nhiệm cũng sẽ bị hủy)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string maPC = dgvChonLopGV.CurrentRow.Cells["MaPC"].Value.ToString();
                string maGV = dgvChonLopGV.CurrentRow.Cells["GiaoVienID"].Value.ToString();
                string maLop = cbChonLop.SelectedValue.ToString();

                using (SqlConnection conn = new SqlConnection(DataProvider.ChuoiKetNoi))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();
                    try
                    {
                        // 1. Xóa bản ghi phân công giảng dạy môn học
                        string sqlDeletePC = "DELETE FROM PhanCongGiangDay WHERE MaPC = @MaPC";
                        SqlParameter[] p1 = { new SqlParameter("@MaPC", maPC) };
                        DataProvider.ExcuteNonQuery_trans(sqlDeletePC, CommandType.Text, p1, conn, tran);

                        // 2. Kiểm tra xem GV này có phải là chủ nhiệm lớp này không
                        string sqlCheckCN = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop AND GiaoVienID = @MaGV";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheckCN, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@MaLop", maLop);
                        cmdCheck.Parameters.AddWithValue("@MaGV", maGV);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            // 3. Gỡ chủ nhiệm
                            string sqlUpdateLop = "UPDATE Lop SET GiaoVienID = NULL WHERE MaLop = @MaLop";
                            DataProvider.ExcuteNonQuery_trans(sqlUpdateLop, CommandType.Text, new SqlParameter[] { new SqlParameter("@MaLop", maLop) }, conn, tran);

                            // 4. Trả lại trạng thái cho Giáo viên
                            string sqlUpdateGV = "UPDATE GiaoVien SET TrangThai = N'Chưa Phân Công' WHERE GiaoVienID = @MaGV";
                            DataProvider.ExcuteNonQuery_trans(sqlUpdateGV, CommandType.Text, new SqlParameter[] { new SqlParameter("@MaGV", maGV) }, conn, tran);
                        }

                        tran.Commit();
                        MessageBox.Show("Đã hủy phân công thành công!");

                        // --- CẬP NHẬT GIAO DIỆN ---
                        LoadDanhSachPhanCong(maLop); // Load lại bảng bên phải
                        FilterGiaoVien();           // Cập nhật lại bảng bên trái
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void cbChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChonLop.SelectedValue != null && !(cbChonLop.SelectedValue is DataRowView))
            {
                LoadDanhSachPhanCong(cbChonLop.SelectedValue.ToString());
            }
        }

        public void FilterGiaoVien()
        {
            // Lấy giá trị từ UI
            string tenGV = txtNhapTenGV.Text.Trim();
            string maCM = cbChuyenMon.SelectedValue?.ToString() ?? "";

            // Xây dựng câu lệnh SQL động
            string sql = "SELECT * FROM GiaoVien WHERE 1=1";
            List<SqlParameter> paras = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(tenGV))
            {
                sql += " AND HoTen LIKE @Ten";
                paras.Add(new SqlParameter("@Ten", "%" + tenGV + "%"));
            }

            if (!string.IsNullOrEmpty(maCM) && maCM != "All") // Giả sử "All" là lựa chọn tất cả
            {
                sql += " AND MaCM = @MaCM";
                paras.Add(new SqlParameter("@MaCM", maCM));
            }

            // Đổ dữ liệu vào bảng trái
            dgvChonGV.DataSource = DataProvider.SelectData(sql, CommandType.Text, paras.ToArray());
        }
        public void FilterPhanCong()
        {
            if (cbChonLop.SelectedValue == null || cbHocKy.SelectedValue == null) return;

            string maLop = cbChonLop.SelectedValue.ToString();
            string maMon = cbMon.SelectedValue?.ToString() ?? "";
            string maHK = cbHocKy.SelectedValue.ToString();

            // Sửa câu SQL tại đây để JOIN thêm bảng NamHoc
            string sql = @"SELECT PC.MaPC, GV.HoTen, Mon.TenMon, 
                   (HK.HocKy + ' (' + NH.TenNamHoc + ')') as HocKy, 
                   GV.GiaoVienID 
                   FROM PhanCongGiangDay PC
                   JOIN GiaoVien GV ON PC.GiaoVienID = GV.GiaoVienID
                   JOIN MonHoc Mon ON PC.MaMon = Mon.MaMon
                   JOIN HocKy HK ON PC.MaHK = HK.MaHK
                   JOIN NamHoc NH ON HK.MaNamHoc = NH.MaNamHoc
                   WHERE PC.MaLop = @MaLop AND PC.MaHK = @MaHK";

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaLop", maLop));
            paras.Add(new SqlParameter("@MaHK", maHK)); // Thêm tham số

            if (!string.IsNullOrEmpty(maMon) && maMon != "All")
            {
                sql += " AND PC.MaMon = @MaMon";
                paras.Add(new SqlParameter("@MaMon", maMon));
            }

            dgvChonLopGV.DataSource = DataProvider.SelectData(sql, CommandType.Text, paras.ToArray());
        }

        private void txtNhapTenGV_TextChanged(object sender, EventArgs e)
        {
            FilterGiaoVien();
        }

        private void cbChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGiaoVien();
        }

        private void cbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPhanCong();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPhanCong();
        }

        private void PhanCongGV_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Load Chuyên môn (Code cũ của bạn)
                DataTable dtCM = DataProvider.TruyVan_LayDuLieu("SELECT MaCM, TenCM FROM ChuyenMon");
                DataRow drCM = dtCM.NewRow();
                drCM["MaCM"] = "All";
                drCM["TenCM"] = "-- Chọn chuyên môn --";
                dtCM.Rows.InsertAt(drCM, 0);
                cbChuyenMon.DataSource = dtCM;
                cbChuyenMon.DisplayMember = "TenCM";
                cbChuyenMon.ValueMember = "MaCM";

                // 2. Load Danh sách Lớp (Cần thiết để chọn lớp bên phải)
                DataTable dtLop = DataProvider.TruyVan_LayDuLieu("SELECT MaLop, TenLop FROM Lop");
                cbChonLop.DataSource = dtLop;
                cbChonLop.DisplayMember = "MaLop";
                cbChonLop.ValueMember = "MaLop";

                // 3. Load Danh sách Môn học
                DataTable dtMon = DataProvider.TruyVan_LayDuLieu("SELECT MaMon, TenMon FROM MonHoc");
                cbMon.DataSource = dtMon;
                cbMon.DisplayMember = "TenMon";
                cbMon.ValueMember = "MaMon";

                // 4. Load Danh sách Học kỳ kèm Năm học
                string sqlHK = @"SELECT HK.MaHK, 
                        (HK.HocKy + ' - ' + NH.TenNamHoc) AS HienThiHK 
                        FROM HocKy HK 
                        JOIN NamHoc NH ON HK.MaNamHoc = NH.MaNamHoc";
                

                DataTable dtHK = DataProvider.TruyVan_LayDuLieu(sqlHK);
                cbHocKy.DataSource = dtHK;
                cbHocKy.DisplayMember = "HienThiHK";
                cbHocKy.ValueMember = "MaHK";       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo dữ liệu: " + ex.Message);
            }
        }
    }
}