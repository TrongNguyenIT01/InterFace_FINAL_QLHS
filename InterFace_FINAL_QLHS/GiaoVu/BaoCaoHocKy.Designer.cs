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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatFileBaoCaoHocKy = new System.Windows.Forms.Button();
            this.btnTaoBaoCaoHocKy = new System.Windows.Forms.Button();
            this.cbHocKyBaoCaoHocKy = new System.Windows.Forms.ComboBox();
            this.dgvBaoCaoHocKy = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNamHoc);
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
            // cbNamHoc
            // 
            this.cbNamHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNamHoc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(23, 25);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(213, 27);
            this.cbNamHoc.TabIndex = 4;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(274, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Báo Cáo Học Kỳ";
            // 
            // btnXuatFileBaoCaoHocKy
            // 
            this.btnXuatFileBaoCaoHocKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXuatFileBaoCaoHocKy.BackColor = System.Drawing.Color.LightGreen;
            this.btnXuatFileBaoCaoHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileBaoCaoHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatFileBaoCaoHocKy.Location = new System.Drawing.Point(626, 25);
            this.btnXuatFileBaoCaoHocKy.Name = "btnXuatFileBaoCaoHocKy";
            this.btnXuatFileBaoCaoHocKy.Size = new System.Drawing.Size(143, 30);
            this.btnXuatFileBaoCaoHocKy.TabIndex = 2;
            this.btnXuatFileBaoCaoHocKy.Text = "Xuất File";
            this.btnXuatFileBaoCaoHocKy.UseVisualStyleBackColor = false;
            this.btnXuatFileBaoCaoHocKy.Click += new System.EventHandler(this.btnXuatFileBaoCaoHocKy_Click);
            // 
            // btnTaoBaoCaoHocKy
            // 
            this.btnTaoBaoCaoHocKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTaoBaoCaoHocKy.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaoBaoCaoHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCaoHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoBaoCaoHocKy.Location = new System.Drawing.Point(466, 25);
            this.btnTaoBaoCaoHocKy.Name = "btnTaoBaoCaoHocKy";
            this.btnTaoBaoCaoHocKy.Size = new System.Drawing.Size(143, 30);
            this.btnTaoBaoCaoHocKy.TabIndex = 1;
            this.btnTaoBaoCaoHocKy.Text = "Tạo Báo Cáo";
            this.btnTaoBaoCaoHocKy.UseVisualStyleBackColor = false;
            this.btnTaoBaoCaoHocKy.Click += new System.EventHandler(this.btnTaoBaoCaoHocKy_Click);
            // 
            // cbHocKyBaoCaoHocKy
            // 
            this.cbHocKyBaoCaoHocKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHocKyBaoCaoHocKy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKyBaoCaoHocKy.FormattingEnabled = true;
            this.cbHocKyBaoCaoHocKy.Location = new System.Drawing.Point(242, 25);
            this.cbHocKyBaoCaoHocKy.Name = "cbHocKyBaoCaoHocKy";
            this.cbHocKyBaoCaoHocKy.Size = new System.Drawing.Size(145, 27);
            this.cbHocKyBaoCaoHocKy.TabIndex = 0;
            // 
            // dgvBaoCaoHocKy
            // 
            this.dgvBaoCaoHocKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCaoHocKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCaoHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCaoHocKy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCaoHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoHocKy.Location = new System.Drawing.Point(0, 126);
            this.dgvBaoCaoHocKy.Name = "dgvBaoCaoHocKy";
            this.dgvBaoCaoHocKy.RowHeadersWidth = 51;
            this.dgvBaoCaoHocKy.RowTemplate.Height = 24;
            this.dgvBaoCaoHocKy.Size = new System.Drawing.Size(800, 324);
            this.dgvBaoCaoHocKy.TabIndex = 1;
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
            this.Load += new System.EventHandler(this.BaoCaoHocKy_Load);
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
        private System.Windows.Forms.ComboBox cbNamHoc;
    }
}