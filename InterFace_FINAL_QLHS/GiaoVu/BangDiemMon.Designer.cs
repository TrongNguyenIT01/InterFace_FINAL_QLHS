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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimBangDiemMon = new System.Windows.Forms.Button();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbNhapLop = new System.Windows.Forms.ComboBox();
            this.dgvBangDiemMon = new System.Windows.Forms.DataGridView();
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
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1456, 122);
            this.panelTieuDe.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.BackColor = System.Drawing.Color.Lime;
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(1239, 57);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(149, 53);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(808, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chọn Môn: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(365, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn Học Kỳ: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Lớp: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(566, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách học sinh";
            // 
            // btnTimBangDiemMon
            // 
            this.btnTimBangDiemMon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimBangDiemMon.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimBangDiemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimBangDiemMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimBangDiemMon.Location = new System.Drawing.Point(1239, 18);
            this.btnTimBangDiemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimBangDiemMon.Name = "btnTimBangDiemMon";
            this.btnTimBangDiemMon.Size = new System.Drawing.Size(149, 33);
            this.btnTimBangDiemMon.TabIndex = 3;
            this.btnTimBangDiemMon.Text = "Tìm Kiếm";
            this.btnTimBangDiemMon.UseVisualStyleBackColor = false;
            this.btnTimBangDiemMon.Click += new System.EventHandler(this.btnTimBangDiemMon_Click);
            // 
            // cbMon
            // 
            this.cbMon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(963, 21);
            this.cbMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(205, 27);
            this.cbMon.TabIndex = 2;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(544, 21);
            this.cbHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(240, 27);
            this.cbHocKy.TabIndex = 1;
            // 
            // cbNhapLop
            // 
            this.cbNhapLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNhapLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNhapLop.FormattingEnabled = true;
            this.cbNhapLop.Location = new System.Drawing.Point(164, 22);
            this.cbNhapLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNhapLop.Name = "cbNhapLop";
            this.cbNhapLop.Size = new System.Drawing.Size(176, 27);
            this.cbNhapLop.TabIndex = 0;
            // 
            // dgvBangDiemMon
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangDiemMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangDiemMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangDiemMon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangDiemMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDiemMon.Location = new System.Drawing.Point(0, 122);
            this.dgvBangDiemMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBangDiemMon.Name = "dgvBangDiemMon";
            this.dgvBangDiemMon.RowHeadersWidth = 51;
            this.dgvBangDiemMon.RowTemplate.Height = 24;
            this.dgvBangDiemMon.Size = new System.Drawing.Size(1456, 651);
            this.dgvBangDiemMon.TabIndex = 1;
            // 
            // BangDiemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 773);
            this.Controls.Add(this.dgvBangDiemMon);
            this.Controls.Add(this.panelTieuDe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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