using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;

namespace QLDSV_HTC.Forms;

public partial class FrmDoiMatKhau : Form
{
    public FrmDoiMatKhau()
    {
        InitializeComponent();
    }

    private void btnDoi_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            AuthBLL.DoiMatKhau(txtCu.Text, txtMoi.Text, txtXacNhan.Text);
            UiHelper.ShowInfo("Đã đổi mật khẩu thành công.");
            Close();
        });
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        Close();
    }
}
