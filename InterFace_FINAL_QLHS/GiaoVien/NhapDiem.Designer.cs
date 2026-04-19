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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHS)).BeginInit();
            this.SuspendLayout();
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
            this.cbChonLop.Location = new System.Drawing.Point(16, 65);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(140, 31);
            this.cbChonLop.TabIndex = 0;
            // 
            // cbChonHocKy
            // 
            this.cbChonHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChonHocKy.FormattingEnabled = true;
            this.cbChonHocKy.Items.AddRange(new object[] {
            "Hoc ky 1",
            "Hoc ky 2",
            "Cuoi ky"});
            this.cbChonHocKy.Location = new System.Drawing.Point(185, 65);
            this.cbChonHocKy.Name = "cbChonHocKy";
            this.cbChonHocKy.Size = new System.Drawing.Size(140, 31);
            this.cbChonHocKy.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(511, 65);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 40);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.Orange;
            this.btnNhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapDiem.ForeColor = System.Drawing.Color.White;
            this.btnNhapDiem.Location = new System.Drawing.Point(662, 65);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(120, 40);
            this.btnNhapDiem.TabIndex = 3;
            this.btnNhapDiem.Text = "Nhập Điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(251, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Danh sách học sinh";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachHS
            // 
            this.dgvDanhSachHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHS.Location = new System.Drawing.Point(12, 142);
            this.dgvDanhSachHS.Name = "dgvDanhSachHS";
            this.dgvDanhSachHS.RowHeadersWidth = 51;
            this.dgvDanhSachHS.RowTemplate.Height = 24;
            this.dgvDanhSachHS.Size = new System.Drawing.Size(770, 299);
            this.dgvDanhSachHS.TabIndex = 5;
            // 
            // lblChonLop
            // 
            this.lblChonLop.AutoSize = true;
            this.lblChonLop.Location = new System.Drawing.Point(12, 30);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(84, 23);
            this.lblChonLop.TabIndex = 6;
            this.lblChonLop.Text = "Chọn Lớp";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(181, 30);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(108, 23);
            this.lblHocKy.TabIndex = 7;
            this.lblHocKy.Text = "Chọn Học Kỳ";
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.dgvDanhSachHS);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbChonHocKy);
            this.Controls.Add(this.cbChonLop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "NhapDiem";
            this.Text = "Nhập Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHS;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.Label lblHocKy;
    }
}