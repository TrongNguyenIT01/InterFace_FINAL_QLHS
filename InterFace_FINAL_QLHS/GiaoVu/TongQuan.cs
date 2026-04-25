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

                // Số lượng học sinh
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM HocSinh", conn);
                lbSLHS.Text = cmd1.ExecuteScalar().ToString();

                // Sinh nhật hôm nay
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM HocSinh WHERE DAY(NgaySinh) = DAY(GETDATE()) AND MONTH(NgaySinh) = MONTH(GETDATE())", conn);
                lbSNHN.Text = cmd2.ExecuteScalar().ToString();

                
            }
        }
    }
}
