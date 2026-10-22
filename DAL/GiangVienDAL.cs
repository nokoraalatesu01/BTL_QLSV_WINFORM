using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class GiangVienDAL
{
    private const string SelectSql =
        @"SELECT g.MAGV, g.HO, g.TEN, g.HOCVI, g.HOCHAM, g.CHUYENMON, g.MAKHOA, k.TENKHOA
          FROM GIANGVIEN g JOIN Khoa k ON k.MAKHOA = g.MAKHOA ";

    private static GiangVien Map(SqlDataReader r) => new()
    {
        MaGV = Db.Str(r, "MAGV"),
        Ho = Db.Str(r, "HO"),
        Ten = Db.Str(r, "TEN"),
        HocVi = Db.StrN(r, "HOCVI"),
        HocHam = Db.StrN(r, "HOCHAM"),
        ChuyenMon = Db.StrN(r, "CHUYENMON"),
        MaKhoa = Db.Str(r, "MAKHOA"),
        TenKhoa = Db.Str(r, "TENKHOA"),
    };

    public static List<GiangVien> Tim(string? keyword, string? maKhoa) =>
        Db.Query<GiangVien>(
            SelectSql +
            @"WHERE (@mk IS NULL OR g.MAKHOA = @mk)
                AND (@kw IS NULL OR g.MAGV LIKE @kw OR g.HO LIKE @kw OR g.TEN LIKE @kw
                     OR (g.HO + N' ' + g.TEN) LIKE @kw OR g.CHUYENMON LIKE @kw)
              ORDER BY g.MAKHOA, g.TEN, g.HO",
            Map, Db.P("@mk", maKhoa), Db.P("@kw", Db.Like(keyword)));

    public static GiangVien? LayTheoMa(string maGV) =>
        Db.Query<GiangVien>(SelectSql + "WHERE g.MAGV = @ma", Map, Db.P("@ma", maGV)).FirstOrDefault();

    public static bool TonTai(string maGV) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM GIANGVIEN WHERE MAGV = @ma", Db.P("@ma", maGV))) > 0;

    /// <summary>Thêm giảng viên và tài khoản đăng nhập của giảng viên trong cùng một transaction.</summary>
    public static void Them(GiangVien g, TaiKhoan taiKhoan)
    {
        Db.InTransaction((conn, tx) =>
        {
            DalUtil.Exec(conn, tx,
                @"INSERT INTO GIANGVIEN (MAGV, HO, TEN, HOCVI, HOCHAM, CHUYENMON, MAKHOA)
                  VALUES (@ma, @ho, @ten, @hv, @hh, @cm, @mk)",
                Db.P("@ma", g.MaGV), Db.P("@ho", g.Ho), Db.P("@ten", g.Ten), Db.P("@hv", g.HocVi),
                Db.P("@hh", g.HocHam), Db.P("@cm", g.ChuyenMon), Db.P("@mk", g.MaKhoa));
            TaiKhoanDAL.Them(conn, tx, taiKhoan);
        });
    }

    public static int Sua(GiangVien g) =>
        Db.Execute(
            @"UPDATE GIANGVIEN
              SET HO = @ho, TEN = @ten, HOCVI = @hv, HOCHAM = @hh, CHUYENMON = @cm, MAKHOA = @mk
              WHERE MAGV = @ma",
            Db.P("@ho", g.Ho), Db.P("@ten", g.Ten), Db.P("@hv", g.HocVi), Db.P("@hh", g.HocHam),
            Db.P("@cm", g.ChuyenMon), Db.P("@mk", g.MaKhoa), Db.P("@ma", g.MaGV));

    /// <summary>Xóa giảng viên; tài khoản của giảng viên bị xóa theo (ON DELETE CASCADE).</summary>
    public static int Xoa(string maGV) =>
        Db.Execute("DELETE FROM GIANGVIEN WHERE MAGV = @ma", Db.P("@ma", maGV));

    public static int DemLopTinChi(string maGV) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM LOPTINCHI WHERE MAGV = @ma", Db.P("@ma", maGV)));
}
