using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using QLDSV_HTC.BLL;

namespace QLDSV_HTC.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            this.TaiHinhAnhGiaoDien();
            this.CanGiuaGiaoDien();
        }

        private void FrmDangNhap_Resize(object sender, EventArgs e)
        {
            this.CanGiuaGiaoDien();
        }

        private void CanGiuaGiaoDien()
        {
            if (this.pnlCard != null && this.picLogo != null)
            {
                // Căn giữa thẻ đăng nhập trên toàn màn hình
                int cardX = (this.ClientSize.Width - this.pnlCard.Width) / 2;
                int cardY = (this.ClientSize.Height - this.pnlCard.Height) / 2 + 50;
                if (cardY < 155) cardY = 155;
                this.pnlCard.Location = new Point(cardX, cardY);

                // Căn giữa logo trường phía trên thẻ đăng nhập
                int logoX = (this.ClientSize.Width - this.picLogo.Width) / 2;
                int logoY = cardY - this.picLogo.Height - 20;
                if (logoY < 15) logoY = 15;
                this.picLogo.Location = new Point(logoX, logoY);
            }
        }

        private void TaiHinhAnhGiaoDien()
        {
            try
            {
                // Nạp hình nền
                var bg = LayHinhAnh("bg-login.jpg");
                if (bg != null)
                {
                    this.BackgroundImage = bg;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }

                // Nạp Logo trường ĐH Giao Thông Vận Tải
                var logo = LayHinhAnh("logo_login.png");
                if (logo != null)
                {
                    this.picLogo.Image = logo;
                }
            }
            catch
            {
                // Nếu không nạp được hình ảnh thì giao diện vẫn hiển thị đẹp mắt
            }
        }

        private static Image? LayHinhAnh(string tenTep)
        {
            try
            {
                string[] cacDuongDan = new string[]
                {
                    Path.Combine(Application.StartupPath, "Resources", "img", tenTep),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "img", tenTep),
                    Path.Combine(Directory.GetCurrentDirectory(), "Resources", "img", tenTep),
                    Path.Combine(Application.StartupPath, "..", "..", "..", "Resources", "img", tenTep)
                };

                foreach (var duongDan in cacDuongDan)
                {
                    if (File.Exists(duongDan))
                    {
                        using (var fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read))
                        {
                            return Image.FromStream(fs);
                        }
                    }
                }
            }
            catch { }
            return null;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtTenDangNhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTenDangNhap.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtMatKhau.Focus();
                    return;
                }

                AuthBLL.DangNhap(this.txtTenDangNhap.Text.Trim(), this.txtMatKhau.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnTogglePass_Click(object sender, EventArgs e)
        {
            this.txtMatKhau.UseSystemPasswordChar = !this.txtMatKhau.UseSystemPasswordChar;
            this.btnTogglePass.Text = this.txtMatKhau.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void lnkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ Văn phòng Khoa hoặc Quản trị viên phòng Đào tạo để được hỗ trợ cấp lại mật khẩu tài khoản.", "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkTroGiup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string huongDan = "HƯỚNG DẪN ĐĂNG NHẬP:\n\n" +
                              "- Quản trị viên: Tên đăng nhập = admin\n" +
                              "- Khoa: Tên đăng nhập = Mã khoa (VD: CNTT)\n" +
                              "- Giảng viên: Tên đăng nhập = Mã giảng viên\n" +
                              "- Sinh viên: Tên đăng nhập = Mã sinh viên\n\n" +
                              "Mật khẩu mặc định khởi tạo: 123456";
            MessageBox.Show(huongDan, "Trợ giúp đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
