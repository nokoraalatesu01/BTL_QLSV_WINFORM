using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class MonHocDAL
{
    private static MonHoc Map(SqlDataReader r) => new()
    {
        MaMH = Db.Str(r, "MAMH"),
        TenMH = Db.Str(r, "TENMH"),
        SoTietLT = Db.Int(r, "SOTIET_LT"),
        SoTietTH = Db.Int(r, "SOTIET_TH"),
    };

    public static List<MonHoc> Tim(string? keyword) =>
        Db.Query<MonHoc>(
            @"SELECT MAMH, TENMH, SOTIET_LT, SOTIET_TH FROM Monhoc
              WHERE (@kw IS NULL OR MAMH LIKE @kw OR TENMH LIKE @kw)
              ORDER BY MAMH",
            Map, Db.P("@kw", Db.Like(keyword)));

    public static MonHoc? LayTheoMa(string maMH) =>
        Db.Query<MonHoc>("SELECT MAMH, TENMH, SOTIET_LT, SOTIET_TH FROM Monhoc WHERE MAMH = @ma",
            Map, Db.P("@ma", maMH)).FirstOrDefault();

    public static bool TonTai(string maMH) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Monhoc WHERE MAMH = @ma", Db.P("@ma", maMH))) > 0;

    public static void Them(MonHoc m) =>
        Db.Execute("INSERT INTO Monhoc (MAMH, TENMH, SOTIET_LT, SOTIET_TH) VALUES (@ma, @ten, @lt, @th)",
            Db.P("@ma", m.MaMH), Db.P("@ten", m.TenMH), Db.P("@lt", m.SoTietLT), Db.P("@th", m.SoTietTH));

    public static int Sua(MonHoc m) =>
        Db.Execute("UPDATE Monhoc SET TENMH = @ten, SOTIET_LT = @lt, SOTIET_TH = @th WHERE MAMH = @ma",
            Db.P("@ten", m.TenMH), Db.P("@lt", m.SoTietLT), Db.P("@th", m.SoTietTH), Db.P("@ma", m.MaMH));

    public static int Xoa(string maMH) =>
        Db.Execute("DELETE FROM Monhoc WHERE MAMH = @ma", Db.P("@ma", maMH));

    public static int DemLopTinChi(string maMH) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM LOPTINCHI WHERE MAMH = @ma", Db.P("@ma", maMH)));
}
