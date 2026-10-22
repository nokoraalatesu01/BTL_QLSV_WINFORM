using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

public static class MonHocBLL
{
    public static List<MonHoc> Tim(string? keyword)
    {
        Quyen.Yeu(ChucNang.MonHoc, HanhDong.Xem);
        return MonHocDAL.Tim(keyword);
    }

    private static MonHoc KiemTra(MonHoc input)
    {
        var m = new MonHoc
        {
            MaMH = Validator.Code(input.MaMH, "Mã môn học", 10),
            TenMH = Validator.Required(input.TenMH, "Tên môn học", 50),
            SoTietLT = input.SoTietLT,
            SoTietTH = input.SoTietTH,
        };

        if (m.SoTietLT < 0 || m.SoTietTH < 0 || m.SoTietLT > 200 || m.SoTietTH > 200)
            throw new BusinessException("Số tiết phải trong khoảng 0 đến 200.");
        if (m.SoTietLT + m.SoTietTH <= 0)
            throw new BusinessException("Tổng số tiết (lý thuyết + thực hành) phải lớn hơn 0.");
        return m;
    }

    public static void Them(MonHoc input)
    {
        Quyen.Yeu(ChucNang.MonHoc, HanhDong.Ghi);
        var m = KiemTra(input);

        if (MonHocDAL.TonTai(m.MaMH))
            throw new BusinessException($"Mã môn học '{m.MaMH}' đã tồn tại.");

        MonHocDAL.Them(m);
    }

    public static void Sua(MonHoc input)
    {
        Quyen.Yeu(ChucNang.MonHoc, HanhDong.Ghi);
        var m = KiemTra(input);

        if (MonHocDAL.Sua(m) == 0)
            throw new BusinessException("Môn học không còn tồn tại. Hãy tải lại danh sách.");
    }

    public static void Xoa(string? maMH)
    {
        Quyen.Yeu(ChucNang.MonHoc, HanhDong.Ghi);
        var ma = Validator.Required(maMH, "Mã môn học", 10);

        int soLtc = MonHocDAL.DemLopTinChi(ma);
        if (soLtc > 0)
            throw new BusinessException($"Không thể xóa: môn học đang được dùng trong {soLtc} lớp tín chỉ.");

        if (MonHocDAL.Xoa(ma) == 0)
            throw new BusinessException("Môn học không còn tồn tại. Hãy tải lại danh sách.");
    }
}
