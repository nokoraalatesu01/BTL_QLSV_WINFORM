using System;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class TaiKhoanDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        public static TaiKhoan? LayTheoTen(string tenDangNhap)
        {
            string sql = "SELECT TENDANGNHAP, MATKHAUHASH, SALT, VAITRO, MAKHOA, MAGV, MASV, HOATDONG FROM TaiKhoan WHERE TENDANGNHAP = '" + tenDangNhap.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                if (!Enum.TryParse<VaiTro>(r["VAITRO"].ToString()?.Trim(), true, out var vaiTro))
                    throw new BusinessException("Tài khoản có vai trò không hợp lệ trong cơ sở dữ liệu.");

                return new TaiKhoan
                {
                    TenDangNhap = r["TENDANGNHAP"].ToString()?.Trim() ?? "",
                    MatKhauHash = r["MATKHAUHASH"].ToString()?.Trim() ?? "",
                    Salt = r["SALT"].ToString()?.Trim() ?? "",
                    VaiTro = vaiTro,
                    MaKhoa = r["MAKHOA"] == DBNull.Value ? null : r["MAKHOA"].ToString()?.Trim(),
                    MaGV = r["MAGV"] == DBNull.Value ? null : r["MAGV"].ToString()?.Trim(),
                    MaSV = r["MASV"] == DBNull.Value ? null : r["MASV"].ToString()?.Trim(),
                    HoatDong = Convert.ToBoolean(r["HOATDONG"])
                };
            }
            return null;
        }

        public static bool TonTai(string tenDangNhap)
        {
            string sql = "SELECT TENDANGNHAP FROM TaiKhoan WHERE TENDANGNHAP = '" + tenDangNhap.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0;
        }

        public static int DoiMatKhau(string tenDangNhap, string hash, string salt)
        {
            string sql = "UPDATE TaiKhoan SET MATKHAUHASH = '" + hash + "', SALT = '" + salt + "' WHERE TENDANGNHAP = '" + tenDangNhap.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static void Them(TaiKhoan tk)
        {
            string mkVal = string.IsNullOrEmpty(tk.MaKhoa) ? "NULL" : "'" + tk.MaKhoa.Trim() + "'";
            string gvVal = string.IsNullOrEmpty(tk.MaGV) ? "NULL" : "'" + tk.MaGV.Trim() + "'";
            string svVal = string.IsNullOrEmpty(tk.MaSV) ? "NULL" : "'" + tk.MaSV.Trim() + "'";
            string sql = "INSERT INTO TaiKhoan (TENDANGNHAP, MATKHAUHASH, SALT, VAITRO, MAKHOA, MAGV, MASV, HOATDONG) VALUES (" +
                         "'" + tk.TenDangNhap.Trim() + "', '" + tk.MatKhauHash + "', '" + tk.Salt + "', '" + tk.VaiTro.ToString() + "', " +
                         mkVal + ", " + gvVal + ", " + svVal + ", 1)";
            dtbase.DataChange(sql);
        }
    }
}
