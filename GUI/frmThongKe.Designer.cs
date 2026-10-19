namespace BTL_QLSV_WINFORM.GUI
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKhoaLop;
        private System.Windows.Forms.TabPage tabHocTap;
        private System.Windows.Forms.DataGridView dgvThongKeKhoa;
        private System.Windows.Forms.DataGridView dgvThongKeLop;
        private System.Windows.Forms.Splitter splitKhoaLop;
        private System.Windows.Forms.DataGridView dgvXepLoai;
        private System.Windows.Forms.Panel pnlTongQuanHocTap;
        private System.Windows.Forms.Label lblTongSinhVien;
        private System.Windows.Forms.Label lblXuatSac;
        private System.Windows.Forms.Label lblGioi;
        private System.Windows.Forms.Label lblKha;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblYeu;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnXuatExcel;
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
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKhoaLop = new System.Windows.Forms.TabPage();
            this.dgvThongKeLop = new System.Windows.Forms.DataGridView();
            this.splitKhoaLop = new System.Windows.Forms.Splitter();
            this.dgvThongKeKhoa = new System.Windows.Forms.DataGridView();
            this.tabHocTap = new System.Windows.Forms.TabPage();
            this.dgvXepLoai = new System.Windows.Forms.DataGridView();
            this.pnlTongQuanHocTap = new System.Windows.Forms.Panel();
            this.lblYeu = new System.Windows.Forms.Label();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.lblKha = new System.Windows.Forms.Label();
            this.lblGioi = new System.Windows.Forms.Label();
            this.lblXuatSac = new System.Windows.Forms.Label();
            this.lblTongSinhVien = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.pnlTieuDe.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabKhoaLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeKhoa)).BeginInit();
            this.tabHocTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepLoai)).BeginInit();
            this.pnlTongQuanHocTap.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(984, 50);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(984, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÁO CÁO VÀ THỐNG KÊ SINH VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKhoaLop);
            this.tabControl.Controls.Add(this.tabHocTap);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(0, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 511);
            this.tabControl.TabIndex = 1;
            // 
            // tabKhoaLop
            // 
            this.tabKhoaLop.Controls.Add(this.dgvThongKeLop);
            this.tabKhoaLop.Controls.Add(this.splitKhoaLop);
            this.tabKhoaLop.Controls.Add(this.dgvThongKeKhoa);
            this.tabKhoaLop.Location = new System.Drawing.Point(4, 26);
            this.tabKhoaLop.Name = "tabKhoaLop";
            this.tabKhoaLop.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoaLop.Size = new System.Drawing.Size(976, 481);
            this.tabKhoaLop.TabIndex = 0;
            this.tabKhoaLop.Text = "Thống kê theo Khoa & Lớp";
            this.tabKhoaLop.UseVisualStyleBackColor = true;
            // 
            // dgvThongKeLop
            // 
            this.dgvThongKeLop.AllowUserToAddRows = false;
            this.dgvThongKeLop.AllowUserToDeleteRows = false;
            this.dgvThongKeLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeLop.Location = new System.Drawing.Point(3, 238);
            this.dgvThongKeLop.MultiSelect = false;
            this.dgvThongKeLop.Name = "dgvThongKeLop";
            this.dgvThongKeLop.ReadOnly = true;
            this.dgvThongKeLop.RowHeadersVisible = false;
            this.dgvThongKeLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeLop.Size = new System.Drawing.Size(970, 240);
            this.dgvThongKeLop.TabIndex = 2;
            // 
            // splitKhoaLop
            // 
            this.splitKhoaLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitKhoaLop.Location = new System.Drawing.Point(3, 233);
            this.splitKhoaLop.Name = "splitKhoaLop";
            this.splitKhoaLop.Size = new System.Drawing.Size(970, 5);
            this.splitKhoaLop.TabIndex = 1;
            this.splitKhoaLop.TabStop = false;
            // 
            // dgvThongKeKhoa
            // 
            this.dgvThongKeKhoa.AllowUserToAddRows = false;
            this.dgvThongKeKhoa.AllowUserToDeleteRows = false;
            this.dgvThongKeKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeKhoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThongKeKhoa.Location = new System.Drawing.Point(3, 3);
            this.dgvThongKeKhoa.MultiSelect = false;
            this.dgvThongKeKhoa.Name = "dgvThongKeKhoa";
            this.dgvThongKeKhoa.ReadOnly = true;
            this.dgvThongKeKhoa.RowHeadersVisible = false;
            this.dgvThongKeKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeKhoa.Size = new System.Drawing.Size(970, 230);
            this.dgvThongKeKhoa.TabIndex = 0;
            // 
            // tabHocTap
            // 
            this.tabHocTap.Controls.Add(this.dgvXepLoai);
            this.tabHocTap.Controls.Add(this.pnlTongQuanHocTap);
            this.tabHocTap.Location = new System.Drawing.Point(4, 26);
            this.tabHocTap.Name = "tabHocTap";
            this.tabHocTap.Padding = new System.Windows.Forms.Padding(3);
            this.tabHocTap.Size = new System.Drawing.Size(976, 481);
            this.tabHocTap.TabIndex = 1;
            this.tabHocTap.Text = "Thống kê Xếp loại Học tập";
            this.tabHocTap.UseVisualStyleBackColor = true;
            // 
            // dgvXepLoai
            // 
            this.dgvXepLoai.AllowUserToAddRows = false;
            this.dgvXepLoai.AllowUserToDeleteRows = false;
            this.dgvXepLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXepLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvXepLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXepLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXepLoai.Location = new System.Drawing.Point(3, 83);
            this.dgvXepLoai.MultiSelect = false;
            this.dgvXepLoai.Name = "dgvXepLoai";
            this.dgvXepLoai.ReadOnly = true;
            this.dgvXepLoai.RowHeadersVisible = false;
            this.dgvXepLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXepLoai.Size = new System.Drawing.Size(970, 395);
            this.dgvXepLoai.TabIndex = 1;
            // 
            // pnlTongQuanHocTap
            // 
            this.pnlTongQuanHocTap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlTongQuanHocTap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTongQuanHocTap.Controls.Add(this.lblYeu);
            this.pnlTongQuanHocTap.Controls.Add(this.lblTrungBinh);
            this.pnlTongQuanHocTap.Controls.Add(this.lblKha);
            this.pnlTongQuanHocTap.Controls.Add(this.lblGioi);
            this.pnlTongQuanHocTap.Controls.Add(this.lblXuatSac);
            this.pnlTongQuanHocTap.Controls.Add(this.lblTongSinhVien);
            this.pnlTongQuanHocTap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTongQuanHocTap.Location = new System.Drawing.Point(3, 3);
            this.pnlTongQuanHocTap.Name = "pnlTongQuanHocTap";
            this.pnlTongQuanHocTap.Size = new System.Drawing.Size(970, 80);
            this.pnlTongQuanHocTap.TabIndex = 0;
            // 
            // lblYeu
            // 
            this.lblYeu.BackColor = System.Drawing.Color.LightCoral;
            this.lblYeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYeu.ForeColor = System.Drawing.Color.White;
            this.lblYeu.Location = new System.Drawing.Point(800, 15);
            this.lblYeu.Name = "lblYeu";
            this.lblYeu.Size = new System.Drawing.Size(140, 50);
            this.lblYeu.TabIndex = 5;
            this.lblYeu.Text = "Yếu (<5.0):\r\n0 SV";
            this.lblYeu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.BackColor = System.Drawing.Color.SandyBrown;
            this.lblTrungBinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrungBinh.ForeColor = System.Drawing.Color.White;
            this.lblTrungBinh.Location = new System.Drawing.Point(645, 15);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(140, 50);
            this.lblTrungBinh.TabIndex = 4;
            this.lblTrungBinh.Text = "Trung bình:\r\n0 SV";
            this.lblTrungBinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKha
            // 
            this.lblKha.BackColor = System.Drawing.Color.SteelBlue;
            this.lblKha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKha.ForeColor = System.Drawing.Color.White;
            this.lblKha.Location = new System.Drawing.Point(490, 15);
            this.lblKha.Name = "lblKha";
            this.lblKha.Size = new System.Drawing.Size(140, 50);
            this.lblKha.TabIndex = 3;
            this.lblKha.Text = "Khá (6.5 - 7.9):\r\n0 SV";
            this.lblKha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGioi
            // 
            this.lblGioi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblGioi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGioi.ForeColor = System.Drawing.Color.White;
            this.lblGioi.Location = new System.Drawing.Point(335, 15);
            this.lblGioi.Name = "lblGioi";
            this.lblGioi.Size = new System.Drawing.Size(140, 50);
            this.lblGioi.TabIndex = 2;
            this.lblGioi.Text = "Giỏi (8.0 - 8.9):\r\n0 SV";
            this.lblGioi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXuatSac
            // 
            this.lblXuatSac.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblXuatSac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXuatSac.ForeColor = System.Drawing.Color.White;
            this.lblXuatSac.Location = new System.Drawing.Point(180, 15);
            this.lblXuatSac.Name = "lblXuatSac";
            this.lblXuatSac.Size = new System.Drawing.Size(140, 50);
            this.lblXuatSac.TabIndex = 1;
            this.lblXuatSac.Text = "Xuất sắc (>=9.0):\r\n0 SV";
            this.lblXuatSac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongSinhVien
            // 
            this.lblTongSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblTongSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongSinhVien.ForeColor = System.Drawing.Color.White;
            this.lblTongSinhVien.Location = new System.Drawing.Point(20, 15);
            this.lblTongSinhVien.Name = "lblTongSinhVien";
            this.lblTongSinhVien.Size = new System.Drawing.Size(145, 50);
            this.lblTongSinhVien.TabIndex = 0;
            this.lblTongSinhVien.Text = "Tổng sinh viên:\r\n0 SV";
            this.lblTongSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlChucNang.Controls.Add(this.btnDong);
            this.pnlChucNang.Controls.Add(this.btnXuatExcel);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 561);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(984, 50);
            this.pnlChucNang.TabIndex = 2;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(860, 8);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 34);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(20, 8);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(150, 34);
            this.btnXuatExcel.TabIndex = 0;
            this.btnXuatExcel.Text = "Xuất file Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.pnlTieuDe.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabKhoaLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeKhoa)).EndInit();
            this.tabHocTap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepLoai)).EndInit();
            this.pnlTongQuanHocTap.ResumeLayout(false);
            this.pnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
