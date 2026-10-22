using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public static class LopBLL
{
    public static List<Lop> Tim(string? keyword)
    {
        Quyen.Yeu(ChucNang.Lop, HanhDong.Xem);
        return LopDAL.Tim(keyword, Quyen.PhamViKhoa);
    }

    private static Lop KiemTra(Lop input)
    {
        var l = new Lop
        {
            MaLop = Validator.Code(input.MaLop, "Mã lớp", 10),
            TenLop = Validator.Required(input.TenLop, "Tên lớp", 50),
            KhoaHoc = Validator.KhoaHoc(input.KhoaHoc),
            MaKhoa = Validator.Required(input.MaKhoa, "Khoa", 10),
        };

        Quyen.YeuKhoa(l.MaKhoa);
        if (!KhoaDAL.TonTai(l.MaKhoa))
            throw new BusinessException("Khoa đã chọn không tồn tại.");
        return l;
    }

    public static void Them(Lop input)
    {
        Quyen.Yeu(ChucNang.Lop, HanhDong.Ghi);
        var l = KiemTra(input);

        if (LopDAL.TonTai(l.MaLop))
            throw new BusinessException($"Mã lớp '{l.MaLop}' đã tồn tại.");

        LopDAL.Them(l);
    }

    public static void Sua(Lop input)
    {
        Quyen.Yeu(ChucNang.Lop, HanhDong.Ghi);
        var l = KiemTra(input);

        var cu = LopDAL.LayTheoMa(l.MaLop)
                 ?? throw new BusinessException("Lớp không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        if (LopDAL.Sua(l) == 0)
            throw new BusinessException("Lớp không còn tồn tại. Hãy tải lại danh sách.");
    }

    public static void Xoa(string? maLop)
    {
        Quyen.Yeu(ChucNang.Lop, HanhDong.Ghi);
        var ma = Validator.Required(maLop, "Mã lớp", 10);

        var cu = LopDAL.LayTheoMa(ma)
                 ?? throw new BusinessException("Lớp không còn tồn tại. Hãy tải lại danh sách.");
        Quyen.YeuKhoa(cu.MaKhoa);

        int soSv = LopDAL.DemSinhVien(ma);
        if (soSv > 0)
            throw new BusinessException($"Không thể xóa lớp: lớp còn {soSv} sinh viên.");

        LopDAL.Xoa(ma);
    }
}
