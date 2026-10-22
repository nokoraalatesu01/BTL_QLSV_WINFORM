using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public static class AuthBLL
{
    public static NguoiDung DangNhap(string? tenDangNhap, string? matKhau)
    {
        var ten = Validator.Required(tenDangNhap, "Tên đăng nhập", 50);
        if (string.IsNullOrEmpty(matKhau))
            throw new BusinessException("Mật khẩu không được để trống.");

        var tk = TaiKhoanDAL.LayTheoTen(ten);
        if (tk == null || !tk.HoatDong || !PasswordHelper.Verify(tk.Salt, matKhau, tk.MatKhauHash))
            throw new BusinessException("Tên đăng nhập hoặc mật khẩu không đúng.");

        var nd = new NguoiDung
        {
            TenDangNhap = tk.TenDangNhap,
            VaiTro = tk.VaiTro,
            MaKhoa = tk.MaKhoa,
            MaGV = tk.MaGV,
            MaSV = tk.MaSV,
            TenHienThi = tk.TenDangNhap,
        };

        if (tk.VaiTro == VaiTro.KHOA && tk.MaKhoa != null)
        {
            var khoa = KhoaDAL.LayTheoMa(tk.MaKhoa);
            nd.TenHienThi = khoa != null ? "Khoa " + khoa.TenKhoa : tk.TenDangNhap;
        }
        else if (tk.VaiTro == VaiTro.GV && tk.MaGV != null)
        {
            // Giảng viên bị giới hạn trong khoa của mình (và chỉ các lớp tín chỉ mình phụ trách).
            var gv = GiangVienDAL.LayTheoMa(tk.MaGV)
                     ?? throw new BusinessException("Tài khoản giảng viên không còn hợp lệ (giảng viên đã bị xóa).");
            nd.MaKhoa = gv.MaKhoa;
            nd.TenHienThi = "GV " + gv.HoTen;
        }
        else if (tk.VaiTro == VaiTro.SV && tk.MaSV != null)
        {
            var sv = SinhVienDAL.LayTheoMa(tk.MaSV);
            nd.TenHienThi = sv != null ? sv.HoTen : tk.TenDangNhap;
        }
        else if (tk.VaiTro == VaiTro.PGV)
        {
            nd.TenHienThi = "Phòng giáo vụ";
        }

        PhienLamViec.DangNhap(nd);
        return nd;
    }

    public static void DangXuat() => PhienLamViec.DangXuat();

    public static void DoiMatKhau(string? matKhauCu, string? matKhauMoi, string? xacNhan)
    {
        var nd = Quyen.HienTai;

        if (string.IsNullOrEmpty(matKhauCu))
            throw new BusinessException("Hãy nhập mật khẩu hiện tại.");
        if (string.IsNullOrEmpty(matKhauMoi) || matKhauMoi.Length < AppConstants.MatKhauToiThieu)
            throw new BusinessException($"Mật khẩu mới phải có ít nhất {AppConstants.MatKhauToiThieu} ký tự.");
        if (matKhauMoi.Length > 100)
            throw new BusinessException("Mật khẩu mới tối đa 100 ký tự.");
        if (matKhauMoi != xacNhan)
            throw new BusinessException("Mật khẩu mới và phần xác nhận không khớp.");
        if (matKhauMoi == matKhauCu)
            throw new BusinessException("Mật khẩu mới phải khác mật khẩu hiện tại.");

        var tk = TaiKhoanDAL.LayTheoTen(nd.TenDangNhap);
        if (tk == null || !tk.HoatDong)
            throw new BusinessException("Tài khoản không còn hợp lệ.");
        if (!PasswordHelper.Verify(tk.Salt, matKhauCu, tk.MatKhauHash))
            throw new BusinessException("Mật khẩu hiện tại không đúng.");

        var salt = PasswordHelper.NewSalt();
        var hash = PasswordHelper.Hash(salt, matKhauMoi);
        if (TaiKhoanDAL.DoiMatKhau(nd.TenDangNhap, hash, salt) == 0)
            throw new BusinessException("Không cập nhật được mật khẩu.");
    }
}
