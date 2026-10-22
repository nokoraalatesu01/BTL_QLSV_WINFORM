using System;
using System.Collections.Generic;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class LopDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        public static List<Lop> Tim(string? keyword, string? maKhoa)
        {
            string sql = @"SELECT l.MALOP, l.TENLOP, l.KHOAHOC, l.MAKHOA, k.TENKHOA
                           FROM Lop l JOIN Khoa k ON k.MAKHOA = l.MAKHOA WHERE 1=1 ";
            if (!string.IsNullOrEmpty(maKhoa))
            {
                sql += " AND l.MAKHOA = '" + maKhoa.Trim() + "'";
            }
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                sql += " AND (l.MALOP LIKE '%" + kw + "%' OR l.TENLOP LIKE N'%" + kw + "%' OR l.KHOAHOC LIKE '%" + kw + "%')";
            }
            sql += " ORDER BY l.MAKHOA, l.MALOP";

            DataTable dt = dtbase.DataReader(sql);
            List<Lop> list = new List<Lop>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new Lop
                {
                    MaLop = r["MALOP"].ToString()?.Trim() ?? "",
                    TenLop = r["TENLOP"].ToString()?.Trim() ?? "",
                    KhoaHoc = r["KHOAHOC"].ToString()?.Trim() ?? "",
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    TenKhoa = r["TENKHOA"].ToString()?.Trim() ?? ""
                });
            }
            return list;
        }

        public static Lop? LayTheoMa(string maLop)
        {
            string sql = @"SELECT l.MALOP, l.TENLOP, l.KHOAHOC, l.MAKHOA, k.TENKHOA
                           FROM Lop l JOIN Khoa k ON k.MAKHOA = l.MAKHOA WHERE l.MALOP = '" + maLop.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new Lop
                {
                    MaLop = r["MALOP"].ToString()?.Trim() ?? "",
                    TenLop = r["TENLOP"].ToString()?.Trim() ?? "",
                    KhoaHoc = r["KHOAHOC"].ToString()?.Trim() ?? "",
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    TenKhoa = r["TENKHOA"].ToString()?.Trim() ?? ""
                };
            }
            return null;
        }

        public static bool TonTai(string maLop)
        {
            string sql = "SELECT MALOP FROM Lop WHERE MALOP = '" + maLop.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0;
        }

        public static void Them(Lop l)
        {
            string sql = "INSERT INTO Lop (MALOP, TENLOP, KHOAHOC, MAKHOA) VALUES ('" + l.MaLop.Trim() + "', N'" + l.TenLop.Trim() + "', '" + l.KhoaHoc.Trim() + "', '" + l.MaKhoa.Trim() + "')";
            dtbase.DataChange(sql);
        }

        public static int Sua(Lop l)
        {
            string sql = "UPDATE Lop SET TENLOP = N'" + l.TenLop.Trim() + "', KHOAHOC = '" + l.KhoaHoc.Trim() + "', MAKHOA = '" + l.MaKhoa.Trim() + "' WHERE MALOP = '" + l.MaLop.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int Xoa(string maLop)
        {
            string sql = "DELETE FROM Lop WHERE MALOP = '" + maLop.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int DemSinhVien(string maLop)
        {
            string sql = "SELECT COUNT(*) FROM Sinhvien WHERE MALOP = '" + maLop.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
    }
}
