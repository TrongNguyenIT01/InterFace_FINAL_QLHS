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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnThemVaoLop = new System.Windows.Forms.Button();
            this.btnXepLop = new System.Windows.Forms.Button();
            this.btnRutKhoiLop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNgayTiepNhan = new System.Windows.Forms.TextBox();
            this.cbKhoiHocSinhChuaCoLop = new System.Windows.Forms.ComboBox();
            this.btnTimHocSinhChuaCoLop = new System.Windows.Forms.Button();
            this.cbKhoiDanhSachLop = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btnTimLop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRutKhoiLop);
            this.panel1.Controls.Add(this.btnXepLop);
            this.panel1.Controls.Add(this.btnThemVaoLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 81);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 369);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // btnThemVaoLop
            // 
            this.btnThemVaoLop.BackColor = System.Drawing.Color.Lime;
            this.btnThemVaoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemVaoLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaoLop.Image")));
            this.btnThemVaoLop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoLop.Location = new System.Drawing.Point(12, 28);
            this.btnThemVaoLop.Name = "btnThemVaoLop";
            this.btnThemVaoLop.Size = new System.Drawing.Size(228, 35);
            this.btnThemVaoLop.TabIndex = 0;
            this.btnThemVaoLop.Text = "Thêm học sinh";
            this.btnThemVaoLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoLop.UseVisualStyleBackColor = false;
            // 
            // btnXepLop
            // 
            this.btnXepLop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXepLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXepLop.Location = new System.Drawing.Point(312, 28);
            this.btnXepLop.Name = "btnXepLop";
            this.btnXepLop.Size = new System.Drawing.Size(177, 35);
            this.btnXepLop.TabIndex = 1;
            this.btnXepLop.Text = "Xếp lớp tự động";
            this.btnXepLop.UseVisualStyleBackColor = false;
            // 
            // btnRutKhoiLop
            // 
            this.btnRutKhoiLop.BackColor = System.Drawing.Color.Orange;
            this.btnRutKhoiLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutKhoiLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRutKhoiLop.Image = ((System.Drawing.Image)(resources.GetObject("btnRutKhoiLop.Image")));
            this.btnRutKhoiLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutKhoiLop.Location = new System.Drawing.Point(560, 28);
            this.btnRutKhoiLop.Name = "btnRutKhoiLop";
            this.btnRutKhoiLop.Size = new System.Drawing.Size(228, 35);
            this.btnRutKhoiLop.TabIndex = 2;
            this.btnRutKhoiLop.Text = "Rút khỏi danh sách";
            this.btnRutKhoiLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRutKhoiLop.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimLop);
            this.panel2.Controls.Add(this.cbLop);
            this.panel2.Controls.Add(this.cbKhoiDanhSachLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 70);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTimHocSinhChuaCoLop);
            this.panel3.Controls.Add(this.cbKhoiHocSinhChuaCoLop);
            this.panel3.Controls.Add(this.txtNgayTiepNhan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 70);
            this.panel3.TabIndex = 1;
            // 
            // txtNgayTiepNhan
            // 
            this.txtNgayTiepNhan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayTiepNhan.Location = new System.Drawing.Point(12, 25);
            this.txtNgayTiepNhan.Name = "txtNgayTiepNhan";
            this.txtNgayTiepNhan.Size = new System.Drawing.Size(135, 27);
            this.txtNgayTiepNhan.TabIndex = 0;
            // 
            // cbKhoiHocSinhChuaCoLop
            // 
            this.cbKhoiHocSinhChuaCoLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKhoiHocSinhChuaCoLop.FormattingEnabled = true;
            this.cbKhoiHocSinhChuaCoLop.Location = new System.Drawing.Point(156, 25);
            this.cbKhoiHocSinhChuaCoLop.Name = "cbKhoiHocSinhChuaCoLop";
            this.cbKhoiHocSinhChuaCoLop.Size = new System.Drawing.Size(135, 27);
            this.cbKhoiHocSinhChuaCoLop.TabIndex = 1;
            // 
            // btnTimHocSinhChuaCoLop
            // 
            this.btnTimHocSinhChuaCoLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimHocSinhChuaCoLop.Location = new System.Drawing.Point(310, 25);
            this.btnTimHocSinhChuaCoLop.Name = "btnTimHocSinhChuaCoLop";
            this.btnTimHocSinhChuaCoLop.Size = new System.Drawing.Size(75, 27);
            this.btnTimHocSinhChuaCoLop.TabIndex = 2;
            this.btnTimHocSinhChuaCoLop.Text = "Tìm";
            this.btnTimHocSinhChuaCoLop.UseVisualStyleBackColor = true;
            // 
            // cbKhoiDanhSachLop
            // 
            this.cbKhoiDanhSachLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKhoiDanhSachLop.FormattingEnabled = true;
            this.cbKhoiDanhSachLop.Location = new System.Drawing.Point(15, 23);
            this.cbKhoiDanhSachLop.Name = "cbKhoiDanhSachLop";
            this.cbKhoiDanhSachLop.Size = new System.Drawing.Size(135, 27);
            this.cbKhoiDanhSachLop.TabIndex = 2;
            // 
            // cbLop
            // 
            this.cbLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(156, 23);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(135, 27);
            this.cbLop.TabIndex = 3;
            // 
            // btnTimLop
            // 
            this.btnTimLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimLop.Location = new System.Drawing.Point(310, 23);
            this.btnTimLop.Name = "btnTimLop";
            this.btnTimLop.Size = new System.Drawing.Size(75, 29);
            this.btnTimLop.TabIndex = 4;
            this.btnTimLop.Text = "Tìm";
            this.btnTimLop.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(400, 299);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(396, 299);
            this.dataGridView2.TabIndex = 1;
            // 
            // LapDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "LapDanhSachLop";
            this.Text = "LapDanhSachLop";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button btnTimHocSinhChuaCoLop;
        private System.Windows.Forms.ComboBox cbKhoiHocSinhChuaCoLop;
        private System.Windows.Forms.TextBox txtNgayTiepNhan;
        private System.Windows.Forms.Button btnTimLop;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoiDanhSachLop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}