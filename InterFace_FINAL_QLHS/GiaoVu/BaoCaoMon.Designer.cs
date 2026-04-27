namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class BaoCaoMon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatFileBaoCaoMon = new System.Windows.Forms.Button();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.dgvBaoCaoMon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXuatFileBaoCaoMon);
            this.panel1.Controls.Add(this.btnTaoBaoCao);
            this.panel1.Controls.Add(this.cbMon);
            this.panel1.Controls.Add(this.cbHocKy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 111);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(216, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Báo Cáo Môn";
            // 
            // btnXuatFileBaoCaoMon
            // 
            this.btnXuatFileBaoCaoMon.BackColor = System.Drawing.Color.LightBlue;
            this.btnXuatFileBaoCaoMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileBaoCaoMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatFileBaoCaoMon.Location = new System.Drawing.Point(812, 25);
            this.btnXuatFileBaoCaoMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXuatFileBaoCaoMon.Name = "btnXuatFileBaoCaoMon";
            this.btnXuatFileBaoCaoMon.Size = new System.Drawing.Size(105, 28);
            this.btnXuatFileBaoCaoMon.TabIndex = 3;
            this.btnXuatFileBaoCaoMon.Text = "Xuất File";
            this.btnXuatFileBaoCaoMon.UseVisualStyleBackColor = false;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaoBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(696, 25);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(105, 28);
            this.btnTaoBaoCao.TabIndex = 2;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // cbMon
            // 
            this.cbMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(443, 25);
            this.cbMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(189, 27);
            this.cbMon.TabIndex = 1;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(145, 25);
            this.cbHocKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(147, 27);
            this.cbHocKy.TabIndex = 0;
            // 
            // dgvBaoCaoMon
            // 
            this.dgvBaoCaoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoMon.Location = new System.Drawing.Point(0, 111);
            this.dgvBaoCaoMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBaoCaoMon.Name = "dgvBaoCaoMon";
            this.dgvBaoCaoMon.RowHeadersWidth = 51;
            this.dgvBaoCaoMon.RowTemplate.Height = 24;
            this.dgvBaoCaoMon.Size = new System.Drawing.Size(954, 430);
            this.dgvBaoCaoMon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn Học Kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn Môn: ";
            // 
            // BaoCaoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 541);
            this.Controls.Add(this.dgvBaoCaoMon);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoMon";
            this.Text = "BaoCaoMon";
            this.Load += new System.EventHandler(this.BaoCaoMon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXuatFileBaoCaoMon;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.DataGridView dgvBaoCaoMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}