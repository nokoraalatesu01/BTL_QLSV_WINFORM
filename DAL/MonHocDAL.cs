using System;
using System.Collections.Generic;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class MonHocDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        public static List<MonHoc> Tim(string? keyword)
        {
            string sql = "SELECT MAMH, TENMH, SOTIET_LT, SOTIET_TH FROM Monhoc";
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                sql += " WHERE MAMH LIKE '%" + kw + "%' OR TENMH LIKE N'%" + kw + "%'";
            }
            sql += " ORDER BY MAMH";

            DataTable dt = dtbase.DataReader(sql);
            List<MonHoc> list = new List<MonHoc>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new MonHoc
                {
                    MaMH = r["MAMH"].ToString()?.Trim() ?? "",
                    TenMH = r["TENMH"].ToString()?.Trim() ?? "",
                    SoTietLT = Convert.ToInt32(r["SOTIET_LT"]),
                    SoTietTH = Convert.ToInt32(r["SOTIET_TH"])
                });
            }
            return list;
        }

        public static MonHoc? LayTheoMa(string maMH)
        {
            string sql = "SELECT MAMH, TENMH, SOTIET_LT, SOTIET_TH FROM Monhoc WHERE MAMH = '" + maMH.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new MonHoc
                {
                    MaMH = r["MAMH"].ToString()?.Trim() ?? "",
                    TenMH = r["TENMH"].ToString()?.Trim() ?? "",
                    SoTietLT = Convert.ToInt32(r["SOTIET_LT"]),
                    SoTietTH = Convert.ToInt32(r["SOTIET_TH"])
                };
            }
            return null;
        }

        public static bool TonTai(string maMH)
        {
            string sql = "SELECT MAMH FROM Monhoc WHERE MAMH = '" + maMH.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0;
        }

        public static void Them(MonHoc m)
        {
            string sql = "INSERT INTO Monhoc (MAMH, TENMH, SOTIET_LT, SOTIET_TH) VALUES ('" + m.MaMH.Trim() + "', N'" + m.TenMH.Trim() + "', " + m.SoTietLT + ", " + m.SoTietTH + ")";
            dtbase.DataChange(sql);
        }

        public static int Sua(MonHoc m)
        {
            string sql = "UPDATE Monhoc SET TENMH = N'" + m.TenMH.Trim() + "', SOTIET_LT = " + m.SoTietLT + ", SOTIET_TH = " + m.SoTietTH + " WHERE MAMH = '" + m.MaMH.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int Xoa(string maMH)
        {
            string sql = "DELETE FROM Monhoc WHERE MAMH = '" + maMH.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        public static int DemLopTinChi(string maMH)
        {
            string sql = "SELECT COUNT(*) FROM LOPTINCHI WHERE MAMH = '" + maMH.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
    }
}
