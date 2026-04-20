namespace InterFace_FINAL_QLHS
{
    partial class TrangGiaoVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangGiaoVu));
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.btnSidebar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnDoiPass = new System.Windows.Forms.Button();
            this.btnSapXepGV = new System.Windows.Forms.Button();
            this.btnXemBaoCaoHK = new System.Windows.Forms.Button();
            this.btnXemBaoCaoMon = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnTraCuuHocSinh = new System.Windows.Forms.Button();
            this.btnDanhSachLop = new System.Windows.Forms.Button();
            this.btnTiepNhanHocSinh = new System.Windows.Forms.Button();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnXepChong = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChiaNgang = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChiaDoc = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelSidebar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 10;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // btnSidebar
            // 
            this.btnSidebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebar.Image = ((System.Drawing.Image)(resources.GetObject("btnSidebar.Image")));
            this.btnSidebar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSidebar.Location = new System.Drawing.Point(0, 0);
            this.btnSidebar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(206, 28);
            this.btnSidebar.TabIndex = 0;
            this.btnSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSidebar.UseVisualStyleBackColor = true;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 456);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(206, 28);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.LightBlue;
            this.panelSidebar.Controls.Add(this.btnDoiPass);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnSapXepGV);
            this.panelSidebar.Controls.Add(this.btnXemBaoCaoHK);
            this.panelSidebar.Controls.Add(this.btnXemBaoCaoMon);
            this.panelSidebar.Controls.Add(this.btnXemDiem);
            this.panelSidebar.Controls.Add(this.btnTraCuuHocSinh);
            this.panelSidebar.Controls.Add(this.btnDanhSachLop);
            this.panelSidebar.Controls.Add(this.btnTiepNhanHocSinh);
            this.panelSidebar.Controls.Add(this.btnTongQuan);
            this.panelSidebar.Controls.Add(this.btnSidebar);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelSidebar.ForeColor = System.Drawing.Color.DarkBlue;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(206, 484);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDoiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiPass.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiPass.Image")));
            this.btnDoiPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiPass.Location = new System.Drawing.Point(0, 428);
            this.btnDoiPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Size = new System.Drawing.Size(206, 28);
            this.btnDoiPass.TabIndex = 10;
            this.btnDoiPass.Text = "Đổi mật khẩu";
            this.btnDoiPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiPass.UseVisualStyleBackColor = true;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // btnSapXepGV
            // 
            this.btnSapXepGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSapXepGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXepGV.Image = ((System.Drawing.Image)(resources.GetObject("btnSapXepGV.Image")));
            this.btnSapXepGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXepGV.Location = new System.Drawing.Point(0, 224);
            this.btnSapXepGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSapXepGV.Name = "btnSapXepGV";
            this.btnSapXepGV.Size = new System.Drawing.Size(206, 28);
            this.btnSapXepGV.TabIndex = 8;
            this.btnSapXepGV.Text = "Sắp xếp giáo viên";
            this.btnSapXepGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapXepGV.UseVisualStyleBackColor = true;
            this.btnSapXepGV.Click += new System.EventHandler(this.btnSapXepGV_Click);
            // 
            // btnXemBaoCaoHK
            // 
            this.btnXemBaoCaoHK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemBaoCaoHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCaoHK.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBaoCaoHK.Image")));
            this.btnXemBaoCaoHK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemBaoCaoHK.Location = new System.Drawing.Point(0, 196);
            this.btnXemBaoCaoHK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemBaoCaoHK.Name = "btnXemBaoCaoHK";
            this.btnXemBaoCaoHK.Size = new System.Drawing.Size(206, 28);
            this.btnXemBaoCaoHK.TabIndex = 7;
            this.btnXemBaoCaoHK.Text = "Báo cáo tổng kết học kỳ";
            this.btnXemBaoCaoHK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemBaoCaoHK.UseVisualStyleBackColor = true;
            this.btnXemBaoCaoHK.Click += new System.EventHandler(this.btnXemBaoCaoHK_Click);
            // 
            // btnXemBaoCaoMon
            // 
            this.btnXemBaoCaoMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemBaoCaoMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCaoMon.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBaoCaoMon.Image")));
            this.btnXemBaoCaoMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemBaoCaoMon.Location = new System.Drawing.Point(0, 168);
            this.btnXemBaoCaoMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemBaoCaoMon.Name = "btnXemBaoCaoMon";
            this.btnXemBaoCaoMon.Size = new System.Drawing.Size(206, 28);
            this.btnXemBaoCaoMon.TabIndex = 6;
            this.btnXemBaoCaoMon.Text = "Báo cáo tổng kết môn";
            this.btnXemBaoCaoMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemBaoCaoMon.UseVisualStyleBackColor = true;
            this.btnXemBaoCaoMon.Click += new System.EventHandler(this.btnXemBaoCaoMon_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.Image")));
            this.btnXemDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDiem.Location = new System.Drawing.Point(0, 140);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(206, 28);
            this.btnXemDiem.TabIndex = 5;
            this.btnXemDiem.Text = "Xem bảng điểm môn";
            this.btnXemDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnTraCuuHocSinh
            // 
            this.btnTraCuuHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraCuuHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuHocSinh.Image")));
            this.btnTraCuuHocSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuuHocSinh.Location = new System.Drawing.Point(0, 112);
            this.btnTraCuuHocSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTraCuuHocSinh.Name = "btnTraCuuHocSinh";
            this.btnTraCuuHocSinh.Size = new System.Drawing.Size(206, 28);
            this.btnTraCuuHocSinh.TabIndex = 4;
            this.btnTraCuuHocSinh.Text = "Tra cứu học sinh";
            this.btnTraCuuHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraCuuHocSinh.UseVisualStyleBackColor = true;
            this.btnTraCuuHocSinh.Click += new System.EventHandler(this.btnTraCuuHocSinh_Click);
            // 
            // btnDanhSachLop
            // 
            this.btnDanhSachLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachLop.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachLop.Image")));
            this.btnDanhSachLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachLop.Location = new System.Drawing.Point(0, 84);
            this.btnDanhSachLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDanhSachLop.Name = "btnDanhSachLop";
            this.btnDanhSachLop.Size = new System.Drawing.Size(206, 28);
            this.btnDanhSachLop.TabIndex = 3;
            this.btnDanhSachLop.Text = "Lập danh sách lớp";
            this.btnDanhSachLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhSachLop.UseVisualStyleBackColor = true;
            this.btnDanhSachLop.Click += new System.EventHandler(this.btnDanhSachLop_Click);
            // 
            // btnTiepNhanHocSinh
            // 
            this.btnTiepNhanHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiepNhanHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepNhanHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnTiepNhanHocSinh.Image")));
            this.btnTiepNhanHocSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiepNhanHocSinh.Location = new System.Drawing.Point(0, 56);
            this.btnTiepNhanHocSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTiepNhanHocSinh.Name = "btnTiepNhanHocSinh";
            this.btnTiepNhanHocSinh.Size = new System.Drawing.Size(206, 28);
            this.btnTiepNhanHocSinh.TabIndex = 2;
            this.btnTiepNhanHocSinh.Text = "Tiếp nhận học sinh";
            this.btnTiepNhanHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiepNhanHocSinh.UseVisualStyleBackColor = true;
            this.btnTiepNhanHocSinh.Click += new System.EventHandler(this.btnTiepNhanHocSinh_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.Image = ((System.Drawing.Image)(resources.GetObject("btnTongQuan.Image")));
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 28);
            this.btnTongQuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(206, 28);
            this.btnTongQuan.TabIndex = 1;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTongQuan.UseVisualStyleBackColor = true;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXepChong,
            this.btnChiaNgang,
            this.btnChiaDoc});
            this.statusStrip1.Location = new System.Drawing.Point(206, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnXepChong
            // 
            this.btnXepChong.Name = "btnXepChong";
            this.btnXepChong.Size = new System.Drawing.Size(64, 17);
            this.btnXepChong.Text = "Xếp chồng";
            this.btnXepChong.Click += new System.EventHandler(this.btnXepChong_Click);
            // 
            // btnChiaNgang
            // 
            this.btnChiaNgang.Name = "btnChiaNgang";
            this.btnChiaNgang.Size = new System.Drawing.Size(68, 17);
            this.btnChiaNgang.Text = "Chia ngang";
            this.btnChiaNgang.Click += new System.EventHandler(this.btnChiaNgang_Click);
            // 
            // btnChiaDoc
            // 
            this.btnChiaDoc.Name = "btnChiaDoc";
            this.btnChiaDoc.Size = new System.Drawing.Size(54, 17);
            this.btnChiaDoc.Text = "Chia dọc";
            this.btnChiaDoc.Click += new System.EventHandler(this.btnChiaDoc_Click);
            // 
            // TrangGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TrangGiaoVu";
            this.Text = "GiaoVu";
            this.panelSidebar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Button btnSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnSapXepGV;
        private System.Windows.Forms.Button btnXemBaoCaoHK;
        private System.Windows.Forms.Button btnXemBaoCaoMon;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnTraCuuHocSinh;
        private System.Windows.Forms.Button btnDanhSachLop;
        private System.Windows.Forms.Button btnTiepNhanHocSinh;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btnXepChong;
        private System.Windows.Forms.ToolStripStatusLabel btnChiaNgang;
        private System.Windows.Forms.ToolStripStatusLabel btnChiaDoc;
        private System.Windows.Forms.Button btnDoiPass;
    }
}