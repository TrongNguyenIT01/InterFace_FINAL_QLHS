namespace InterFace_FINAL_QLHS.Admin
{
    partial class ThongTinNamHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDSNamHOc;
        private System.Windows.Forms.Label lblThongTinThayDOi;
        private System.Windows.Forms.Label lblMaNamHoc;
        private System.Windows.Forms.TextBox txtMaNH;
        private System.Windows.Forms.Label lblTenNamHoc;
        private System.Windows.Forms.TextBox txtTenNH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;

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
            this.lblDSNamHOc = new System.Windows.Forms.Label();
            this.lblThongTinThayDOi = new System.Windows.Forms.Label();
            this.lblMaNamHoc = new System.Windows.Forms.Label();
            this.txtMaNH = new System.Windows.Forms.TextBox();
            this.lblTenNamHoc = new System.Windows.Forms.Label();
            this.txtTenNH = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDSNamHoc = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNamHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1000, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thông Tin Năm Học";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSNamHOc
            // 
            this.lblDSNamHOc.AutoSize = true;
            this.lblDSNamHOc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDSNamHOc.Location = new System.Drawing.Point(15, 60);
            this.lblDSNamHOc.Name = "lblDSNamHOc";
            this.lblDSNamHOc.Size = new System.Drawing.Size(175, 23);
            this.lblDSNamHOc.TabIndex = 1;
            this.lblDSNamHOc.Text = "Danh sách Năm Học:";
            // 
            // lblThongTinThayDOi
            // 
            this.lblThongTinThayDOi.AutoSize = true;
            this.lblThongTinThayDOi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThongTinThayDOi.Location = new System.Drawing.Point(550, 60);
            this.lblThongTinThayDOi.Name = "lblThongTinThayDOi";
            this.lblThongTinThayDOi.Size = new System.Drawing.Size(93, 23);
            this.lblThongTinThayDOi.TabIndex = 2;
            this.lblThongTinThayDOi.Text = "Thông tin:";
            // 
            // lblMaNamHoc
            // 
            this.lblMaNamHoc.AutoSize = true;
            this.lblMaNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaNamHoc.Location = new System.Drawing.Point(550, 100);
            this.lblMaNamHoc.Name = "lblMaNamHoc";
            this.lblMaNamHoc.Size = new System.Drawing.Size(115, 23);
            this.lblMaNamHoc.TabIndex = 4;
            this.lblMaNamHoc.Text = "Mã Năm Học:";
            // 
            // txtMaNH
            // 
            this.txtMaNH.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaNH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNH.Location = new System.Drawing.Point(688, 97);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.Size = new System.Drawing.Size(300, 30);
            this.txtMaNH.TabIndex = 5;
            // 
            // lblTenNamHoc
            // 
            this.lblTenNamHoc.AutoSize = true;
            this.lblTenNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenNamHoc.Location = new System.Drawing.Point(550, 150);
            this.lblTenNamHoc.Name = "lblTenNamHoc";
            this.lblTenNamHoc.Size = new System.Drawing.Size(117, 23);
            this.lblTenNamHoc.TabIndex = 6;
            this.lblTenNamHoc.Text = "Tên Năm Học:";
            // 
            // txtTenNH
            // 
            this.txtTenNH.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenNH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenNH.Location = new System.Drawing.Point(688, 147);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(300, 30);
            this.txtTenNH.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(649, 235);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(840, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDSNamHoc
            // 
            this.dgvDSNamHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNamHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNamHoc.Location = new System.Drawing.Point(19, 97);
            this.dgvDSNamHoc.Name = "dgvDSNamHoc";
            this.dgvDSNamHoc.ReadOnly = true;
            this.dgvDSNamHoc.RowHeadersWidth = 51;
            this.dgvDSNamHoc.RowTemplate.Height = 24;
            this.dgvDSNamHoc.Size = new System.Drawing.Size(514, 341);
            this.dgvDSNamHoc.TabIndex = 13;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(744, 302);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ThongTinNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.dgvDSNamHoc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNH);
            this.Controls.Add(this.lblTenNamHoc);
            this.Controls.Add(this.txtMaNH);
            this.Controls.Add(this.lblMaNamHoc);
            this.Controls.Add(this.lblThongTinThayDOi);
            this.Controls.Add(this.lblDSNamHOc);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "ThongTinNamHoc";
            this.Text = "Thông Tin Năm Học";
            this.Load += new System.EventHandler(this.ThongTinNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNamHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNamHoc;
        private System.Windows.Forms.Button btnSua;
    }
}