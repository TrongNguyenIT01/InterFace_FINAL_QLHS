namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class TraCuuHocSinh
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
            this.cbKhoiLop = new System.Windows.Forms.ComboBox();
            this.btnTimHS = new System.Windows.Forms.Button();
            this.txtTimHS = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNamHoc);
            this.panel1.Controls.Add(this.cbKhoiLop);
            this.panel1.Controls.Add(this.btnTimHS);
            this.panel1.Controls.Add(this.txtTimHS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 68);
            this.panel1.TabIndex = 0;
            // 
            // cbKhoiLop
            // 
            this.cbKhoiLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKhoiLop.FormattingEnabled = true;
            this.cbKhoiLop.Location = new System.Drawing.Point(175, 27);
            this.cbKhoiLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoiLop.Name = "cbKhoiLop";
            this.cbKhoiLop.Size = new System.Drawing.Size(170, 27);
            this.cbKhoiLop.TabIndex = 3;
            // 
            // btnTimHS
            // 
            this.btnTimHS.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimHS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimHS.Location = new System.Drawing.Point(934, 20);
            this.btnTimHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimHS.Name = "btnTimHS";
            this.btnTimHS.Size = new System.Drawing.Size(75, 34);
            this.btnTimHS.TabIndex = 2;
            this.btnTimHS.Text = "Tìm";
            this.btnTimHS.UseVisualStyleBackColor = false;
            this.btnTimHS.Click += new System.EventHandler(this.btnTimHS_Click);
            // 
            // txtTimHS
            // 
            this.txtTimHS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimHS.Location = new System.Drawing.Point(24, 27);
            this.txtTimHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimHS.Name = "txtTimHS";
            this.txtTimHS.Size = new System.Drawing.Size(145, 27);
            this.txtTimHS.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 49);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(310, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỌC SINH";
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(0, 117);
            this.dgvDanhSachHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 24;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(1021, 460);
            this.dgvDanhSachHocSinh.TabIndex = 3;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(351, 25);
            this.cbNamHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(170, 27);
            this.cbNamHoc.TabIndex = 4;
            // 
            // TraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 577);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraCuuHocSinh";
            this.Text = "TraCuuHocSinh";
            this.Load += new System.EventHandler(this.TraCuuHocSinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimHS;
        private System.Windows.Forms.Button btnTimHS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoiLop;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.ComboBox cbNamHoc;
    }
}