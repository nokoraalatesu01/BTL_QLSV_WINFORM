using System;
using System.Collections.Generic;
using System.Data;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.DAL
{
    public static class KhoaDAL
    {
        private static DataBaseProcess dtbase = new DataBaseProcess();

        /// <summary>maKhoa = null: lấy tất cả khoa.</summary>
        public static List<Khoa> LayTatCa(string? maKhoa = null)
        {
            string sql = "SELECT MAKHOA, TENKHOA FROM Khoa";
            if (!string.IsNullOrEmpty(maKhoa))
            {
                sql += " WHERE MAKHOA = '" + maKhoa.Trim() + "'";
            }
            sql += " ORDER BY TENKHOA";

            DataTable dt = dtbase.DataReader(sql);
            List<Khoa> list = new List<Khoa>();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new Khoa
                {
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    TenKhoa = r["TENKHOA"].ToString()?.Trim() ?? ""
                });
            }
            return list;
        }

        public static Khoa? LayTheoMa(string maKhoa)
        {
            string sql = "SELECT MAKHOA, TENKHOA FROM Khoa WHERE MAKHOA = '" + maKhoa.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new Khoa
                {
                    MaKhoa = r["MAKHOA"].ToString()?.Trim() ?? "",
                    TenKhoa = r["TENKHOA"].ToString()?.Trim() ?? ""
                };
            }
            return null;
        }

        public static bool TonTai(string maKhoa)
        {
            string sql = "SELECT MAKHOA FROM Khoa WHERE MAKHOA = '" + maKhoa.Trim() + "'";
            DataTable dt = dtbase.DataReader(sql);
            return dt.Rows.Count > 0;
        }

        /// <summary>Thêm khoa; nếu có tài khoản kèm theo thì thêm luôn tài khoản.</summary>
        public static void Them(Khoa k, TaiKhoan? taiKhoanKhoa)
        {
            string sql = "INSERT INTO Khoa (MAKHOA, TENKHOA) VALUES (N'" + k.MaKhoa.Trim() + "', N'" + k.TenKhoa.Trim() + "')";
            dtbase.DataChange(sql);
            if (taiKhoanKhoa != null)
            {
                TaiKhoanDAL.Them(taiKhoanKhoa);
            }
        }

        public static int Sua(Khoa k)
        {
            string sql = "UPDATE Khoa SET TENKHOA = N'" + k.TenKhoa.Trim() + "' WHERE MAKHOA = '" + k.MaKhoa.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }

        /// <summary>Số lớp, giảng viên, lớp tín chỉ đang thuộc khoa.</summary>
        public static (int Lop, int GiangVien, int LopTinChi) DemThamChieu(string maKhoa)
        {
            string sqlLop = "SELECT COUNT(*) FROM Lop WHERE MAKHOA = '" + maKhoa.Trim() + "'";
            string sqlGV = "SELECT COUNT(*) FROM GIANGVIEN WHERE MAKHOA = '" + maKhoa.Trim() + "'";
            string sqlLTC = "SELECT COUNT(*) FROM LOPTINCHI WHERE MAKHOA = '" + maKhoa.Trim() + "'";

            DataTable dtLop = dtbase.DataReader(sqlLop);
            DataTable dtGV = dtbase.DataReader(sqlGV);
            DataTable dtLTC = dtbase.DataReader(sqlLTC);

            int lop = dtLop.Rows.Count > 0 ? Convert.ToInt32(dtLop.Rows[0][0]) : 0;
            int gv = dtGV.Rows.Count > 0 ? Convert.ToInt32(dtGV.Rows[0][0]) : 0;
            int ltc = dtLTC.Rows.Count > 0 ? Convert.ToInt32(dtLTC.Rows[0][0]) : 0;

            return (lop, gv, ltc);
        }

        /// <summary>Xóa khoa cùng tài khoản đăng nhập vai trò KHOA của khoa đó.</summary>
        public static int Xoa(string maKhoa)
        {
            string sqlTK = "DELETE FROM TaiKhoan WHERE MAKHOA = '" + maKhoa.Trim() + "' AND VAITRO = 'KHOA'";
            dtbase.DataChange(sqlTK);

            string sql = "DELETE FROM Khoa WHERE MAKHOA = '" + maKhoa.Trim() + "'";
            dtbase.DataChange(sql);
            return 1;
        }
    }
}
