#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmMain
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>Required method for Designer support - do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            pnlSidebar = new QLDSV_HTC.UI.GradientPanel();
            pnlSidebarNav = new Panel();
            btnNavBangDiem = new QLDSV_HTC.UI.SidebarButton();
            btnNavNhapDiem = new QLDSV_HTC.UI.SidebarButton();
            btnNavLopTinChi = new QLDSV_HTC.UI.SidebarButton();
            btnNavGiangVien = new QLDSV_HTC.UI.SidebarButton();
            btnNavMonHoc = new QLDSV_HTC.UI.SidebarButton();
            btnNavSinhVien = new QLDSV_HTC.UI.SidebarButton();
            btnNavLop = new QLDSV_HTC.UI.SidebarButton();
            btnNavKhoa = new QLDSV_HTC.UI.SidebarButton();
            btnNavDashboard = new QLDSV_HTC.UI.SidebarButton();
            pnlSidebarFooter = new Panel();
            btnNavDangXuat = new QLDSV_HTC.UI.SidebarButton();
            btnNavDoiMatKhau = new QLDSV_HTC.UI.SidebarButton();
            pnlSidebarHeader = new Panel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            lblAppSub = new Label();
            pnlHeader = new Panel();
            lblPageTitle = new Label();
            lblNguoiDung = new Label();
            pnlContent = new Panel();
            pnlWelcome = new Panel();
            pnlWelcomeCard = new Panel();
            lblWelcomeHello = new Label();
            lblWelcomeSub = new Label();
            lblWelcomeRole = new Label();
            pnlWelcomeDivider = new Panel();
            lblWelcomeTip = new Label();
            pnlSpacer = new Panel();
            pnlInfoCard = new Panel();
            lblInfoTitle = new Label();
            lblInfoDesc = new Label();
            lblInfoContact = new Label();
            pnlSidebar.SuspendLayout();
            pnlSidebarNav.SuspendLayout();
            pnlSidebarFooter.SuspendLayout();
            pnlSidebarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlWelcome.SuspendLayout();
            pnlWelcomeCard.SuspendLayout();
            pnlInfoCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(22, 43, 85);
            pnlSidebar.Controls.Add(pnlSidebarNav);
            pnlSidebar.Controls.Add(pnlSidebarFooter);
            pnlSidebar.Controls.Add(pnlSidebarHeader);
            pnlSidebar.Decorations = true;
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.EndColor = Color.FromArgb(22, 43, 85);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(296, 1055);
            pnlSidebar.StartColor = Color.FromArgb(32, 57, 111);
            pnlSidebar.TabIndex = 2;
            // 
            // pnlSidebarNav
            // 
            pnlSidebarNav.BackColor = Color.Transparent;
            pnlSidebarNav.Controls.Add(btnNavBangDiem);
            pnlSidebarNav.Controls.Add(btnNavNhapDiem);
            pnlSidebarNav.Controls.Add(btnNavLopTinChi);
            pnlSidebarNav.Controls.Add(btnNavGiangVien);
            pnlSidebarNav.Controls.Add(btnNavMonHoc);
            pnlSidebarNav.Controls.Add(btnNavSinhVien);
            pnlSidebarNav.Controls.Add(btnNavLop);
            pnlSidebarNav.Controls.Add(btnNavKhoa);
            pnlSidebarNav.Controls.Add(btnNavDashboard);
            pnlSidebarNav.Dock = DockStyle.Fill;
            pnlSidebarNav.Location = new Point(0, 130);
            pnlSidebarNav.Margin = new Padding(4, 5, 4, 5);
            pnlSidebarNav.Name = "pnlSidebarNav";
            pnlSidebarNav.Padding = new Padding(10, 12, 10, 0);
            pnlSidebarNav.Size = new Size(296, 756);
            pnlSidebarNav.TabIndex = 0;
            // 
            // btnNavBangDiem
            // 
            btnNavBangDiem.Active = false;
            btnNavBangDiem.Dock = DockStyle.Top;
            btnNavBangDiem.FlatStyle = FlatStyle.Flat;
            btnNavBangDiem.Font = new Font("Segoe UI", 9.75F);
            btnNavBangDiem.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavBangDiem.Icon = UI.NavIcon.BangDiem;
            btnNavBangDiem.Location = new Point(10, 548);
            btnNavBangDiem.Margin = new Padding(4, 5, 4, 5);
            btnNavBangDiem.Name = "btnNavBangDiem";
            btnNavBangDiem.ShowIcon = true;
            btnNavBangDiem.Size = new Size(276, 67);
            btnNavBangDiem.TabIndex = 0;
            btnNavBangDiem.Text = "Bảng điểm cá nhân";
            btnNavBangDiem.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBangDiem.Click += btnNavBangDiem_Click;
            // 
            // btnNavNhapDiem
            // 
            btnNavNhapDiem.Active = false;
            btnNavNhapDiem.Dock = DockStyle.Top;
            btnNavNhapDiem.FlatStyle = FlatStyle.Flat;
            btnNavNhapDiem.Font = new Font("Segoe UI", 9.75F);
            btnNavNhapDiem.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavNhapDiem.Icon = UI.NavIcon.NhapDiem;
            btnNavNhapDiem.Location = new Point(10, 481);
            btnNavNhapDiem.Margin = new Padding(4, 5, 4, 5);
            btnNavNhapDiem.Name = "btnNavNhapDiem";
            btnNavNhapDiem.ShowIcon = true;
            btnNavNhapDiem.Size = new Size(276, 67);
            btnNavNhapDiem.TabIndex = 1;
            btnNavNhapDiem.Text = "Nhập điểm";
            btnNavNhapDiem.TextAlign = ContentAlignment.MiddleLeft;
            btnNavNhapDiem.Click += btnNavNhapDiem_Click;
            // 
            // btnNavLopTinChi
            // 
            btnNavLopTinChi.Active = false;
            btnNavLopTinChi.Dock = DockStyle.Top;
            btnNavLopTinChi.FlatStyle = FlatStyle.Flat;
            btnNavLopTinChi.Font = new Font("Segoe UI", 9.75F);
            btnNavLopTinChi.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavLopTinChi.Icon = UI.NavIcon.LopTinChi;
            btnNavLopTinChi.Location = new Point(10, 414);
            btnNavLopTinChi.Margin = new Padding(4, 5, 4, 5);
            btnNavLopTinChi.Name = "btnNavLopTinChi";
            btnNavLopTinChi.ShowIcon = true;
            btnNavLopTinChi.Size = new Size(276, 67);
            btnNavLopTinChi.TabIndex = 2;
            btnNavLopTinChi.Text = "Lớp tín chỉ";
            btnNavLopTinChi.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLopTinChi.Click += btnNavLopTinChi_Click;
            // 
            // btnNavGiangVien
            // 
            btnNavGiangVien.Active = false;
            btnNavGiangVien.Dock = DockStyle.Top;
            btnNavGiangVien.FlatStyle = FlatStyle.Flat;
            btnNavGiangVien.Font = new Font("Segoe UI", 9.75F);
            btnNavGiangVien.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavGiangVien.Icon = UI.NavIcon.GiangVien;
            btnNavGiangVien.Location = new Point(10, 347);
            btnNavGiangVien.Margin = new Padding(4, 5, 4, 5);
            btnNavGiangVien.Name = "btnNavGiangVien";
            btnNavGiangVien.ShowIcon = true;
            btnNavGiangVien.Size = new Size(276, 67);
            btnNavGiangVien.TabIndex = 3;
            btnNavGiangVien.Text = "Quản lý giảng viên";
            btnNavGiangVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNavGiangVien.Click += btnNavGiangVien_Click;
            // 
            // btnNavMonHoc
            // 
            btnNavMonHoc.Active = false;
            btnNavMonHoc.Dock = DockStyle.Top;
            btnNavMonHoc.FlatStyle = FlatStyle.Flat;
            btnNavMonHoc.Font = new Font("Segoe UI", 9.75F);
            btnNavMonHoc.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavMonHoc.Icon = UI.NavIcon.MonHoc;
            btnNavMonHoc.Location = new Point(10, 280);
            btnNavMonHoc.Margin = new Padding(4, 5, 4, 5);
            btnNavMonHoc.Name = "btnNavMonHoc";
            btnNavMonHoc.ShowIcon = true;
            btnNavMonHoc.Size = new Size(276, 67);
            btnNavMonHoc.TabIndex = 4;
            btnNavMonHoc.Text = "Quản lý môn học";
            btnNavMonHoc.TextAlign = ContentAlignment.MiddleLeft;
            btnNavMonHoc.Click += btnNavMonHoc_Click;
            // 
            // btnNavSinhVien
            // 
            btnNavSinhVien.Active = false;
            btnNavSinhVien.Dock = DockStyle.Top;
            btnNavSinhVien.FlatStyle = FlatStyle.Flat;
            btnNavSinhVien.Font = new Font("Segoe UI", 9.75F);
            btnNavSinhVien.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavSinhVien.Icon = UI.NavIcon.SinhVien;
            btnNavSinhVien.Location = new Point(10, 213);
            btnNavSinhVien.Margin = new Padding(4, 5, 4, 5);
            btnNavSinhVien.Name = "btnNavSinhVien";
            btnNavSinhVien.ShowIcon = true;
            btnNavSinhVien.Size = new Size(276, 67);
            btnNavSinhVien.TabIndex = 5;
            btnNavSinhVien.Text = "Quản lý sinh viên";
            btnNavSinhVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSinhVien.Click += btnNavSinhVien_Click;
            // 
            // btnNavLop
            // 
            btnNavLop.Active = false;
            btnNavLop.Dock = DockStyle.Top;
            btnNavLop.FlatStyle = FlatStyle.Flat;
            btnNavLop.Font = new Font("Segoe UI", 9.75F);
            btnNavLop.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavLop.Icon = UI.NavIcon.Lop;
            btnNavLop.Location = new Point(10, 146);
            btnNavLop.Margin = new Padding(4, 5, 4, 5);
            btnNavLop.Name = "btnNavLop";
            btnNavLop.ShowIcon = true;
            btnNavLop.Size = new Size(276, 67);
            btnNavLop.TabIndex = 6;
            btnNavLop.Text = "Quản lý lớp";
            btnNavLop.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLop.Click += btnNavLop_Click;
            // 
            // btnNavKhoa
            // 
            btnNavKhoa.Active = false;
            btnNavKhoa.Dock = DockStyle.Top;
            btnNavKhoa.FlatStyle = FlatStyle.Flat;
            btnNavKhoa.Font = new Font("Segoe UI", 9.75F);
            btnNavKhoa.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavKhoa.Icon = UI.NavIcon.Khoa;
            btnNavKhoa.Location = new Point(10, 79);
            btnNavKhoa.Margin = new Padding(4, 5, 4, 5);
            btnNavKhoa.Name = "btnNavKhoa";
            btnNavKhoa.ShowIcon = true;
            btnNavKhoa.Size = new Size(276, 67);
            btnNavKhoa.TabIndex = 7;
            btnNavKhoa.Text = "Quản lý khoa";
            btnNavKhoa.TextAlign = ContentAlignment.MiddleLeft;
            btnNavKhoa.Click += btnNavKhoa_Click;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Active = false;
            btnNavDashboard.Dock = DockStyle.Top;
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 9.75F);
            btnNavDashboard.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavDashboard.Icon = UI.NavIcon.Dashboard;
            btnNavDashboard.Location = new Point(10, 12);
            btnNavDashboard.Margin = new Padding(4, 5, 4, 5);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.ShowIcon = true;
            btnNavDashboard.Size = new Size(276, 67);
            btnNavDashboard.TabIndex = 8;
            btnNavDashboard.Text = "Tổng quan";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // pnlSidebarFooter
            // 
            pnlSidebarFooter.BackColor = Color.Transparent;
            pnlSidebarFooter.Controls.Add(btnNavDangXuat);
            pnlSidebarFooter.Controls.Add(btnNavDoiMatKhau);
            pnlSidebarFooter.Dock = DockStyle.Bottom;
            pnlSidebarFooter.Location = new Point(0, 886);
            pnlSidebarFooter.Margin = new Padding(4, 5, 4, 5);
            pnlSidebarFooter.Name = "pnlSidebarFooter";
            pnlSidebarFooter.Padding = new Padding(10, 0, 10, 12);
            pnlSidebarFooter.Size = new Size(296, 169);
            pnlSidebarFooter.TabIndex = 1;
            // 
            // btnNavDangXuat
            // 
            btnNavDangXuat.Active = false;
            btnNavDangXuat.Dock = DockStyle.Top;
            btnNavDangXuat.FlatStyle = FlatStyle.Flat;
            btnNavDangXuat.Font = new Font("Segoe UI", 9.75F);
            btnNavDangXuat.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavDangXuat.Icon = UI.NavIcon.Logout;
            btnNavDangXuat.Location = new Point(10, 67);
            btnNavDangXuat.Margin = new Padding(4, 5, 4, 5);
            btnNavDangXuat.Name = "btnNavDangXuat";
            btnNavDangXuat.ShowIcon = true;
            btnNavDangXuat.Size = new Size(276, 67);
            btnNavDangXuat.TabIndex = 0;
            btnNavDangXuat.Text = "Đăng xuất";
            btnNavDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDangXuat.Click += btnNavDangXuat_Click;
            // 
            // btnNavDoiMatKhau
            // 
            btnNavDoiMatKhau.Active = false;
            btnNavDoiMatKhau.Dock = DockStyle.Top;
            btnNavDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnNavDoiMatKhau.Font = new Font("Segoe UI", 9.75F);
            btnNavDoiMatKhau.ForeColor = Color.FromArgb(184, 201, 232);
            btnNavDoiMatKhau.Icon = UI.NavIcon.DoiMatKhau;
            btnNavDoiMatKhau.Location = new Point(10, 0);
            btnNavDoiMatKhau.Margin = new Padding(4, 5, 4, 5);
            btnNavDoiMatKhau.Name = "btnNavDoiMatKhau";
            btnNavDoiMatKhau.ShowIcon = true;
            btnNavDoiMatKhau.Size = new Size(276, 67);
            btnNavDoiMatKhau.TabIndex = 1;
            btnNavDoiMatKhau.Text = "Đổi mật khẩu";
            btnNavDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDoiMatKhau.Click += btnNavDoiMatKhau_Click;
            // 
            // pnlSidebarHeader
            // 
            pnlSidebarHeader.BackColor = Color.Transparent;
            pnlSidebarHeader.Controls.Add(picLogo);
            pnlSidebarHeader.Controls.Add(lblAppName);
            pnlSidebarHeader.Controls.Add(lblAppSub);
            pnlSidebarHeader.Dock = DockStyle.Top;
            pnlSidebarHeader.Location = new Point(0, 0);
            pnlSidebarHeader.Margin = new Padding(4, 5, 4, 5);
            pnlSidebarHeader.Name = "pnlSidebarHeader";
            pnlSidebarHeader.Padding = new Padding(15, 18, 15, 12);
            pnlSidebarHeader.Size = new Size(296, 130);
            pnlSidebarHeader.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(15, 25);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(62, 74);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(87, 21);
            lblAppName.Margin = new Padding(4, 0, 4, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(108, 50);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "QUẢN LÝ\r\nSINH VIÊN";
            // 
            // lblAppSub
            // 
            lblAppSub.AutoSize = true;
            lblAppSub.Font = new Font("Segoe UI", 8.75F);
            lblAppSub.ForeColor = Color.FromArgb(140, 180, 230);
            lblAppSub.Location = new Point(87, 83);
            lblAppSub.Margin = new Padding(4, 0, 4, 0);
            lblAppSub.Name = "lblAppSub";
            lblAppSub.Size = new Size(77, 20);
            lblAppSub.TabIndex = 2;
            lblAppSub.Text = "UTC Portal";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Controls.Add(lblNguoiDung);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(296, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(26, 0, 26, 0);
            pnlHeader.Size = new Size(1350, 86);
            pnlHeader.TabIndex = 1;
            pnlHeader.Paint += PnlHeader_Paint;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Dock = DockStyle.Left;
            lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblPageTitle.Location = new Point(26, 0);
            lblPageTitle.Margin = new Padding(4, 0, 4, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(138, 32);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Tổng quan";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNguoiDung.Font = new Font("Segoe UI", 8.75F);
            lblNguoiDung.ForeColor = Color.FromArgb(113, 128, 150);
            lblNguoiDung.Location = new Point(1093, 0);
            lblNguoiDung.Margin = new Padding(4, 0, 4, 0);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(643, 86);
            lblNguoiDung.TabIndex = 1;
            lblNguoiDung.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(242, 245, 252);
            pnlContent.Controls.Add(pnlWelcome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(296, 86);
            pnlContent.Margin = new Padding(4, 5, 4, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1350, 969);
            pnlContent.TabIndex = 0;
            // 
            // pnlWelcome
            // 
            pnlWelcome.AutoScroll = true;
            pnlWelcome.BackColor = Color.FromArgb(245, 247, 250);
            pnlWelcome.Controls.Add(pnlWelcomeCard);
            pnlWelcome.Controls.Add(pnlInfoCard);
            pnlWelcome.Dock = DockStyle.Fill;
            pnlWelcome.Location = new Point(0, 0);
            pnlWelcome.Margin = new Padding(4, 5, 4, 5);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Padding = new Padding(39, 38, 39, 38);
            pnlWelcome.Size = new Size(1350, 969);
            pnlWelcome.TabIndex = 0;
            // 
            // pnlWelcomeCard
            // 
            pnlWelcomeCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlWelcomeCard.BackColor = Color.FromArgb(26, 46, 112);
            pnlWelcomeCard.Controls.Add(lblWelcomeHello);
            pnlWelcomeCard.Controls.Add(lblWelcomeSub);
            pnlWelcomeCard.Controls.Add(lblWelcomeRole);
            pnlWelcomeCard.Controls.Add(pnlWelcomeDivider);
            pnlWelcomeCard.Controls.Add(lblWelcomeTip);
            pnlWelcomeCard.Location = new Point(39, 38);
            pnlWelcomeCard.Margin = new Padding(4, 5, 4, 5);
            pnlWelcomeCard.Name = "pnlWelcomeCard";
            pnlWelcomeCard.Size = new Size(1200, 310);
            pnlWelcomeCard.TabIndex = 0;
            // 
            // lblWelcomeHello
            // 
            lblWelcomeHello.AutoSize = true;
            lblWelcomeHello.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcomeHello.ForeColor = Color.White;
            lblWelcomeHello.Location = new Point(36, 34);
            lblWelcomeHello.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeHello.Name = "lblWelcomeHello";
            lblWelcomeHello.Size = new Size(210, 41);
            lblWelcomeHello.TabIndex = 0;
            lblWelcomeHello.Text = "Xin chào bạn!";
            // 
            // lblWelcomeSub
            // 
            lblWelcomeSub.AutoSize = true;
            lblWelcomeSub.Font = new Font("Segoe UI", 11.5F);
            lblWelcomeSub.ForeColor = Color.FromArgb(210, 230, 255);
            lblWelcomeSub.Location = new Point(39, 110);
            lblWelcomeSub.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(805, 28);
            lblWelcomeSub.TabIndex = 1;
            lblWelcomeSub.Text = "Chào mừng bạn đến với Cổng thông tin đào tạo - Trường Đại học Giao thông Vận tải (UTC)";
            // 
            // lblWelcomeRole
            // 
            lblWelcomeRole.AutoSize = true;
            lblWelcomeRole.Font = new Font("Segoe UI", 10.5F);
            lblWelcomeRole.ForeColor = Color.FromArgb(170, 205, 255);
            lblWelcomeRole.Location = new Point(39, 163);
            lblWelcomeRole.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeRole.Name = "lblWelcomeRole";
            lblWelcomeRole.Size = new Size(225, 25);
            lblWelcomeRole.TabIndex = 2;
            lblWelcomeRole.Text = "Vai trò tài khoản: Hệ thống";
            // 
            // pnlWelcomeDivider
            // 
            pnlWelcomeDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlWelcomeDivider.BackColor = Color.FromArgb(80, 255, 255, 255);
            pnlWelcomeDivider.Location = new Point(39, 222);
            pnlWelcomeDivider.Margin = new Padding(4, 5, 4, 5);
            pnlWelcomeDivider.Name = "pnlWelcomeDivider";
            pnlWelcomeDivider.Size = new Size(1120, 2);
            pnlWelcomeDivider.TabIndex = 3;
            // 
            // lblWelcomeTip
            // 
            lblWelcomeTip.AutoSize = true;
            lblWelcomeTip.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblWelcomeTip.ForeColor = Color.FromArgb(235, 245, 255);
            lblWelcomeTip.Location = new Point(36, 253);
            lblWelcomeTip.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeTip.Name = "lblWelcomeTip";
            lblWelcomeTip.Size = new Size(683, 23);
            lblWelcomeTip.TabIndex = 4;
            lblWelcomeTip.Text = "💡 Hướng dẫn: Bạn hãy chọn các chức năng trên thanh menu bên trái để bắt đầu làm việc.";
            // 
            // pnlInfoCard
            // 
            pnlInfoCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlInfoCard.BackColor = Color.White;
            pnlInfoCard.Controls.Add(lblInfoTitle);
            pnlInfoCard.Controls.Add(lblInfoDesc);
            pnlInfoCard.Controls.Add(lblInfoContact);
            pnlInfoCard.Location = new Point(39, 414);
            pnlInfoCard.Margin = new Padding(4, 5, 4, 5);
            pnlInfoCard.Name = "pnlInfoCard";
            pnlInfoCard.Padding = new Padding(32, 38, 32, 38);
            pnlInfoCard.Size = new Size(1200, 280);
            pnlInfoCard.TabIndex = 1;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblInfoTitle.ForeColor = Color.FromArgb(26, 46, 112);
            lblInfoTitle.Location = new Point(32, 31);
            lblInfoTitle.Margin = new Padding(4, 0, 4, 0);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(637, 30);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "HỆ THỐNG QUẢN LÝ ĐÀO TẠO THEO TÍN CHỈ (UTC PORTAL)";
            // 
            // lblInfoDesc
            // 
            lblInfoDesc.AutoSize = true;
            lblInfoDesc.Font = new Font("Segoe UI", 10.5F);
            lblInfoDesc.ForeColor = Color.FromArgb(71, 85, 105);
            lblInfoDesc.Location = new Point(32, 92);
            lblInfoDesc.Margin = new Padding(4, 0, 4, 0);
            lblInfoDesc.Name = "lblInfoDesc";
            lblInfoDesc.Size = new Size(816, 50);
            lblInfoDesc.TabIndex = 1;
            lblInfoDesc.Text = "Phần mềm phục vụ công tác quản lý sinh viên, giảng viên, môn học, lớp tín chỉ và bảng điểm học tập.\r\nPhát triển theo quy chuẩn đào tạo học chế tín chỉ của Trường Đại học Giao thông Vận tải.";
            // 
            // lblInfoContact
            // 
            lblInfoContact.AutoSize = true;
            lblInfoContact.Font = new Font("Segoe UI", 10F);
            lblInfoContact.ForeColor = Color.FromArgb(100, 116, 139);
            lblInfoContact.Location = new Point(32, 192);
            lblInfoContact.Margin = new Padding(4, 0, 4, 0);
            lblInfoContact.Name = "lblInfoContact";
            lblInfoContact.Size = new Size(541, 46);
            lblInfoContact.TabIndex = 2;
            lblInfoContact.Text = "📌 Địa chỉ: Số 3 phố Cầu Giấy, Láng Thượng, Đống Đa, Hà Nội\r\n📞 Điện thoại hỗ trợ: (024) 37663311   |   ✉ Email: hotro@utc.edu.vn";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1646, 1055);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1311, 1018);
            Name = "FrmMain";
            Text = "Quản lý sinh viên — UTC Portal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebarNav.ResumeLayout(false);
            pnlSidebarFooter.ResumeLayout(false);
            pnlSidebarHeader.ResumeLayout(false);
            pnlSidebarHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlWelcome.ResumeLayout(false);
            pnlWelcomeCard.ResumeLayout(false);
            pnlWelcomeCard.PerformLayout();
            pnlInfoCard.ResumeLayout(false);
            pnlInfoCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private void PnlHeader_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Đường kẻ dưới header
            using var pen = new System.Drawing.Pen(QLDSV_HTC.UI.Palette.Border, 1);
            e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
        }

        private QLDSV_HTC.UI.GradientPanel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSub;
        private System.Windows.Forms.Panel pnlSidebarNav;
        private QLDSV_HTC.UI.SidebarButton btnNavDashboard;
        private QLDSV_HTC.UI.SidebarButton btnNavKhoa;
        private QLDSV_HTC.UI.SidebarButton btnNavLop;
        private QLDSV_HTC.UI.SidebarButton btnNavSinhVien;
        private QLDSV_HTC.UI.SidebarButton btnNavMonHoc;
        private QLDSV_HTC.UI.SidebarButton btnNavGiangVien;
        private QLDSV_HTC.UI.SidebarButton btnNavLopTinChi;
        private QLDSV_HTC.UI.SidebarButton btnNavNhapDiem;
        private QLDSV_HTC.UI.SidebarButton btnNavBangDiem;
        private System.Windows.Forms.Panel pnlSidebarFooter;
        private QLDSV_HTC.UI.SidebarButton btnNavDoiMatKhau;
        private QLDSV_HTC.UI.SidebarButton btnNavDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Panel pnlContent;

        // Các control chào mừng tổng quan kéo thả trực quan trong Designer
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Panel pnlWelcomeCard;
        private System.Windows.Forms.Label lblWelcomeHello;
        private System.Windows.Forms.Label lblWelcomeSub;
        private System.Windows.Forms.Label lblWelcomeRole;
        private System.Windows.Forms.Panel pnlWelcomeDivider;
        private System.Windows.Forms.Label lblWelcomeTip;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Panel pnlInfoCard;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfoDesc;
        private System.Windows.Forms.Label lblInfoContact;
    }
}
