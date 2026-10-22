using System;
using System.Collections.Generic;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class GiangVienDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        public static List<GiangVien> Tim(string? keyword, string? maKhoa)
        {
            string sql = @"SELECT g.MAGV, g.HO, g.TEN, g.HOCVI, g.HOCHAM, g.CHUYENMON, g.MAKHOA, k.TENKHOA
                           FROM GIANGVIEN g JOIN Khoa k ON k.MAKHOA = g.MAKHOA WHERE 1=1 ";
            if (!string.IsNullOrEmpty(maKhoa))
            {
                sql += " AND g.MAKHOA = '" + maKhoa.Trim() + "'";
            }
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                sql += " AND (g.MAGV LIKE '%" + kw + "%' OR g.HO LIKE N'%" + kw + "%' OR g.TEN LIKE N'%" + kw + "%' OR (g.HO + N' ' + g.TEN) LIKE N'%" + kw + "%' OR g.CHUYENMON LIKE N'%" + kw + "%')";
            }
            sql += " ORDER BY g.MAKHOA, g.TEN, g.HO";

            DataTable dt = dtbase.DataReader(sql);
            List<GiangVien> list = new List<GiangVien>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new GiangVien
                {
                    MaGV = r["MAGV"].ToString()?.Trim() ?? "",
                    Ho = r["HO"].ToString()?.Trim() ?? "",
                    Ten = r["TEN"].ToString()?.Trim() ?? "",
                    HocVi = r["HOCVI"] == DBNull.Value ? null : r["HOCVI"].ToString()?.Trim(),
                    HocHam = r["HOCHAM"] == DBNull.Value ? null : r["HOCHAM"].ToString()?.Trim(),
                    ChuyenMon = r["CHUYENMON"] == DBNull.Value ? null : r["CHUYENMON"].ToString()?.Trim(),
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    TenKhoa = r["TENKHOA"].ToString()?.Trim() ?? ""
                });
            }
            return list;
        }

        public static GiangVien? LayTheoMa(string maGV)
        {
            string sql = @"SELECT g.MAGV, g.HO, g.TEN, g.HOCVI, g.HOCHAM, g.CHUYENMON, g.MAKHOA, k.TENKHOA
                           FROM GIANGVIEN g JOIN Khoa k ON k.MAKHOA = g.MAKHOA WHERE g.MAGV = '" + maGV.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new GiangVien
                {
                    MaGV = r["MAGV"].ToString()?.Trim() ?? "",
                    Ho = r["HO"].ToString()?.Trim() ?? "",
                    Ten = r["TEN"].ToString()?.Trim() ?? "",
                    HocVi = r["HOCVI"] == DBNull.Value ? null : r["HOCVI"].ToString()?.Trim(),
                    HocHam = r["HOCHAM"] == DBNull.Value ? null : r["HOCHAM"].ToString()?.Trim(),
                    ChuyenMon = r["CHUYENMON"] == DBNull.Value ? null : r["CHUYENMON"].ToString()?.Trim(),
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    TenKhoa = r["TENKHOA"].ToString()?.Trim() ?? ""
                };
            }
            return null;
        }

        public static bool TonTai(string maGV)
        {
            string sql = "SELECT MAGV FROM GIANGVIEN WHERE MAGV = '" + maGV.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0;
        }

        public static void Them(GiangVien g, TaiKhoan taiKhoan)
        {
            string sql = "INSERT INTO GIANGVIEN (MAGV, HO, TEN, HOCVI, HOCHAM, CHUYENMON, MAKHOA) VALUES (" +
                         "'" + g.MaGV.Trim() + "', N'" + g.Ho.Trim() + "', N'" + g.Ten.Trim() + "', " +
                         (string.IsNullOrEmpty(g.HocVi) ? "NULL" : "N'" + g.HocVi.Trim() + "'") + ", " +
                         (string.IsNullOrEmpty(g.HocHam) ? "NULL" : "N'" + g.HocHam.Trim() + "'") + ", " +
                         (string.IsNullOrEmpty(g.ChuyenMon) ? "NULL" : "N'" + g.ChuyenMon.Trim() + "'") + ", " +
                         "'" + g.MaKhoa.Trim() + "')";
            dtbase.DataChange(sql);
            TaiKhoanDAL.Them(taiKhoan);
        }

        public static int Sua(GiangVien g)
        {
            string sql = "UPDATE GIANGVIEN SET " +
                         "HO = N'" + g.Ho.Trim() + "', " +
                         "TEN = N'" + g.Ten.Trim() + "', " +
                         "HOCVI = " + (string.IsNullOrEmpty(g.HocVi) ? "NULL" : "N'" + g.HocVi.Trim() + "'") + ", " +
                         "HOCHAM = " + (string.IsNullOrEmpty(g.HocHam) ? "NULL" : "N'" + g.HocHam.Trim() + "'") + ", " +
                         "CHUYENMON = " + (string.IsNullOrEmpty(g.ChuyenMon) ? "NULL" : "N'" + g.ChuyenMon.Trim() + "'") + ", " +
                         "MAKHOA = '" + g.MaKhoa.Trim() + "' " +
                         "WHERE MAGV = '" + g.MaGV.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int Xoa(string maGV)
        {
            string sql = "DELETE FROM GIANGVIEN WHERE MAGV = '" + maGV.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int DemLopTinChi(string maGV)
        {
            string sql = "SELECT COUNT(*) FROM LOPTINCHI WHERE MAGV = '" + maGV.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
    }
}
