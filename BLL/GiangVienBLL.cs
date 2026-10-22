using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public static class GiangVienBLL
{
    public static List<GiangVien> Tim(string? keyword)
    {
        Quyen.Yeu(ChucNang.GiangVien, HanhDong.Xem);
        return GiangVienDAL.Tim(keyword, Quyen.PhamViKhoa);
    }

    /// <summary>Danh sách khoa để chọn (tài khoản KHOA chỉ thấy khoa của mình).</summary>
    public static List<Khoa> LayKhoaChoChon()
    {
        Quyen.Yeu(ChucNang.GiangVien, HanhDong.Xem);
        return KhoaDAL.LayTatCa(Quyen.PhamViKhoa);
    }

    private static GiangVien KiemTra(GiangVien input)
    {
        var g = new GiangVien
        {
            MaGV = Validator.Code(input.MaGV, "Mã giảng viên", 10),
            Ho = Validator.Required(input.Ho, "Họ", 50),
            Ten = Validator.Required(input.Ten, "Tên", 20),
            HocVi = Validator.Optional(input.HocVi, "Học vị", 20),
            HocHam = Validator.Optional(input.HocHam, "Học hàm", 20),
            ChuyenMon = Validator.Optional(input.ChuyenMon, "Chuyên môn", 50),
            MaKhoa = Validator.Required(input.MaKhoa, "Khoa", 10),
        };

        Quyen.YeuKhoa(g.MaKhoa);
        if (!KhoaDAL.TonTai(g.MaKhoa))
            throw new BusinessException("Khoa đã chọn không tồn tại.");
        return g;
    }

    /// <summary>Thêm giảng viên và tự tạo tài khoản (tên đăng nhập = mã GV, mật khẩu mặc định).</summary>
    public static void Them(GiangVien input)
    {
        Quyen.Yeu(ChucNang.GiangVien, HanhDong.Ghi);
        var g = KiemTra(input);

        if (GiangVienDAL.TonTai(g.MaGV))
            throw new BusinessException($"Mã giảng viên '{g.MaGV}' đã tồn tại.");
        if (TaiKhoanDAL.TonTai(g.MaGV))
            throw new BusinessException($"Tên đăng nhập '{g.MaGV}' đã được dùng cho tài khoản khác.");

        var salt = PasswordHelper.NewSalt();
        var taiKhoan = new TaiKhoan
        {
            TenDangNhap = g.MaGV,
            Salt = salt,
            MatKhauHash = PasswordHelper.Hash(salt, AppConstants.MatKhauMacDinh),
            VaiTro = VaiTro.GV,
            MaGV = g.MaGV,
            HoatDong = true,
        };

        GiangVienDAL.Them(g, taiKhoan);
    }

    public static void Sua(GiangVien input)
    {
        Quyen.Yeu(ChucNang.GiangVien, HanhDong.Ghi);
        var g = KiemTra(input);

        var cu = GiangVienDAL.LayTheoMa(g.MaGV)
                 ?? throw new BusinessException("Giảng viên không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        if (cu.MaKhoa != g.MaKhoa && GiangVienDAL.DemLopTinChi(g.MaGV) > 0)
            throw new BusinessException("Không thể chuyển khoa: giảng viên đang phụ trách lớp tín chỉ của khoa hiện tại.");

        if (GiangVienDAL.Sua(g) == 0)
            throw new BusinessException("Giảng viên không còn tồn tại. Hãy tải lại danh sách.");
    }

    public static void Xoa(string? maGV)
    {
        Quyen.Yeu(ChucNang.GiangVien, HanhDong.Ghi);
        var ma = Validator.Required(maGV, "Mã giảng viên", 10);

        var cu = GiangVienDAL.LayTheoMa(ma)
                 ?? throw new BusinessException("Giảng viên không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        int soLtc = GiangVienDAL.DemLopTinChi(ma);
        if (soLtc > 0)
            throw new BusinessException($"Không thể xóa: giảng viên đang phụ trách {soLtc} lớp tín chỉ.");

        GiangVienDAL.Xoa(ma);
    }
}
