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
    }
}
