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
            // =====================================================================
            // LAYOUT CHÍNH: Sidebar (trái) + Header (trên) + Content (giữa)
            // =====================================================================
            pnlSidebar = new QLDSV_HTC.UI.GradientPanel();
            pnlSidebarHeader = new System.Windows.Forms.Panel();
            picLogo = new System.Windows.Forms.PictureBox();
            lblAppName = new System.Windows.Forms.Label();
            lblAppSub = new System.Windows.Forms.Label();
            pnlSidebarNav = new System.Windows.Forms.Panel();
            // Nav buttons
            btnNavDashboard = new QLDSV_HTC.UI.SidebarButton();
            btnNavKhoa = new QLDSV_HTC.UI.SidebarButton();
            btnNavLop = new QLDSV_HTC.UI.SidebarButton();
            btnNavSinhVien = new QLDSV_HTC.UI.SidebarButton();
            btnNavMonHoc = new QLDSV_HTC.UI.SidebarButton();
            btnNavGiangVien = new QLDSV_HTC.UI.SidebarButton();
            btnNavLopTinChi = new QLDSV_HTC.UI.SidebarButton();
            btnNavNhapDiem = new QLDSV_HTC.UI.SidebarButton();
            btnNavBangDiem = new QLDSV_HTC.UI.SidebarButton();
            btnNavHoSo = new QLDSV_HTC.UI.SidebarButton();
            picAvatar = new System.Windows.Forms.PictureBox();
            pnlSidebarFooter = new System.Windows.Forms.Panel();
            btnNavDoiMatKhau = new QLDSV_HTC.UI.SidebarButton();
            btnNavDangXuat = new QLDSV_HTC.UI.SidebarButton();

            // Header
            pnlHeader = new System.Windows.Forms.Panel();
            lblPageTitle = new System.Windows.Forms.Label();
            lblNguoiDung = new System.Windows.Forms.Label();

            // Content area
            pnlContent = new System.Windows.Forms.Panel();

            // =====================================================================
            // CẤU HÌNH
            // =====================================================================
            pnlSidebar.SuspendLayout();
            pnlSidebarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlSidebarNav.SuspendLayout();
            pnlSidebarFooter.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();

            // ---- SIDEBAR ----
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Width = 230;
            pnlSidebar.StartColor = QLDSV_HTC.UI.Palette.SidebarTop;
            pnlSidebar.EndColor = QLDSV_HTC.UI.Palette.SidebarBottom;
            pnlSidebar.Decorations = true;

            // Sidebar Header: Logo + Tên ứng dụng
            pnlSidebarHeader.Name = "pnlSidebarHeader";
            pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSidebarHeader.Height = 85;
            pnlSidebarHeader.BackColor = System.Drawing.Color.Transparent;
            pnlSidebarHeader.Padding = new System.Windows.Forms.Padding(12, 12, 12, 8);

            // picLogo
            picLogo.Name = "picLogo";
            picLogo.Location = new System.Drawing.Point(12, 16);
            picLogo.Size = new System.Drawing.Size(48, 48);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.BackColor = System.Drawing.Color.Transparent;

            lblAppName.Name = "lblAppName";
            lblAppName.Text = "QUẢN LÝ\r\nSINH VIÊN";
            lblAppName.Font = new System.Drawing.Font(QLDSV_HTC.UI.Palette.FontFamily, 11F, System.Drawing.FontStyle.Bold);
            lblAppName.ForeColor = System.Drawing.Color.White;
            lblAppName.Location = new System.Drawing.Point(68, 14);
            lblAppName.AutoSize = true;

            lblAppSub.Name = "lblAppSub";
            lblAppSub.Text = "UTC Portal";
            lblAppSub.Font = QLDSV_HTC.UI.Palette.FontSmall;
            lblAppSub.ForeColor = System.Drawing.Color.FromArgb(140, 180, 230);
            lblAppSub.Location = new System.Drawing.Point(68, 54);
            lblAppSub.AutoSize = true;

            pnlSidebarHeader.Controls.Add(picLogo);
            pnlSidebarHeader.Controls.Add(lblAppName);
            pnlSidebarHeader.Controls.Add(lblAppSub);

            // Sidebar Nav: Danh sách nút điều hướng
            pnlSidebarNav.Name = "pnlSidebarNav";
            pnlSidebarNav.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSidebarNav.BackColor = System.Drawing.Color.Transparent;
            pnlSidebarNav.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);

            // --- Dashboard ---
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Text = "Tổng quan";
            btnNavDashboard.Icon = QLDSV_HTC.UI.NavIcon.Dashboard;
            btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavDashboard.Height = 42;
            btnNavDashboard.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);

            // --- Khoa ---
            btnNavKhoa.Name = "btnNavKhoa";
            btnNavKhoa.Text = "Quản lý khoa";
            btnNavKhoa.Icon = QLDSV_HTC.UI.NavIcon.Khoa;
            btnNavKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavKhoa.Height = 42;
            btnNavKhoa.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavKhoa.Click += new System.EventHandler(this.btnNavKhoa_Click);

            // --- Lớp ---
            btnNavLop.Name = "btnNavLop";
            btnNavLop.Text = "Quản lý lớp";
            btnNavLop.Icon = QLDSV_HTC.UI.NavIcon.Lop;
            btnNavLop.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavLop.Height = 42;
            btnNavLop.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavLop.Click += new System.EventHandler(this.btnNavLop_Click);

            // --- Sinh viên ---
            btnNavSinhVien.Name = "btnNavSinhVien";
            btnNavSinhVien.Text = "Quản lý sinh viên";
            btnNavSinhVien.Icon = QLDSV_HTC.UI.NavIcon.SinhVien;
            btnNavSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavSinhVien.Height = 42;
            btnNavSinhVien.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavSinhVien.Click += new System.EventHandler(this.btnNavSinhVien_Click);

            // --- Môn học ---
            btnNavMonHoc.Name = "btnNavMonHoc";
            btnNavMonHoc.Text = "Quản lý môn học";
            btnNavMonHoc.Icon = QLDSV_HTC.UI.NavIcon.MonHoc;
            btnNavMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavMonHoc.Height = 42;
            btnNavMonHoc.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavMonHoc.Click += new System.EventHandler(this.btnNavMonHoc_Click);

            // --- Giảng viên ---
            btnNavGiangVien.Name = "btnNavGiangVien";
            btnNavGiangVien.Text = "Quản lý giảng viên";
            btnNavGiangVien.Icon = QLDSV_HTC.UI.NavIcon.GiangVien;
            btnNavGiangVien.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavGiangVien.Height = 42;
            btnNavGiangVien.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavGiangVien.Click += new System.EventHandler(this.btnNavGiangVien_Click);

            // --- Lớp tín chỉ ---
            btnNavLopTinChi.Name = "btnNavLopTinChi";
            btnNavLopTinChi.Text = "Lớp tín chỉ";
            btnNavLopTinChi.Icon = QLDSV_HTC.UI.NavIcon.LopTinChi;
            btnNavLopTinChi.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavLopTinChi.Height = 42;
            btnNavLopTinChi.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavLopTinChi.Click += new System.EventHandler(this.btnNavLopTinChi_Click);

            // --- Nhập điểm ---
            btnNavNhapDiem.Name = "btnNavNhapDiem";
            btnNavNhapDiem.Text = "Nhập điểm";
            btnNavNhapDiem.Icon = QLDSV_HTC.UI.NavIcon.NhapDiem;
            btnNavNhapDiem.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavNhapDiem.Height = 42;
            btnNavNhapDiem.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavNhapDiem.Click += new System.EventHandler(this.btnNavNhapDiem_Click);

            // --- Bảng điểm ---
            btnNavBangDiem.Name = "btnNavBangDiem";
            btnNavBangDiem.Text = "Bảng điểm cá nhân";
            btnNavBangDiem.Icon = QLDSV_HTC.UI.NavIcon.BangDiem;
            btnNavBangDiem.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavBangDiem.Height = 42;
            btnNavBangDiem.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavBangDiem.Click += new System.EventHandler(this.btnNavBangDiem_Click);

            // --- Hồ sơ cá nhân (chỉ sinh viên) ---
            btnNavHoSo.Name = "btnNavHoSo";
            btnNavHoSo.Text = "Hồ sơ cá nhân";
            btnNavHoSo.Icon = QLDSV_HTC.UI.NavIcon.SinhVien;
            btnNavHoSo.Dock = System.Windows.Forms.DockStyle.Top;
            btnNavHoSo.Height = 42;
            btnNavHoSo.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavHoSo.Visible = false;
            btnNavHoSo.Click += new System.EventHandler(this.btnNavHoSo_Click);

            // Thứ tự Dock.Top: add theo thứ tự ngược
            pnlSidebarNav.Controls.Add(btnNavBangDiem);
            pnlSidebarNav.Controls.Add(btnNavNhapDiem);
            pnlSidebarNav.Controls.Add(btnNavLopTinChi);
            pnlSidebarNav.Controls.Add(btnNavGiangVien);
            pnlSidebarNav.Controls.Add(btnNavMonHoc);
            pnlSidebarNav.Controls.Add(btnNavSinhVien);
            pnlSidebarNav.Controls.Add(btnNavLop);
            pnlSidebarNav.Controls.Add(btnNavKhoa);
            pnlSidebarNav.Controls.Add(btnNavHoSo);
            pnlSidebarNav.Controls.Add(btnNavDashboard);

            // Sidebar Footer: đổi mật khẩu + đăng xuất
            pnlSidebarFooter.Name = "pnlSidebarFooter";
            pnlSidebarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlSidebarFooter.Height = 100;
            pnlSidebarFooter.BackColor = System.Drawing.Color.Transparent;
            pnlSidebarFooter.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);

            btnNavDoiMatKhau.Name = "btnNavDoiMatKhau";
            btnNavDoiMatKhau.Text = "Đổi mật khẩu";
            btnNavDoiMatKhau.Icon = QLDSV_HTC.UI.NavIcon.DoiMatKhau;
            btnNavDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnNavDoiMatKhau.Height = 40;
            btnNavDoiMatKhau.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavDoiMatKhau.Click += new System.EventHandler(this.btnNavDoiMatKhau_Click);

            btnNavDangXuat.Name = "btnNavDangXuat";
            btnNavDangXuat.Text = "Đăng xuất";
            btnNavDangXuat.Icon = QLDSV_HTC.UI.NavIcon.Logout;
            btnNavDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnNavDangXuat.Height = 40;
            btnNavDangXuat.Font = QLDSV_HTC.UI.Palette.FontBase;
            btnNavDangXuat.Click += new System.EventHandler(this.btnNavDangXuat_Click);

            pnlSidebarFooter.Controls.Add(btnNavDoiMatKhau);
            pnlSidebarFooter.Controls.Add(btnNavDangXuat);

            // Lắp sidebar
            pnlSidebar.Controls.Add(pnlSidebarNav);
            pnlSidebar.Controls.Add(pnlSidebarFooter);
            pnlSidebar.Controls.Add(pnlSidebarHeader);

            // ---- HEADER ----
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Height = 56;
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);

            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Text = "Tổng quan";
            lblPageTitle.Font = new System.Drawing.Font(QLDSV_HTC.UI.Palette.FontFamily, 14F, System.Drawing.FontStyle.Bold);
            lblPageTitle.ForeColor = QLDSV_HTC.UI.Palette.Navy;
            lblPageTitle.Location = new System.Drawing.Point(24, 14);
            lblPageTitle.AutoSize = true;

            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Text = "";
            lblNguoiDung.Font = QLDSV_HTC.UI.Palette.FontSmall;
            lblNguoiDung.ForeColor = QLDSV_HTC.UI.Palette.Muted;
            lblNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblNguoiDung.AutoSize = false;
            lblNguoiDung.Size = new System.Drawing.Size(500, 56);

            // Ảnh đại diện nhỏ trên thanh tài khoản (chỉ hiện với sinh viên)
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new System.Drawing.Size(36, 36);
            picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picAvatar.BackColor = QLDSV_HTC.UI.Palette.PrimarySoft;
            picAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picAvatar.Visible = false;
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Controls.Add(lblNguoiDung);
            pnlHeader.Controls.Add(picAvatar);
            pnlHeader.Paint += PnlHeader_Paint;

            // ---- CONTENT ----
            pnlContent.Name = "pnlContent";
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.BackColor = QLDSV_HTC.UI.Palette.Canvas;
            pnlContent.Padding = new System.Windows.Forms.Padding(0);

            // Lắp vào form
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlSidebar);

            // ---- FORM ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1024, 680);
            this.Text = "Quản lý sinh viên — UTC Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);

            pnlSidebar.ResumeLayout(false);
            pnlSidebarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlSidebarNav.ResumeLayout(false);
            pnlSidebarFooter.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
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
        private QLDSV_HTC.UI.SidebarButton btnNavHoSo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlSidebarFooter;
        private QLDSV_HTC.UI.SidebarButton btnNavDoiMatKhau;
        private QLDSV_HTC.UI.SidebarButton btnNavDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Panel pnlContent;
    }
}
