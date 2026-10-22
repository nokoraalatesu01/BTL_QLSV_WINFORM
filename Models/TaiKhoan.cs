namespace QLDSV_HTC.Models;

public enum VaiTro
{
    PGV,
    KHOA,
    GV,
    SV
}

/// <summary>Bản ghi bảng TaiKhoan.</summary>
public class TaiKhoan
{
    public string TenDangNhap { get; set; } = "";
    public string MatKhauHash { get; set; } = "";
    public string Salt { get; set; } = "";
    public VaiTro VaiTro { get; set; }
    public string? MaKhoa { get; set; }
    public string? MaGV { get; set; }
    public string? MaSV { get; set; }
    public bool HoatDong { get; set; } = true;
}

/// <summary>Người dùng đang đăng nhập (không chứa mật khẩu/hash).</summary>
public class NguoiDung
{
    public string TenDangNhap { get; set; } = "";
    public VaiTro VaiTro { get; set; }
    /// <summary>Tài khoản KHOA: khoa quản lý. Tài khoản GV: khoa của giảng viên.</summary>
    public string? MaKhoa { get; set; }
    public string? MaGV { get; set; }
    public string? MaSV { get; set; }
    public string TenHienThi { get; set; } = "";

    public string VaiTroText => VaiTro switch
    {
        VaiTro.PGV => "Phòng giáo vụ",
        VaiTro.KHOA => "Khoa",
        VaiTro.GV => "Giảng viên",
        VaiTro.SV => "Sinh viên",
        _ => VaiTro.ToString(),
    };
}
