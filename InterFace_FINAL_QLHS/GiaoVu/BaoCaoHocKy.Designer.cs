namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class BaoCaoHocKy
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
            this.dgvBaoCaoHocKy = new System.Windows.Forms.DataGridView();
            this.cbHocKyBaoCaoHocKy = new System.Windows.Forms.ComboBox();
            this.btnTaoBaoCaoHocKy = new System.Windows.Forms.Button();
            this.btnXuatFileBaoCaoHocKy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXuatFileBaoCaoHocKy);
            this.panel1.Controls.Add(this.btnTaoBaoCaoHocKy);
            this.panel1.Controls.Add(this.cbHocKyBaoCaoHocKy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 126);
            this.panel1.TabIndex = 0;
            // 
            // dgvBaoCaoHocKy
            // 
            this.dgvBaoCaoHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoHocKy.Location = new System.Drawing.Point(0, 126);
            this.dgvBaoCaoHocKy.Name = "dgvBaoCaoHocKy";
            this.dgvBaoCaoHocKy.RowHeadersWidth = 51;
            this.dgvBaoCaoHocKy.RowTemplate.Height = 24;
            this.dgvBaoCaoHocKy.Size = new System.Drawing.Size(800, 324);
            this.dgvBaoCaoHocKy.TabIndex = 1;
            // 
            // cbHocKyBaoCaoHocKy
            // 
            this.cbHocKyBaoCaoHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKyBaoCaoHocKy.FormattingEnabled = true;
            this.cbHocKyBaoCaoHocKy.Location = new System.Drawing.Point(35, 28);
            this.cbHocKyBaoCaoHocKy.Name = "cbHocKyBaoCaoHocKy";
            this.cbHocKyBaoCaoHocKy.Size = new System.Drawing.Size(145, 27);
            this.cbHocKyBaoCaoHocKy.TabIndex = 0;
            // 
            // btnTaoBaoCaoHocKy
            // 
            this.btnTaoBaoCaoHocKy.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaoBaoCaoHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCaoHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoBaoCaoHocKy.Location = new System.Drawing.Point(466, 25);
            this.btnTaoBaoCaoHocKy.Name = "btnTaoBaoCaoHocKy";
            this.btnTaoBaoCaoHocKy.Size = new System.Drawing.Size(143, 30);
            this.btnTaoBaoCaoHocKy.TabIndex = 1;
            this.btnTaoBaoCaoHocKy.Text = "Tạo Báo Cáo";
            this.btnTaoBaoCaoHocKy.UseVisualStyleBackColor = false;
            // 
            // btnXuatFileBaoCaoHocKy
            // 
            this.btnXuatFileBaoCaoHocKy.BackColor = System.Drawing.Color.LightGreen;
            this.btnXuatFileBaoCaoHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileBaoCaoHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatFileBaoCaoHocKy.Location = new System.Drawing.Point(626, 25);
            this.btnXuatFileBaoCaoHocKy.Name = "btnXuatFileBaoCaoHocKy";
            this.btnXuatFileBaoCaoHocKy.Size = new System.Drawing.Size(143, 30);
            this.btnXuatFileBaoCaoHocKy.TabIndex = 2;
            this.btnXuatFileBaoCaoHocKy.Text = "Xuất File";
            this.btnXuatFileBaoCaoHocKy.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(269, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Báo Cáo Học Kỳ";
            // 
            // BaoCaoHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBaoCaoHocKy);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoHocKy";
            this.Text = "BaoCaoHocKy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoHocKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBaoCaoHocKy;
        private System.Windows.Forms.Button btnXuatFileBaoCaoHocKy;
        private System.Windows.Forms.Button btnTaoBaoCaoHocKy;
        private System.Windows.Forms.ComboBox cbHocKyBaoCaoHocKy;
        private System.Windows.Forms.Label label1;
    }
}