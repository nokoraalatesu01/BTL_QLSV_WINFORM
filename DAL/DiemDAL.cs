using System.Data;
using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class DiemDAL
{
    /// <summary>Danh sách sinh viên (đăng ký chưa hủy) của một lớp tín chỉ cùng điểm.</summary>
    public static List<DiemSinhVien> LayDanhSach(int maLTC) =>
        Db.Query<DiemSinhVien>(
            @"SELECT d.MALTC, d.MASV, s.HO, s.TEN, s.MALOP, d.DIEM_CC, d.DIEM_GK, d.DIEM_CK, d.DIEM_TK
              FROM DANGKY d JOIN Sinhvien s ON s.MASV = d.MASV
              WHERE d.MALTC = @ma AND d.HUYDANGKY = 0
              ORDER BY s.TEN, s.HO, d.MASV",
            r => new DiemSinhVien
            {
                MaLTC = Db.Int(r, "MALTC"),
                MaSV = Db.Str(r, "MASV"),
                HoTen = (Db.Str(r, "HO") + " " + Db.Str(r, "TEN")).Trim(),
                MaLop = Db.Str(r, "MALOP"),
                DiemCC = Db.IntN(r, "DIEM_CC"),
                DiemGK = Db.DecN(r, "DIEM_GK"),
                DiemCK = Db.DecN(r, "DIEM_CK"),
                DiemTK = Db.DecN(r, "DIEM_TK"),
            },
            Db.P("@ma", maLTC));

    /// <summary>Lưu điểm cả lớp trong một transaction; lỗi bất kỳ sẽ rollback toàn bộ.</summary>
    public static void CapNhat(int maLTC, IEnumerable<DiemSinhVien> danhSach)
    {
        Db.InTransaction((conn, tx) =>
        {
            foreach (var d in danhSach)
            {
                int rows = DalUtil.Exec(conn, tx,
                    @"UPDATE DANGKY SET DIEM_CC = @cc, DIEM_GK = @gk, DIEM_CK = @ck
                      WHERE MALTC = @ltc AND MASV = @sv AND HUYDANGKY = 0",
                    IntParam("@cc", d.DiemCC),
                    DecParam("@gk", d.DiemGK),
                    DecParam("@ck", d.DiemCK),
                    Db.P("@ltc", maLTC),
                    Db.P("@sv", d.MaSV));

                if (rows != 1)
                    throw new BusinessException($"Sinh viên {d.MaSV} không thuộc lớp tín chỉ này (hoặc đã hủy đăng ký).");
            }
        });
    }

    /// <summary>Bảng điểm của một sinh viên (các lớp tín chỉ chưa hủy).</summary>
    public static List<BangDiemDong> LayBangDiemSinhVien(string maSV) =>
        Db.Query<BangDiemDong>(
            @"SELECT t.MALTC, t.NIENKHOA, t.HOCKY, t.MAMH, m.TENMH, t.NHOM,
                     d.DIEM_CC, d.DIEM_GK, d.DIEM_CK, d.DIEM_TK
              FROM DANGKY d
              JOIN LOPTINCHI t ON t.MALTC = d.MALTC
              JOIN Monhoc m ON m.MAMH = t.MAMH
              WHERE d.MASV = @sv AND d.HUYDANGKY = 0 AND t.HUYLOP = 0
              ORDER BY t.NIENKHOA, t.HOCKY, m.TENMH",
            r => new BangDiemDong
            {
                MaLTC = Db.Int(r, "MALTC"),
                NienKhoa = Db.Str(r, "NIENKHOA"),
                HocKy = Db.Int(r, "HOCKY"),
                MaMH = Db.Str(r, "MAMH"),
                TenMH = Db.Str(r, "TENMH"),
                Nhom = Db.Int(r, "NHOM"),
                DiemCC = Db.IntN(r, "DIEM_CC"),
                DiemGK = Db.DecN(r, "DIEM_GK"),
                DiemCK = Db.DecN(r, "DIEM_CK"),
                DiemTK = Db.DecN(r, "DIEM_TK"),
            },
            Db.P("@sv", maSV));

    private static SqlParameter IntParam(string name, decimal? value) =>
        new(name, SqlDbType.Int) { Value = value.HasValue ? (object)(int)value.Value : DBNull.Value };

    private static SqlParameter DecParam(string name, decimal? value) =>
        new(name, SqlDbType.Decimal)
        {
            Precision = 3,
            Scale = 1,
            Value = value.HasValue ? (object)value.Value : DBNull.Value,
        };
}
