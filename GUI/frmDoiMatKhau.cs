using System;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.BLL;
using BTL_QLSV_WINFORM.Helpers;

namespace BTL_QLSV_WINFORM.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        private AuthBLL authBLL = new AuthBLL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser != null)
            {
                txtTenDangNhap.Text = SessionManager.CurrentUser.TenDangNhap;
            }
            else
            {
                txtTenDangNhap.Text = "admin";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string passCu = txtMatKhauCu.Text.Trim();
            string passMoi = txtMatKhauMoi.Text.Trim();
            string xacNhan = txtXacNhan.Text.Trim();

            var result = authBLL.DoiMatKhau(user, passCu, passMoi, xacNhan);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
