namespace InterFace_FINAL_QLHS.GiaoVien
{
    partial class ThongTinGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblThongTinGV = new System.Windows.Forms.Label();
            this.dgvLopDangDay = new System.Windows.Forms.DataGridView();
            this.lblLopDangDay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvThongTinGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopDangDay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTinGV
            // 
            this.lblThongTinGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThongTinGV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinGV.Location = new System.Drawing.Point(224, 13);
            this.lblThongTinGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinGV.Name = "lblThongTinGV";
            this.lblThongTinGV.Size = new System.Drawing.Size(151, 28);
            this.lblThongTinGV.TabIndex = 0;
            this.lblThongTinGV.Text = "Thông Tin Giáo Viên";
            // 
            // dgvLopDangDay
            // 
            this.dgvLopDangDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopDangDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLopDangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopDangDay.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLopDangDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopDangDay.Location = new System.Drawing.Point(2, 239);
            this.dgvLopDangDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLopDangDay.Name = "dgvLopDangDay";
            this.dgvLopDangDay.RowHeadersWidth = 51;
            this.dgvLopDangDay.RowTemplate.Height = 24;
            this.dgvLopDangDay.Size = new System.Drawing.Size(596, 125);
            this.dgvLopDangDay.TabIndex = 3;
            // 
            // lblLopDangDay
            // 
            this.lblLopDangDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLopDangDay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopDangDay.Location = new System.Drawing.Point(246, 195);
            this.lblLopDangDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLopDangDay.Name = "lblLopDangDay";
            this.lblLopDangDay.Size = new System.Drawing.Size(108, 28);
            this.lblLopDangDay.TabIndex = 2;
            this.lblLopDangDay.Text = "Lớp Đang Dạy";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvLopDangDay, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblThongTinGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLopDangDay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvThongTinGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.72222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.72222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 366);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dgvThongTinGV
            // 
            this.dgvThongTinGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinGV.Location = new System.Drawing.Point(3, 58);
            this.dgvThongTinGV.Name = "dgvThongTinGV";
            this.dgvThongTinGV.Size = new System.Drawing.Size(594, 121);
            this.dgvThongTinGV.TabIndex = 4;
            // 
            // ThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThongTinGiaoVien";
            this.Text = "Thông Tin Giáo Viên";
            this.Load += new System.EventHandler(this.ThongTinGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopDangDay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinGV;
        private System.Windows.Forms.DataGridView dgvLopDangDay;
        private System.Windows.Forms.Label lblLopDangDay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvThongTinGV;
    }
}