using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class LopDAL
{
    private const string SelectSql =
        @"SELECT l.MALOP, l.TENLOP, l.KHOAHOC, l.MAKHOA, k.TENKHOA
          FROM Lop l JOIN Khoa k ON k.MAKHOA = l.MAKHOA ";

    private static Lop Map(SqlDataReader r) => new()
    {
        MaLop = Db.Str(r, "MALOP"),
        TenLop = Db.Str(r, "TENLOP"),
        KhoaHoc = Db.Str(r, "KHOAHOC"),
        MaKhoa = Db.Str(r, "MAKHOA"),
        TenKhoa = Db.Str(r, "TENKHOA"),
    };

    /// <summary>maKhoa = null: mọi khoa. keyword = null/rỗng: không lọc theo từ khóa.</summary>
    public static List<Lop> Tim(string? keyword, string? maKhoa) =>
        Db.Query<Lop>(
            SelectSql +
            @"WHERE (@mk IS NULL OR l.MAKHOA = @mk)
                AND (@kw IS NULL OR l.MALOP LIKE @kw OR l.TENLOP LIKE @kw OR l.KHOAHOC LIKE @kw)
              ORDER BY l.MAKHOA, l.MALOP",
            Map, Db.P("@mk", maKhoa), Db.P("@kw", Db.Like(keyword)));

    public static Lop? LayTheoMa(string maLop) =>
        Db.Query<Lop>(SelectSql + "WHERE l.MALOP = @ma", Map, Db.P("@ma", maLop)).FirstOrDefault();

    public static bool TonTai(string maLop) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Lop WHERE MALOP = @ma", Db.P("@ma", maLop))) > 0;

    public static void Them(Lop l) =>
        Db.Execute("INSERT INTO Lop (MALOP, TENLOP, KHOAHOC, MAKHOA) VALUES (@ma, @ten, @kh, @mk)",
            Db.P("@ma", l.MaLop), Db.P("@ten", l.TenLop), Db.P("@kh", l.KhoaHoc), Db.P("@mk", l.MaKhoa));

    public static int Sua(Lop l) =>
        Db.Execute("UPDATE Lop SET TENLOP = @ten, KHOAHOC = @kh, MAKHOA = @mk WHERE MALOP = @ma",
            Db.P("@ten", l.TenLop), Db.P("@kh", l.KhoaHoc), Db.P("@mk", l.MaKhoa), Db.P("@ma", l.MaLop));

    public static int Xoa(string maLop) =>
        Db.Execute("DELETE FROM Lop WHERE MALOP = @ma", Db.P("@ma", maLop));

    public static int DemSinhVien(string maLop) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Sinhvien WHERE MALOP = @ma", Db.P("@ma", maLop)));
}
