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
            this.cbHocKyBaoCaoMon = new System.Windows.Forms.ComboBox();
            this.cbMonHocBaoCaoMon = new System.Windows.Forms.ComboBox();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.btnXuatFileBaoCaoMon = new System.Windows.Forms.Button();
            this.dgvBaoCaoMon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXuatFileBaoCaoMon);
            this.panel1.Controls.Add(this.btnTaoBaoCao);
            this.panel1.Controls.Add(this.cbMonHocBaoCaoMon);
            this.panel1.Controls.Add(this.cbHocKyBaoCaoMon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 137);
            this.panel1.TabIndex = 0;
            // 
            // cbHocKyBaoCaoMon
            // 
            this.cbHocKyBaoCaoMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKyBaoCaoMon.FormattingEnabled = true;
            this.cbHocKyBaoCaoMon.Location = new System.Drawing.Point(21, 31);
            this.cbHocKyBaoCaoMon.Name = "cbHocKyBaoCaoMon";
            this.cbHocKyBaoCaoMon.Size = new System.Drawing.Size(145, 27);
            this.cbHocKyBaoCaoMon.TabIndex = 0;
            // 
            // cbMonHocBaoCaoMon
            // 
            this.cbMonHocBaoCaoMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMonHocBaoCaoMon.FormattingEnabled = true;
            this.cbMonHocBaoCaoMon.Location = new System.Drawing.Point(183, 31);
            this.cbMonHocBaoCaoMon.Name = "cbMonHocBaoCaoMon";
            this.cbMonHocBaoCaoMon.Size = new System.Drawing.Size(145, 27);
            this.cbMonHocBaoCaoMon.TabIndex = 1;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaoBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(476, 26);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(140, 35);
            this.btnTaoBaoCao.TabIndex = 2;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnXuatFileBaoCaoMon
            // 
            this.btnXuatFileBaoCaoMon.BackColor = System.Drawing.Color.LightBlue;
            this.btnXuatFileBaoCaoMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileBaoCaoMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatFileBaoCaoMon.Location = new System.Drawing.Point(631, 26);
            this.btnXuatFileBaoCaoMon.Name = "btnXuatFileBaoCaoMon";
            this.btnXuatFileBaoCaoMon.Size = new System.Drawing.Size(140, 35);
            this.btnXuatFileBaoCaoMon.TabIndex = 3;
            this.btnXuatFileBaoCaoMon.Text = "Xuất File";
            this.btnXuatFileBaoCaoMon.UseVisualStyleBackColor = false;
            // 
            // dgvBaoCaoMon
            // 
            this.dgvBaoCaoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoMon.Location = new System.Drawing.Point(0, 137);
            this.dgvBaoCaoMon.Name = "dgvBaoCaoMon";
            this.dgvBaoCaoMon.RowHeadersWidth = 51;
            this.dgvBaoCaoMon.RowTemplate.Height = 24;
            this.dgvBaoCaoMon.Size = new System.Drawing.Size(800, 313);
            this.dgvBaoCaoMon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(288, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Báo Cáo Môn";
            // 
            // BaoCaoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBaoCaoMon);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoMon";
            this.Text = "BaoCaoMon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXuatFileBaoCaoMon;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.ComboBox cbMonHocBaoCaoMon;
        private System.Windows.Forms.ComboBox cbHocKyBaoCaoMon;
        private System.Windows.Forms.DataGridView dgvBaoCaoMon;
        private System.Windows.Forms.Label label1;
    }
}