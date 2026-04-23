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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNamHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTieuDe.BackColor = System.Drawing.Color.White;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(80, -4);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1000, 47);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thông Tin Năm Học";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSNamHOc
            // 
            this.lblDSNamHOc.AutoSize = true;
            this.lblDSNamHOc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNamHOc.Location = new System.Drawing.Point(12, 3);
            this.lblDSNamHOc.Name = "lblDSNamHOc";
            this.lblDSNamHOc.Size = new System.Drawing.Size(209, 28);
            this.lblDSNamHOc.TabIndex = 1;
            this.lblDSNamHOc.Text = "Danh sách Năm Học:";
            // 
            // lblThongTinThayDOi
            // 
            this.lblThongTinThayDOi.AutoSize = true;
            this.lblThongTinThayDOi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinThayDOi.Location = new System.Drawing.Point(3, 17);
            this.lblThongTinThayDOi.Name = "lblThongTinThayDOi";
            this.lblThongTinThayDOi.Size = new System.Drawing.Size(109, 28);
            this.lblThongTinThayDOi.TabIndex = 2;
            this.lblThongTinThayDOi.Text = "Thông tin:";
            // 
            // lblMaNamHoc
            // 
            this.lblMaNamHoc.AutoSize = true;
            this.lblMaNamHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNamHoc.Location = new System.Drawing.Point(3, 57);
            this.lblMaNamHoc.Name = "lblMaNamHoc";
            this.lblMaNamHoc.Size = new System.Drawing.Size(141, 28);
            this.lblMaNamHoc.TabIndex = 4;
            this.lblMaNamHoc.Text = "Mã Năm Học:";
            // 
            // txtMaNH
            // 
            this.txtMaNH.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNH.Location = new System.Drawing.Point(176, 57);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.Size = new System.Drawing.Size(467, 34);
            this.txtMaNH.TabIndex = 5;
            // 
            // lblTenNamHoc
            // 
            this.lblTenNamHoc.AutoSize = true;
            this.lblTenNamHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNamHoc.Location = new System.Drawing.Point(3, 107);
            this.lblTenNamHoc.Name = "lblTenNamHoc";
            this.lblTenNamHoc.Size = new System.Drawing.Size(144, 28);
            this.lblTenNamHoc.TabIndex = 6;
            this.lblTenNamHoc.Text = "Tên Năm Học:";
            // 
            // txtTenNH
            // 
            this.txtTenNH.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNH.Location = new System.Drawing.Point(176, 107);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(467, 34);
            this.txtTenNH.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(728, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 75);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1021, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 75);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDSNamHoc
            // 
            this.dgvDSNamHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNamHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNamHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNamHoc.Location = new System.Drawing.Point(0, 0);
            this.dgvDSNamHoc.Name = "dgvDSNamHoc";
            this.dgvDSNamHoc.ReadOnly = true;
            this.dgvDSNamHoc.RowHeadersWidth = 51;
            this.dgvDSNamHoc.RowTemplate.Height = 24;
            this.dgvDSNamHoc.Size = new System.Drawing.Size(1154, 364);
            this.dgvDSNamHoc.TabIndex = 13;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(877, 57);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 75);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 45);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblDSNamHOc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 42);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDSNamHoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 364);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblMaNamHoc);
            this.panel4.Controls.Add(this.lblThongTinThayDOi);
            this.panel4.Controls.Add(this.txtMaNH);
            this.panel4.Controls.Add(this.lblTenNamHoc);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.txtTenNH);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 451);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1154, 152);
            this.panel4.TabIndex = 17;
            // 
            // ThongTinNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 603);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "ThongTinNamHoc";
            this.Text = "Thông Tin Năm Học";
            this.Load += new System.EventHandler(this.ThongTinNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNamHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNamHoc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}