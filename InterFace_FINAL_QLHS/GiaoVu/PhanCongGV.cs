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
            // Kiểm tra xem đã chọn giáo viên ở bảng bên phải chưa
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

                // 1. Kiểm tra xem lớp này ĐÃ CÓ chủ nhiệm chưa
                string sqlCheckCN = @"SELECT GV.HoTen, GV.GiaoVienID 
                             FROM Lop L 
                             JOIN GiaoVien GV ON L.GiaoVienID = GV.GiaoVienID 
                             WHERE L.MaLop = @MaLop";

                SqlCommand cmdCheck = new SqlCommand(sqlCheckCN, conn);
                cmdCheck.Parameters.AddWithValue("@MaLop", maLop);
                SqlDataAdapter da = new SqlDataAdapter(cmdCheck);
                DataTable dtCN = new DataTable();
                da.Fill(dtCN);

                if (dtCN.Rows.Count > 0)
                {
                    string maGVCu = dtCN.Rows[0]["GiaoVienID"].ToString();
                    string tenGVChuNhiemCu = dtCN.Rows[0]["HoTen"].ToString();

                    // Nếu giáo viên đang chọn chính là chủ nhiệm hiện tại rồi thì thôi
                    if (maGV == maGVCu)
                    {
                        MessageBox.Show($"{tenGVChon} hiện đã là chủ nhiệm của lớp {tenLop} rồi.");
                        return;
                    }

                    // Thông báo xác nhận thay thế
                    DialogResult result = MessageBox.Show(
                        $"Lớp {tenLop} đã có giáo viên chủ nhiệm là: {tenGVChuNhiemCu}.\n\n" +
                        $"Bạn có muốn thay thế bằng giáo viên {tenGVChon} không?",
                        "Xác nhận thay đổi chủ nhiệm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No) return;
                }

                // 2. Thực hiện cập nhật (Sử dụng Transaction để đảm bảo an toàn dữ liệu)
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // Bước A: Nếu có chủ nhiệm cũ, ta có thể trả trạng thái của họ về 'Chưa chủ nhiệm' (tùy logic của Phú)
                    // Ở đây mình làm theo hướng cập nhật thẳng cho GV mới:

                    // Bước B: Cập nhật giáo viên chủ nhiệm cho Lớp
                    string sqlLop = "UPDATE Lop SET GiaoVienID = @MaGV WHERE MaLop = @MaLop";
                    SqlParameter[] p1 = { new SqlParameter("@MaGV", maGV), new SqlParameter("@MaLop", maLop) };
                    DataProvider.ExcuteNonQuery_trans(sqlLop, CommandType.Text, p1, conn, tran);

                    // Bước C: Cập nhật trạng thái cho Giáo viên mới
                    string sqlGV = "UPDATE GiaoVien SET TrangThai = N'Đã chủ nhiệm' WHERE GiaoVienID = @MaGV";
                    SqlParameter[] p2 = { new SqlParameter("@MaGV", maGV) };
                    DataProvider.ExcuteNonQuery_trans(sqlGV, CommandType.Text, p2, conn, tran);

                    tran.Commit();
                    MessageBox.Show($"Đã xác nhận {tenGVChon} là giáo viên chủ nhiệm của lớp {tenLop}!");

                    // Cập nhật lại UI nếu cần
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

            // 1. Lấy mã GV đang là chủ nhiệm hiện tại của lớp đó để trả lại trạng thái
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
                        string sql2 = "UPDATE GiaoVien SET TrangThai = N'Chưa chủ nhiệm' WHERE GiaoVienID = @MaGV";
                        DataProvider.ExcuteNonQuery_trans(sql2, CommandType.Text, new SqlParameter[] { new SqlParameter("@MaGV", maGVCu) }, conn, tran);

                        tran.Commit();
                        MessageBox.Show("Đã hủy vai trò chủ nhiệm của lớp!");
                    }
                    catch { tran.Rollback(); }
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

                        // 2. Kiểm tra xem GV này có phải là chủ nhiệm của lớp này không
                        string sqlCheckCN = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop AND GiaoVienID = @MaGV";
                        SqlParameter[] pCheck = {
                    new SqlParameter("@MaLop", maLop),
                    new SqlParameter("@MaGV", maGV)
                };

                        // Sử dụng ExecuteScalar để lấy số lượng dòng thỏa mãn
                        SqlCommand cmdCheck = new SqlCommand(sqlCheckCN, conn, tran);
                        cmdCheck.Parameters.AddRange(pCheck);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            // 3. Nếu đúng là chủ nhiệm, gỡ mã GV khỏi bảng Lop
                            string sqlUpdateLop = "UPDATE Lop SET GiaoVienID = NULL WHERE MaLop = @MaLop";
                            SqlParameter[] p2 = { new SqlParameter("@MaLop", maLop) };
                            DataProvider.ExcuteNonQuery_trans(sqlUpdateLop, CommandType.Text, p2, conn, tran);

                            // 4. Trả lại trạng thái cho Giáo viên
                            string sqlUpdateGV = "UPDATE GiaoVien SET TrangThai = N'Chưa chủ nhiệm' WHERE GiaoVienID = @MaGV";
                            SqlParameter[] p3 = { new SqlParameter("@MaGV", maGV) };
                            DataProvider.ExcuteNonQuery_trans(sqlUpdateGV, CommandType.Text, p3, conn, tran);
                        }

                        tran.Commit();
                        MessageBox.Show("Đã hủy phân công môn học và vai trò chủ nhiệm (nếu có) thành công!");

                        // Reload lại dữ liệu
                        LoadDanhSachPhanCong(maLop);
                        FilterGiaoVien(); // Để cập nhật lại trạng thái "Chưa chủ nhiệm" bên bảng trái
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi khi hủy phân công: " + ex.Message);
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
            string maHK = cbHocKy.SelectedValue.ToString(); // Thêm dòng này

            string sql = @"SELECT PC.MaPC, GV.HoTen, Mon.TenMon, HK.HocKy, GV.GiaoVienID 
                   FROM PhanCongGiangDay PC
                   JOIN GiaoVien GV ON PC.GiaoVienID = GV.GiaoVienID
                   JOIN MonHoc Mon ON PC.MaMon = Mon.MaMon
                   JOIN HocKy HK ON PC.MaHK = HK.MaHK
                   WHERE PC.MaLop = @MaLop AND PC.MaHK = @MaHK"; // Thêm điều kiện lọc học kỳ

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
                cbChonLop.DisplayMember = "TenLop";
                cbChonLop.ValueMember = "MaLop";

                // 3. Load Danh sách Môn học
                DataTable dtMon = DataProvider.TruyVan_LayDuLieu("SELECT MaMon, TenMon FROM MonHoc");
                cbMon.DataSource = dtMon;
                cbMon.DisplayMember = "TenMon";
                cbMon.ValueMember = "MaMon";

                DataTable dtHK = DataProvider.TruyVan_LayDuLieu("SELECT MaHK, HocKy FROM HocKy");
                cbHocKy.DataSource = dtHK;
                cbHocKy.DisplayMember = "HocKy"; // Hiển thị: Học kỳ 1, Học kỳ 2...
                cbHocKy.ValueMember = "MaHK";    // Giá trị lưu: HK01, HK02...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo dữ liệu: " + ex.Message);
            }
        }
    }
}