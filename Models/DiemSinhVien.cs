namespace QLDSV_HTC.Models;

/// <summary>Điểm của một sinh viên trong một lớp tín chỉ (bảng DANGKY).</summary>
public class DiemSinhVien
{
    public int MaLTC { get; set; }
    public string MaSV { get; set; } = "";
    public string HoTen { get; set; } = "";
    public string MaLop { get; set; } = "";

    /// <summary>Chuyên cần (số nguyên 0..10), null = chưa nhập.</summary>
    public decimal? DiemCC { get; set; }

    /// <summary>Giữa kỳ (0..10, bước 0.5), null = chưa nhập.</summary>
    public decimal? DiemGK { get; set; }

    /// <summary>Cuối kỳ (0..10, bước 0.5), null = chưa nhập.</summary>
    public decimal? DiemCK { get; set; }

    /// <summary>Tổng kết = CC×0.1 + GK×0.3 + CK×0.6 (null nếu thiếu điểm).</summary>
    public decimal? DiemTK { get; set; }
}
