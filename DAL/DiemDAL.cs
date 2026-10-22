using System;
using System.Collections.Generic;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class DiemDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        /// <summary>Danh sách sinh viên (đăng ký chưa hủy) của một lớp tín chỉ cùng điểm.</summary>
        public static List<DiemSinhVien> LayDanhSach(int maLTC)
        {
            string sql = @"SELECT d.MALTC, d.MASV, s.HO, s.TEN, s.MALOP, d.DIEM_CC, d.DIEM_GK, d.DIEM_CK, d.DIEM_TK
                           FROM DANGKY d JOIN Sinhvien s ON s.MASV = d.MASV
                           WHERE d.MALTC = " + maLTC + @" AND d.HUYDANGKY = 0
                           ORDER BY s.TEN, s.HO, d.MASV";
            DataTable dt = dtbase.DataReader(sql);
            List<DiemSinhVien> list = new List<DiemSinhVien>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new DiemSinhVien
                {
                    MaLTC = Convert.ToInt32(r["MALTC"]),
                    MaSV = r["MASV"].ToString()?.Trim() ?? "",
                    HoTen = (r["HO"].ToString()?.Trim() + " " + r["TEN"].ToString()?.Trim()).Trim(),
                    MaLop = r["MALOP"].ToString()?.Trim() ?? "",
                    DiemCC = r["DIEM_CC"] == DBNull.Value ? null : (int?)Convert.ToInt32(r["DIEM_CC"]),
                    DiemGK = r["DIEM_GK"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["DIEM_GK"]),
                    DiemCK = r["DIEM_CK"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["DIEM_CK"]),
                    DiemTK = r["DIEM_TK"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["DIEM_TK"])
                });
            }
            return list;
        }

        /// <summary>Lưu điểm cả lớp.</summary>
        public static void CapNhat(int maLTC, IEnumerable<DiemSinhVien> danhSach)
        {
            foreach (var d in danhSach)
            {
                string ccVal = d.DiemCC.HasValue ? d.DiemCC.Value.ToString() : "NULL";
                string gkVal = d.DiemGK.HasValue ? d.DiemGK.Value.ToString(System.Globalization.CultureInfo.InvariantCulture) : "NULL";
                string ckVal = d.DiemCK.HasValue ? d.DiemCK.Value.ToString(System.Globalization.CultureInfo.InvariantCulture) : "NULL";

                string sql = "UPDATE DANGKY SET DIEM_CC = " + ccVal + ", DIEM_GK = " + gkVal + ", DIEM_CK = " + ckVal +
                             " WHERE MALTC = " + maLTC + " AND MASV = '" + d.MaSV.Trim() + "' AND HUYDANGKY = 0";
                dtbase.DataChange(sql);
            }
        }

        /// <summary>Bảng điểm của một sinh viên (các lớp tín chỉ chưa hủy).</summary>
        public static List<BangDiemDong> LayBangDiemSinhVien(string maSV)
        {
            string sql = @"SELECT t.MALTC, t.NIENKHOA, t.HOCKY, t.MAMH, m.TENMH, t.NHOM,
                                  d.DIEM_CC, d.DIEM_GK, d.DIEM_CK, d.DIEM_TK
                           FROM DANGKY d
                           JOIN LOPTINCHI t ON t.MALTC = d.MALTC
                           JOIN Monhoc m ON m.MAMH = t.MAMH
                           WHERE d.MASV = '" + maSV.Trim() + @"' AND d.HUYDANGKY = 0 AND t.HUYLOP = 0
                           ORDER BY t.NIENKHOA, t.HOCKY, m.TENMH";
            DataTable dt = dtbase.DataReader(sql);
            List<BangDiemDong> list = new List<BangDiemDong>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new BangDiemDong
                {
                    MaLTC = Convert.ToInt32(r["MALTC"]),
                    NienKhoa = r["NIENKHOA"].ToString()?.Trim() ?? "",
                    HocKy = Convert.ToInt32(r["HOCKY"]),
                    MaMH = r["MAMH"].ToString()?.Trim() ?? "",
                    TenMH = r["TENMH"].ToString()?.Trim() ?? "",
                    Nhom = Convert.ToInt32(r["NHOM"]),
                    DiemCC = r["DIEM_CC"] == DBNull.Value ? null : (int?)Convert.ToInt32(r["DIEM_CC"]),
                    DiemGK = r["DIEM_GK"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["DIEM_GK"]),
                    DiemCK = r["DIEM_CK"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["DIEM_CK"]),
                    DiemTK = r["DIEM_TK"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["DIEM_TK"])
                });
            }
            return list;
        }

        public static int DemDangKy(int maLTC)
        {
            string sql = "SELECT COUNT(*) FROM DANGKY WHERE MALTC = " + maLTC + " AND HUYDANGKY = 0";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
    }
}
