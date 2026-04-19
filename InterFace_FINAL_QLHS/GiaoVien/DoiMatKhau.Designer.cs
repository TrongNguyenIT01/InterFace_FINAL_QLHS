namespace InterFace_FINAL_QLHS.GiaoVien
{
    partial class DoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMKcu;
        private System.Windows.Forms.Label lblMKmoi;
        private System.Windows.Forms.Label lblNhapMKmoi;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtNhapLaiMKmoi;
        private System.Windows.Forms.Button btnXacNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMKcu = new System.Windows.Forms.Label();
            this.lblMKmoi = new System.Windows.Forms.Label();
            this.lblNhapMKmoi = new System.Windows.Forms.Label();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMKmoi = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đổi mật khẩu:";
            // 
            // lblMKcu
            // 
            this.lblMKcu.AutoSize = true;
            this.lblMKcu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMKcu.Location = new System.Drawing.Point(30, 70);
            this.lblMKcu.Name = "lblMKcu";
            this.lblMKcu.Size = new System.Drawing.Size(114, 23);
            this.lblMKcu.TabIndex = 1;
            this.lblMKcu.Text = "Mật khẩu cũ:";
            // 
            // lblMKmoi
            // 
            this.lblMKmoi.AutoSize = true;
            this.lblMKmoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMKmoi.Location = new System.Drawing.Point(30, 120);
            this.lblMKmoi.Name = "lblMKmoi";
            this.lblMKmoi.Size = new System.Drawing.Size(128, 23);
            this.lblMKmoi.TabIndex = 2;
            this.lblMKmoi.Text = "Mật khẩu mới:";
            // 
            // lblNhapMKmoi
            // 
            this.lblNhapMKmoi.AutoSize = true;
            this.lblNhapMKmoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNhapMKmoi.Location = new System.Drawing.Point(30, 170);
            this.lblNhapMKmoi.Name = "lblNhapMKmoi";
            this.lblNhapMKmoi.Size = new System.Drawing.Size(200, 23);
            this.lblNhapMKmoi.TabIndex = 3;
            this.lblNhapMKmoi.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtMKcu
            // 
            this.txtMKcu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMKcu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMKcu.Location = new System.Drawing.Point(276, 67);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.PasswordChar = '*';
            this.txtMKcu.Size = new System.Drawing.Size(300, 30);
            this.txtMKcu.TabIndex = 4;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMKmoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMKmoi.Location = new System.Drawing.Point(276, 117);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.PasswordChar = '*';
            this.txtMKmoi.Size = new System.Drawing.Size(300, 30);
            this.txtMKmoi.TabIndex = 5;
            // 
            // txtNhapLaiMKmoi
            // 
            this.txtNhapLaiMKmoi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNhapLaiMKmoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhapLaiMKmoi.Location = new System.Drawing.Point(276, 167);
            this.txtNhapLaiMKmoi.Name = "txtNhapLaiMKmoi";
            this.txtNhapLaiMKmoi.PasswordChar = '*';
            this.txtNhapLaiMKmoi.Size = new System.Drawing.Size(300, 30);
            this.txtNhapLaiMKmoi.TabIndex = 6;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(346, 212);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 35);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtNhapLaiMKmoi);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.lblNhapMKmoi);
            this.Controls.Add(this.lblMKmoi);
            this.Controls.Add(this.lblMKcu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}