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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbKhoiLop);
            this.panel1.Controls.Add(this.btnTimHS);
            this.panel1.Controls.Add(this.txtTimHS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 55);
            this.panel1.TabIndex = 0;
            // 
            // cbKhoiLop
            // 
            this.cbKhoiLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKhoiLop.FormattingEnabled = true;
            this.cbKhoiLop.Location = new System.Drawing.Point(131, 22);
            this.cbKhoiLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKhoiLop.Name = "cbKhoiLop";
            this.cbKhoiLop.Size = new System.Drawing.Size(104, 24);
            this.cbKhoiLop.TabIndex = 3;
            // 
            // btnTimHS
            // 
            this.btnTimHS.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimHS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimHS.Location = new System.Drawing.Point(535, 18);
            this.btnTimHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimHS.Name = "btnTimHS";
            this.btnTimHS.Size = new System.Drawing.Size(56, 28);
            this.btnTimHS.TabIndex = 2;
            this.btnTimHS.Text = "Tìm";
            this.btnTimHS.UseVisualStyleBackColor = false;
            // 
            // txtTimHS
            // 
            this.txtTimHS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimHS.Location = new System.Drawing.Point(18, 22);
            this.txtTimHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimHS.Name = "txtTimHS";
            this.txtTimHS.Size = new System.Drawing.Size(110, 23);
            this.txtTimHS.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 40);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(145, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỌC SINH";
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(0, 95);
            this.dgvDanhSachHocSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 24;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(766, 374);
            this.dgvDanhSachHocSinh.TabIndex = 3;
            // 
            // TraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 469);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TraCuuHocSinh";
            this.Text = "TraCuuHocSinh";
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
    }
}