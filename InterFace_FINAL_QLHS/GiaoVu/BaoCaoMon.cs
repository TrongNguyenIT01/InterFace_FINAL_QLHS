using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS.GiaoVu
{
    public partial class BaoCaoMon : Form
    {
        public BaoCaoMon()
        {
            InitializeComponent();
        }

        private void load_CB()
        {
          
            string sql_HK = $"Select HocKy + ' - ' + MaNamHoc AS HienThi, MaNamHoc, MaHK, MaNamHoc From HocKy";
            string sql_MH = $"Select MaMon, TenMon From MonHoc";


      
            DataTable HK = DataProvider.TruyVan_LayDuLieu(sql_HK);
            DataTable MH = DataProvider.TruyVan_LayDuLieu(sql_MH);


            cbHocKy.DataSource = HK;
            cbHocKy.DisplayMember = "HienThi";
            cbHocKy.ValueMember = "MaHK";
            cbHocKy.SelectedIndex = -1;

            cbMon.DataSource = MH;
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
            cbMon.SelectedIndex = -1;


        }

        private void BaoCaoMon_Load(object sender, EventArgs e)
        {
            load_CB();
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
       
            if (cbHocKy.SelectedValue == null || cbMon.SelectedValue == null)
            {
                MessageBox.Show($"Vui lòng chọn đầy đủ Học kỳ và môn học muốn tạo báo cáo!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            string maHK = cbHocKy.SelectedValue.ToString();
            string maMon = cbMon.SelectedValue.ToString();

            // Lấy MaNamHoc từ dòng đang chọn trong ComboBox Học Kỳ
            DataRowView rowHK = (DataRowView)cbHocKy.SelectedItem;
            string maNamHoc = rowHK["MaNamHoc"].ToString();

          
            //Join bảng LopHoc, QuaTrinhHocTap và MonHoc
            string sql = $@"
        SELECT 
            L.MaLop AS [Lớp],
            COUNT(Q.MaHS) AS [Sĩ số],
            SUM(CASE WHEN dbo.fn_TinhDiemTBMon(Q.MaHS, '{maMon}', '{maHK}') >= M.DiemChuan THEN 1 ELSE 0 END) AS [Số Lượng Đạt]
        FROM Lop L
        JOIN QuaTrinhHocTap Q ON L.MaLop = Q.MaLop
        CROSS JOIN MonHoc M -- Lấy điểm chuẩn của môn đang chọn
        WHERE M.MaMon = '{maMon}' 
          AND Q.MaNamHoc = '{maNamHoc}'
          AND Q.TrangThai = N'Đang học' -- Chỉ tính học sinh đang học
        GROUP BY L.MaLop, M.DiemChuan";

            // Lấy dữ liệu và xử lý hiển thị
            DataTable dtResult = DataProvider.TruyVan_LayDuLieu(sql);

           
            DataTable dtFinal = new DataTable();
            dtFinal.Columns.Add("STT", typeof(int));
            dtFinal.Columns.Add("Lớp", typeof(string));
            dtFinal.Columns.Add("Sĩ số", typeof(int));
            dtFinal.Columns.Add("Số Lượng Đạt", typeof(int));
            dtFinal.Columns.Add("Tỉ Lệ Đạt", typeof(string));
            dtFinal.Columns.Add("Tỉ Lệ Rớt", typeof(string));


            int stt = 1;
            foreach (DataRow row in dtResult.Rows)
            {
                int siSo = Convert.ToInt32(row["Sĩ số"]);
                int soLuongDat = Convert.ToInt32(row["Số Lượng Đạt"]);
                double tiLe = siSo > 0 ? (double)soLuongDat / siSo * 100 : 0;
                double tileTruot = 100- tiLe; 

                dtFinal.Rows.Add(
                    stt++,
                    row["Lớp"],
                    siSo,
                    soLuongDat,
                    Math.Round(tiLe, 2).ToString() + "%",
                    Math.Round(tileTruot, 2).ToString() + "%"
                   

                );
            }

          
            dgvBaoCaoMon.DataSource = dtFinal;

         
            dgvBaoCaoMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
