using System;
using System.Data;
using System.Globalization;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.DAL
{
    public class DiemDAL
    {
        private DataBaseProcess dtbase = new DataBaseProcess();

        public DataTable GetAllDiem()
        {
            string sql = @"SELECT d.MaSV, (sv.HoDem + ' ' + sv.Ten) AS HoTen,
                                 d.MaMH, mh.TenMH, mh.SoTinChi,
                                 d.DiemQuaTrinh, d.DiemThi, d.DiemTongKet, d.DiemChu
                          FROM tblDiem d
                          LEFT JOIN tblSinhVien sv ON d.MaSV = sv.MaSV
                          LEFT JOIN tblMonHoc mh ON d.MaMH = mh.MaMH";
            return dtbase.DataReader(sql);
        }

        public DataTable GetDiemBySinhVien(string maSV)
        {
            string sql = $@"SELECT d.MaSV, (sv.HoDem + ' ' + sv.Ten) AS HoTen,
                                  d.MaMH, mh.TenMH, mh.SoTinChi,
                                  d.DiemQuaTrinh, d.DiemThi, d.DiemTongKet, d.DiemChu
                           FROM tblDiem d
                           LEFT JOIN tblSinhVien sv ON d.MaSV = sv.MaSV
                           LEFT JOIN tblMonHoc mh ON d.MaMH = mh.MaMH
                           WHERE d.MaSV = '{maSV}'";
            return dtbase.DataReader(sql);
        }

        public bool KiemTraTonTai(string maSV, string maMH)
        {
            DataTable dt = dtbase.DataReader($"SELECT * FROM tblDiem WHERE MaSV = '{maSV}' AND MaMH = '{maMH}'");
            return dt.Rows.Count > 0;
        }

        public bool InsertDiem(DiemDTO d)
        {
            string dqt = d.DiemQuaTrinh.ToString(CultureInfo.InvariantCulture);
            string dthi = d.DiemThi.ToString(CultureInfo.InvariantCulture);
            string dtk = d.DiemTongKet.ToString(CultureInfo.InvariantCulture);

            string sql = $@"INSERT INTO tblDiem(MaSV, MaMH, DiemQuaTrinh, DiemThi, DiemTongKet, DiemChu) 
                           VALUES(N'{d.MaSV}', N'{d.MaMH}', {dqt}, {dthi}, {dtk}, N'{d.DiemChu}')";
            return dtbase.DataChange(sql) > 0;
        }

        public bool UpdateDiem(DiemDTO d)
        {
            string dqt = d.DiemQuaTrinh.ToString(CultureInfo.InvariantCulture);
            string dthi = d.DiemThi.ToString(CultureInfo.InvariantCulture);
            string dtk = d.DiemTongKet.ToString(CultureInfo.InvariantCulture);

            string sql = $@"UPDATE tblDiem SET 
                           DiemQuaTrinh = {dqt},
                           DiemThi = {dthi},
                           DiemTongKet = {dtk},
                           DiemChu = N'{d.DiemChu}'
                           WHERE MaSV = N'{d.MaSV}' AND MaMH = N'{d.MaMH}'";
            return dtbase.DataChange(sql) > 0;
        }

        public bool DeleteDiem(string maSV, string maMH)
        {
            string sql = $"DELETE FROM tblDiem WHERE MaSV = N'{maSV}' AND MaMH = N'{maMH}'";
            return dtbase.DataChange(sql) > 0;
        }
    }
}
