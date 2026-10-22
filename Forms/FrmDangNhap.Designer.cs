#nullable disable
namespace QLDSV_HTC.Forms
{
    partial class FrmDangNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlLeft = new QLDSV_HTC.UI.GradientPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new QLDSV_HTC.UI.ModernButton();
            this.btnThoat = new QLDSV_HTC.UI.ModernButton();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            //
            // pnlLeft
            //
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 300;
            this.pnlLeft.StartColor = QLDSV_HTC.UI.Palette.Primary;
            this.pnlLeft.EndColor = QLDSV_HTC.UI.Palette.PrimaryDarker;
            this.pnlLeft.Decorations = true;
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.Controls.Add(this.lblTieuDe);
            //
            // picLogo
            //
            this.picLogo.Size = new System.Drawing.Size(120, 120);
            this.picLogo.Location = new System.Drawing.Point(90, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            //
            // lblTieuDe
            //
            this.lblTieuDe.AutoSize = false;
            this.lblTieuDe.Location = new System.Drawing.Point(20, 230);
            this.lblTieuDe.Size = new System.Drawing.Size(260, 60);
            this.lblTieuDe.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.ForeColor = QLDSV_HTC.UI.Palette.Surface;
            this.lblTieuDe.Font = QLDSV_HTC.UI.Palette.FontH2;
            //
            // lblDangNhap
            //
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Location = new System.Drawing.Point(340, 40);
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.Font = QLDSV_HTC.UI.Palette.FontH2;
            this.lblDangNhap.ForeColor = QLDSV_HTC.UI.Palette.Text;
            //
            // lblTenDangNhap
            //
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(340, 100);
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            //
            // txtTenDangNhap
            //
            this.txtTenDangNhap.Location = new System.Drawing.Point(340, 126);
            this.txtTenDangNhap.Size = new System.Drawing.Size(380, 30);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.TabIndex = 1;
            //
            // lblMatKhau
            //
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(340, 170);
            this.lblMatKhau.Text = "Mật khẩu:";
            //
            // txtMatKhau
            //
            this.txtMatKhau.Location = new System.Drawing.Point(340, 196);
            this.txtMatKhau.Size = new System.Drawing.Size(380, 30);
            this.txtMatKhau.MaxLength = 100;
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            //
            // btnDangNhap
            //
            this.btnDangNhap.Location = new System.Drawing.Point(340, 250);
            this.btnDangNhap.Size = new System.Drawing.Size(180, 40);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new System.Drawing.Point(540, 250);
            this.btnThoat.Size = new System.Drawing.Size(180, 40);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            //
            // lblGoiY
            //
            this.lblGoiY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGoiY.Location = new System.Drawing.Point(300, 390);
            this.lblGoiY.Size = new System.Drawing.Size(460, 70);
            this.lblGoiY.TabIndex = 6;
            this.lblGoiY.Text = "Tài khoản mẫu (mật khẩu 123456):\npgv  |  khoa_cntt  |  khoa_vt  |  N21CN001";
            this.lblGoiY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoiY.ForeColor = QLDSV_HTC.UI.Palette.Muted;
            this.lblGoiY.Font = QLDSV_HTC.UI.Palette.FontSmall;
            //
            // FrmDangNhap
            //
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(760, 460);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.lblDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblGoiY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Quản lý điểm sinh viên (QLDSV_HTC)";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private QLDSV_HTC.UI.GradientPanel pnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private QLDSV_HTC.UI.ModernButton btnDangNhap;
        private QLDSV_HTC.UI.ModernButton btnThoat;
        private System.Windows.Forms.Label lblGoiY;
    }
}
