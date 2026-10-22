using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;

namespace QLDSV_HTC.Forms;

public partial class FrmDangNhap : Form
{
    public FrmDangNhap()
    {
        InitializeComponent();
    }

    private void btnDangNhap_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            AuthBLL.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            DialogResult = DialogResult.OK; // gán DialogResult sẽ tự đóng hộp thoại
        });
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }
}
