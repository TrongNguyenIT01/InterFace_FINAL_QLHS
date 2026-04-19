namespace InterFace_FINAL_QLHS.Admin
{
    partial class ThongTinHocKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDSHocKy;
        private System.Windows.Forms.Label lblThongTinThayDoi;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.Label lblMaNamHoc;
        private System.Windows.Forms.TextBox txtMaNamHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;

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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblDSHocKy = new System.Windows.Forms.Label();
            this.lblThongTinThayDoi = new System.Windows.Forms.Label();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.txtHK = new System.Windows.Forms.TextBox();
            this.lblMaNamHoc = new System.Windows.Forms.Label();
            this.txtMaNamHoc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvDSHocKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1000, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thông Tin Học Kỳ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSHocKy
            // 
            this.lblDSHocKy.AutoSize = true;
            this.lblDSHocKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDSHocKy.Location = new System.Drawing.Point(15, 60);
            this.lblDSHocKy.Name = "lblDSHocKy";
            this.lblDSHocKy.Size = new System.Drawing.Size(156, 23);
            this.lblDSHocKy.TabIndex = 1;
            this.lblDSHocKy.Text = "Danh sách Học Kỳ:";
            // 
            // lblThongTinThayDoi
            // 
            this.lblThongTinThayDoi.AutoSize = true;
            this.lblThongTinThayDoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongTinThayDoi.Location = new System.Drawing.Point(550, 60);
            this.lblThongTinThayDoi.Name = "lblThongTinThayDoi";
            this.lblThongTinThayDoi.Size = new System.Drawing.Size(93, 23);
            this.lblThongTinThayDoi.TabIndex = 2;
            this.lblThongTinThayDoi.Text = "Thông tin:";
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaHK.Location = new System.Drawing.Point(550, 100);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(95, 23);
            this.lblMaHK.TabIndex = 4;
            this.lblMaHK.Text = "Mã Học Kỳ:";
            // 
            // txtMaHK
            // 
            this.txtMaHK.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaHK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaHK.Location = new System.Drawing.Point(678, 97);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(300, 30);
            this.txtMaHK.TabIndex = 5;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHocKy.Location = new System.Drawing.Point(550, 150);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(66, 23);
            this.lblHocKy.TabIndex = 6;
            this.lblHocKy.Text = "Học Kỳ:";
            // 
            // txtHK
            // 
            this.txtHK.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHK.Location = new System.Drawing.Point(678, 147);
            this.txtHK.Name = "txtHK";
            this.txtHK.Size = new System.Drawing.Size(300, 30);
            this.txtHK.TabIndex = 7;
            // 
            // lblMaNamHoc
            // 
            this.lblMaNamHoc.AutoSize = true;
            this.lblMaNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaNamHoc.Location = new System.Drawing.Point(550, 200);
            this.lblMaNamHoc.Name = "lblMaNamHoc";
            this.lblMaNamHoc.Size = new System.Drawing.Size(115, 23);
            this.lblMaNamHoc.TabIndex = 8;
            this.lblMaNamHoc.Text = "Mã Năm Học:";
            // 
            // txtMaNamHoc
            // 
            this.txtMaNamHoc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNamHoc.Location = new System.Drawing.Point(678, 197);
            this.txtMaNamHoc.Name = "txtMaNamHoc";
            this.txtMaNamHoc.Size = new System.Drawing.Size(300, 30);
            this.txtMaNamHoc.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(650, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(800, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(725, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // dgvDSHocKy
            // 
            this.dgvDSHocKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHocKy.Location = new System.Drawing.Point(19, 100);
            this.dgvDSHocKy.Name = "dgvDSHocKy";
            this.dgvDSHocKy.RowHeadersWidth = 51;
            this.dgvDSHocKy.RowTemplate.Height = 24;
            this.dgvDSHocKy.Size = new System.Drawing.Size(492, 334);
            this.dgvDSHocKy.TabIndex = 13;
            // 
            // ThongTinHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.dgvDSHocKy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaNamHoc);
            this.Controls.Add(this.lblMaNamHoc);
            this.Controls.Add(this.txtHK);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.lblThongTinThayDoi);
            this.Controls.Add(this.lblDSHocKy);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "ThongTinHocKy";
            this.Text = "Thông Tin Học Kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHocKy;
    }
}