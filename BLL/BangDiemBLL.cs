using QLDSV_HTC.DAL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.BLL;

/// <summary>
/// Sinh viên xem thông tin và điểm của chính mình. Mã sinh viên luôn lấy từ phiên đăng nhập,
/// không nhận từ giao diện, nên không thể xem điểm của người khác.
/// </summary>
public static class BangDiemBLL
{
    private static string MaSvHienTai()
    {
        Quyen.Yeu(ChucNang.DiemCaNhan, HanhDong.Xem);
        var maSV = Quyen.HienTai.MaSV;
        if (string.IsNullOrWhiteSpace(maSV))
            throw new BusinessException("Tài khoản chưa gắn với sinh viên nào.");
        return maSV;
    }

    public static SinhVien LayThongTinCaNhan()
    {
        var maSV = MaSvHienTai();
        return SinhVienDAL.LayTheoMa(maSV)
               ?? throw new BusinessException("Không tìm thấy hồ sơ sinh viên.");
    }

    public static List<BangDiemDong> LayBangDiem() => DiemDAL.LayBangDiemSinhVien(MaSvHienTai());
}
