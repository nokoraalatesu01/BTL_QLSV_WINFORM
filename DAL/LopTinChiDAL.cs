using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class LopTinChiDAL
{
    private const string SelectSql =
        @"SELECT t.MALTC, t.NIENKHOA, t.HOCKY, t.MAMH, m.TENMH, t.NHOM, t.MAGV,
                 (g.HO + N' ' + g.TEN) AS TENGV, t.MAKHOA, t.SOSVTOITHIEU, t.HUYLOP,
                 (SELECT COUNT(*) FROM DANGKY d WHERE d.MALTC = t.MALTC AND d.HUYDANGKY = 0) AS SOSV
          FROM LOPTINCHI t
          JOIN Monhoc m ON m.MAMH = t.MAMH
          JOIN GIANGVIEN g ON g.MAGV = t.MAGV ";

    private static LopTinChi Map(SqlDataReader r) => new()
    {
        MaLTC = Db.Int(r, "MALTC"),
        NienKhoa = Db.Str(r, "NIENKHOA"),
        HocKy = Db.Int(r, "HOCKY"),
        MaMH = Db.Str(r, "MAMH"),
        TenMH = Db.Str(r, "TENMH"),
        Nhom = Db.Int(r, "NHOM"),
        MaGV = Db.Str(r, "MAGV"),
        TenGV = Db.Str(r, "TENGV"),
        MaKhoa = Db.Str(r, "MAKHOA"),
        SoSVToiThieu = Db.Int(r, "SOSVTOITHIEU"),
        HuyLop = Db.Bool(r, "HUYLOP"),
        SoSV = Db.Int(r, "SOSV"),
    };

    /// <summary>Các tham số null = không lọc.</summary>
    public static List<LopTinChi> Tim(string? maKhoa, string? nienKhoa, int? hocKy) =>
        Db.Query<LopTinChi>(
            SelectSql +
            @"WHERE (@mk IS NULL OR t.MAKHOA = @mk)
                AND (@nk IS NULL OR t.NIENKHOA = @nk)
                AND (@hk IS NULL OR t.HOCKY = @hk)
              ORDER BY t.NIENKHOA DESC, t.HOCKY, m.TENMH, t.NHOM",
            Map, Db.P("@mk", maKhoa), Db.P("@nk", nienKhoa), Db.P("@hk", hocKy));

    public static LopTinChi? LayTheoMa(int maLTC) =>
        Db.Query<LopTinChi>(SelectSql + "WHERE t.MALTC = @ma", Map, Db.P("@ma", maLTC)).FirstOrDefault();

    public static List<string> LayNienKhoa(string? maKhoa) =>
        Db.Query<string>(
            "SELECT DISTINCT NIENKHOA FROM LOPTINCHI WHERE (@mk IS NULL OR MAKHOA = @mk) ORDER BY NIENKHOA DESC",
            r => Db.Str(r, "NIENKHOA"), Db.P("@mk", maKhoa));

    /// <summary>Thêm lớp tín chỉ, trả về MALTC mới.</summary>
    public static int Them(LopTinChi t)
    {
        var id = Db.Scalar(
            @"INSERT INTO LOPTINCHI (NIENKHOA, HOCKY, MAMH, NHOM, MAGV, MAKHOA, SOSVTOITHIEU, HUYLOP)
              OUTPUT INSERTED.MALTC
              VALUES (@nk, @hk, @mh, @nhom, @gv, @mk, @sv, @huy)",
            Db.P("@nk", t.NienKhoa), Db.P("@hk", t.HocKy), Db.P("@mh", t.MaMH), Db.P("@nhom", t.Nhom),
            Db.P("@gv", t.MaGV), Db.P("@mk", t.MaKhoa), Db.P("@sv", t.SoSVToiThieu), Db.P("@huy", t.HuyLop));
        return Convert.ToInt32(id);
    }

    public static int Sua(LopTinChi t) =>
        Db.Execute(
            @"UPDATE LOPTINCHI
              SET NIENKHOA = @nk, HOCKY = @hk, MAMH = @mh, NHOM = @nhom, MAGV = @gv,
                  MAKHOA = @mk, SOSVTOITHIEU = @sv, HUYLOP = @huy
              WHERE MALTC = @ma",
            Db.P("@nk", t.NienKhoa), Db.P("@hk", t.HocKy), Db.P("@mh", t.MaMH), Db.P("@nhom", t.Nhom),
            Db.P("@gv", t.MaGV), Db.P("@mk", t.MaKhoa), Db.P("@sv", t.SoSVToiThieu), Db.P("@huy", t.HuyLop),
            Db.P("@ma", t.MaLTC));

    public static int Xoa(int maLTC) =>
        Db.Execute("DELETE FROM LOPTINCHI WHERE MALTC = @ma", Db.P("@ma", maLTC));

    /// <summary>Số bản ghi DANGKY (kể cả đã hủy) của lớp tín chỉ.</summary>
    public static int DemDangKy(int maLTC) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM DANGKY WHERE MALTC = @ma", Db.P("@ma", maLTC)));
}
