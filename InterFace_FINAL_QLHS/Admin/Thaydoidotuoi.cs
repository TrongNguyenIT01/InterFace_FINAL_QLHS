using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterFace_FINAL_QLHS.Config;


using System.Data.SqlClient;

namespace InterFace_FINAL_QLHS.Admin
{
    public partial class Thaydoidotuoi : Form
    {
        public Thaydoidotuoi()
        {
            InitializeComponent();
        }


        private void grboxThongtinhientai_Enter(object sender, EventArgs e)
        {
            string tuoimax = "SELECT GiaTri FROM ThamSo WHERE MaThamSo='TuoiTD'";
            string tuoimin = "SELECT GiaTri FROM ThamSo WHERE MaThamSo='TuoiTT'";

            DataTable dtMax = DataProvider.TruyVan_LayDuLieu(tuoimax);
            DataTable dtMin = DataProvider.TruyVan_LayDuLieu(tuoimin);


            txtTuoiMax.Text = dtMax.Rows[0]["GiaTri"].ToString();
            txtTuoiMin.Text = dtMin.Rows[0]["GiaTri"].ToString();
        }

        private bool validateTuoi()
        {
           
            if (nbTuoitoidamoi.Value < nbTuoitoithieumoi.Value)
            {
                MessageBox.Show("Độ tuổi tối đa phải lớn hơn hoặc bằng độ tuổi tối thiểu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (validateTuoi())
            {
                string sql = $"UPDATE ThamSo SET GiaTri = @TuoiMax WHERE MaThamSo = 'TuoiTD'; " +
                             $"UPDATE ThamSo SET GiaTri = @TuoiMin WHERE MaThamSo = 'TuoiTT';";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TuoiMax", nbTuoitoidamoi.Value),
                    new SqlParameter("@TuoiMin", nbTuoitoithieumoi.Value)
                };

                if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters) > 0)
                {
                    MessageBox.Show("Cập nhật độ tuổi thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grboxThongtinhientai_Enter(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật độ tuổi thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
