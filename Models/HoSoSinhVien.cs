namespace QLDSV_HTC.Models;

/// <summary>Kiểu dữ liệu của một trường hồ sơ, dùng để kiểm tra đầu vào khi lưu.</summary>
public enum KieuTruong
{
    VanBan,
    Email,
    DienThoai
}

/// <summary>
/// Một dòng thông tin trong hồ sơ. Chỉ được tạo khi cột tương ứng THỰC SỰ tồn tại trong CSDL
/// (hoặc là dữ liệu chỉ-xem suy ra từ bảng Lop/Khoa).
/// </summary>
public class TruongHoSo
{
    public string Nhom { get; set; } = "";
    public string Ten { get; set; } = "";

    /// <summary>Tên cột thật trong bảng Sinhvien; null nếu là dữ liệu chỉ để xem (không có nơi lưu).</summary>
    public string? TenCot { get; set; }

    public bool CoTheSua { get; set; }
    public int DoDaiToiDa { get; set; } = 100;
    public KieuTruong Kieu { get; set; } = KieuTruong.VanBan;
    public string GiaTri { get; set; } = "";
}

/// <summary>Hồ sơ cá nhân của sinh viên đang đăng nhập (không chứa mật khẩu hay thông tin nhạy cảm).</summary>
public class HoSoSinhVien
{
    public string MaSV { get; set; } = "";
    public string Ho { get; set; } = "";
    public string Ten { get; set; } = "";
    public string MaLop { get; set; } = "";
    public string TenLop { get; set; } = "";
    public string TenKhoa { get; set; } = "";
    public DateTime? NgaySinh { get; set; }

    /// <summary>Số CMND/CCCD nếu CSDL có cột tương ứng và có dữ liệu; ngược lại null.</summary>
    public string? SoGiayTo { get; set; }
    public string NhanSoGiayTo { get; set; } = "CMND/CCCD";

    /// <summary>CSDL đã có cột ANHDAIDIEN (VARBINARY) để lưu ảnh hay chưa.</summary>
    public bool CoCotAnh { get; set; }
    public byte[]? Anh { get; set; }

    public List<TruongHoSo> Truong { get; } = new();

    public string HoTen => $"{Ho} {Ten}".Trim();
}
