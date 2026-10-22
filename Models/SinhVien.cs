namespace QLDSV_HTC.Models;

public class SinhVien
{
    public string MaSV { get; set; } = "";
    public string Ho { get; set; } = "";
    public string Ten { get; set; } = "";
    public string MaLop { get; set; } = "";
    public string TenLop { get; set; } = "";
    public string MaKhoa { get; set; } = "";

    /// <summary>"Nam" hoặc "Nữ" (cột GIOITINH, kiểu NVARCHAR).</summary>
    public string GioiTinh { get; set; } = "Nam";

    public string? DiaChi { get; set; }
    public DateTime? NgaySinh { get; set; }
    public bool DaNghiHoc { get; set; }

    public string HoTen => $"{Ho} {Ten}".Trim();
    public string TrangThai => DaNghiHoc ? "Đã nghỉ học" : "Đang học";
}
