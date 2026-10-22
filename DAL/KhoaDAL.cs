using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class KhoaDAL
{
    private static Khoa Map(SqlDataReader r) => new()
    {
        MaKhoa = Db.Str(r, "MAKHOA"),
        TenKhoa = Db.Str(r, "TENKHOA"),
    };

    /// <summary>maKhoa = null: lấy tất cả khoa.</summary>
    public static List<Khoa> LayTatCa(string? maKhoa = null) =>
        Db.Query<Khoa>(
            "SELECT MAKHOA, TENKHOA FROM Khoa WHERE (@mk IS NULL OR MAKHOA = @mk) ORDER BY TENKHOA",
            Map, Db.P("@mk", maKhoa));

    public static Khoa? LayTheoMa(string maKhoa) =>
        Db.Query<Khoa>("SELECT MAKHOA, TENKHOA FROM Khoa WHERE MAKHOA = @mk", Map, Db.P("@mk", maKhoa)).FirstOrDefault();

    public static bool TonTai(string maKhoa) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Khoa WHERE MAKHOA = @mk", Db.P("@mk", maKhoa))) > 0;

    /// <summary>Thêm khoa; nếu có tài khoản kèm theo thì thêm trong cùng một transaction.</summary>
    public static void Them(Khoa k, TaiKhoan? taiKhoanKhoa)
    {
        Db.InTransaction((conn, tx) =>
        {
            DalUtil.Exec(conn, tx, "INSERT INTO Khoa (MAKHOA, TENKHOA) VALUES (@ma, @ten)",
                Db.P("@ma", k.MaKhoa), Db.P("@ten", k.TenKhoa));
            if (taiKhoanKhoa != null)
                TaiKhoanDAL.Them(conn, tx, taiKhoanKhoa);
        });
    }

    public static int Sua(Khoa k) =>
        Db.Execute("UPDATE Khoa SET TENKHOA = @ten WHERE MAKHOA = @ma",
            Db.P("@ten", k.TenKhoa), Db.P("@ma", k.MaKhoa));

    /// <summary>Số lớp, giảng viên, lớp tín chỉ đang thuộc khoa.</summary>
    public static (int Lop, int GiangVien, int LopTinChi) DemThamChieu(string maKhoa)
    {
        var rows = Db.Query<(int, int, int)>(
            @"SELECT (SELECT COUNT(*) FROM Lop WHERE MAKHOA = @mk) AS L,
                     (SELECT COUNT(*) FROM GIANGVIEN WHERE MAKHOA = @mk) AS G,
                     (SELECT COUNT(*) FROM LOPTINCHI WHERE MAKHOA = @mk) AS T",
            r => (Db.Int(r, "L"), Db.Int(r, "G"), Db.Int(r, "T")),
            Db.P("@mk", maKhoa));
        return rows.Count > 0 ? rows[0] : (0, 0, 0);
    }

    /// <summary>Xóa khoa cùng tài khoản đăng nhập vai trò KHOA của khoa đó (một transaction).</summary>
    public static int Xoa(string maKhoa)
    {
        int rows = 0;
        Db.InTransaction((conn, tx) =>
        {
            DalUtil.Exec(conn, tx, "DELETE FROM TaiKhoan WHERE MAKHOA = @mk AND VAITRO = 'KHOA'", Db.P("@mk", maKhoa));
            rows = DalUtil.Exec(conn, tx, "DELETE FROM Khoa WHERE MAKHOA = @mk", Db.P("@mk", maKhoa));
        });
        return rows;
    }
}
