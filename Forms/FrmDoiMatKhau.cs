using System;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

public partial class FrmDoiMatKhau : BaseForm
{
    public FrmDoiMatKhau()
    {
        InitializeComponent();
    }

    private void btnDoi_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(this.txtCu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMoi.Focus();
                return;
            }

            if (this.txtMoi.Text != this.txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtXacNhan.Focus();
                return;
            }

            AuthBLL.DoiMatKhau(this.txtCu.Text, this.txtMoi.Text, this.txtXacNhan.Text);
            MessageBox.Show("Đã đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
