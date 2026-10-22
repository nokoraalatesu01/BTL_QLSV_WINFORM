using System;
using System.Collections.Generic;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class SinhVienDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        public static List<SinhVien> Tim(string? keyword, string? maKhoa, string? maLop)
        {
            string sql = @"SELECT s.MASV, s.HO, s.TEN, s.MALOP, l.TENLOP, l.MAKHOA, s.GIOITINH, s.DIACHI, s.NGAYSINH, s.DANGHIHOC
                           FROM Sinhvien s JOIN Lop l ON l.MALOP = s.MALOP WHERE 1=1 ";
            if (!string.IsNullOrEmpty(maKhoa))
            {
                sql += " AND l.MAKHOA = '" + maKhoa.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(maLop))
            {
                sql += " AND s.MALOP = '" + maLop.Trim() + "'";
            }
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                sql += " AND (s.MASV LIKE '%" + kw + "%' OR s.HO LIKE N'%" + kw + "%' OR s.TEN LIKE N'%" + kw + "%' OR (s.HO + N' ' + s.TEN) LIKE N'%" + kw + "%' OR s.DIACHI LIKE N'%" + kw + "%')";
            }
            sql += " ORDER BY s.MALOP, s.TEN, s.HO";

            DataTable dt = dtbase.DataReader(sql);
            List<SinhVien> list = new List<SinhVien>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new SinhVien
                {
                    MaSV = r["MASV"].ToString()?.Trim() ?? "",
                    Ho = r["HO"].ToString()?.Trim() ?? "",
                    Ten = r["TEN"].ToString()?.Trim() ?? "",
                    MaLop = r["MALOP"].ToString()?.Trim() ?? "",
                    TenLop = r["TENLOP"].ToString()?.Trim() ?? "",
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    GioiTinh = r["GIOITINH"].ToString()?.Trim() ?? "",
                    DiaChi = r["DIACHI"] == DBNull.Value ? null : r["DIACHI"].ToString()?.Trim(),
                    NgaySinh = r["NGAYSINH"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(r["NGAYSINH"]),
                    DaNghiHoc = Convert.ToBoolean(r["DANGHIHOC"])
                });
            }
            return list;
        }

        public static SinhVien? LayTheoMa(string maSV)
        {
            string sql = @"SELECT s.MASV, s.HO, s.TEN, s.MALOP, l.TENLOP, l.MAKHOA, s.GIOITINH, s.DIACHI, s.NGAYSINH, s.DANGHIHOC
                           FROM Sinhvien s JOIN Lop l ON l.MALOP = s.MALOP WHERE s.MASV = '" + maSV.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new SinhVien
                {
                    MaSV = r["MASV"].ToString()?.Trim() ?? "",
                    Ho = r["HO"].ToString()?.Trim() ?? "",
                    Ten = r["TEN"].ToString()?.Trim() ?? "",
                    MaLop = r["MALOP"].ToString()?.Trim() ?? "",
                    TenLop = r["TENLOP"].ToString()?.Trim() ?? "",
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    GioiTinh = r["GIOITINH"].ToString()?.Trim() ?? "",
                    DiaChi = r["DIACHI"] == DBNull.Value ? null : r["DIACHI"].ToString()?.Trim(),
                    NgaySinh = r["NGAYSINH"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(r["NGAYSINH"]),
                    DaNghiHoc = Convert.ToBoolean(r["DANGHIHOC"])
                };
            }
            return null;
        }

        public static bool TonTai(string maSV)
        {
            string sql = "SELECT MASV FROM Sinhvien WHERE MASV = '" + maSV.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0;
        }

        public static void Them(SinhVien sv, TaiKhoan taiKhoan)
        {
            string ngaySinhSql = sv.NgaySinh.HasValue ? "'" + sv.NgaySinh.Value.ToString("yyyy-MM-dd") + "'" : "NULL";
            string sql = "INSERT INTO Sinhvien (MASV, HO, TEN, MALOP, GIOITINH, DIACHI, NGAYSINH, DANGHIHOC) VALUES (" +
                         "'" + sv.MaSV.Trim() + "', N'" + sv.Ho.Trim() + "', N'" + sv.Ten.Trim() + "', '" + sv.MaLop.Trim() + "', " +
                         "N'" + sv.GioiTinh.Trim() + "', " + (string.IsNullOrEmpty(sv.DiaChi) ? "NULL" : "N'" + sv.DiaChi.Trim() + "'") + ", " +
                         ngaySinhSql + ", " + (sv.DaNghiHoc ? "1" : "0") + ")";
            dtbase.DataChange(sql);
            TaiKhoanDAL.Them(taiKhoan);
        }

        public static int Sua(SinhVien sv)
        {
            string ngaySinhSql = sv.NgaySinh.HasValue ? "'" + sv.NgaySinh.Value.ToString("yyyy-MM-dd") + "'" : "NULL";
            string sql = "UPDATE Sinhvien SET " +
                         "HO = N'" + sv.Ho.Trim() + "', " +
                         "TEN = N'" + sv.Ten.Trim() + "', " +
                         "MALOP = '" + sv.MaLop.Trim() + "', " +
                         "GIOITINH = N'" + sv.GioiTinh.Trim() + "', " +
                         "DIACHI = " + (string.IsNullOrEmpty(sv.DiaChi) ? "NULL" : "N'" + sv.DiaChi.Trim() + "'") + ", " +
                         "NGAYSINH = " + ngaySinhSql + ", " +
                         "DANGHIHOC = " + (sv.DaNghiHoc ? "1" : "0") + " " +
                         "WHERE MASV = '" + sv.MaSV.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int Xoa(string maSV)
        {
            string sql = "DELETE FROM Sinhvien WHERE MASV = '" + maSV.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int DemDangKy(string maSV)
        {
            string sql = "SELECT COUNT(*) FROM DANGKY WHERE MASV = '" + maSV.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
    }
}
