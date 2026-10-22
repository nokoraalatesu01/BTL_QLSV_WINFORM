using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

/// <summary>Nhập điểm (PGV: mọi khoa; KHOA: lớp tín chỉ của khoa mình; GV: chỉ lớp tín chỉ mình phụ trách).</summary>
public static class DiemBLL
{
    public static List<string> LayNienKhoa()
    {
        Quyen.Yeu(ChucNang.NhapDiem, HanhDong.Xem);
        return Quyen.LocLopTinChi(LopTinChiDAL.Tim(Quyen.PhamViKhoa, null, null))
            .Select(x => x.NienKhoa).Distinct().OrderByDescending(x => x).ToList();
    }

    /// <summary>Các lớp tín chỉ còn hoạt động (chưa hủy) có thể nhập điểm.</summary>
    public static List<LopTinChi> LayLopTinChi(string? nienKhoa, int? hocKy)
    {
        Quyen.Yeu(ChucNang.NhapDiem, HanhDong.Xem);
        var nk = string.IsNullOrWhiteSpace(nienKhoa) ? null : nienKhoa.Trim();
        return Quyen.LocLopTinChi(LopTinChiDAL.Tim(Quyen.PhamViKhoa, nk, hocKy)).Where(x => !x.HuyLop).ToList();
    }

    public static List<DiemSinhVien> LayDanhSachDiem(int maLTC)
    {
        Quyen.Yeu(ChucNang.NhapDiem, HanhDong.Xem);
        var ltc = LopTinChiDAL.LayTheoMa(maLTC)
                  ?? throw new BusinessException("Lớp tín chỉ không tồn tại.");
        Quyen.YeuLopTinChi(ltc);
        return DiemDAL.LayDanhSach(maLTC);
    }

    /// <summary>
    /// Kiểm tra và lưu điểm cả lớp. Chuyên cần: số nguyên 0–10; giữa kỳ, cuối kỳ: 0–10 bước 0.5.
    /// Cho phép để trống (chưa nhập); điểm tổng kết chỉ có khi đủ ba điểm.
    /// </summary>
    public static void LuuDiem(int maLTC, IReadOnlyList<DiemSinhVien> danhSach)
    {
        Quyen.Yeu(ChucNang.NhapDiem, HanhDong.Ghi);

        var ltc = LopTinChiDAL.LayTheoMa(maLTC)
                  ?? throw new BusinessException("Lớp tín chỉ không tồn tại.");
        Quyen.YeuLopTinChi(ltc);
        if (ltc.HuyLop)
            throw new BusinessException("Lớp tín chỉ đã bị hủy, không thể nhập điểm.");
        if (danhSach == null || danhSach.Count == 0)
            throw new BusinessException("Không có sinh viên nào để lưu điểm.");

        var loi = new List<string>();
        var daGap = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var d in danhSach)
        {
            if (!daGap.Add(d.MaSV))
            {
                loi.Add($"{d.MaSV}: xuất hiện nhiều lần trong danh sách.");
                continue;
            }

            if (d.DiemCC.HasValue
                && (!DiemHelper.LaDiemHopLe(d.DiemCC.Value, false) || d.DiemCC.Value != decimal.Truncate(d.DiemCC.Value)))
                loi.Add($"{d.MaSV}: điểm chuyên cần phải là số nguyên từ 0 đến 10.");

            if (d.DiemGK.HasValue && !DiemHelper.LaDiemHopLe(d.DiemGK.Value, true))
                loi.Add($"{d.MaSV}: điểm giữa kỳ phải từ 0 đến 10, bước 0.5.");

            if (d.DiemCK.HasValue && !DiemHelper.LaDiemHopLe(d.DiemCK.Value, true))
                loi.Add($"{d.MaSV}: điểm cuối kỳ phải từ 0 đến 10, bước 0.5.");
        }

        if (loi.Count > 0)
        {
            var hienThi = loi.Take(10).ToList();
            if (loi.Count > hienThi.Count)
                hienThi.Add($"... và {loi.Count - hienThi.Count} lỗi khác.");
            throw new BusinessException("Điểm không hợp lệ:\n" + string.Join("\n", hienThi));
        }

        DiemDAL.CapNhat(maLTC, danhSach);
    }
}
