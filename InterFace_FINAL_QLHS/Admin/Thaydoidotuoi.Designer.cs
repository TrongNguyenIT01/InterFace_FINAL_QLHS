namespace InterFace_FINAL_QLHS.Admin
{
    partial class Thaydoidotuoi
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
            this.panelTuoi = new System.Windows.Forms.Panel();
            this.lblThayDoiTuoi = new System.Windows.Forms.Label();
            this.grboxThongtinhientai = new System.Windows.Forms.GroupBox();
            this.txtTuoiMax = new System.Windows.Forms.TextBox();
            this.txtTuoiMin = new System.Windows.Forms.TextBox();
            this.lblTuoitoithieuhientai = new System.Windows.Forms.Label();
            this.lblTuoitoidahientai = new System.Windows.Forms.Label();
            this.grboxThongtinmoi = new System.Windows.Forms.GroupBox();
            this.lblTuoitoithieumoi = new System.Windows.Forms.Label();
            this.nbTuoitoithieumoi = new System.Windows.Forms.NumericUpDown();
            this.lblTuoitoidamoi = new System.Windows.Forms.Label();
            this.nbTuoitoidamoi = new System.Windows.Forms.NumericUpDown();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panelTuoi.SuspendLayout();
            this.grboxThongtinhientai.SuspendLayout();
            this.grboxThongtinmoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTuoitoithieumoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTuoitoidamoi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTuoi
            // 
            this.panelTuoi.BackColor = System.Drawing.Color.White;
            this.panelTuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTuoi.Controls.Add(this.lblThayDoiTuoi);
            this.panelTuoi.Controls.Add(this.grboxThongtinhientai);
            this.panelTuoi.Controls.Add(this.grboxThongtinmoi);
            this.panelTuoi.Controls.Add(this.btnXacNhan);
            this.panelTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTuoi.Location = new System.Drawing.Point(0, 0);
            this.panelTuoi.Name = "panelTuoi";
            this.panelTuoi.Size = new System.Drawing.Size(800, 450);
            this.panelTuoi.TabIndex = 0;
            // 
            // lblThayDoiTuoi
            // 
            this.lblThayDoiTuoi.AutoSize = true;
            this.lblThayDoiTuoi.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblThayDoiTuoi.Location = new System.Drawing.Point(180, 10);
            this.lblThayDoiTuoi.Name = "lblThayDoiTuoi";
            this.lblThayDoiTuoi.Size = new System.Drawing.Size(329, 32);
            this.lblThayDoiTuoi.TabIndex = 0;
            this.lblThayDoiTuoi.Text = "Thay Đổi Tuổi Quy Định";
            // 
            // grboxThongtinhientai
            // 
            this.grboxThongtinhientai.Controls.Add(this.txtTuoiMax);
            this.grboxThongtinhientai.Controls.Add(this.txtTuoiMin);
            this.grboxThongtinhientai.Controls.Add(this.lblTuoitoithieuhientai);
            this.grboxThongtinhientai.Controls.Add(this.lblTuoitoidahientai);
            this.grboxThongtinhientai.Location = new System.Drawing.Point(20, 60);
            this.grboxThongtinhientai.Name = "grboxThongtinhientai";
            this.grboxThongtinhientai.Size = new System.Drawing.Size(715, 124);
            this.grboxThongtinhientai.TabIndex = 1;
            this.grboxThongtinhientai.TabStop = false;
            this.grboxThongtinhientai.Text = "Thông Tin Hiện Tại";
            this.grboxThongtinhientai.Enter += new System.EventHandler(this.grboxThongtinhientai_Enter);
            // 
            // txtTuoiMax
            // 
            this.txtTuoiMax.Location = new System.Drawing.Point(193, 70);
            this.txtTuoiMax.Name = "txtTuoiMax";
            this.txtTuoiMax.ReadOnly = true;
            this.txtTuoiMax.Size = new System.Drawing.Size(127, 22);
            this.txtTuoiMax.TabIndex = 4;
            // 
            // txtTuoiMin
            // 
            this.txtTuoiMin.Location = new System.Drawing.Point(193, 27);
            this.txtTuoiMin.Name = "txtTuoiMin";
            this.txtTuoiMin.ReadOnly = true;
            this.txtTuoiMin.Size = new System.Drawing.Size(127, 22);
            this.txtTuoiMin.TabIndex = 3;
            // 
            // lblTuoitoithieuhientai
            // 
            this.lblTuoitoithieuhientai.AutoSize = true;
            this.lblTuoitoithieuhientai.Location = new System.Drawing.Point(20, 30);
            this.lblTuoitoithieuhientai.Name = "lblTuoitoithieuhientai";
            this.lblTuoitoithieuhientai.Size = new System.Drawing.Size(130, 16);
            this.lblTuoitoithieuhientai.TabIndex = 0;
            this.lblTuoitoithieuhientai.Text = "Tuổi tối thiểu hiện tại:";
            // 
            // lblTuoitoidahientai
            // 
            this.lblTuoitoidahientai.AutoSize = true;
            this.lblTuoitoidahientai.Location = new System.Drawing.Point(20, 70);
            this.lblTuoitoidahientai.Name = "lblTuoitoidahientai";
            this.lblTuoitoidahientai.Size = new System.Drawing.Size(118, 16);
            this.lblTuoitoidahientai.TabIndex = 2;
            this.lblTuoitoidahientai.Text = "Tuổi tối đa hiện tại:";
            // 
            // grboxThongtinmoi
            // 
            this.grboxThongtinmoi.Controls.Add(this.lblTuoitoithieumoi);
            this.grboxThongtinmoi.Controls.Add(this.nbTuoitoithieumoi);
            this.grboxThongtinmoi.Controls.Add(this.lblTuoitoidamoi);
            this.grboxThongtinmoi.Controls.Add(this.nbTuoitoidamoi);
            this.grboxThongtinmoi.Location = new System.Drawing.Point(20, 190);
            this.grboxThongtinmoi.Name = "grboxThongtinmoi";
            this.grboxThongtinmoi.Size = new System.Drawing.Size(715, 122);
            this.grboxThongtinmoi.TabIndex = 2;
            this.grboxThongtinmoi.TabStop = false;
            this.grboxThongtinmoi.Text = "Thông Tin Mới";
            // 
            // lblTuoitoithieumoi
            // 
            this.lblTuoitoithieumoi.AutoSize = true;
            this.lblTuoitoithieumoi.Location = new System.Drawing.Point(20, 30);
            this.lblTuoitoithieumoi.Name = "lblTuoitoithieumoi";
            this.lblTuoitoithieumoi.Size = new System.Drawing.Size(125, 16);
            this.lblTuoitoithieumoi.TabIndex = 0;
            this.lblTuoitoithieumoi.Text = "Tuổi tối thiểu - [mới]:";
            // 
            // nbTuoitoithieumoi
            // 
            this.nbTuoitoithieumoi.Location = new System.Drawing.Point(200, 30);
            this.nbTuoitoithieumoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbTuoitoithieumoi.Name = "nbTuoitoithieumoi";
            this.nbTuoitoithieumoi.Size = new System.Drawing.Size(120, 22);
            this.nbTuoitoithieumoi.TabIndex = 1;
            this.nbTuoitoithieumoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTuoitoidamoi
            // 
            this.lblTuoitoidamoi.AutoSize = true;
            this.lblTuoitoidamoi.Location = new System.Drawing.Point(20, 70);
            this.lblTuoitoidamoi.Name = "lblTuoitoidamoi";
            this.lblTuoitoidamoi.Size = new System.Drawing.Size(113, 16);
            this.lblTuoitoidamoi.TabIndex = 2;
            this.lblTuoitoidamoi.Text = "Tuổi tối đa - [mới]:";
            // 
            // nbTuoitoidamoi
            // 
            this.nbTuoitoidamoi.Location = new System.Drawing.Point(200, 70);
            this.nbTuoitoidamoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbTuoitoidamoi.Name = "nbTuoitoidamoi";
            this.nbTuoitoidamoi.Size = new System.Drawing.Size(120, 22);
            this.nbTuoitoidamoi.TabIndex = 3;
            this.nbTuoitoidamoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXacNhan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(263, 318);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(227, 40);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "✔ Xác nhận thay đổi";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // Thaydoidotuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTuoi);
            this.Name = "Thaydoidotuoi";
            this.Text = "Thay đổi tuổi quy định";
            this.panelTuoi.ResumeLayout(false);
            this.panelTuoi.PerformLayout();
            this.grboxThongtinhientai.ResumeLayout(false);
            this.grboxThongtinhientai.PerformLayout();
            this.grboxThongtinmoi.ResumeLayout(false);
            this.grboxThongtinmoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTuoitoithieumoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTuoitoidamoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTuoi;
        private System.Windows.Forms.Label lblThayDoiTuoi;
        private System.Windows.Forms.GroupBox grboxThongtinhientai;
        private System.Windows.Forms.Label lblTuoitoithieuhientai;
        private System.Windows.Forms.Label lblTuoitoidahientai;
        private System.Windows.Forms.GroupBox grboxThongtinmoi;
        private System.Windows.Forms.Label lblTuoitoithieumoi;
        private System.Windows.Forms.NumericUpDown nbTuoitoithieumoi;
        private System.Windows.Forms.Label lblTuoitoidamoi;
        private System.Windows.Forms.NumericUpDown nbTuoitoidamoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtTuoiMax;
        private System.Windows.Forms.TextBox txtTuoiMin;
    }
}