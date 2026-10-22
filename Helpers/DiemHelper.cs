using System.Globalization;

namespace QLDSV_HTC.Helpers;

/// <summary>Quy tắc tính và kiểm tra điểm.</summary>
public static class DiemHelper
{
    public const decimal HeSoCC = 0.1m;
    public const decimal HeSoGK = 0.3m;
    public const decimal HeSoCK = 0.6m;

    /// <summary>Điểm tổng kết = CC×0.1 + GK×0.3 + CK×0.6; null nếu thiếu một trong ba điểm.</summary>
    public static decimal? TinhTongKet(int? cc, decimal? gk, decimal? ck)
    {
        if (!cc.HasValue || !gk.HasValue || !ck.HasValue) return null;
        return Math.Round(cc.Value * HeSoCC + gk.Value * HeSoGK + ck.Value * HeSoCK, 2, MidpointRounding.AwayFromZero);
    }

    /// <summary>Điểm trong khoảng 0–10; nếu buocNuaDiem thì phải là bội số của 0.5.</summary>
    public static bool LaDiemHopLe(decimal diem, bool buocNuaDiem)
    {
        if (diem < 0m || diem > 10m) return false;
        return !buocNuaDiem || diem * 2m == decimal.Truncate(diem * 2m);
    }

    /// <summary>
    /// Đọc điểm từ chuỗi (chấp nhận cả '.' và ','). Chuỗi rỗng =&gt; thành công với value = null.
    /// Trả về false nếu không phải số hợp lệ.
    /// </summary>
    public static bool TryParse(string? text, out decimal? value)
    {
        value = null;
        var s = (text ?? "").Trim();
        if (s.Length == 0) return true;
        s = s.Replace(',', '.');
        if (!decimal.TryParse(s, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var d))
            return false;
        value = d;
        return true;
    }
}
