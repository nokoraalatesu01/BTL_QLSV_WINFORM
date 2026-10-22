using System;
using System.Collections.Generic;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class LopTinChiDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        private const string SelectSql =
            @"SELECT t.MALTC, t.NIENKHOA, t.HOCKY, t.MAMH, m.TENMH, t.NHOM, t.MAGV,
                     (g.HO + N' ' + g.TEN) AS TENGV, t.MAKHOA, t.SOSVTOITHIEU, t.HUYLOP,
                     (SELECT COUNT(*) FROM DANGKY d WHERE d.MALTC = t.MALTC AND d.HUYDANGKY = 0) AS SOSV
              FROM LOPTINCHI t
              JOIN Monhoc m ON m.MAMH = t.MAMH
              JOIN GIANGVIEN g ON g.MAGV = t.MAGV ";

        public static List<LopTinChi> Tim(string? maKhoa, string? nienKhoa, int? hocKy)
        {
            string sql = SelectSql + " WHERE 1=1 ";
            if (!string.IsNullOrEmpty(maKhoa))
            {
                sql += " AND t.MAKHOA = '" + maKhoa.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(nienKhoa))
            {
                sql += " AND t.NIENKHOA = '" + nienKhoa.Trim() + "'";
            }
            if (hocKy.HasValue)
            {
                sql += " AND t.HOCKY = " + hocKy.Value;
            }
            sql += " ORDER BY t.NIENKHOA DESC, t.HOCKY, m.TENMH, t.NHOM";

            DataTable dt = dtbase.DataReader(sql);
            List<LopTinChi> list = new List<LopTinChi>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new LopTinChi
                {
                    MaLTC = Convert.ToInt32(r["MALTC"]),
                    NienKhoa = r["NIENKHOA"].ToString()?.Trim() ?? "",
                    HocKy = Convert.ToInt32(r["HOCKY"]),
                    MaMH = r["MAMH"].ToString()?.Trim() ?? "",
                    TenMH = r["TENMH"].ToString()?.Trim() ?? "",
                    Nhom = Convert.ToInt32(r["NHOM"]),
                    MaGV = r["MAGV"].ToString()?.Trim() ?? "",
                    TenGV = r["TENGV"].ToString()?.Trim() ?? "",
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    SoSVToiThieu = Convert.ToInt32(r["SOSVTOITHIEU"]),
                    HuyLop = Convert.ToBoolean(r["HUYLOP"]),
                    SoSV = Convert.ToInt32(r["SOSV"])
                });
            }
            return list;
        }

        public static LopTinChi? LayTheoMa(int maLTC)
        {
            string sql = SelectSql + " WHERE t.MALTC = " + maLTC;
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new LopTinChi
                {
                    MaLTC = Convert.ToInt32(r["MALTC"]),
                    NienKhoa = r["NIENKHOA"].ToString()?.Trim() ?? "",
                    HocKy = Convert.ToInt32(r["HOCKY"]),
                    MaMH = r["MAMH"].ToString()?.Trim() ?? "",
                    TenMH = r["TENMH"].ToString()?.Trim() ?? "",
                    Nhom = Convert.ToInt32(r["NHOM"]),
                    MaGV = r["MAGV"].ToString()?.Trim() ?? "",
                    TenGV = r["TENGV"].ToString()?.Trim() ?? "",
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    SoSVToiThieu = Convert.ToInt32(r["SOSVTOITHIEU"]),
                    HuyLop = Convert.ToBoolean(r["HUYLOP"]),
                    SoSV = Convert.ToInt32(r["SOSV"])
                };
            }
            return null;
        }

        public static List<string> LayNienKhoa(string? maKhoa)
        {
            string sql = "SELECT DISTINCT NIENKHOA FROM LOPTINCHI";
            if (!string.IsNullOrEmpty(maKhoa))
            {
                sql += " WHERE MAKHOA = '" + maKhoa.Trim() + "'";
            }
            sql += " ORDER BY NIENKHOA DESC";

            DataTable dt = dtbase.DataReader(sql);
            List<string> list = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(r["NIENKHOA"].ToString()?.Trim() ?? "");
            }
            return list;
        }

        public static int Them(LopTinChi t)
        {
            string sql = "INSERT INTO LOPTINCHI (NIENKHOA, HOCKY, MAMH, NHOM, MAGV, MAKHOA, SOSVTOITHIEU, HUYLOP) VALUES (" +
                         "'" + t.NienKhoa.Trim() + "', " + t.HocKy + ", '" + t.MaMH.Trim() + "', " + t.Nhom + ", " +
                         "'" + t.MaGV.Trim() + "', '" + t.MaKhoa.Trim() + "', " + t.SoSVToiThieu + ", " + (t.HuyLop ? "1" : "0") + ")";
            dtbase.DataChange(sql);

            // Lấy ID mới nhất
            string sqlId = "SELECT MAX(MALTC) FROM LOPTINCHI";
            DataTable dt = dtbase.DataReader(sqlId);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }

        public static int Sua(LopTinChi t)
        {
            string sql = "UPDATE LOPTINCHI SET " +
                         "NIENKHOA = '" + t.NienKhoa.Trim() + "', " +
                         "HOCKY = " + t.HocKy + ", " +
                         "MAMH = '" + t.MaMH.Trim() + "', " +
                         "NHOM = " + t.Nhom + ", " +
                         "MAGV = '" + t.MaGV.Trim() + "', " +
                         "MAKHOA = '" + t.MaKhoa.Trim() + "', " +
                         "SOSVTOITHIEU = " + t.SoSVToiThieu + ", " +
                         "HUYLOP = " + (t.HuyLop ? "1" : "0") + " " +
                         "WHERE MALTC = " + t.MaLTC;
            dtbase.DataChange(sql);
            return 1;
        }

        public static int Xoa(int maLTC)
        {
            string sql = "DELETE FROM LOPTINCHI WHERE MALTC = " + maLTC;
            dtbase.DataChange(sql);
            return 1;
        }

        public static bool TrungThongTin(string nienKhoa, int hocKy, string maMH, int nhom, int? boQuaMaLTC = null)
        {
            string sql = "SELECT MALTC FROM LOPTINCHI WHERE NIENKHOA = '" + nienKhoa.Trim() + "' AND HOCKY = " + hocKy + " AND MAMH = '" + maMH.Trim() + "' AND NHOM = " + nhom;
            if (boQuaMaLTC.HasValue)
            {
                sql += " AND MALTC <> " + boQuaMaLTC.Value;
            }
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0;
        }

        public static int DemDangKy(int maLTC)
        {
            string sql = "SELECT COUNT(*) FROM DANGKY WHERE MALTC = " + maLTC + " AND HUYDANGKY = 0";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
    }
}
