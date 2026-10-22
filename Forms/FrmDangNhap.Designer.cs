#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmDangNhap
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
            picLogo = new PictureBox();
            pnlCard = new Panel();
            lblHeThong = new Label();
            lblDangNhap = new Label();
            pnlUserBox = new Panel();
            lblUserIcon = new Label();
            txtTenDangNhap = new TextBox();
            pnlPassBox = new Panel();
            lblPassIcon = new Label();
            txtMatKhau = new TextBox();
            btnTogglePass = new Button();
            lnkQuenMatKhau = new LinkLabel();
            lnkTroGiup = new LinkLabel();
            btnDangNhap = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlCard.SuspendLayout();
            pnlUserBox.SuspendLayout();
            pnlPassBox.SuspendLayout();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(210, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(680, 125);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(248, 250, 253);
            pnlCard.Controls.Add(lblHeThong);
            pnlCard.Controls.Add(lblDangNhap);
            pnlCard.Controls.Add(pnlUserBox);
            pnlCard.Controls.Add(pnlPassBox);
            pnlCard.Controls.Add(lnkQuenMatKhau);
            pnlCard.Controls.Add(lnkTroGiup);
            pnlCard.Controls.Add(btnDangNhap);
            pnlCard.Controls.Add(btnThoat);
            pnlCard.Location = new Point(240, 175);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(620, 478);
            pnlCard.TabIndex = 1;
            // 
            // lblHeThong
            // 
            lblHeThong.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeThong.ForeColor = Color.FromArgb(21, 48, 107);
            lblHeThong.Location = new Point(20, 28);
            lblHeThong.Name = "lblHeThong";
            lblHeThong.Size = new Size(580, 36);
            lblHeThong.TabIndex = 0;
            lblHeThong.Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            lblHeThong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDangNhap
            // 
            lblDangNhap.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblDangNhap.ForeColor = Color.FromArgb(21, 48, 107);
            lblDangNhap.Location = new Point(20, 68);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(580, 56);
            lblDangNhap.TabIndex = 1;
            lblDangNhap.Text = "ĐĂNG NHẬP";
            lblDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUserBox
            // 
            pnlUserBox.BackColor = Color.White;
            pnlUserBox.BorderStyle = BorderStyle.FixedSingle;
            pnlUserBox.Controls.Add(lblUserIcon);
            pnlUserBox.Controls.Add(txtTenDangNhap);
            pnlUserBox.Location = new Point(50, 138);
            pnlUserBox.Name = "pnlUserBox";
            pnlUserBox.Size = new Size(520, 54);
            pnlUserBox.TabIndex = 2;
            // 
            // lblUserIcon
            // 
            lblUserIcon.BackColor = Color.FromArgb(245, 247, 250);
            lblUserIcon.Dock = DockStyle.Left;
            lblUserIcon.Font = new Font("Segoe UI", 15F);
            lblUserIcon.ForeColor = Color.FromArgb(39, 75, 141);
            lblUserIcon.Location = new Point(0, 0);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(54, 52);
            lblUserIcon.TabIndex = 0;
            lblUserIcon.Text = "👤";
            lblUserIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.None;
            txtTenDangNhap.Font = new Font("Segoe UI", 13F);
            txtTenDangNhap.ForeColor = Color.FromArgb(30, 41, 59);
            txtTenDangNhap.Location = new Point(68, 13);
            txtTenDangNhap.MaxLength = 50;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tài khoản hoặc Email";
            txtTenDangNhap.Size = new Size(438, 29);
            txtTenDangNhap.TabIndex = 1;
            // 
            // pnlPassBox
            // 
            pnlPassBox.BackColor = Color.White;
            pnlPassBox.BorderStyle = BorderStyle.FixedSingle;
            pnlPassBox.Controls.Add(lblPassIcon);
            pnlPassBox.Controls.Add(txtMatKhau);
            pnlPassBox.Controls.Add(btnTogglePass);
            pnlPassBox.Location = new Point(50, 208);
            pnlPassBox.Name = "pnlPassBox";
            pnlPassBox.Size = new Size(520, 54);
            pnlPassBox.TabIndex = 3;
            // 
            // lblPassIcon
            // 
            lblPassIcon.BackColor = Color.FromArgb(245, 247, 250);
            lblPassIcon.Dock = DockStyle.Left;
            lblPassIcon.Font = new Font("Segoe UI", 15F);
            lblPassIcon.ForeColor = Color.FromArgb(39, 75, 141);
            lblPassIcon.Location = new Point(0, 0);
            lblPassIcon.Name = "lblPassIcon";
            lblPassIcon.Size = new Size(54, 52);
            lblPassIcon.TabIndex = 0;
            lblPassIcon.Text = "🔒";
            lblPassIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 13F);
            txtMatKhau.ForeColor = Color.FromArgb(30, 41, 59);
            txtMatKhau.Location = new Point(68, 13);
            txtMatKhau.MaxLength = 100;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            txtMatKhau.Size = new Size(395, 29);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnTogglePass
            // 
            btnTogglePass.BackColor = Color.Transparent;
            btnTogglePass.Cursor = Cursors.Hand;
            btnTogglePass.FlatAppearance.BorderSize = 0;
            btnTogglePass.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTogglePass.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTogglePass.FlatStyle = FlatStyle.Flat;
            btnTogglePass.Font = new Font("Segoe UI", 13F);
            btnTogglePass.ForeColor = Color.FromArgb(100, 116, 139);
            btnTogglePass.Location = new Point(470, 8);
            btnTogglePass.Name = "btnTogglePass";
            btnTogglePass.Size = new Size(42, 38);
            btnTogglePass.TabIndex = 2;
            btnTogglePass.Text = "👁";
            btnTogglePass.UseVisualStyleBackColor = false;
            btnTogglePass.Click += btnTogglePass_Click;
            // 
            // lnkQuenMatKhau
            // 
            lnkQuenMatKhau.ActiveLinkColor = Color.FromArgb(37, 99, 235);
            lnkQuenMatKhau.AutoSize = true;
            lnkQuenMatKhau.Font = new Font("Segoe UI", 11F);
            lnkQuenMatKhau.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkQuenMatKhau.LinkColor = Color.FromArgb(30, 58, 138);
            lnkQuenMatKhau.Location = new Point(50, 276);
            lnkQuenMatKhau.Name = "lnkQuenMatKhau";
            lnkQuenMatKhau.Size = new Size(150, 25);
            lnkQuenMatKhau.TabIndex = 4;
            lnkQuenMatKhau.TabStop = true;
            lnkQuenMatKhau.Text = "Quên mật khẩu?";
            lnkQuenMatKhau.LinkClicked += lnkQuenMatKhau_LinkClicked;
            // 
            // lnkTroGiup
            // 
            lnkTroGiup.ActiveLinkColor = Color.FromArgb(37, 99, 235);
            lnkTroGiup.AutoSize = true;
            lnkTroGiup.Font = new Font("Segoe UI", 11F);
            lnkTroGiup.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkTroGiup.LinkColor = Color.FromArgb(30, 58, 138);
            lnkTroGiup.Location = new Point(468, 276);
            lnkTroGiup.Name = "lnkTroGiup";
            lnkTroGiup.Size = new Size(112, 25);
            lnkTroGiup.TabIndex = 5;
            lnkTroGiup.TabStop = true;
            lnkTroGiup.Text = "❓ Trợ giúp!";
            lnkTroGiup.LinkClicked += lnkTroGiup_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(39, 75, 141);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(50, 318);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(520, 56);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(241, 245, 249);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(71, 85, 105);
            btnThoat.Location = new Point(50, 390);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(520, 48);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 46, 112);
            CancelButton = btnThoat;
            ClientSize = new Size(1100, 750);
            Controls.Add(pnlCard);
            Controls.Add(picLogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống - Quản lý sinh viên";
            WindowState = FormWindowState.Maximized;
            Load += FrmDangNhap_Load;
            Resize += FrmDangNhap_Resize;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlUserBox.ResumeLayout(false);
            pnlUserBox.PerformLayout();
            pnlPassBox.ResumeLayout(false);
            pnlPassBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblHeThong;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Panel pnlUserBox;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Panel pnlPassBox;
        private System.Windows.Forms.Label lblPassIcon;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnTogglePass;
        private System.Windows.Forms.LinkLabel lnkQuenMatKhau;
        private System.Windows.Forms.LinkLabel lnkTroGiup;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}
