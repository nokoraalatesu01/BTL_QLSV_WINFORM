namespace BTL_QLSV_WINFORM.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLLopKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuQLMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeTongHop;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinNhom;

        private System.Windows.Forms.ToolStrip toolStripNhanh;
        private System.Windows.Forms.ToolStripButton tsbtnSinhVien;
        private System.Windows.Forms.ToolStripButton tsbtnLopKhoa;
        private System.Windows.Forms.ToolStripButton tsbtnMonHoc;
        private System.Windows.Forms.ToolStripButton tsbtnDiem;
        private System.Windows.Forms.ToolStripButton tsbtnThongKe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDangXuat;

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslblNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel tslblCSDL;
        private System.Windows.Forms.ToolStripStatusLabel tslblThoiGian;
        private System.Windows.Forms.Timer timerThoiGian;

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCardSV;
        private System.Windows.Forms.Label lblCountSV;
        private System.Windows.Forms.Label lblTitleSV;
        private System.Windows.Forms.Panel pnlCardLop;
        private System.Windows.Forms.Label lblCountLop;
        private System.Windows.Forms.Label lblTitleLop;
        private System.Windows.Forms.Panel pnlCardKhoa;
        private System.Windows.Forms.Label lblCountKhoa;
        private System.Windows.Forms.Label lblTitleKhoa;
        private System.Windows.Forms.Panel pnlCardMon;
        private System.Windows.Forms.Label lblCountMon;
        private System.Windows.Forms.Label lblTitleMon;
        private System.Windows.Forms.GroupBox grbThaoTacNhanh;
        private System.Windows.Forms.Button btnMoSV;
        private System.Windows.Forms.Button btnMoLop;
        private System.Windows.Forms.Button btnMoDiem;
        private System.Windows.Forms.Button btnMoThongKe;

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
            this.components = new System.ComponentModel.Container();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLLopKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeTongHop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinNhom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNhanh = new System.Windows.Forms.ToolStrip();
            this.tsbtnSinhVien = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLopKhoa = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMonHoc = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDiem = new System.Windows.Forms.ToolStripButton();
            this.tsbtnThongKe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslblNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblCSDL = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerThoiGian = new System.Windows.Forms.Timer(this.components);
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.grbThaoTacNhanh = new System.Windows.Forms.GroupBox();
            this.btnMoThongKe = new System.Windows.Forms.Button();
            this.btnMoDiem = new System.Windows.Forms.Button();
            this.btnMoLop = new System.Windows.Forms.Button();
            this.btnMoSV = new System.Windows.Forms.Button();
            this.pnlCardMon = new System.Windows.Forms.Panel();
            this.lblCountMon = new System.Windows.Forms.Label();
            this.lblTitleMon = new System.Windows.Forms.Label();
            this.pnlCardKhoa = new System.Windows.Forms.Panel();
            this.lblCountKhoa = new System.Windows.Forms.Label();
            this.lblTitleKhoa = new System.Windows.Forms.Label();
            this.pnlCardLop = new System.Windows.Forms.Panel();
            this.lblCountLop = new System.Windows.Forms.Label();
            this.lblTitleLop = new System.Windows.Forms.Label();
            this.pnlCardSV = new System.Windows.Forms.Panel();
            this.lblCountSV = new System.Windows.Forms.Label();
            this.lblTitleSV = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mnMain.SuspendLayout();
            this.toolStripNhanh.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.grbThaoTacNhanh.SuspendLayout();
            this.pnlCardMon.SuspendLayout();
            this.pnlCardKhoa.SuspendLayout();
            this.pnlCardLop.SuspendLayout();
            this.pnlCardSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain (Theo tuần 3)
            // 
            this.mnMain.BackColor = System.Drawing.Color.White;
            this.mnMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuQuanLyDiem,
            this.mnuBaoCao,
            this.mnuTroGiup});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(1184, 27);
            this.mnMain.TabIndex = 0;
            this.mnMain.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiMatKhau,
            this.mnuDangXuat,
            this.toolStripSeparator1,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(79, 23);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(161, 24);
            this.mnuDoiMatKhau.Text = "&Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(161, 24);
            this.mnuDangXuat.Text = "Đăng &xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(161, 24);
            this.mnuThoat.Text = "Th&oát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLSinhVien,
            this.mnuQLLopKhoa,
            this.mnuQLMonHoc});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(84, 23);
            this.mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuQLSinhVien
            // 
            this.mnuQLSinhVien.Name = "mnuQLSinhVien";
            this.mnuQLSinhVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuQLSinhVien.Size = new System.Drawing.Size(242, 24);
            this.mnuQLSinhVien.Text = "Quản lý &Sinh viên";
            this.mnuQLSinhVien.Click += new System.EventHandler(this.mnuQLSinhVien_Click);
            // 
            // mnuQLLopKhoa
            // 
            this.mnuQLLopKhoa.Name = "mnuQLLopKhoa";
            this.mnuQLLopKhoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuQLLopKhoa.Size = new System.Drawing.Size(242, 24);
            this.mnuQLLopKhoa.Text = "Quản lý &Lớp - Khoa";
            this.mnuQLLopKhoa.Click += new System.EventHandler(this.mnuQLLopKhoa_Click);
            // 
            // mnuQLMonHoc
            // 
            this.mnuQLMonHoc.Name = "mnuQLMonHoc";
            this.mnuQLMonHoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuQLMonHoc.Size = new System.Drawing.Size(242, 24);
            this.mnuQLMonHoc.Text = "Quản lý &Môn học";
            this.mnuQLMonHoc.Click += new System.EventHandler(this.mnuQLMonHoc_Click);
            // 
            // mnuQuanLyDiem
            // 
            this.mnuQuanLyDiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapDiem});
            this.mnuQuanLyDiem.Name = "mnuQuanLyDiem";
            this.mnuQuanLyDiem.Size = new System.Drawing.Size(70, 23);
            this.mnuQuanLyDiem.Text = "Học &tập";
            // 
            // mnuNhapDiem
            // 
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuNhapDiem.Size = new System.Drawing.Size(268, 24);
            this.mnuNhapDiem.Text = "Quản lý &Điểm && Kết quả";
            this.mnuNhapDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeTongHop});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(135, 23);
            this.mnuBaoCao.Text = "&Báo cáo Thống kê";
            // 
            // mnuThongKeTongHop
            // 
            this.mnuThongKeTongHop.Name = "mnuThongKeTongHop";
            this.mnuThongKeTongHop.Size = new System.Drawing.Size(232, 24);
            this.mnuThongKeTongHop.Text = "&Thống kê tổng hợp && XL";
            this.mnuThongKeTongHop.Click += new System.EventHandler(this.mnuThongKeTongHop_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinNhom});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(71, 23);
            this.mnuTroGiup.Text = "Trợ &giúp";
            // 
            // mnuThongTinNhom
            // 
            this.mnuThongTinNhom.Name = "mnuThongTinNhom";
            this.mnuThongTinNhom.Size = new System.Drawing.Size(203, 24);
            this.mnuThongTinNhom.Text = "Thông tin &Bài tập lớn";
            this.mnuThongTinNhom.Click += new System.EventHandler(this.mnuThongTinNhom_Click);
            // 
            // toolStripNhanh
            // 
            this.toolStripNhanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.toolStripNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.toolStripNhanh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripNhanh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSinhVien,
            this.tsbtnLopKhoa,
            this.tsbtnMonHoc,
            this.tsbtnDiem,
            this.tsbtnThongKe,
            this.toolStripSeparator2,
            this.tsbtnDangXuat});
            this.toolStripNhanh.Location = new System.Drawing.Point(0, 27);
            this.toolStripNhanh.Name = "toolStripNhanh";
            this.toolStripNhanh.Size = new System.Drawing.Size(1184, 38);
            this.toolStripNhanh.TabIndex = 1;
            // 
            // tsbtnSinhVien
            // 
            this.tsbtnSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSinhVien.Name = "tsbtnSinhVien";
            this.tsbtnSinhVien.Padding = new System.Windows.Forms.Padding(8);
            this.tsbtnSinhVien.Size = new System.Drawing.Size(83, 35);
            this.tsbtnSinhVien.Text = "Sinh viên";
            this.tsbtnSinhVien.Click += new System.EventHandler(this.mnuQLSinhVien_Click);
            // 
            // tsbtnLopKhoa
            // 
            this.tsbtnLopKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLopKhoa.Name = "tsbtnLopKhoa";
            this.tsbtnLopKhoa.Padding = new System.Windows.Forms.Padding(8);
            this.tsbtnLopKhoa.Size = new System.Drawing.Size(95, 35);
            this.tsbtnLopKhoa.Text = "Lớp - Khoa";
            this.tsbtnLopKhoa.Click += new System.EventHandler(this.mnuQLLopKhoa_Click);
            // 
            // tsbtnMonHoc
            // 
            this.tsbtnMonHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMonHoc.Name = "tsbtnMonHoc";
            this.tsbtnMonHoc.Padding = new System.Windows.Forms.Padding(8);
            this.tsbtnMonHoc.Size = new System.Drawing.Size(82, 35);
            this.tsbtnMonHoc.Text = "Môn học";
            this.tsbtnMonHoc.Click += new System.EventHandler(this.mnuQLMonHoc_Click);
            // 
            // tsbtnDiem
            // 
            this.tsbtnDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDiem.Name = "tsbtnDiem";
            this.tsbtnDiem.Padding = new System.Windows.Forms.Padding(8);
            this.tsbtnDiem.Size = new System.Drawing.Size(94, 35);
            this.tsbtnDiem.Text = "Bảng điểm";
            this.tsbtnDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);
            // 
            // tsbtnThongKe
            // 
            this.tsbtnThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnThongKe.Name = "tsbtnThongKe";
            this.tsbtnThongKe.Padding = new System.Windows.Forms.Padding(8);
            this.tsbtnThongKe.Size = new System.Drawing.Size(83, 35);
            this.tsbtnThongKe.Text = "Thống kê";
            this.tsbtnThongKe.Click += new System.EventHandler(this.mnuThongKeTongHop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnDangXuat
            // 
            this.tsbtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDangXuat.Name = "tsbtnDangXuat";
            this.tsbtnDangXuat.Padding = new System.Windows.Forms.Padding(8);
            this.tsbtnDangXuat.Size = new System.Drawing.Size(91, 35);
            this.tsbtnDangXuat.Text = "Đăng xuất";
            this.tsbtnDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblNguoiDung,
            this.tslblCSDL,
            this.tslblThoiGian});
            this.statusStrip.Location = new System.Drawing.Point(0, 695);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslblNguoiDung
            // 
            this.tslblNguoiDung.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tslblNguoiDung.Name = "tslblNguoiDung";
            this.tslblNguoiDung.Size = new System.Drawing.Size(185, 21);
            this.tslblNguoiDung.Text = "Người dùng: Admin (Quản trị)";
            // 
            // tslblCSDL
            // 
            this.tslblCSDL.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tslblCSDL.ForeColor = System.Drawing.Color.Green;
            this.tslblCSDL.Name = "tslblCSDL";
            this.tslblCSDL.Size = new System.Drawing.Size(193, 21);
            this.tslblCSDL.Text = "● CSDL: Sẵn sàng (Local Mode)";
            // 
            // tslblThoiGian
            // 
            this.tslblThoiGian.Name = "tslblThoiGian";
            this.tslblThoiGian.Size = new System.Drawing.Size(791, 21);
            this.tslblThoiGian.Spring = true;
            this.tslblThoiGian.Text = "Thời gian: 00:00:00";
            this.tslblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerThoiGian
            // 
            this.timerThoiGian.Enabled = true;
            this.timerThoiGian.Interval = 1000;
            this.timerThoiGian.Tick += new System.EventHandler(this.timerThoiGian_Tick);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlDashboard.Controls.Add(this.grbThaoTacNhanh);
            this.pnlDashboard.Controls.Add(this.pnlCardMon);
            this.pnlDashboard.Controls.Add(this.pnlCardKhoa);
            this.pnlDashboard.Controls.Add(this.pnlCardLop);
            this.pnlDashboard.Controls.Add(this.pnlCardSV);
            this.pnlDashboard.Controls.Add(this.lblWelcome);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 65);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1184, 630);
            this.pnlDashboard.TabIndex = 3;
            // 
            // grbThaoTacNhanh
            // 
            this.grbThaoTacNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThaoTacNhanh.BackColor = System.Drawing.Color.White;
            this.grbThaoTacNhanh.Controls.Add(this.btnMoThongKe);
            this.grbThaoTacNhanh.Controls.Add(this.btnMoDiem);
            this.grbThaoTacNhanh.Controls.Add(this.btnMoLop);
            this.grbThaoTacNhanh.Controls.Add(this.btnMoSV);
            this.grbThaoTacNhanh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grbThaoTacNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.grbThaoTacNhanh.Location = new System.Drawing.Point(30, 240);
            this.grbThaoTacNhanh.Name = "grbThaoTacNhanh";
            this.grbThaoTacNhanh.Size = new System.Drawing.Size(1124, 200);
            this.grbThaoTacNhanh.TabIndex = 5;
            this.grbThaoTacNhanh.TabStop = false;
            this.grbThaoTacNhanh.Text = "Truy cập nhanh chức năng hệ thống";
            // 
            // btnMoThongKe
            // 
            this.btnMoThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnMoThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoThongKe.ForeColor = System.Drawing.Color.White;
            this.btnMoThongKe.Location = new System.Drawing.Point(850, 45);
            this.btnMoThongKe.Name = "btnMoThongKe";
            this.btnMoThongKe.Size = new System.Drawing.Size(240, 110);
            this.btnMoThongKe.TabIndex = 3;
            this.btnMoThongKe.Text = "BÁO CÁO THỐNG KÊ\r\n\r\nTổng hợp & Xếp loại";
            this.btnMoThongKe.UseVisualStyleBackColor = false;
            this.btnMoThongKe.Click += new System.EventHandler(this.mnuThongKeTongHop_Click);
            // 
            // btnMoDiem
            // 
            this.btnMoDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnMoDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoDiem.ForeColor = System.Drawing.Color.White;
            this.btnMoDiem.Location = new System.Drawing.Point(580, 45);
            this.btnMoDiem.Name = "btnMoDiem";
            this.btnMoDiem.Size = new System.Drawing.Size(240, 110);
            this.btnMoDiem.TabIndex = 2;
            this.btnMoDiem.Text = "QUẢN LÝ ĐIỂM\r\n\r\nBảng điểm học phần";
            this.btnMoDiem.UseVisualStyleBackColor = false;
            this.btnMoDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);
            // 
            // btnMoLop
            // 
            this.btnMoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnMoLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoLop.ForeColor = System.Drawing.Color.White;
            this.btnMoLop.Location = new System.Drawing.Point(310, 45);
            this.btnMoLop.Name = "btnMoLop";
            this.btnMoLop.Size = new System.Drawing.Size(240, 110);
            this.btnMoLop.TabIndex = 1;
            this.btnMoLop.Text = "LỚP VÀ KHOA VIỆN\r\n\r\nCơ cấu đào tạo";
            this.btnMoLop.UseVisualStyleBackColor = false;
            this.btnMoLop.Click += new System.EventHandler(this.mnuQLLopKhoa_Click);
            // 
            // btnMoSV
            // 
            this.btnMoSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnMoSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoSV.ForeColor = System.Drawing.Color.White;
            this.btnMoSV.Location = new System.Drawing.Point(35, 45);
            this.btnMoSV.Name = "btnMoSV";
            this.btnMoSV.Size = new System.Drawing.Size(240, 110);
            this.btnMoSV.TabIndex = 0;
            this.btnMoSV.Text = "QUẢN LÝ SINH VIÊN\r\n\r\nHồ sơ & Tìm kiếm";
            this.btnMoSV.UseVisualStyleBackColor = false;
            this.btnMoSV.Click += new System.EventHandler(this.mnuQLSinhVien_Click);
            // 
            // pnlCardMon
            // 
            this.pnlCardMon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlCardMon.Controls.Add(this.lblCountMon);
            this.pnlCardMon.Controls.Add(this.lblTitleMon);
            this.pnlCardMon.Location = new System.Drawing.Point(880, 80);
            this.pnlCardMon.Name = "pnlCardMon";
            this.pnlCardMon.Size = new System.Drawing.Size(250, 120);
            this.pnlCardMon.TabIndex = 4;
            // 
            // lblCountMon
            // 
            this.lblCountMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountMon.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountMon.ForeColor = System.Drawing.Color.White;
            this.lblCountMon.Location = new System.Drawing.Point(0, 35);
            this.lblCountMon.Name = "lblCountMon";
            this.lblCountMon.Size = new System.Drawing.Size(250, 85);
            this.lblCountMon.TabIndex = 1;
            this.lblCountMon.Text = "5";
            this.lblCountMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleMon
            // 
            this.lblTitleMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleMon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleMon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleMon.Location = new System.Drawing.Point(0, 0);
            this.lblTitleMon.Name = "lblTitleMon";
            this.lblTitleMon.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTitleMon.Size = new System.Drawing.Size(250, 35);
            this.lblTitleMon.TabIndex = 0;
            this.lblTitleMon.Text = "MÔN HỌC";
            // 
            // pnlCardKhoa
            // 
            this.pnlCardKhoa.BackColor = System.Drawing.Color.DarkOrchid;
            this.pnlCardKhoa.Controls.Add(this.lblCountKhoa);
            this.pnlCardKhoa.Controls.Add(this.lblTitleKhoa);
            this.pnlCardKhoa.Location = new System.Drawing.Point(600, 80);
            this.pnlCardKhoa.Name = "pnlCardKhoa";
            this.pnlCardKhoa.Size = new System.Drawing.Size(250, 120);
            this.pnlCardKhoa.TabIndex = 3;
            // 
            // lblCountKhoa
            // 
            this.lblCountKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountKhoa.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountKhoa.ForeColor = System.Drawing.Color.White;
            this.lblCountKhoa.Location = new System.Drawing.Point(0, 35);
            this.lblCountKhoa.Name = "lblCountKhoa";
            this.lblCountKhoa.Size = new System.Drawing.Size(250, 85);
            this.lblCountKhoa.TabIndex = 1;
            this.lblCountKhoa.Text = "4";
            this.lblCountKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleKhoa
            // 
            this.lblTitleKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleKhoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleKhoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleKhoa.Location = new System.Drawing.Point(0, 0);
            this.lblTitleKhoa.Name = "lblTitleKhoa";
            this.lblTitleKhoa.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTitleKhoa.Size = new System.Drawing.Size(250, 35);
            this.lblTitleKhoa.TabIndex = 0;
            this.lblTitleKhoa.Text = "KHOA / VIỆN";
            // 
            // pnlCardLop
            // 
            this.pnlCardLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnlCardLop.Controls.Add(this.lblCountLop);
            this.pnlCardLop.Controls.Add(this.lblTitleLop);
            this.pnlCardLop.Location = new System.Drawing.Point(315, 80);
            this.pnlCardLop.Name = "pnlCardLop";
            this.pnlCardLop.Size = new System.Drawing.Size(250, 120);
            this.pnlCardLop.TabIndex = 2;
            // 
            // lblCountLop
            // 
            this.lblCountLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountLop.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountLop.ForeColor = System.Drawing.Color.White;
            this.lblCountLop.Location = new System.Drawing.Point(0, 35);
            this.lblCountLop.Name = "lblCountLop";
            this.lblCountLop.Size = new System.Drawing.Size(250, 85);
            this.lblCountLop.TabIndex = 1;
            this.lblCountLop.Text = "5";
            this.lblCountLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleLop
            // 
            this.lblTitleLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleLop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleLop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleLop.Location = new System.Drawing.Point(0, 0);
            this.lblTitleLop.Name = "lblTitleLop";
            this.lblTitleLop.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTitleLop.Size = new System.Drawing.Size(250, 35);
            this.lblTitleLop.TabIndex = 0;
            this.lblTitleLop.Text = "LỚP HỌC";
            // 
            // pnlCardSV
            // 
            this.pnlCardSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlCardSV.Controls.Add(this.lblCountSV);
            this.pnlCardSV.Controls.Add(this.lblTitleSV);
            this.pnlCardSV.Location = new System.Drawing.Point(30, 80);
            this.pnlCardSV.Name = "pnlCardSV";
            this.pnlCardSV.Size = new System.Drawing.Size(250, 120);
            this.pnlCardSV.TabIndex = 1;
            // 
            // lblCountSV
            // 
            this.lblCountSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountSV.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountSV.ForeColor = System.Drawing.Color.White;
            this.lblCountSV.Location = new System.Drawing.Point(0, 35);
            this.lblCountSV.Name = "lblCountSV";
            this.lblCountSV.Size = new System.Drawing.Size(250, 85);
            this.lblCountSV.TabIndex = 1;
            this.lblCountSV.Text = "6";
            this.lblCountSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleSV
            // 
            this.lblTitleSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleSV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleSV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleSV.Location = new System.Drawing.Point(0, 0);
            this.lblTitleSV.Name = "lblTitleSV";
            this.lblTitleSV.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTitleSV.Size = new System.Drawing.Size(250, 35);
            this.lblTitleSV.TabIndex = 0;
            this.lblTitleSV.Text = "TỔNG SINH VIÊN";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblWelcome.Location = new System.Drawing.Point(25, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(520, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "TỔNG QUAN HỆ THỐNG QUẢN LÝ SINH VIÊN";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripNhanh);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Sinh viên - Lập trình trực quan C#";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.toolStripNhanh.ResumeLayout(false);
            this.toolStripNhanh.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.grbThaoTacNhanh.ResumeLayout(false);
            this.pnlCardMon.ResumeLayout(false);
            this.pnlCardKhoa.ResumeLayout(false);
            this.pnlCardLop.ResumeLayout(false);
            this.pnlCardSV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
