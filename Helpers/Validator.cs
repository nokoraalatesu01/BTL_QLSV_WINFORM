using System.Text.RegularExpressions;

namespace QLDSV_HTC.Helpers;

/// <summary>Kiểm tra dữ liệu đầu vào; ném BusinessException với thông báo tiếng Việt.</summary>
public static class Validator
{
    private static readonly Regex CodeRegex = new(@"^[A-Za-z0-9_\-]+$", RegexOptions.Compiled);
    private static readonly Regex NienKhoaRegex = new(@"^(\d{4})-(\d{4})$", RegexOptions.Compiled);

    public static string Required(string? value, string fieldName, int maxLength)
    {
        var v = (value ?? "").Trim();
        if (v.Length == 0)
            throw new BusinessException($"{fieldName} không được để trống.");
        if (v.Length > maxLength)
            throw new BusinessException($"{fieldName} tối đa {maxLength} ký tự.");
        return v;
    }

    public static string? Optional(string? value, string fieldName, int maxLength)
    {
        var v = (value ?? "").Trim();
        if (v.Length == 0) return null;
        if (v.Length > maxLength)
            throw new BusinessException($"{fieldName} tối đa {maxLength} ký tự.");
        return v;
    }

    /// <summary>Mã (khóa chính): bắt buộc, chỉ gồm chữ, số, '_' và '-', tự chuyển thành chữ hoa.</summary>
    public static string Code(string? value, string fieldName, int maxLength)
    {
        var v = Required(value, fieldName, maxLength);
        if (!CodeRegex.IsMatch(v))
            throw new BusinessException($"{fieldName} chỉ được chứa chữ cái không dấu, chữ số, '_' hoặc '-' (không có khoảng trắng).");
        return v.ToUpperInvariant();
    }

    /// <summary>Giới tính: chỉ nhận "Nam" hoặc "Nữ" (không phân biệt hoa thường), trả về dạng chuẩn.</summary>
    public static string GioiTinh(string? value)
    {
        var v = (value ?? "").Trim();
        if (string.Equals(v, "Nam", StringComparison.OrdinalIgnoreCase)) return "Nam";
        if (string.Equals(v, "Nữ", StringComparison.OrdinalIgnoreCase)) return "Nữ";
        throw new BusinessException("Giới tính chỉ được là 'Nam' hoặc 'Nữ'.");
    }

    public static string KhoaHoc(string? value)
    {
        var v = Required(value, "Khóa học", 4);
        if (!Regex.IsMatch(v, @"^\d{4}$"))
            throw new BusinessException("Khóa học phải gồm 4 chữ số (ví dụ 2021).");
        int year = int.Parse(v);
        if (year < 1990 || year > DateTime.Today.Year + 1)
            throw new BusinessException("Khóa học không hợp lý.");
        return v;
    }

    public static string NienKhoa(string? value)
    {
        var v = Required(value, "Niên khóa", 9);
        var m = NienKhoaRegex.Match(v);
        if (!m.Success)
            throw new BusinessException("Niên khóa phải có dạng yyyy-yyyy (ví dụ 2023-2024).");
        if (int.Parse(m.Groups[2].Value) != int.Parse(m.Groups[1].Value) + 1)
            throw new BusinessException("Niên khóa phải gồm hai năm liên tiếp (ví dụ 2023-2024).");
        return v;
    }
}
