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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNhapTenHoacMaHS
            // 
            this.txtNhapTenHoacMaHS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhapTenHoacMaHS.Location = new System.Drawing.Point(5, 80);
            this.txtNhapTenHoacMaHS.Name = "txtNhapTenHoacMaHS";
            this.txtNhapTenHoacMaHS.Size = new System.Drawing.Size(220, 30);
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
            this.cbChonLop.Location = new System.Drawing.Point(240, 80);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(170, 31);
            this.cbChonLop.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(590, 80);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 40);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Danh sách học sinh";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(15, 146);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 24;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(773, 296);
            this.dgvDanhSachHocSinh.TabIndex = 4;
            // 
            // lblNhaptenhoacmahocsinh
            // 
            this.lblNhaptenhoacmahocsinh.AutoSize = true;
            this.lblNhaptenhoacmahocsinh.Location = new System.Drawing.Point(1, 54);
            this.lblNhaptenhoacmahocsinh.Name = "lblNhaptenhoacmahocsinh";
            this.lblNhaptenhoacmahocsinh.Size = new System.Drawing.Size(222, 23);
            this.lblNhaptenhoacmahocsinh.TabIndex = 5;
            this.lblNhaptenhoacmahocsinh.Text = "Nhập tên hoặc mã học sinh";
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(236, 54);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(84, 23);
            this.lblChonLop.TabIndex = 6;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // TraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.lblNhaptenhoacmahocsinh);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbChonLop);
            this.Controls.Add(this.txtNhapTenHoacMaHS);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "TraCuuHocSinh";
            this.Text = "Tra Cứu Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.Label lblNhaptenhoacmahocsinh;
        private System.Windows.Forms.Label lblChonLop;
    }
}