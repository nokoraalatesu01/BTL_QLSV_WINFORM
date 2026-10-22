namespace QLDSV_HTC.Models;

public class GiangVien
{
    public string MaGV { get; set; } = "";
    public string Ho { get; set; } = "";
    public string Ten { get; set; } = "";
    public string? HocVi { get; set; }
    public string? HocHam { get; set; }
    public string? ChuyenMon { get; set; }
    public string MaKhoa { get; set; } = "";
    public string TenKhoa { get; set; } = "";

    public string HoTen => $"{Ho} {Ten}".Trim();
    public string HienThi => $"{MaGV} - {HoTen}";
}
