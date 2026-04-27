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
using System.Windows.Forms.DataVisualization.Charting;

namespace InterFace_FINAL_QLHS
{
    public partial class TongQuan : Form
    {
        public TongQuan()
        {
            InitializeComponent();
        }

        private void TongQuan_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=QLHS;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM HocSinh", conn);
                lbSLHS.Text = cmd1.ExecuteScalar().ToString();

                
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM HocSinh WHERE DAY(NgaySinh) = DAY(GETDATE()) AND MONTH(NgaySinh) = MONTH(GETDATE())", conn);
                lbSNHN.Text = cmd2.ExecuteScalar().ToString();

                string sqlChuaNhapHoc = "SELECT COUNT(*) FROM TiepNhanHS WHERE TrangThai = N'Chưa Phân Lớp'";
                SqlCommand cmd3 = new SqlCommand(sqlChuaNhapHoc, conn);
                lbHSCNH.Text = cmd3.ExecuteScalar().ToString();

                string sqlChart = @"
                    SELECT NgayTiepNhan, COUNT(*) AS SoLuong 
                    FROM TiepNhanHS 
                    WHERE NgayTiepNhan IS NOT NULL
                    GROUP BY NgayTiepNhan 
                    ORDER BY NgayTiepNhan ASC";

                SqlCommand cmdChart = new SqlCommand(sqlChart, conn);
                using (SqlDataReader reader = cmdChart.ExecuteReader())
                {
                    
                    chart1.Series[0].Points.Clear();

                    
                    chart1.Series[0].Name = "Số lượng tiếp nhận";

                    while (reader.Read())
                    {
                        DateTime ngay = Convert.ToDateTime(reader["NgayTiepNhan"]);
                        int soLuong = Convert.ToInt32(reader["SoLuong"]);

                        // Thêm dữ liệu vào trục X (Ngày) và trục Y (Số lượng)
                        // Dùng format "dd/MM" hoặc "dd/MM/yyyy" để trục X hiển thị ngày tháng đẹp hơn
                        chart1.Series[0].Points.AddXY(ngay.ToString("dd/MM"), soLuong);
                    }
                }
               
                string sqlChart2 = @"
                    SELECT TrangThai, COUNT(*) AS SoLuong 
                    FROM TiepNhanHS 
                    GROUP BY TrangThai";

                SqlCommand cmdChart2 = new SqlCommand(sqlChart2, conn);
                using (SqlDataReader reader2 = cmdChart2.ExecuteReader())
                {
                    
                    chart2.Series[0].Points.Clear();

                    
                    chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    // Cài đặt hiển thị nhãn (label) ngay trên các lát cắt của biểu đồ
                    chart2.Series[0].IsValueShownAsLabel = true;

                    while (reader2.Read())
                    {
                        string trangThai = reader2["TrangThai"].ToString();
                        int soLuong = Convert.ToInt32(reader2["SoLuong"]);

                        // Thêm dữ liệu vào biểu đồ
                        int pointIndex = chart2.Series[0].Points.AddXY(trangThai, soLuong);

                        // Tùy chỉnh nhãn hiển thị (ví dụ: "Chưa Phân Lớp: 15")
                        chart2.Series[0].Points[pointIndex].Label = $"{trangThai}: {soLuong}";

                        // Tùy chỉnh Legend (Chú thích)
                        chart2.Series[0].Points[pointIndex].LegendText = trangThai;
                    }
                }
            }
        }

    }
}
