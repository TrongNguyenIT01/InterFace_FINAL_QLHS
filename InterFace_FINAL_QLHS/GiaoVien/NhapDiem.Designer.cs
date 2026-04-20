namespace InterFace_FINAL_QLHS.GiaoVien
{
    partial class NhapDiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbChonLop;
        private System.Windows.Forms.ComboBox cbChonHocKy;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnNhapDiem;
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
            this.cbChonLop = new System.Windows.Forms.ComboBox();
            this.cbChonHocKy = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDanhSachHS = new System.Windows.Forms.DataGridView();
            this.lblChonLop = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbChonLop
            // 
            this.cbChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChonLop.FormattingEnabled = true;
            this.cbChonLop.Location = new System.Drawing.Point(32, 54);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(140, 31);
            this.cbChonLop.TabIndex = 0;
            // 
            // cbChonHocKy
            // 
            this.cbChonHocKy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbChonHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChonHocKy.FormattingEnabled = true;
            this.cbChonHocKy.Location = new System.Drawing.Point(215, 54);
            this.cbChonHocKy.Name = "cbChonHocKy";
            this.cbChonHocKy.Size = new System.Drawing.Size(140, 31);
            this.cbChonHocKy.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(523, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 40);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapDiem.BackColor = System.Drawing.Color.Orange;
            this.btnNhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapDiem.ForeColor = System.Drawing.Color.White;
            this.btnNhapDiem.Location = new System.Drawing.Point(668, 23);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(120, 40);
            this.btnNhapDiem.TabIndex = 3;
            this.btnNhapDiem.Text = "Nhập Điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(237, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Danh Sách Học Sinh";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachHS
            // 
            this.dgvDanhSachHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHS.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachHS.Name = "dgvDanhSachHS";
            this.dgvDanhSachHS.RowHeadersWidth = 51;
            this.dgvDanhSachHS.RowTemplate.Height = 24;
            this.dgvDanhSachHS.Size = new System.Drawing.Size(800, 450);
            this.dgvDanhSachHS.TabIndex = 5;
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(28, 23);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(84, 23);
            this.lblChonLop.TabIndex = 6;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(211, 23);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(108, 23);
            this.lblHocKy.TabIndex = 7;
            this.lblHocKy.Text = "Chọn Học Kỳ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblChonLop);
            this.panel2.Controls.Add(this.cbChonLop);
            this.panel2.Controls.Add(this.lblHocKy);
            this.panel2.Controls.Add(this.btnNhapDiem);
            this.panel2.Controls.Add(this.cbChonHocKy);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 108);
            this.panel2.TabIndex = 9;
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDanhSachHS);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "NhapDiem";
            this.Text = "Nhập Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHS;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}