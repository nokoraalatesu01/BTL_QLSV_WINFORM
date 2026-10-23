using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public enum ChucNang
{
    Khoa,
    Lop,
    SinhVien,
    MonHoc,
    GiangVien,
    LopTinChi,
    NhapDiem,
    DiemCaNhan,

    /// <summary>Sinh viên xem/cập nhật hồ sơ của chính mình.</summary>
    HoSoCaNhan
}

public enum HanhDong
{
    /// <summary>Xem danh sách / tìm kiếm.</summary>
    Xem,

    /// <summary>Thêm, sửa, xóa (hoặc lưu điểm).</summary>
    Ghi
}

/// <summary>Người dùng đang đăng nhập trong phiên làm việc hiện tại.</summary>
public static class PhienLamViec
{
    public static NguoiDung? NguoiDungHienTai { get; private set; }

    public static void DangNhap(NguoiDung nguoiDung) => NguoiDungHienTai = nguoiDung;

    public static void DangXuat() => NguoiDungHienTai = null;
}

/// <summary>
/// Ma trận phân quyền. Giao diện dùng <see cref="CoQuyen"/> để ẩn/hiện chức năng,
/// còn mọi hàm ở tầng BLL gọi <see cref="Yeu"/> / <see cref="YeuKhoa"/> để chặn thật sự.
/// </summary>
public static class Quyen
{
    public static NguoiDung HienTai =>
        PhienLamViec.NguoiDungHienTai ?? throw new UnauthorizedAccessException("Bạn chưa đăng nhập.");

    public static bool CoQuyen(ChucNang chucNang, HanhDong hanhDong)
    {
        var nd = PhienLamViec.NguoiDungHienTai;
        if (nd == null) return false;

        switch (nd.VaiTro)
        {
            case VaiTro.PGV:
                // Phòng giáo vụ: toàn quyền trên mọi khoa; không có "điểm cá nhân".
                return chucNang != ChucNang.DiemCaNhan && chucNang != ChucNang.HoSoCaNhan;

            case VaiTro.KHOA:
                switch (chucNang)
                {
                    case ChucNang.Khoa:
                    case ChucNang.MonHoc:
                        return hanhDong == HanhDong.Xem;   // chỉ xem
                    case ChucNang.Lop:
                    case ChucNang.SinhVien:
                    case ChucNang.GiangVien:
                    case ChucNang.LopTinChi:
                    case ChucNang.NhapDiem:
                        return true;                       // đầy đủ, nhưng chỉ trong khoa của mình
                    default:
                        return false;
                }

            case VaiTro.GV:
                // Giảng viên: CHỈ chấm và xem điểm các lớp tín chỉ do mình phụ trách.
                // Phạm vi thu hẹp ở BLL (YeuLopTinChi / LocLopTinChi): đúng khoa và đúng giảng viên.
                return chucNang == ChucNang.NhapDiem;

            case VaiTro.SV:
                // Xem bảng điểm của mình; xem/cập nhật hồ sơ của mình (BLL luôn lấy MaSV từ phiên đăng nhập).
                return (chucNang == ChucNang.DiemCaNhan && hanhDong == HanhDong.Xem)
                       || chucNang == ChucNang.HoSoCaNhan;

            default:
                return false;
        }
    }

    public static void Yeu(ChucNang chucNang, HanhDong hanhDong)
    {
        _ = HienTai; // ném lỗi nếu chưa đăng nhập
        if (!CoQuyen(chucNang, hanhDong))
        {
            var viec = hanhDong == HanhDong.Xem ? "xem" : "thay đổi";
            throw new UnauthorizedAccessException($"Bạn không có quyền {viec} dữ liệu này.");
        }
    }

    /// <summary>Mã khoa bị giới hạn: tài khoản KHOA/GV trả về khoa của mình, PGV trả về null (không giới hạn).</summary>
    public static string? PhamViKhoa
    {
        get
        {
            var nd = HienTai;
            return nd.VaiTro is VaiTro.KHOA or VaiTro.GV ? nd.MaKhoa : null;
        }
    }

    /// <summary>PGV được thao tác trên mọi khoa; tài khoản KHOA/GV chỉ được thao tác trên khoa của mình.</summary>
    public static void YeuKhoa(string maKhoa)
    {
        var nd = HienTai;
        if (nd.VaiTro == VaiTro.PGV) return;

        if ((nd.VaiTro == VaiTro.KHOA || nd.VaiTro == VaiTro.GV)
            && string.Equals(nd.MaKhoa?.Trim(), (maKhoa ?? "").Trim(), StringComparison.OrdinalIgnoreCase))
            return;

        throw new UnauthorizedAccessException("Bạn chỉ được thao tác trên dữ liệu thuộc khoa của mình.");
    }

    /// <summary>
    /// Lớp tín chỉ có được thao tác không: đúng khoa; riêng GV còn phải là giảng viên phụ trách lớp đó.
    /// </summary>
    public static void YeuLopTinChi(LopTinChi ltc)
    {
        YeuKhoa(ltc.MaKhoa);
        var nd = HienTai;
        if (nd.VaiTro == VaiTro.GV
            && !string.Equals(nd.MaGV?.Trim(), (ltc.MaGV ?? "").Trim(), StringComparison.OrdinalIgnoreCase))
            throw new UnauthorizedAccessException("Bạn chỉ được thao tác trên lớp tín chỉ do mình phụ trách.");
    }

    /// <summary>Giữ lại các lớp tín chỉ được phép: GV chỉ thấy lớp của mình; vai trò khác không đổi.</summary>
    public static List<LopTinChi> LocLopTinChi(IEnumerable<LopTinChi> ds)
    {
        var nd = HienTai;
        if (nd.VaiTro != VaiTro.GV) return ds.ToList();
        return ds.Where(x => string.Equals(x.MaGV?.Trim(), nd.MaGV?.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
