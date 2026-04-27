namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class LenLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNamHocHienTai = new System.Windows.Forms.ComboBox();
            this.cbNamHocMoi = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm Học Hiện Tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm Học Mới: ";
            // 
            // cbNamHocHienTai
            // 
            this.cbNamHocHienTai.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHocHienTai.FormattingEnabled = true;
            this.cbNamHocHienTai.Location = new System.Drawing.Point(217, 59);
            this.cbNamHocHienTai.Name = "cbNamHocHienTai";
            this.cbNamHocHienTai.Size = new System.Drawing.Size(307, 34);
            this.cbNamHocHienTai.TabIndex = 2;
            // 
            // cbNamHocMoi
            // 
            this.cbNamHocMoi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHocMoi.FormattingEnabled = true;
            this.cbNamHocMoi.Location = new System.Drawing.Point(217, 148);
            this.cbNamHocMoi.Name = "cbNamHocMoi";
            this.cbNamHocMoi.Size = new System.Drawing.Size(307, 34);
            this.cbNamHocMoi.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(205, 233);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(123, 48);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(401, 232);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(123, 49);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // LenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 397);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cbNamHocMoi);
            this.Controls.Add(this.cbNamHocHienTai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LenLop";
            this.Text = "LenLop";
            this.Load += new System.EventHandler(this.LenLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNamHocHienTai;
        private System.Windows.Forms.ComboBox cbNamHocMoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}