using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace_FINAL_QLHS
{
    public partial class TiepNhanHocSinh : Form
    {
        public TiepNhanHocSinh()
        {
            InitializeComponent();
        }

        private void btnTaiMau_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.FileName = "Mau_Import_HS.xlsx";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string souceFile = Path.Combine(Application.StartupPath,"Template", "Mau_Import_HS.xlsx");

                    File.Copy(souceFile, sfd.FileName, true);
                    MessageBox.Show("Tải file mẫu import thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
