namespace InterFace_FINAL_QLHS.GiaoVien
{
    partial class TrangGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangGiaoVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnTTGV = new System.Windows.Forms.Button();
            this.btnTraCuuHS = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stXepChong = new System.Windows.Forms.ToolStripStatusLabel();
            this.stChiaNgang = new System.Windows.Forms.ToolStripStatusLabel();
            this.stChiadoc = new System.Windows.Forms.ToolStripStatusLabel();
            this.timesidebar = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnDoiMK);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnTTGV);
            this.panel1.Controls.Add(this.btnTraCuuHS);
            this.panel1.Controls.Add(this.btnNhapDiem);
            this.panel1.Controls.Add(this.btnTongQuan);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightBlue;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 393);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(364, 57);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.LightBlue;
            this.btnDoiMK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDoiMK.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMK.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.Location = new System.Drawing.Point(0, 335);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDoiMK.Size = new System.Drawing.Size(364, 58);
            this.btnDoiMK.TabIndex = 5;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnTTGV
            // 
            this.btnTTGV.BackColor = System.Drawing.Color.LightBlue;
            this.btnTTGV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnTTGV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTTGV.Image = ((System.Drawing.Image)(resources.GetObject("btnTTGV.Image")));
            this.btnTTGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTGV.Location = new System.Drawing.Point(0, 188);
            this.btnTTGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTGV.Name = "btnTTGV";
            this.btnTTGV.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnTTGV.Size = new System.Drawing.Size(364, 50);
            this.btnTTGV.TabIndex = 4;
            this.btnTTGV.Text = "Thông Tin Giáo Viên";
            this.btnTTGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTGV.UseVisualStyleBackColor = false;
            this.btnTTGV.Click += new System.EventHandler(this.btnTTGV_Click);
            // 
            // btnTraCuuHS
            // 
            this.btnTraCuuHS.BackColor = System.Drawing.Color.LightBlue;
            this.btnTraCuuHS.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnTraCuuHS.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTraCuuHS.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuHS.Image")));
            this.btnTraCuuHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuuHS.Location = new System.Drawing.Point(0, 142);
            this.btnTraCuuHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuuHS.Name = "btnTraCuuHS";
            this.btnTraCuuHS.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnTraCuuHS.Size = new System.Drawing.Size(364, 50);
            this.btnTraCuuHS.TabIndex = 3;
            this.btnTraCuuHS.Text = "Tra Cứu Học Sinh";
            this.btnTraCuuHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraCuuHS.UseVisualStyleBackColor = false;
            this.btnTraCuuHS.Click += new System.EventHandler(this.btnTraCuuHS_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.LightBlue;
            this.btnNhapDiem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapDiem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.Image")));
            this.btnNhapDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapDiem.Location = new System.Drawing.Point(0, 94);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnNhapDiem.Size = new System.Drawing.Size(364, 50);
            this.btnNhapDiem.TabIndex = 2;
            this.btnNhapDiem.Text = "Nhập Điểm";
            this.btnNhapDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.LightBlue;
            this.btnTongQuan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnTongQuan.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTongQuan.Image = ((System.Drawing.Image)(resources.GetObject("btnTongQuan.Image")));
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 47);
            this.btnTongQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(364, 50);
            this.btnTongQuan.TabIndex = 1;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTongQuan.UseVisualStyleBackColor = false;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.LightBlue;
            this.btnDashBoard.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashBoard.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDashBoard.Size = new System.Drawing.Size(364, 50);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stXepChong,
            this.stChiaNgang,
            this.stChiadoc});
            this.statusStrip1.Location = new System.Drawing.Point(364, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(436, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stXepChong
            // 
            this.stXepChong.Name = "stXepChong";
            this.stXepChong.Size = new System.Drawing.Size(82, 20);
            this.stXepChong.Text = "Xếp Chồng";
            this.stXepChong.Click += new System.EventHandler(this.stXepChong_Click);
            // 
            // stChiaNgang
            // 
            this.stChiaNgang.Name = "stChiaNgang";
            this.stChiaNgang.Size = new System.Drawing.Size(87, 20);
            this.stChiaNgang.Text = "Chia Ngang";
            this.stChiaNgang.Click += new System.EventHandler(this.stChiaNgang_Click);
            // 
            // stChiadoc
            // 
            this.stChiadoc.Name = "stChiadoc";
            this.stChiadoc.Size = new System.Drawing.Size(69, 20);
            this.stChiadoc.Text = "Chia Dọc";
            this.stChiadoc.Click += new System.EventHandler(this.stChiadoc_Click);
            // 
            // timesidebar
            // 
            this.timesidebar.Interval = 10;
            this.timesidebar.Tick += new System.EventHandler(this.Timesidebar_Tick);
            // 
            // TrangGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrangGiaoVien";
            this.Text = "Trang Giáo Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnTTGV;
        private System.Windows.Forms.Button btnTraCuuHS;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timesidebar;
        private System.Windows.Forms.ToolStripStatusLabel stXepChong;
        private System.Windows.Forms.ToolStripStatusLabel stChiaNgang;
        private System.Windows.Forms.ToolStripStatusLabel stChiadoc;
    }
}