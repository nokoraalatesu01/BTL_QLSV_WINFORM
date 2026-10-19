using System;
using System.Data;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.DAL
{
    public class SinhVienDAL
    {
        private DataBaseProcess dtbase = new DataBaseProcess();

        public DataTable GetAllSinhVien()
        {
            string sql = @"SELECT sv.MaSV, sv.HoDem, sv.Ten, 
                                 (sv.HoDem + ' ' + sv.Ten) AS HoVaTen,
                                 sv.NgaySinh, sv.GioiTinh, sv.QueQuan, 
                                 sv.SoDienThoai, sv.Email, sv.MaLop, 
                                 l.TenLop, k.TenKhoa, sv.AnhDaiDien
                          FROM tblSinhVien sv 
                          LEFT JOIN tblLop l ON sv.MaLop = l.MaLop 
                          LEFT JOIN tblKhoa k ON l.MaKhoa = k.MaKhoa";
            return dtbase.DataReader(sql);
        }

        public bool KiemTraTonTai(string maSV)
        {
            DataTable dt = dtbase.DataReader($"SELECT * FROM tblSinhVien WHERE MaSV = '{maSV}'");
            return dt.Rows.Count > 0;
        }

        public bool InsertSinhVien(SinhVienDTO sv)
        {
            string ngaySinh = sv.NgaySinh.ToString("yyyy-MM-dd");
            string sql = $@"INSERT INTO tblSinhVien(MaSV, HoDem, Ten, NgaySinh, GioiTinh, QueQuan, SoDienThoai, Email, MaLop, AnhDaiDien) 
                           VALUES(N'{sv.MaSV}', N'{sv.HoDem}', N'{sv.Ten}', '{ngaySinh}', N'{sv.GioiTinh}', N'{sv.QueQuan}', N'{sv.SoDienThoai}', N'{sv.Email}', N'{sv.MaLop}', N'{sv.AnhDaiDien}')";
            return dtbase.DataChange(sql) > 0;
        }

        public bool UpdateSinhVien(SinhVienDTO sv)
        {
            string ngaySinh = sv.NgaySinh.ToString("yyyy-MM-dd");
            string sql = $@"UPDATE tblSinhVien SET 
                           HoDem = N'{sv.HoDem}',
                           Ten = N'{sv.Ten}',
                           NgaySinh = '{ngaySinh}',
                           GioiTinh = N'{sv.GioiTinh}',
                           QueQuan = N'{sv.QueQuan}',
                           SoDienThoai = N'{sv.SoDienThoai}',
                           Email = N'{sv.Email}',
                           MaLop = N'{sv.MaLop}',
                           AnhDaiDien = N'{sv.AnhDaiDien}'
                           WHERE MaSV = N'{sv.MaSV}'";
            return dtbase.DataChange(sql) > 0;
        }

        public bool DeleteSinhVien(string maSV)
        {
            string sql = $"DELETE FROM tblSinhVien WHERE MaSV = N'{maSV}'";
            return dtbase.DataChange(sql) > 0;
        }

        public DataTable TimKiemSinhVien(string maSV, string hoTen, string maLop, string maKhoa)
        {
            string sql = @"SELECT sv.MaSV, sv.HoDem, sv.Ten, 
                                 (sv.HoDem + ' ' + sv.Ten) AS HoVaTen,
                                 sv.NgaySinh, sv.GioiTinh, sv.QueQuan, 
                                 sv.SoDienThoai, sv.Email, sv.MaLop, 
                                 l.TenLop, k.TenKhoa, sv.AnhDaiDien
                          FROM tblSinhVien sv 
                          LEFT JOIN tblLop l ON sv.MaLop = l.MaLop 
                          LEFT JOIN tblKhoa k ON l.MaKhoa = k.MaKhoa
                          WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(maSV))
                sql += $" AND sv.MaSV LIKE '%{maSV.Trim()}%'";

            if (!string.IsNullOrWhiteSpace(hoTen))
                sql += $" AND (sv.HoDem + ' ' + sv.Ten) LIKE N'%{hoTen.Trim()}%'";

            if (!string.IsNullOrWhiteSpace(maLop) && maLop != "Tất cả")
                sql += $" AND sv.MaLop = '{maLop}'";

            if (!string.IsNullOrWhiteSpace(maKhoa) && maKhoa != "Tất cả")
                sql += $" AND l.MaKhoa = '{maKhoa}'";

            return dtbase.DataReader(sql);
        }
    }
}
