namespace QLDSV_HTC.Models;

/// <summary>Một dòng trong bảng điểm cá nhân của sinh viên.</summary>
public class BangDiemDong
{
    public int MaLTC { get; set; }
    public string NienKhoa { get; set; } = "";
    public int HocKy { get; set; }
    public string MaMH { get; set; } = "";
    public string TenMH { get; set; } = "";
    public int Nhom { get; set; }
    public decimal? DiemCC { get; set; }
    public decimal? DiemGK { get; set; }
    public decimal? DiemCK { get; set; }
    public decimal? DiemTK { get; set; }
}
