using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public static class LopTinChiBLL
{
    public static List<LopTinChi> Tim(string? nienKhoa, int? hocKy)
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Xem);
        var nk = string.IsNullOrWhiteSpace(nienKhoa) ? null : nienKhoa.Trim();
        return Quyen.LocLopTinChi(LopTinChiDAL.Tim(Quyen.PhamViKhoa, nk, hocKy));
    }

    public static List<string> LayNienKhoa()
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Xem);
        return Quyen.LocLopTinChi(LopTinChiDAL.Tim(Quyen.PhamViKhoa, null, null))
            .Select(x => x.NienKhoa).Distinct().OrderByDescending(x => x).ToList();
    }

    public static List<MonHoc> LayMonHocChoChon()
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Xem);
        return MonHocDAL.Tim(null);
    }

    public static List<Khoa> LayKhoaChoChon()
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Xem);
        return KhoaDAL.LayTatCa(Quyen.PhamViKhoa);
    }

    public static List<GiangVien> LayGiangVienTheoKhoa(string? maKhoa)
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Xem);
        if (string.IsNullOrWhiteSpace(maKhoa)) return new List<GiangVien>();
        Quyen.YeuKhoa(maKhoa);
        return GiangVienDAL.Tim(null, maKhoa.Trim());
    }

    private static LopTinChi KiemTra(LopTinChi input)
    {
        var t = new LopTinChi
        {
            MaLTC = input.MaLTC,
            NienKhoa = Validator.NienKhoa(input.NienKhoa),
            HocKy = input.HocKy,
            MaMH = Validator.Required(input.MaMH, "Môn học", 10),
            Nhom = input.Nhom,
            MaGV = Validator.Required(input.MaGV, "Giảng viên", 10),
            MaKhoa = Validator.Required(input.MaKhoa, "Khoa", 10),
            SoSVToiThieu = input.SoSVToiThieu,
            HuyLop = input.HuyLop,
        };

        if (t.HocKy < 1 || t.HocKy > 3)
            throw new BusinessException("Học kỳ phải là 1, 2 hoặc 3.");
        if (t.Nhom < 1 || t.Nhom > 99)
            throw new BusinessException("Nhóm phải từ 1 đến 99.");
        if (t.SoSVToiThieu < 0 || t.SoSVToiThieu > 500)
            throw new BusinessException("Số sinh viên tối thiểu phải từ 0 đến 500.");

        Quyen.YeuKhoa(t.MaKhoa);
        if (!KhoaDAL.TonTai(t.MaKhoa))
            throw new BusinessException("Khoa đã chọn không tồn tại.");
        if (!MonHocDAL.TonTai(t.MaMH))
            throw new BusinessException("Môn học đã chọn không tồn tại.");

        var gv = GiangVienDAL.LayTheoMa(t.MaGV)
                 ?? throw new BusinessException("Giảng viên đã chọn không tồn tại.");
        if (!string.Equals(gv.MaKhoa, t.MaKhoa, StringComparison.OrdinalIgnoreCase))
            throw new BusinessException("Giảng viên phải thuộc khoa mở lớp tín chỉ.");

        return t;
    }

    /// <summary>Tạo lớp tín chỉ, trả về mã lớp tín chỉ mới.</summary>
    public static int Them(LopTinChi input)
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Ghi);
        var t = KiemTra(input);
        return LopTinChiDAL.Them(t);
    }

    public static void Sua(LopTinChi input)
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Ghi);
        var t = KiemTra(input);

        var cu = LopTinChiDAL.LayTheoMa(t.MaLTC)
                 ?? throw new BusinessException("Lớp tín chỉ không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        // Khi đã có sinh viên/điểm thì không đổi các thông tin định danh của lớp.
        bool doiDinhDanh = cu.NienKhoa != t.NienKhoa || cu.HocKy != t.HocKy || cu.MaMH != t.MaMH
                           || cu.Nhom != t.Nhom || cu.MaKhoa != t.MaKhoa;
        if (doiDinhDanh && LopTinChiDAL.DemDangKy(t.MaLTC) > 0)
            throw new BusinessException(
                "Lớp đã có sinh viên/điểm: không được đổi niên khóa, học kỳ, môn học, nhóm hoặc khoa. " +
                "Chỉ được đổi giảng viên, số SV tối thiểu hoặc hủy lớp.");

        if (LopTinChiDAL.Sua(t) == 0)
            throw new BusinessException("Lớp tín chỉ không còn tồn tại. Hãy tải lại danh sách.");
    }

    public static void Xoa(int maLTC)
    {
        Quyen.Yeu(ChucNang.LopTinChi, HanhDong.Ghi);

        var cu = LopTinChiDAL.LayTheoMa(maLTC)
                 ?? throw new BusinessException("Lớp tín chỉ không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        int soDangKy = LopTinChiDAL.DemDangKy(maLTC);
        if (soDangKy > 0)
            throw new BusinessException(
                $"Không thể xóa: lớp đã có {soDangKy} bản ghi sinh viên/điểm. Hãy dùng 'Hủy lớp' thay vì xóa.");

        LopTinChiDAL.Xoa(maLTC);
    }
}
