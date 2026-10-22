namespace QLDSV_HTC.Models;

public class Lop
{
    public string MaLop { get; set; } = "";
    public string TenLop { get; set; } = "";
    public string KhoaHoc { get; set; } = "";
    public string MaKhoa { get; set; } = "";
    public string TenKhoa { get; set; } = "";

    public string HienThi => $"{MaLop} - {TenLop}";
}
