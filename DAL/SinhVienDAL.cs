using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class SinhVienDAL
{
    private const string SelectSql =
        @"SELECT s.MASV, s.HO, s.TEN, s.MALOP, l.TENLOP, l.MAKHOA, s.GIOITINH, s.DIACHI, s.NGAYSINH, s.DANGHIHOC
          FROM Sinhvien s JOIN Lop l ON l.MALOP = s.MALOP ";

    private static SinhVien Map(SqlDataReader r) => new()
    {
        MaSV = Db.Str(r, "MASV"),
        Ho = Db.Str(r, "HO"),
        Ten = Db.Str(r, "TEN"),
        MaLop = Db.Str(r, "MALOP"),
        TenLop = Db.Str(r, "TENLOP"),
        MaKhoa = Db.Str(r, "MAKHOA"),
        GioiTinh = Db.Str(r, "GIOITINH"),
        DiaChi = Db.StrN(r, "DIACHI"),
        NgaySinh = Db.DateN(r, "NGAYSINH"),
        DaNghiHoc = Db.Bool(r, "DANGHIHOC"),
    };

    /// <summary>Tìm theo từ khóa (mã, họ tên, địa chỉ), lọc theo khoa và/hoặc lớp (null = không lọc).</summary>
    public static List<SinhVien> Tim(string? keyword, string? maKhoa, string? maLop) =>
        Db.Query<SinhVien>(
            SelectSql +
            @"WHERE (@mk IS NULL OR l.MAKHOA = @mk)
                AND (@ml IS NULL OR s.MALOP = @ml)
                AND (@kw IS NULL OR s.MASV LIKE @kw OR s.HO LIKE @kw OR s.TEN LIKE @kw
                     OR (s.HO + N' ' + s.TEN) LIKE @kw OR s.DIACHI LIKE @kw)
              ORDER BY s.MALOP, s.TEN, s.HO",
            Map, Db.P("@mk", maKhoa), Db.P("@ml", maLop), Db.P("@kw", Db.Like(keyword)));

    public static SinhVien? LayTheoMa(string maSV) =>
        Db.Query<SinhVien>(SelectSql + "WHERE s.MASV = @ma", Map, Db.P("@ma", maSV)).FirstOrDefault();

    public static bool TonTai(string maSV) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Sinhvien WHERE MASV = @ma", Db.P("@ma", maSV))) > 0;

    /// <summary>Thêm sinh viên và tài khoản đăng nhập của sinh viên trong cùng một transaction.</summary>
    public static void Them(SinhVien sv, TaiKhoan taiKhoan)
    {
        Db.InTransaction((conn, tx) =>
        {
            DalUtil.Exec(conn, tx,
                @"INSERT INTO Sinhvien (MASV, HO, TEN, MALOP, GIOITINH, DIACHI, NGAYSINH, DANGHIHOC)
                  VALUES (@ma, @ho, @ten, @lop, @gt, @dc, @ns, @nghi)",
                Db.P("@ma", sv.MaSV), Db.P("@ho", sv.Ho), Db.P("@ten", sv.Ten), Db.P("@lop", sv.MaLop),
                Db.P("@gt", sv.GioiTinh), Db.P("@dc", sv.DiaChi), Db.P("@ns", sv.NgaySinh), Db.P("@nghi", sv.DaNghiHoc));
            TaiKhoanDAL.Them(conn, tx, taiKhoan);
        });
    }

    public static int Sua(SinhVien sv) =>
        Db.Execute(
            @"UPDATE Sinhvien
              SET HO = @ho, TEN = @ten, MALOP = @lop, GIOITINH = @gt, DIACHI = @dc, NGAYSINH = @ns, DANGHIHOC = @nghi
              WHERE MASV = @ma",
            Db.P("@ho", sv.Ho), Db.P("@ten", sv.Ten), Db.P("@lop", sv.MaLop), Db.P("@gt", sv.GioiTinh),
            Db.P("@dc", sv.DiaChi), Db.P("@ns", sv.NgaySinh), Db.P("@nghi", sv.DaNghiHoc), Db.P("@ma", sv.MaSV));

    /// <summary>Xóa sinh viên; tài khoản của sinh viên bị xóa theo (ON DELETE CASCADE).</summary>
    public static int Xoa(string maSV) =>
        Db.Execute("DELETE FROM Sinhvien WHERE MASV = @ma", Db.P("@ma", maSV));

    public static int DemDangKy(string maSV) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM DANGKY WHERE MASV = @ma", Db.P("@ma", maSV)));
}
