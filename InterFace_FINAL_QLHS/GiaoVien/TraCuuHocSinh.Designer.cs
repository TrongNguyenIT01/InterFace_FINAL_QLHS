namespace InterFace_FINAL_QLHS.GiaoVien
{
    partial class TraCuuHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNhapTenHoacMaHS;
        private System.Windows.Forms.ComboBox cbChonLop;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNhapTenHoacMaHS = new System.Windows.Forms.TextBox();
            this.cbChonLop = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.lblNhaptenhoacmahocsinh = new System.Windows.Forms.Label();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapTenHoacMaHS
            // 
            this.txtNhapTenHoacMaHS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhapTenHoacMaHS.Location = new System.Drawing.Point(16, 39);
            this.txtNhapTenHoacMaHS.Name = "txtNhapTenHoacMaHS";
            this.txtNhapTenHoacMaHS.Size = new System.Drawing.Size(244, 30);
            this.txtNhapTenHoacMaHS.TabIndex = 0;
            // 
            // cbChonLop
            // 
            this.cbChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChonLop.FormattingEnabled = true;
            this.cbChonLop.Items.AddRange(new object[] {
            "10A1",
            "10A2",
            "10A3",
            "10A4",
            "11A1",
            "11A2",
            "11A3",
            "12A1",
            "12A2"});
            this.cbChonLop.Location = new System.Drawing.Point(318, 38);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(170, 31);
            this.cbChonLop.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(646, 29);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 40);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(286, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Danh Sách Học Sinh";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(0, 148);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 24;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(800, 302);
            this.dgvDanhSachHocSinh.TabIndex = 4;
            // 
            // lblNhaptenhoacmahocsinh
            // 
            this.lblNhaptenhoacmahocsinh.AutoSize = true;
            this.lblNhaptenhoacmahocsinh.Location = new System.Drawing.Point(12, 9);
            this.lblNhaptenhoacmahocsinh.Name = "lblNhaptenhoacmahocsinh";
            this.lblNhaptenhoacmahocsinh.Size = new System.Drawing.Size(229, 23);
            this.lblNhaptenhoacmahocsinh.TabIndex = 5;
            this.lblNhaptenhoacmahocsinh.Text = "Nhập Tên Hoặc Mã Học Sinh";
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(314, 9);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(84, 23);
            this.lblChonLop.TabIndex = 6;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 51);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbChonLop);
            this.panel2.Controls.Add(this.lblChonLop);
            this.panel2.Controls.Add(this.lblNhaptenhoacmahocsinh);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtNhapTenHoacMaHS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 97);
            this.panel2.TabIndex = 8;
            // 
            // TraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "TraCuuHocSinh";
            this.Text = "Tra Cứu Học Sinh";
            this.Load += new System.EventHandler(this.TraCuuHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.Label lblNhaptenhoacmahocsinh;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}