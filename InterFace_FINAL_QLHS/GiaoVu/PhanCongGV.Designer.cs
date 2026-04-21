namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class PhanCongGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCongGV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyLop = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvChonGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbChuyenMon = new System.Windows.Forms.ComboBox();
            this.txtNhapTenGV = new System.Windows.Forms.TextBox();
            this.dgvChonLopGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbChonLop = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnChonLopChuNhiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonLopGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyLop);
            this.panel1.Controls.Add(this.btnPhanCong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnHuyLop
            // 
            this.btnHuyLop.BackColor = System.Drawing.Color.Orange;
            this.btnHuyLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyLop.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyLop.Image")));
            this.btnHuyLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyLop.Location = new System.Drawing.Point(942, 25);
            this.btnHuyLop.Name = "btnHuyLop";
            this.btnHuyLop.Size = new System.Drawing.Size(156, 36);
            this.btnHuyLop.TabIndex = 1;
            this.btnHuyLop.Text = "Hủy lớp";
            this.btnHuyLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyLop.UseVisualStyleBackColor = false;
            this.btnHuyLop.Click += new System.EventHandler(this.btnHuyLop_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.BackColor = System.Drawing.Color.LightGreen;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhanCong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanCong.Image")));
            this.btnPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhanCong.Location = new System.Drawing.Point(12, 25);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(156, 36);
            this.btnPhanCong.TabIndex = 0;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.UseVisualStyleBackColor = false;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.dgvChonGV);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.dgvChonLopGV);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 525);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // dgvChonGV
            // 
            this.dgvChonGV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvChonGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChonGV.Location = new System.Drawing.Point(0, 98);
            this.dgvChonGV.Name = "dgvChonGV";
            this.dgvChonGV.RowHeadersWidth = 51;
            this.dgvChonGV.RowTemplate.Height = 24;
            this.dgvChonGV.Size = new System.Drawing.Size(555, 427);
            this.dgvChonGV.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbChuyenMon);
            this.panel2.Controls.Add(this.txtNhapTenGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 98);
            this.panel2.TabIndex = 0;
            // 
            // cbChuyenMon
            // 
            this.cbChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuyenMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChuyenMon.FormattingEnabled = true;
            this.cbChuyenMon.Location = new System.Drawing.Point(337, 20);
            this.cbChuyenMon.Name = "cbChuyenMon";
            this.cbChuyenMon.Size = new System.Drawing.Size(215, 27);
            this.cbChuyenMon.TabIndex = 1;
            this.cbChuyenMon.SelectedIndexChanged += new System.EventHandler(this.cbChuyenMon_SelectedIndexChanged);
            // 
            // txtNhapTenGV
            // 
            this.txtNhapTenGV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhapTenGV.Location = new System.Drawing.Point(12, 20);
            this.txtNhapTenGV.Name = "txtNhapTenGV";
            this.txtNhapTenGV.Size = new System.Drawing.Size(319, 27);
            this.txtNhapTenGV.TabIndex = 0;
            this.txtNhapTenGV.TextChanged += new System.EventHandler(this.txtNhapTenGV_TextChanged);
            // 
            // dgvChonLopGV
            // 
            this.dgvChonLopGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvChonLopGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonLopGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChonLopGV.Location = new System.Drawing.Point(0, 98);
            this.dgvChonLopGV.Name = "dgvChonLopGV";
            this.dgvChonLopGV.RowHeadersWidth = 51;
            this.dgvChonLopGV.RowTemplate.Height = 24;
            this.dgvChonLopGV.Size = new System.Drawing.Size(551, 427);
            this.dgvChonLopGV.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.cbHocKy);
            this.panel3.Controls.Add(this.cbMon);
            this.panel3.Controls.Add(this.cbChonLop);
            this.panel3.Controls.Add(this.btn);
            this.panel3.Controls.Add(this.btnChonLopChuNhiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 98);
            this.panel3.TabIndex = 0;
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(367, 20);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(176, 27);
            this.cbHocKy.TabIndex = 4;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // cbMon
            // 
            this.cbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(185, 20);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(176, 27);
            this.cbMon.TabIndex = 3;
            this.cbMon.SelectedIndexChanged += new System.EventHandler(this.cbMon_SelectedIndexChanged);
            // 
            // cbChonLop
            // 
            this.cbChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChonLop.FormattingEnabled = true;
            this.cbChonLop.Location = new System.Drawing.Point(3, 20);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(176, 27);
            this.cbChonLop.TabIndex = 2;
            this.cbChonLop.SelectedIndexChanged += new System.EventHandler(this.cbChonLop_SelectedIndexChanged);
            this.cbChonLop.Click += new System.EventHandler(this.cbChonLop_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn.Location = new System.Drawing.Point(3, 60);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(150, 32);
            this.btn.TabIndex = 1;
            this.btn.Text = "Hủy chủ nhiệm";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnHuyChuNhiem_Click);
            // 
            // btnChonLopChuNhiem
            // 
            this.btnChonLopChuNhiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonLopChuNhiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonLopChuNhiem.Location = new System.Drawing.Point(393, 60);
            this.btnChonLopChuNhiem.Name = "btnChonLopChuNhiem";
            this.btnChonLopChuNhiem.Size = new System.Drawing.Size(150, 32);
            this.btnChonLopChuNhiem.TabIndex = 0;
            this.btnChonLopChuNhiem.Text = "Lớp chủ nhiệm";
            this.btnChonLopChuNhiem.UseVisualStyleBackColor = true;
            this.btnChonLopChuNhiem.Click += new System.EventHandler(this.btnChonLopChuNhiem_Click);
            // 
            // PhanCongGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 625);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "PhanCongGV";
            this.Text = "PhanCongGV";
            this.Load += new System.EventHandler(this.PhanCongGV_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonLopGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnHuyLop;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNhapTenGV;
        private System.Windows.Forms.DataGridView dgvChonGV;
        private System.Windows.Forms.DataGridView dgvChonLopGV;
        private System.Windows.Forms.ComboBox cbChuyenMon;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnChonLopChuNhiem;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbChonLop;
    }
}