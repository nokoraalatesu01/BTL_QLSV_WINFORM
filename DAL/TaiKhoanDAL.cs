using Microsoft.Data.SqlClient;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL;

public static class TaiKhoanDAL
{
    private static TaiKhoan Map(SqlDataReader r)
    {
        if (!Enum.TryParse<VaiTro>(Db.Str(r, "VAITRO"), true, out var vaiTro))
            throw new BusinessException("Tài khoản có vai trò không hợp lệ trong cơ sở dữ liệu.");

        return new TaiKhoan
        {
            TenDangNhap = Db.Str(r, "TENDANGNHAP"),
            MatKhauHash = Db.Str(r, "MATKHAUHASH"),
            Salt = Db.Str(r, "SALT"),
            VaiTro = vaiTro,
            MaKhoa = Db.StrN(r, "MAKHOA"),
            MaGV = Db.StrN(r, "MAGV"),
            MaSV = Db.StrN(r, "MASV"),
            HoatDong = Db.Bool(r, "HOATDONG"),
        };
    }

    public static TaiKhoan? LayTheoTen(string tenDangNhap) =>
        Db.Query<TaiKhoan>(
            "SELECT TENDANGNHAP, MATKHAUHASH, SALT, VAITRO, MAKHOA, MAGV, MASV, HOATDONG FROM TaiKhoan WHERE TENDANGNHAP = @ten",
            Map, Db.P("@ten", tenDangNhap)).FirstOrDefault();

    public static bool TonTai(string tenDangNhap) =>
        Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM TaiKhoan WHERE TENDANGNHAP = @ten", Db.P("@ten", tenDangNhap))) > 0;

    public static int DoiMatKhau(string tenDangNhap, string hash, string salt) =>
        Db.Execute("UPDATE TaiKhoan SET MATKHAUHASH = @h, SALT = @s WHERE TENDANGNHAP = @ten",
            Db.P("@h", hash), Db.P("@s", salt), Db.P("@ten", tenDangNhap));

    /// <summary>Thêm tài khoản bên trong một transaction đang mở.</summary>
    public static void Them(SqlConnection conn, SqlTransaction tx, TaiKhoan tk) =>
        DalUtil.Exec(conn, tx,
            @"INSERT INTO TaiKhoan (TENDANGNHAP, MATKHAUHASH, SALT, VAITRO, MAKHOA, MAGV, MASV, HOATDONG)
              VALUES (@ten, @h, @s, @vt, @mk, @gv, @sv, 1)",
            Db.P("@ten", tk.TenDangNhap), Db.P("@h", tk.MatKhauHash), Db.P("@s", tk.Salt),
            Db.P("@vt", tk.VaiTro.ToString()), Db.P("@mk", tk.MaKhoa), Db.P("@gv", tk.MaGV), Db.P("@sv", tk.MaSV));
}
