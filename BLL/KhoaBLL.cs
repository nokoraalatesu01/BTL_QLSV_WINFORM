using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public static class KhoaBLL
{
    /// <summary>PGV thấy mọi khoa; tài khoản KHOA chỉ thấy khoa của mình.</summary>
    public static List<Khoa> LayDanhSach()
    {
        Quyen.Yeu(ChucNang.Khoa, HanhDong.Xem);
        return KhoaDAL.LayTatCa(Quyen.PhamViKhoa);
    }

    /// <summary>Thêm khoa và tự tạo tài khoản đăng nhập "khoa_[mã khoa]". Trả về tên đăng nhập đã tạo.</summary>
    public static string Them(Khoa input)
    {
        Quyen.Yeu(ChucNang.Khoa, HanhDong.Ghi);

        var k = new Khoa
        {
            MaKhoa = Validator.Code(input.MaKhoa, "Mã khoa", 10),
            TenKhoa = Validator.Required(input.TenKhoa, "Tên khoa", 50),
        };

        if (KhoaDAL.TonTai(k.MaKhoa))
            throw new BusinessException($"Mã khoa '{k.MaKhoa}' đã tồn tại.");

        var tenDangNhap = "khoa_" + k.MaKhoa.ToLowerInvariant();
        if (TaiKhoanDAL.TonTai(tenDangNhap))
            throw new BusinessException($"Tên đăng nhập '{tenDangNhap}' (tài khoản của khoa) đã tồn tại.");

        var salt = PasswordHelper.NewSalt();
        var taiKhoan = new TaiKhoan
        {
            TenDangNhap = tenDangNhap,
            Salt = salt,
            MatKhauHash = PasswordHelper.Hash(salt, AppConstants.MatKhauMacDinh),
            VaiTro = VaiTro.KHOA,
            MaKhoa = k.MaKhoa,
            HoatDong = true,
        };

        KhoaDAL.Them(k, taiKhoan);
        return tenDangNhap;
    }

    public static void Sua(Khoa input)
    {
        Quyen.Yeu(ChucNang.Khoa, HanhDong.Ghi);

        var maKhoa = Validator.Required(input.MaKhoa, "Mã khoa", 10);
        var k = new Khoa
        {
            MaKhoa = maKhoa,
            TenKhoa = Validator.Required(input.TenKhoa, "Tên khoa", 50),
        };

        if (KhoaDAL.Sua(k) == 0)
            throw new BusinessException("Khoa không còn tồn tại (có thể đã bị xóa). Hãy tải lại danh sách.");
    }

    public static void Xoa(string? maKhoa)
    {
        Quyen.Yeu(ChucNang.Khoa, HanhDong.Ghi);

        var ma = Validator.Required(maKhoa, "Mã khoa", 10);
        var (lop, giangVien, lopTinChi) = KhoaDAL.DemThamChieu(ma);
        if (lop + giangVien + lopTinChi > 0)
            throw new BusinessException(
                $"Không thể xóa khoa: còn {lop} lớp, {giangVien} giảng viên, {lopTinChi} lớp tín chỉ thuộc khoa này.");

        if (KhoaDAL.Xoa(ma) == 0)
            throw new BusinessException("Khoa không còn tồn tại (có thể đã bị xóa). Hãy tải lại danh sách.");
    }
}
