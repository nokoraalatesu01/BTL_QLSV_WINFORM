using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public static class SinhVienBLL
{
    /// <summary>Danh sách lớp để chọn trong ComboBox (tài khoản KHOA chỉ thấy lớp của khoa mình).</summary>
    public static List<Lop> LayLopChoChon()
    {
        Quyen.Yeu(ChucNang.SinhVien, HanhDong.Xem);
        return LopDAL.Tim(null, Quyen.PhamViKhoa);
    }

    public static List<SinhVien> Tim(string? keyword, string? maLop)
    {
        Quyen.Yeu(ChucNang.SinhVien, HanhDong.Xem);
        var ml = string.IsNullOrWhiteSpace(maLop) ? null : maLop.Trim();
        return SinhVienDAL.Tim(keyword, Quyen.PhamViKhoa, ml);
    }

    private static SinhVien KiemTra(SinhVien input)
    {
        var sv = new SinhVien
        {
            MaSV = Validator.Code(input.MaSV, "Mã sinh viên", 10),
            Ho = Validator.Required(input.Ho, "Họ", 50),
            Ten = Validator.Required(input.Ten, "Tên", 20),
            MaLop = Validator.Required(input.MaLop, "Lớp", 10),
            GioiTinh = Validator.GioiTinh(input.GioiTinh),
            DiaChi = Validator.Optional(input.DiaChi, "Địa chỉ", 100),
            NgaySinh = input.NgaySinh?.Date,
            DaNghiHoc = input.DaNghiHoc,
        };

        if (sv.NgaySinh.HasValue)
        {
            if (sv.NgaySinh.Value > DateTime.Today)
                throw new BusinessException("Ngày sinh không được ở tương lai.");
            if (sv.NgaySinh.Value.Year < 1950)
                throw new BusinessException("Ngày sinh không hợp lý (trước năm 1950).");
        }

        var lop = LopDAL.LayTheoMa(sv.MaLop)
                  ?? throw new BusinessException("Lớp đã chọn không tồn tại.");
        Quyen.YeuKhoa(lop.MaKhoa);
        sv.MaKhoa = lop.MaKhoa;
        return sv;
    }

    /// <summary>Thêm sinh viên và tự tạo tài khoản (tên đăng nhập = mã SV, mật khẩu mặc định).</summary>
    public static void Them(SinhVien input)
    {
        Quyen.Yeu(ChucNang.SinhVien, HanhDong.Ghi);
        var sv = KiemTra(input);

        if (SinhVienDAL.TonTai(sv.MaSV))
            throw new BusinessException($"Mã sinh viên '{sv.MaSV}' đã tồn tại.");
        if (TaiKhoanDAL.TonTai(sv.MaSV))
            throw new BusinessException($"Tên đăng nhập '{sv.MaSV}' đã được dùng cho tài khoản khác.");

        var salt = PasswordHelper.NewSalt();
        var taiKhoan = new TaiKhoan
        {
            TenDangNhap = sv.MaSV,
            Salt = salt,
            MatKhauHash = PasswordHelper.Hash(salt, AppConstants.MatKhauMacDinh),
            VaiTro = VaiTro.SV,
            MaSV = sv.MaSV,
            HoatDong = true,
        };

        SinhVienDAL.Them(sv, taiKhoan);
    }

    public static void Sua(SinhVien input)
    {
        Quyen.Yeu(ChucNang.SinhVien, HanhDong.Ghi);
        var sv = KiemTra(input);

        var cu = SinhVienDAL.LayTheoMa(sv.MaSV)
                 ?? throw new BusinessException("Sinh viên không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        if (SinhVienDAL.Sua(sv) == 0)
            throw new BusinessException("Sinh viên không còn tồn tại. Hãy tải lại danh sách.");
    }

    public static void Xoa(string? maSV)
    {
        Quyen.Yeu(ChucNang.SinhVien, HanhDong.Ghi);
        var ma = Validator.Required(maSV, "Mã sinh viên", 10);

        var cu = SinhVienDAL.LayTheoMa(ma)
                 ?? throw new BusinessException("Sinh viên không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        int soDangKy = SinhVienDAL.DemDangKy(ma);
        if (soDangKy > 0)
            throw new BusinessException(
                $"Không thể xóa: sinh viên đã có {soDangKy} lớp tín chỉ/điểm. Hãy đánh dấu 'Đã nghỉ học' thay vì xóa.");

        SinhVienDAL.Xoa(ma);
    }
}
