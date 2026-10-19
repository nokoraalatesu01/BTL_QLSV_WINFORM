namespace BTL_QLSV_WINFORM.GUI
{
    partial class frmThongTinNhom
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblDeTai;
        private System.Windows.Forms.GroupBox grbThanhVien;
        private System.Windows.Forms.Label lblTV;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblDeTai = new System.Windows.Forms.Label();
            this.grbThanhVien = new System.Windows.Forms.GroupBox();
            this.lblTV = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.grbThanhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblTieuDe.Location = new System.Drawing.Point(12, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(460, 35);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÀI TẬP LỚN MÔN HỌC";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenMon
            // 
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTenMon.Location = new System.Drawing.Point(12, 55);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(460, 25);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "HỌC PHẦN: LẬP TRÌNH TRỰC QUAN (LTTQ)";
            this.lblTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeTai
            // 
            this.lblDeTai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblDeTai.Location = new System.Drawing.Point(12, 85);
            this.lblDeTai.Name = "lblDeTai";
            this.lblDeTai.Size = new System.Drawing.Size(460, 45);
            this.lblDeTai.TabIndex = 2;
            this.lblDeTai.Text = "Đề tài: XÂY DỰNG ỨNG DỤNG QUẢN LÝ SINH VIÊN\r\nKiến trúc 3 lớp (3-Tier) & Kết nối CSDL SQL Server";
            this.lblDeTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbThanhVien
            // 
            this.grbThanhVien.Controls.Add(this.lblTV);
            this.grbThanhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grbThanhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbThanhVien.Location = new System.Drawing.Point(30, 140);
            this.grbThanhVien.Name = "grbThanhVien";
            this.grbThanhVien.Size = new System.Drawing.Size(425, 170);
            this.grbThanhVien.TabIndex = 3;
            this.grbThanhVien.TabStop = false;
            this.grbThanhVien.Text = "Thông tin Đồ án & Nhóm phát triển";
            // 
            // lblTV
            // 
            this.lblTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTV.ForeColor = System.Drawing.Color.Black;
            this.lblTV.Location = new System.Drawing.Point(3, 21);
            this.lblTV.Name = "lblTV";
            this.lblTV.Padding = new System.Windows.Forms.Padding(10);
            this.lblTV.Size = new System.Drawing.Size(419, 146);
            this.lblTV.TabIndex = 0;
            this.lblTV.Text = "• Nhánh phát triển: DaiKaThaiBinh\r\n• Ngôn ngữ: C# .NET Windows Forms\r\n• Cơ sở dữ liệu: SQL Server Local / In-Memory Seed Data\r\n• Chức năng chính: Quản lý Sinh viên, Lớp học, Khoa viện, Môn học, Bảng điểm, Thống kê, Báo cáo & Xuất Excel.";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(180, 325);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 36);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThongTinNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grbThanhVien);
            this.Controls.Add(this.lblDeTai);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmThongTinNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới thiệu Bài tập lớn";
            this.grbThanhVien.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
