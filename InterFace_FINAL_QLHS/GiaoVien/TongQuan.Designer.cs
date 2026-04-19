namespace InterFace_FINAL_QLHS.GiaoVien
{
    partial class TongQuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Add controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTimKiem;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDSLopDangDay = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTimLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopDangDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh Sách Lớp Đang Dạy";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(30, 63);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(180, 30);
            this.txtTimKiem.TabIndex = 1;
            // 
            // dgvDSLopDangDay
            // 
            this.dgvDSLopDangDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLopDangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLopDangDay.Location = new System.Drawing.Point(30, 111);
            this.dgvDSLopDangDay.Name = "dgvDSLopDangDay";
            this.dgvDSLopDangDay.RowHeadersWidth = 51;
            this.dgvDSLopDangDay.RowTemplate.Height = 24;
            this.dgvDSLopDangDay.Size = new System.Drawing.Size(750, 327);
            this.dgvDSLopDangDay.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(595, 43);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(185, 50);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // lblTimLop
            // 
            this.lblTimLop.AutoSize = true;
            this.lblTimLop.Location = new System.Drawing.Point(26, 37);
            this.lblTimLop.Name = "lblTimLop";
            this.lblTimLop.Size = new System.Drawing.Size(71, 23);
            this.lblTimLop.TabIndex = 4;
            this.lblTimLop.Text = "Tìm Lớp";
            // 
            // TongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimLop);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvDSLopDangDay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "TongQuan";
            this.Text = "Tổng Quan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopDangDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSLopDangDay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTimLop;
    }
}