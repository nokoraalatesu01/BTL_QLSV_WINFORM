using System.Text.RegularExpressions;
using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

/// <summary>
/// Sinh viên xem và cập nhật hồ sơ CỦA CHÍNH MÌNH. Mã sinh viên luôn lấy từ phiên đăng nhập,
/// giao diện không thể truyền mã khác vào nên không thể sửa hồ sơ của người khác.
/// </summary>
public static class HoSoSinhVienBLL
{
    private static readonly string[] ThuTuNhom =
    {
        HoSoSinhVienDAL.NhomCaNhan,
        HoSoSinhVienDAL.NhomLienHe,
        HoSoSinhVienDAL.NhomNganHang,
        HoSoSinhVienDAL.NhomHocTap,
    };

    private static readonly Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
    private static readonly Regex DienThoaiRegex = new(@"^\+?[0-9][0-9 .\-]{7,14}$", RegexOptions.Compiled);

    private static string MaSvHienTai(HanhDong hanhDong)
    {
        Quyen.Yeu(ChucNang.HoSoCaNhan, hanhDong);
        var maSV = Quyen.HienTai.MaSV;
        if (string.IsNullOrWhiteSpace(maSV))
            throw new BusinessException("Tài khoản chưa gắn với sinh viên nào.");
        return maSV.Trim();
    }

    private static int ThuTuCuaNhom(string nhom)
    {
        int k = Array.IndexOf(ThuTuNhom, nhom);
        return k < 0 ? int.MaxValue : k;
    }

    public static HoSoSinhVien LayHoSo()
    {
        var maSV = MaSvHienTai(HanhDong.Xem);
        var hs = HoSoSinhVienDAL.LayHoSo(maSV)
                 ?? throw new BusinessException("Không tìm thấy hồ sơ sinh viên.");

        // Trường chỉ-xem mà không có dữ liệu thì ẩn; trường chỉnh sửa được thì giữ lại (ô trống) để có thể nhập.
        var giuLai = hs.Truong
            .Where(t => t.CoTheSua || !string.IsNullOrWhiteSpace(t.GiaTri))
            .Select((t, i) => (t, i))
            .OrderBy(x => ThuTuCuaNhom(x.t.Nhom))
            .ThenBy(x => x.i)
            .Select(x => x.t)
            .ToList();

        hs.Truong.Clear();
        hs.Truong.AddRange(giuLai);
        return hs;
    }

    /// <summary>Ảnh đại diện của sinh viên đang đăng nhập; null nếu không phải sinh viên, chưa có cột ảnh hoặc chưa có ảnh.</summary>
    public static byte[]? LayAnhDaiDien()
    {
        var nd = PhienLamViec.NguoiDungHienTai;
        if (nd == null || nd.VaiTro != VaiTro.SV || string.IsNullOrWhiteSpace(nd.MaSV)) return null;
        if (!Quyen.CoQuyen(ChucNang.HoSoCaNhan, HanhDong.Xem)) return null;
        return HoSoSinhVienDAL.LayAnh(nd.MaSV.Trim());
    }

    /// <summary>
    /// Lưu các trường đã đổi (khóa = tên cột thật) và/hoặc ảnh mới. Ném BusinessException nếu dữ liệu không hợp lệ
    /// hoặc không có nơi lưu; chỉ trở về bình thường khi CSDL đã cập nhật đúng 1 dòng.
    /// </summary>
    public static void Luu(IReadOnlyDictionary<string, string?> giaTriMoi, byte[]? anhMoi)
    {
        var maSV = MaSvHienTai(HanhDong.Ghi);
        var hs = HoSoSinhVienDAL.LayHoSo(maSV)
                 ?? throw new BusinessException("Không tìm thấy hồ sơ sinh viên.");

        var hopLe = new Dictionary<string, string?>(StringComparer.OrdinalIgnoreCase);
        foreach (var (tenCot, giaTri) in giaTriMoi)
        {
            var truong = hs.Truong.FirstOrDefault(t =>
                t.CoTheSua && string.Equals(t.TenCot, tenCot, StringComparison.OrdinalIgnoreCase))
                ?? throw new BusinessException("Có trường thông tin không được phép chỉnh sửa.");

            var v = (giaTri ?? "").Trim();
            if (v.Length > truong.DoDaiToiDa)
                throw new BusinessException($"{truong.Ten} tối đa {truong.DoDaiToiDa} ký tự.");

            if (v.Length > 0)
            {
                if (truong.Kieu == KieuTruong.Email && !EmailRegex.IsMatch(v))
                    throw new BusinessException("Email không đúng định dạng (ví dụ: ten@example.com).");
                if (truong.Kieu == KieuTruong.DienThoai && !DienThoaiRegex.IsMatch(v))
                    throw new BusinessException("Số điện thoại chỉ gồm chữ số (8–15 ký tự), có thể bắt đầu bằng '+'.");
            }

            hopLe[truong.TenCot!] = v.Length == 0 ? null : v;
        }

        if (anhMoi != null)
        {
            if (!hs.CoCotAnh)
                throw new BusinessException(
                    "CSDL chưa có cột lưu ảnh đại diện (Sinhvien.ANHDAIDIEN). Hãy chạy script Database/ThemAnhDaiDien.sql trước.");
            AnhHelper.KiemTraDuLieuAnh(anhMoi);
        }

        HoSoSinhVienDAL.Luu(maSV, hopLe, anhMoi);
    }
}
