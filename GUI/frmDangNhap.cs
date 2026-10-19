using System;
using System.Drawing;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.BLL;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.Helpers;

namespace BTL_QLSV_WINFORM.GUI
{
    public partial class frmDangNhap : Form
    {
        private AuthBLL authBLL = new AuthBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (DataBaseProcess.IsUsingSqlServer)
            {
                lblTrangThaiDB.Text = "● Đang kết nối: SQL Server (Trực tuyến)";
                lblTrangThaiDB.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThaiDB.Text = "● Đang chạy chế độ: Dữ liệu Cục bộ (Local Mode)";
                lblTrangThaiDB.ForeColor = Color.DarkOrange;
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            var result = authBLL.DangNhap(username, password);
            if (result.Success)
            {
                MessageBox.Show($"Chào mừng {result.User?.HoTen} ({result.User?.Quyen})!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain main = new frmMain();
                main.FormClosed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show(result.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
