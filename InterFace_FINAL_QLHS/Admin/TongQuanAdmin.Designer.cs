namespace InterFace_FINAL_QLHS.Admin
{
    partial class TongQuanAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongQuanAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnXepChong = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChiaNgang = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChiaDoc = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timesidebar = new System.Windows.Forms.Timer(this.components);
            this.btnThietLapDiem = new System.Windows.Forms.Button();
            this.btnDoiPass = new System.Windows.Forms.Button();
            this.btnThongTinNamHoc = new System.Windows.Forms.Button();
            this.btnThongTinHK = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnChuyenMon = new System.Windows.Forms.Button();
            this.btnThayDoiThongTinMonHoc = new System.Windows.Forms.Button();
            this.btnThayDoiQuyDinhThongTinLopHoc = new System.Windows.Forms.Button();
            this.btnThayDoiQuyDinhDoTuoi = new System.Windows.Forms.Button();
            this.btnCapTaiKhoan = new System.Windows.Forms.Button();
            this.btnSideBar = new System.Windows.Forms.Button();
            this.btnLanKT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnLanKT);
            this.panel1.Controls.Add(this.btnThietLapDiem);
            this.panel1.Controls.Add(this.btnDoiPass);
            this.panel1.Controls.Add(this.btnThongTinNamHoc);
            this.panel1.Controls.Add(this.btnThongTinHK);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnChuyenMon);
            this.panel1.Controls.Add(this.btnThayDoiThongTinMonHoc);
            this.panel1.Controls.Add(this.btnThayDoiQuyDinhThongTinLopHoc);
            this.panel1.Controls.Add(this.btnThayDoiQuyDinhDoTuoi);
            this.panel1.Controls.Add(this.btnCapTaiKhoan);
            this.panel1.Controls.Add(this.btnSideBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 549);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXepChong,
            this.btnChiaNgang,
            this.btnChiaDoc});
            this.statusStrip1.Location = new System.Drawing.Point(273, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(620, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnXepChong
            // 
            this.btnXepChong.Name = "btnXepChong";
            this.btnXepChong.Size = new System.Drawing.Size(66, 17);
            this.btnXepChong.Text = "Xếp Chồng";
            this.btnXepChong.Click += new System.EventHandler(this.btnXepChong_Click);
            // 
            // btnChiaNgang
            // 
            this.btnChiaNgang.Name = "btnChiaNgang";
            this.btnChiaNgang.Size = new System.Drawing.Size(70, 17);
            this.btnChiaNgang.Text = "Chia Ngang";
            this.btnChiaNgang.Click += new System.EventHandler(this.btnChiaNgang_Click);
            // 
            // btnChiaDoc
            // 
            this.btnChiaDoc.Name = "btnChiaDoc";
            this.btnChiaDoc.Size = new System.Drawing.Size(55, 17);
            this.btnChiaDoc.Text = "Chia Dọc";
            this.btnChiaDoc.Click += new System.EventHandler(this.btnChiaDoc_Click);
            // 
            // Timesidebar
            // 
            this.Timesidebar.Interval = 10;
            this.Timesidebar.Tick += new System.EventHandler(this.Timesidebar_Tick);
            // 
            // btnThietLapDiem
            // 
            this.btnThietLapDiem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThietLapDiem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThietLapDiem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThietLapDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnThietLapDiem.Image")));
            this.btnThietLapDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietLapDiem.Location = new System.Drawing.Point(2, 302);
            this.btnThietLapDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThietLapDiem.Name = "btnThietLapDiem";
            this.btnThietLapDiem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThietLapDiem.Size = new System.Drawing.Size(273, 41);
            this.btnThietLapDiem.TabIndex = 10;
            this.btnThietLapDiem.Text = "Thiết Lập Loại Điểm";
            this.btnThietLapDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietLapDiem.UseVisualStyleBackColor = false;
            this.btnThietLapDiem.Click += new System.EventHandler(this.btnThietLapDiem_Click);
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.BackColor = System.Drawing.Color.LightBlue;
            this.btnDoiPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDoiPass.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiPass.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDoiPass.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiPass.Image")));
            this.btnDoiPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiPass.Location = new System.Drawing.Point(0, 467);
            this.btnDoiPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDoiPass.Size = new System.Drawing.Size(273, 41);
            this.btnDoiPass.TabIndex = 9;
            this.btnDoiPass.Text = "Đổi mật khẩu";
            this.btnDoiPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiPass.UseVisualStyleBackColor = false;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // btnThongTinNamHoc
            // 
            this.btnThongTinNamHoc.BackColor = System.Drawing.Color.LightBlue;
            this.btnThongTinNamHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongTinNamHoc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThongTinNamHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinNamHoc.Image")));
            this.btnThongTinNamHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinNamHoc.Location = new System.Drawing.Point(0, 266);
            this.btnThongTinNamHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongTinNamHoc.Name = "btnThongTinNamHoc";
            this.btnThongTinNamHoc.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThongTinNamHoc.Size = new System.Drawing.Size(273, 41);
            this.btnThongTinNamHoc.TabIndex = 8;
            this.btnThongTinNamHoc.Text = "Thông Tin Năm Học";
            this.btnThongTinNamHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTinNamHoc.UseVisualStyleBackColor = false;
            this.btnThongTinNamHoc.Click += new System.EventHandler(this.btnThongTinNamHoc_Click);
            // 
            // btnThongTinHK
            // 
            this.btnThongTinHK.BackColor = System.Drawing.Color.LightBlue;
            this.btnThongTinHK.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongTinHK.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThongTinHK.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinHK.Image")));
            this.btnThongTinHK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinHK.Location = new System.Drawing.Point(0, 228);
            this.btnThongTinHK.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongTinHK.Name = "btnThongTinHK";
            this.btnThongTinHK.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThongTinHK.Size = new System.Drawing.Size(273, 41);
            this.btnThongTinHK.TabIndex = 7;
            this.btnThongTinHK.Text = "Thông Tin Học Kỳ";
            this.btnThongTinHK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTinHK.UseVisualStyleBackColor = false;
            this.btnThongTinHK.Click += new System.EventHandler(this.btnThongTinHK_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightBlue;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 508);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(273, 41);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnChuyenMon
            // 
            this.btnChuyenMon.BackColor = System.Drawing.Color.LightBlue;
            this.btnChuyenMon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnChuyenMon.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnChuyenMon.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenMon.Image")));
            this.btnChuyenMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenMon.Location = new System.Drawing.Point(0, 190);
            this.btnChuyenMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChuyenMon.Name = "btnChuyenMon";
            this.btnChuyenMon.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnChuyenMon.Size = new System.Drawing.Size(273, 41);
            this.btnChuyenMon.TabIndex = 5;
            this.btnChuyenMon.Text = "Chuyên môn";
            this.btnChuyenMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenMon.UseVisualStyleBackColor = false;
            this.btnChuyenMon.Click += new System.EventHandler(this.btnChuyenMon_Click);
            // 
            // btnThayDoiThongTinMonHoc
            // 
            this.btnThayDoiThongTinMonHoc.BackColor = System.Drawing.Color.LightBlue;
            this.btnThayDoiThongTinMonHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThayDoiThongTinMonHoc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThayDoiThongTinMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThayDoiThongTinMonHoc.Image")));
            this.btnThayDoiThongTinMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiThongTinMonHoc.Location = new System.Drawing.Point(0, 152);
            this.btnThayDoiThongTinMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnThayDoiThongTinMonHoc.Name = "btnThayDoiThongTinMonHoc";
            this.btnThayDoiThongTinMonHoc.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThayDoiThongTinMonHoc.Size = new System.Drawing.Size(273, 41);
            this.btnThayDoiThongTinMonHoc.TabIndex = 4;
            this.btnThayDoiThongTinMonHoc.Text = "Thay đổi thông tin môn học";
            this.btnThayDoiThongTinMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThayDoiThongTinMonHoc.UseVisualStyleBackColor = false;
            this.btnThayDoiThongTinMonHoc.Click += new System.EventHandler(this.btnThayDoiThongTinMonHoc_Click);
            // 
            // btnThayDoiQuyDinhThongTinLopHoc
            // 
            this.btnThayDoiQuyDinhThongTinLopHoc.BackColor = System.Drawing.Color.LightBlue;
            this.btnThayDoiQuyDinhThongTinLopHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThayDoiQuyDinhThongTinLopHoc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThayDoiQuyDinhThongTinLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThayDoiQuyDinhThongTinLopHoc.Image")));
            this.btnThayDoiQuyDinhThongTinLopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiQuyDinhThongTinLopHoc.Location = new System.Drawing.Point(0, 114);
            this.btnThayDoiQuyDinhThongTinLopHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnThayDoiQuyDinhThongTinLopHoc.Name = "btnThayDoiQuyDinhThongTinLopHoc";
            this.btnThayDoiQuyDinhThongTinLopHoc.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThayDoiQuyDinhThongTinLopHoc.Size = new System.Drawing.Size(273, 41);
            this.btnThayDoiQuyDinhThongTinLopHoc.TabIndex = 3;
            this.btnThayDoiQuyDinhThongTinLopHoc.Text = "Thay đổi thông tin lớp học";
            this.btnThayDoiQuyDinhThongTinLopHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThayDoiQuyDinhThongTinLopHoc.UseVisualStyleBackColor = false;
            this.btnThayDoiQuyDinhThongTinLopHoc.Click += new System.EventHandler(this.btnThayDoiQuyDinhThongTinLopHoc_Click);
            // 
            // btnThayDoiQuyDinhDoTuoi
            // 
            this.btnThayDoiQuyDinhDoTuoi.BackColor = System.Drawing.Color.LightBlue;
            this.btnThayDoiQuyDinhDoTuoi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThayDoiQuyDinhDoTuoi.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThayDoiQuyDinhDoTuoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThayDoiQuyDinhDoTuoi.Image")));
            this.btnThayDoiQuyDinhDoTuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiQuyDinhDoTuoi.Location = new System.Drawing.Point(0, 76);
            this.btnThayDoiQuyDinhDoTuoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThayDoiQuyDinhDoTuoi.Name = "btnThayDoiQuyDinhDoTuoi";
            this.btnThayDoiQuyDinhDoTuoi.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThayDoiQuyDinhDoTuoi.Size = new System.Drawing.Size(273, 41);
            this.btnThayDoiQuyDinhDoTuoi.TabIndex = 2;
            this.btnThayDoiQuyDinhDoTuoi.Text = "Thay đổi độ tuổi";
            this.btnThayDoiQuyDinhDoTuoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThayDoiQuyDinhDoTuoi.UseVisualStyleBackColor = false;
            this.btnThayDoiQuyDinhDoTuoi.Click += new System.EventHandler(this.btnThayDoiQuyDinhDoTuoi_Click);
            // 
            // btnCapTaiKhoan
            // 
            this.btnCapTaiKhoan.BackColor = System.Drawing.Color.LightBlue;
            this.btnCapTaiKhoan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapTaiKhoan.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCapTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnCapTaiKhoan.Image")));
            this.btnCapTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapTaiKhoan.Location = new System.Drawing.Point(0, 37);
            this.btnCapTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapTaiKhoan.Name = "btnCapTaiKhoan";
            this.btnCapTaiKhoan.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCapTaiKhoan.Size = new System.Drawing.Size(273, 41);
            this.btnCapTaiKhoan.TabIndex = 1;
            this.btnCapTaiKhoan.Text = "Cấp Tài Khoản";
            this.btnCapTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapTaiKhoan.UseVisualStyleBackColor = false;
            this.btnCapTaiKhoan.Click += new System.EventHandler(this.btnCapTaiKhoan_Click);
            // 
            // btnSideBar
            // 
            this.btnSideBar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSideBar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSideBar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSideBar.Image = ((System.Drawing.Image)(resources.GetObject("btnSideBar.Image")));
            this.btnSideBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideBar.Location = new System.Drawing.Point(0, 0);
            this.btnSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSideBar.Name = "btnSideBar";
            this.btnSideBar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSideBar.Size = new System.Drawing.Size(273, 41);
            this.btnSideBar.TabIndex = 0;
            this.btnSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideBar.UseVisualStyleBackColor = false;
            this.btnSideBar.Click += new System.EventHandler(this.btnSideBar_Click);
            // 
            // btnLanKT
            // 
            this.btnLanKT.BackColor = System.Drawing.Color.LightBlue;
            this.btnLanKT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLanKT.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLanKT.Image = ((System.Drawing.Image)(resources.GetObject("btnLanKT.Image")));
            this.btnLanKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanKT.Location = new System.Drawing.Point(2, 338);
            this.btnLanKT.Margin = new System.Windows.Forms.Padding(2);
            this.btnLanKT.Name = "btnLanKT";
            this.btnLanKT.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLanKT.Size = new System.Drawing.Size(273, 41);
            this.btnLanKT.TabIndex = 11;
            this.btnLanKT.Text = "Thiết Lập Quy Định Lần Kiểm Tra";
            this.btnLanKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLanKT.UseVisualStyleBackColor = false;
            this.btnLanKT.Click += new System.EventHandler(this.btnLanKT_Click);
            // 
            // TongQuanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 549);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TongQuanAdmin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSideBar;
        private System.Windows.Forms.Button btnThayDoiQuyDinhDoTuoi;
        private System.Windows.Forms.Button btnCapTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnChuyenMon;
        private System.Windows.Forms.Button btnThayDoiThongTinMonHoc;
        private System.Windows.Forms.Button btnThayDoiQuyDinhThongTinLopHoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btnXepChong;
        private System.Windows.Forms.ToolStripStatusLabel btnChiaNgang;
        private System.Windows.Forms.ToolStripStatusLabel btnChiaDoc;
        private System.Windows.Forms.Timer Timesidebar;
        private System.Windows.Forms.Button btnThongTinHK;
        private System.Windows.Forms.Button btnThongTinNamHoc;
        private System.Windows.Forms.Button btnDoiPass;
        private System.Windows.Forms.Button btnThietLapDiem;
        private System.Windows.Forms.Button btnLanKT;
    }
}