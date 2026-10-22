namespace QLDSV_HTC.Models;

public class LopTinChi
{
    public int MaLTC { get; set; }
    public string NienKhoa { get; set; } = "";
    public int HocKy { get; set; }
    public string MaMH { get; set; } = "";
    public string TenMH { get; set; } = "";
    public int Nhom { get; set; }
    public string MaGV { get; set; } = "";
    public string TenGV { get; set; } = "";
    public string MaKhoa { get; set; } = "";
    public int SoSVToiThieu { get; set; }
    public bool HuyLop { get; set; }

    /// <summary>Số sinh viên hiện có trong lớp (đăng ký chưa hủy).</summary>
    public int SoSV { get; set; }

    public string TrangThai => HuyLop ? "Đã hủy" : "Hoạt động";
    public string HienThi => $"{MaLTC} - {TenMH} - Nhóm {Nhom} ({TenGV})";
}
