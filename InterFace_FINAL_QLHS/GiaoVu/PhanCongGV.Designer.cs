namespace InterFace_FINAL_QLHS.GiaoVu
{
    partial class PhanCongGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCongGV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnHuyLop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.btnChuyenMon = new System.Windows.Forms.Button();
            this.btnChonLopChuNhiem = new System.Windows.Forms.Button();
            this.btnChonLopGV = new System.Windows.Forms.Button();
            this.dgvChonGV = new System.Windows.Forms.DataGridView();
            this.dgvChonLopGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonLopGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyLop);
            this.panel1.Controls.Add(this.btnPhanCong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.dgvChonGV);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.dgvChonLopGV);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 350);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.BackColor = System.Drawing.Color.LightGreen;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhanCong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanCong.Image")));
            this.btnPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhanCong.Location = new System.Drawing.Point(12, 25);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(156, 36);
            this.btnPhanCong.TabIndex = 0;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.UseVisualStyleBackColor = false;
            // 
            // btnHuyLop
            // 
            this.btnHuyLop.BackColor = System.Drawing.Color.Orange;
            this.btnHuyLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyLop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyLop.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyLop.Image")));
            this.btnHuyLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyLop.Location = new System.Drawing.Point(632, 25);
            this.btnHuyLop.Name = "btnHuyLop";
            this.btnHuyLop.Size = new System.Drawing.Size(156, 36);
            this.btnHuyLop.TabIndex = 1;
            this.btnHuyLop.Text = "Hủy lớp";
            this.btnHuyLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyLop.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnChuyenMon);
            this.panel2.Controls.Add(this.txtChuyenMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 63);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.btnChonLopGV);
            this.panel3.Controls.Add(this.btnChonLopChuNhiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 63);
            this.panel3.TabIndex = 0;
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChuyenMon.Location = new System.Drawing.Point(12, 20);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(197, 27);
            this.txtChuyenMon.TabIndex = 0;
            // 
            // btnChuyenMon
            // 
            this.btnChuyenMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChuyenMon.Location = new System.Drawing.Point(215, 16);
            this.btnChuyenMon.Name = "btnChuyenMon";
            this.btnChuyenMon.Size = new System.Drawing.Size(182, 32);
            this.btnChuyenMon.TabIndex = 1;
            this.btnChuyenMon.Text = "Chọn chuyên môn";
            this.btnChuyenMon.UseVisualStyleBackColor = true;
            // 
            // btnChonLopChuNhiem
            // 
            this.btnChonLopChuNhiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonLopChuNhiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonLopChuNhiem.Location = new System.Drawing.Point(240, 15);
            this.btnChonLopChuNhiem.Name = "btnChonLopChuNhiem";
            this.btnChonLopChuNhiem.Size = new System.Drawing.Size(144, 32);
            this.btnChonLopChuNhiem.TabIndex = 0;
            this.btnChonLopChuNhiem.Text = "Lớp chủ nhiệm";
            this.btnChonLopChuNhiem.UseVisualStyleBackColor = true;
            // 
            // btnChonLopGV
            // 
            this.btnChonLopGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonLopGV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonLopGV.Location = new System.Drawing.Point(13, 15);
            this.btnChonLopGV.Name = "btnChonLopGV";
            this.btnChonLopGV.Size = new System.Drawing.Size(144, 32);
            this.btnChonLopGV.TabIndex = 1;
            this.btnChonLopGV.Text = "Chọn lớp";
            this.btnChonLopGV.UseVisualStyleBackColor = true;
            // 
            // dgvChonGV
            // 
            this.dgvChonGV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvChonGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChonGV.Location = new System.Drawing.Point(0, 63);
            this.dgvChonGV.Name = "dgvChonGV";
            this.dgvChonGV.RowHeadersWidth = 51;
            this.dgvChonGV.RowTemplate.Height = 24;
            this.dgvChonGV.Size = new System.Drawing.Size(400, 287);
            this.dgvChonGV.TabIndex = 1;
            // 
            // dgvChonLopGV
            // 
            this.dgvChonLopGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvChonLopGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonLopGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChonLopGV.Location = new System.Drawing.Point(0, 63);
            this.dgvChonLopGV.Name = "dgvChonLopGV";
            this.dgvChonLopGV.RowHeadersWidth = 51;
            this.dgvChonLopGV.RowTemplate.Height = 24;
            this.dgvChonLopGV.Size = new System.Drawing.Size(396, 287);
            this.dgvChonLopGV.TabIndex = 1;
            // 
            // PhanCongGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "PhanCongGV";
            this.Text = "PhanCongGV";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonLopGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnHuyLop;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChuyenMon;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.Button btnChonLopGV;
        private System.Windows.Forms.Button btnChonLopChuNhiem;
        private System.Windows.Forms.DataGridView dgvChonGV;
        private System.Windows.Forms.DataGridView dgvChonLopGV;
    }
}