using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.DTO;
using BTL_QLSV_WINFORM.Helpers;

namespace BTL_QLSV_WINFORM.BLL
{
    public class AuthBLL
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public (bool Success, string Message, TaiKhoanDTO? User) DangNhap(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return (false, "Vui lòng nhập tên đăng nhập!", null);

            if (string.IsNullOrWhiteSpace(password))
                return (false, "Vui lòng nhập mật khẩu!", null);

            TaiKhoanDTO? user = taiKhoanDAL.KiemTraDangNhap(username.Trim(), password);
            if (user != null)
            {
                SessionManager.SetSession(user);
                return (true, "Đăng nhập thành công!", user);
            }

            return (false, "Tên đăng nhập hoặc mật khẩu không chính xác!", null);
        }

        public (bool Success, string Message) DoiMatKhau(string username, string matKhauCu, string matKhauMoi, string xacNhan)
        {
            if (string.IsNullOrWhiteSpace(matKhauCu))
                return (false, "Vui lòng nhập mật khẩu cũ!");

            if (string.IsNullOrWhiteSpace(matKhauMoi) || matKhauMoi.Length < 6)
                return (false, "Mật khẩu mới phải có tối thiểu 6 ký tự!");

            if (matKhauMoi != xacNhan)
                return (false, "Xác nhận mật khẩu không trùng khớp!");

            TaiKhoanDTO? user = taiKhoanDAL.KiemTraDangNhap(username, matKhauCu);
            if (user == null)
                return (false, "Mật khẩu cũ không chính xác!");

            bool ok = taiKhoanDAL.DoiMatKhau(username, matKhauMoi);
            return ok ? (true, "Đổi mật khẩu thành công!") : (false, "Đổi mật khẩu thất bại!");
        }
    }
}
