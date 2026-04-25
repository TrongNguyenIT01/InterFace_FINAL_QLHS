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
using static InterFace_FINAL_QLHS.QuenMK;

namespace InterFace_FINAL_QLHS.GiaoVien
{
    public partial class ThongTinGiaoVien : Form
    {
        string IDGV = Session.UserName;
        public ThongTinGiaoVien()
        {
            InitializeComponent();
        }
        private void Load_TT()
        {
            string sql = @"SELECT 
                                gv.GiaoVienID,
                                gv.HoTen,
                                gv.NgaySinh,
                                gv.GioiTinh,
                                gv.DiaChi,
                                gv.Email,
                                gv.SoDienThoai,
                                cm.TenCM,
                                gv.TrangThai
                           FROM GiaoVien gv
                           JOIN ChuyenMon cm ON gv.MaCM = cm.MaCM
                           WHERE gv.GiaoVienID = @IDGV";

            SqlParameter[] param = {
                new SqlParameter("@IDGV", IDGV)
            };

            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, param);

            dgvThongTinGV.AutoGenerateColumns = false;
            dgvThongTinGV.DataSource = dt;

            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvThongTinGV.Columns.Clear();

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "GiaoVienID",
                HeaderText = "ID",
                Width = 80
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "HoTen",
                HeaderText = "Họ Tên",
                Width = 150
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngày Sinh",
                DefaultCellStyle = { Format = "dd/MM/yyyy" },
                Width = 100
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "GioiTinh",
                HeaderText = "Giới Tính",
                Width = 80
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DiaChi",
                HeaderText = "Địa Chỉ",
                Width = 200
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 150
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SoDienThoai",
                HeaderText = "SĐT",
                Width = 100
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TenCM",
                HeaderText = "Chuyên Môn",
                Width = 120
            });

            dgvThongTinGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái",
                Width = 100
            });
        }

        private void dgvLopDangDay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvThongTinGV.Columns[e.ColumnIndex].DataPropertyName == "GioiTinh")
            {
                if (e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }

            if (dgvThongTinGV.Columns[e.ColumnIndex].DataPropertyName == "TrangThai")
            {
                if (e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Đang dạy" : "";
                    e.FormattingApplied = true;
                }
            }


        }
        private void Load_LOP(string keyword = "")
        {
            try
            {
                // Lấy IDUser từ Session đã có sẵn
                string maGV = UserSession.CurrentUsername;

                // Câu lệnh SQL kết nối các bảng để lấy: Tên lớp, Tên môn, Sĩ số
                string sql = @"
                    SELECT 
                        L.MaLop AS [Mã Lớp],
                        L.TenLop AS [Tên Lớp], 
                        MH.TenMon AS [Môn Giảng Dạy], 
                        L.SiSo AS [Sĩ Số],
                        HK.HocKy AS [Học Kỳ]
                    FROM PhanCongGiangDay PC
                    INNER JOIN Lop L ON PC.MaLop = L.MaLop
                    INNER JOIN MonHoc MH ON PC.MaMon = MH.MaMon
                    INNER JOIN HocKy HK ON PC.MaHK = HK.MaHK
                    WHERE PC.GiaoVienID = @maGV";

                // Nếu người dùng có nhập từ khóa tìm kiếm
                if (!string.IsNullOrEmpty(keyword))
                {
                    // Thêm điều kiện tìm theo L.MaLop
                    sql += " AND (L.TenLop LIKE @key OR MH.TenMon LIKE @key OR L.MaLop LIKE @key)";
                }

                // Tạo tham số
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@maGV", maGV),
                    new SqlParameter("@key", "%" + keyword + "%")
                };

                // Gọi DataProvider để lấy dữ liệu
                DataTable dt = DataProvider.SelectData(sql, CommandType.Text, paras);

                // Đổ vào DataGridView (giả sử tên là dgvDSLopDangDay)
                dgvLopDangDay.DataSource = dt;

                // Tùy chỉnh giao diện DataGridView một chút
                if (dgvLopDangDay.Columns.Count > 0)
                {
                    dgvLopDangDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void ThongTinGiaoVien_Load(object sender, EventArgs e)
        {
            Load_TT();
            Load_LOP();
        }
    }
}
