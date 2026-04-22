namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class LapDanhSachLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapDanhSachLop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRutKhoiLop = new System.Windows.Forms.Button();
            this.btnXepLop = new System.Windows.Forms.Button();
            this.btnThemVaoLop = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTimHSTN = new System.Windows.Forms.Button();
            this.cbKhoiTN = new System.Windows.Forms.ComboBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtGVCN = new System.Windows.Forms.TextBox();
            this.btnTimLop = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNamHoc);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRutKhoiLop);
            this.panel1.Controls.Add(this.btnXepLop);
            this.panel1.Controls.Add(this.btnThemVaoLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 66);
            this.panel1.TabIndex = 0;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.BackColor = System.Drawing.SystemColors.Info;
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(532, 23);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(229, 31);
            this.cbNamHoc.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Yellow;
            this.btnExport.Location = new System.Drawing.Point(1066, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(181, 38);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất Danh Sách Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(195, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa Danh Sách";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRutKhoiLop
            // 
            this.btnRutKhoiLop.BackColor = System.Drawing.Color.Orange;
            this.btnRutKhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutKhoiLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRutKhoiLop.Image = ((System.Drawing.Image)(resources.GetObject("btnRutKhoiLop.Image")));
            this.btnRutKhoiLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutKhoiLop.Location = new System.Drawing.Point(825, 23);
            this.btnRutKhoiLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnRutKhoiLop.Name = "btnRutKhoiLop";
            this.btnRutKhoiLop.Size = new System.Drawing.Size(191, 28);
            this.btnRutKhoiLop.TabIndex = 2;
            this.btnRutKhoiLop.Text = "Rút khỏi danh sách";
            this.btnRutKhoiLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRutKhoiLop.UseVisualStyleBackColor = false;
            // 
            // btnXepLop
            // 
            this.btnXepLop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXepLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXepLop.Location = new System.Drawing.Point(376, 23);
            this.btnXepLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnXepLop.Name = "btnXepLop";
            this.btnXepLop.Size = new System.Drawing.Size(133, 28);
            this.btnXepLop.TabIndex = 1;
            this.btnXepLop.Text = "Xếp lớp tự động";
            this.btnXepLop.UseVisualStyleBackColor = false;
            this.btnXepLop.Click += new System.EventHandler(this.btnXepLop_Click);
            // 
            // btnThemVaoLop
            // 
            this.btnThemVaoLop.BackColor = System.Drawing.Color.Lime;
            this.btnThemVaoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemVaoLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaoLop.Image")));
            this.btnThemVaoLop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoLop.Location = new System.Drawing.Point(9, 23);
            this.btnThemVaoLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemVaoLop.Name = "btnThemVaoLop";
            this.btnThemVaoLop.Size = new System.Drawing.Size(171, 28);
            this.btnThemVaoLop.TabIndex = 0;
            this.btnThemVaoLop.Text = "Thêm học sinh";
            this.btnThemVaoLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoLop.UseVisualStyleBackColor = false;
            this.btnThemVaoLop.Click += new System.EventHandler(this.btnThemVaoLop_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.dgvTN);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.dgvLop);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1309, 695);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // dgvTN
            // 
            this.dgvTN.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTN.Location = new System.Drawing.Point(0, 57);
            this.dgvTN.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.RowTemplate.Height = 24;
            this.dgvTN.Size = new System.Drawing.Size(580, 638);
            this.dgvTN.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTimHSTN);
            this.panel3.Controls.Add(this.cbKhoiTN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 57);
            this.panel3.TabIndex = 1;
            // 
            // btnTimHSTN
            // 
            this.btnTimHSTN.BackColor = System.Drawing.Color.Chartreuse;
            this.btnTimHSTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimHSTN.ForeColor = System.Drawing.Color.Black;
            this.btnTimHSTN.Location = new System.Drawing.Point(300, 12);
            this.btnTimHSTN.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimHSTN.Name = "btnTimHSTN";
            this.btnTimHSTN.Size = new System.Drawing.Size(67, 28);
            this.btnTimHSTN.TabIndex = 2;
            this.btnTimHSTN.Text = "Tìm";
            this.btnTimHSTN.UseVisualStyleBackColor = false;
            this.btnTimHSTN.Click += new System.EventHandler(this.btnTimHSTN_Click);
            // 
            // cbKhoiTN
            // 
            this.cbKhoiTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoiTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKhoiTN.FormattingEnabled = true;
            this.cbKhoiTN.Items.AddRange(new object[] {
            "--Tìm Học Sinh Theo Khối--"});
            this.cbKhoiTN.Location = new System.Drawing.Point(20, 16);
            this.cbKhoiTN.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhoiTN.Name = "cbKhoiTN";
            this.cbKhoiTN.Size = new System.Drawing.Size(263, 27);
            this.cbKhoiTN.TabIndex = 1;
            // 
            // dgvLop
            // 
            this.dgvLop.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.Location = new System.Drawing.Point(0, 57);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(726, 638);
            this.dgvLop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSiSo);
            this.panel2.Controls.Add(this.txtGVCN);
            this.panel2.Controls.Add(this.btnTimLop);
            this.panel2.Controls.Add(this.cbLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 57);
            this.panel2.TabIndex = 0;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(463, 16);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiSo.Multiline = true;
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(169, 27);
            this.txtSiSo.TabIndex = 6;
            // 
            // txtGVCN
            // 
            this.txtGVCN.Location = new System.Drawing.Point(202, 16);
            this.txtGVCN.Margin = new System.Windows.Forms.Padding(2);
            this.txtGVCN.Multiline = true;
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.ReadOnly = true;
            this.txtGVCN.Size = new System.Drawing.Size(222, 27);
            this.txtGVCN.TabIndex = 5;
            // 
            // btnTimLop
            // 
            this.btnTimLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTimLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimLop.Location = new System.Drawing.Point(135, 15);
            this.btnTimLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimLop.Name = "btnTimLop";
            this.btnTimLop.Size = new System.Drawing.Size(56, 24);
            this.btnTimLop.TabIndex = 4;
            this.btnTimLop.Text = "Tìm";
            this.btnTimLop.UseVisualStyleBackColor = false;
            this.btnTimLop.Click += new System.EventHandler(this.btnTimLop_Click);
            // 
            // cbLop
            // 
            this.cbLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(2, 16);
            this.cbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(122, 27);
            this.cbLop.TabIndex = 3;
            // 
            // LapDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 761);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LapDanhSachLop";
            this.Text = "LapDanhSachLop";
            this.Load += new System.EventHandler(this.LapDanhSachLop_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRutKhoiLop;
        private System.Windows.Forms.Button btnXepLop;
        private System.Windows.Forms.Button btnThemVaoLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTimHSTN;
        private System.Windows.Forms.ComboBox cbKhoiTN;
        private System.Windows.Forms.Button btnTimLop;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtGVCN;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbNamHoc;
    }
}