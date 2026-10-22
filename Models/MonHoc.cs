namespace QLDSV_HTC.Models;

public class MonHoc
{
    public string MaMH { get; set; } = "";
    public string TenMH { get; set; } = "";
    public int SoTietLT { get; set; }
    public int SoTietTH { get; set; }

    public int TongSoTiet => SoTietLT + SoTietTH;
    public string HienThi => $"{MaMH} - {TenMH}";
}
