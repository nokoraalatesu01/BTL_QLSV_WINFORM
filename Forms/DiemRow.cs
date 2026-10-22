using System.Globalization;
using QLDSV_HTC.Helpers;

namespace QLDSV_HTC.Forms;

/// <summary>Một dòng trong lưới nhập điểm; điểm giữ dạng chuỗi để người dùng gõ tự do rồi mới kiểm tra.</summary>
public sealed class DiemRow
{
    private string _cc = "";
    private string _gk = "";
    private string _ck = "";

    public string MaSV { get; set; } = "";
    public string HoTen { get; set; } = "";
    public string MaLop { get; set; } = "";

    public string CC { get => _cc; set => _cc = (value ?? "").Trim(); }
    public string GK { get => _gk; set => _gk = (value ?? "").Trim(); }
    public string CK { get => _ck; set => _ck = (value ?? "").Trim(); }

    /// <summary>Tổng kết = CC×0.1 + GK×0.3 + CK×0.6; rỗng nếu thiếu điểm hoặc có điểm sai.</summary>
    public string TongKet
    {
        get
        {
            if (FrmNhapDiem.KiemTraCC(CC, out var cc) != null
                || FrmNhapDiem.KiemTraGKCK(GK, "Giữa kỳ", out var gk) != null
                || FrmNhapDiem.KiemTraGKCK(CK, "Cuối kỳ", out var ck) != null)
                return "";

            var tk = DiemHelper.TinhTongKet((int?)cc, gk, ck);
            return tk.HasValue ? tk.Value.ToString("0.00", CultureInfo.InvariantCulture) : "";
        }
    }
}
