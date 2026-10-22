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
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lblGoiY = new Label();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(566, 80);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(39, 129);
            lblTenDangNhap.Margin = new Padding(4, 0, 4, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(128, 23);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            lblTenDangNhap.Click += lblTenDangNhap_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(193, 123);
            txtTenDangNhap.Margin = new Padding(4, 5, 4, 5);
            txtTenDangNhap.MaxLength = 50;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(320, 30);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(39, 190);
            lblMatKhau.Margin = new Padding(4, 0, 4, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(193, 184);
            txtMatKhau.Margin = new Padding(4, 5, 4, 5);
            txtMatKhau.MaxLength = 100;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(320, 30);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(244, 255);
            btnDangNhap.Margin = new Padding(4, 5, 4, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(129, 49);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(386, 255);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 49);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblGoiY
            // 
            lblGoiY.Dock = DockStyle.Bottom;
            lblGoiY.ForeColor = Color.DimGray;
            lblGoiY.Location = new Point(0, 343);
            lblGoiY.Margin = new Padding(4, 0, 4, 0);
            lblGoiY.Name = "lblGoiY";
            lblGoiY.Size = new Size(566, 71);
            lblGoiY.TabIndex = 6;
            lblGoiY.Text = "Tài khoản mẫu (mật khẩu 123456):\npgv  |  khoa_cntt  |  khoa_vt  |  N21CN001";
            lblGoiY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(566, 414);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(lblGoiY);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Quản lý điểm sinh viên (QLDSV_HTC)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblGoiY;
    }
}
