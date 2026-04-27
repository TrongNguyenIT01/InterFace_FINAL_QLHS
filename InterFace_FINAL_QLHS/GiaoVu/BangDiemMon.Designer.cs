namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class BangDiemMon
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
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimBangDiemMon = new System.Windows.Forms.Button();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbNhapLop = new System.Windows.Forms.ComboBox();
            this.dgvBangDiemMon = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemMon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.Controls.Add(this.btnExport);
            this.panelTieuDe.Controls.Add(this.label4);
            this.panelTieuDe.Controls.Add(this.label3);
            this.panelTieuDe.Controls.Add(this.label2);
            this.panelTieuDe.Controls.Add(this.label1);
            this.panelTieuDe.Controls.Add(this.btnTimBangDiemMon);
            this.panelTieuDe.Controls.Add(this.cbMon);
            this.panelTieuDe.Controls.Add(this.cbHocKy);
            this.panelTieuDe.Controls.Add(this.cbNhapLop);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(2);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1092, 99);
            this.panelTieuDe.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(606, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chọn Môn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(274, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn Học Kỳ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Lớp: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(175, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách học sinh";
            // 
            // btnTimBangDiemMon
            // 
            this.btnTimBangDiemMon.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimBangDiemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimBangDiemMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimBangDiemMon.Location = new System.Drawing.Point(929, 15);
            this.btnTimBangDiemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimBangDiemMon.Name = "btnTimBangDiemMon";
            this.btnTimBangDiemMon.Size = new System.Drawing.Size(112, 27);
            this.btnTimBangDiemMon.TabIndex = 3;
            this.btnTimBangDiemMon.Text = "Tìm Kiếm";
            this.btnTimBangDiemMon.UseVisualStyleBackColor = false;
            this.btnTimBangDiemMon.Click += new System.EventHandler(this.btnTimBangDiemMon_Click);
            // 
            // cbMon
            // 
            this.cbMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(722, 17);
            this.cbMon.Margin = new System.Windows.Forms.Padding(2);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(155, 27);
            this.cbMon.TabIndex = 2;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(408, 17);
            this.cbHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(181, 27);
            this.cbHocKy.TabIndex = 1;
            // 
            // cbNhapLop
            // 
            this.cbNhapLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNhapLop.FormattingEnabled = true;
            this.cbNhapLop.Location = new System.Drawing.Point(123, 18);
            this.cbNhapLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhapLop.Name = "cbNhapLop";
            this.cbNhapLop.Size = new System.Drawing.Size(133, 27);
            this.cbNhapLop.TabIndex = 0;
            // 
            // dgvBangDiemMon
            // 
            this.dgvBangDiemMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiemMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDiemMon.Location = new System.Drawing.Point(0, 99);
            this.dgvBangDiemMon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBangDiemMon.Name = "dgvBangDiemMon";
            this.dgvBangDiemMon.RowHeadersWidth = 51;
            this.dgvBangDiemMon.RowTemplate.Height = 24;
            this.dgvBangDiemMon.Size = new System.Drawing.Size(1092, 529);
            this.dgvBangDiemMon.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Lime;
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(929, 46);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 43);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // BangDiemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 628);
            this.Controls.Add(this.dgvBangDiemMon);
            this.Controls.Add(this.panelTieuDe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BangDiemMon";
            this.Text = "BangDiemMon";
            this.Load += new System.EventHandler(this.BangDiemMon_Load);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimBangDiemMon;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbNhapLop;
        private System.Windows.Forms.DataGridView dgvBangDiemMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
    }
}