using System.Data;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.DAL
{
    public class LopDAL
    {
        private DataBaseProcess dtbase = new DataBaseProcess();

        public DataTable GetAllLop()
        {
            return dtbase.DataReader("SELECT * FROM tblLop");
        }

        public DataTable GetAllLopWithKhoa()
        {
            return dtbase.DataReader("SELECT l.MaLop, l.TenLop, l.KhoaHoc, l.MaKhoa, k.TenKhoa FROM tblLop l LEFT JOIN tblKhoa k ON l.MaKhoa = k.MaKhoa");
        }

        public bool KiemTraTonTai(string maLop)
        {
            DataTable dt = dtbase.DataReader($"SELECT * FROM tblLop WHERE MaLop = '{maLop}'");
            return dt.Rows.Count > 0;
        }

        public bool InsertLop(LopDTO l)
        {
            string sql = $"INSERT INTO tblLop(MaLop, TenLop, KhoaHoc, MaKhoa) VALUES(N'{l.MaLop}', N'{l.TenLop}', N'{l.KhoaHoc}', N'{l.MaKhoa}')";
            return dtbase.DataChange(sql) > 0;
        }

        public bool UpdateLop(LopDTO l)
        {
            string sql = $"UPDATE tblLop SET TenLop = N'{l.TenLop}', KhoaHoc = N'{l.KhoaHoc}', MaKhoa = N'{l.MaKhoa}' WHERE MaLop = N'{l.MaLop}'";
            return dtbase.DataChange(sql) > 0;
        }

        public bool DeleteLop(string maLop)
        {
            string sql = $"DELETE FROM tblLop WHERE MaLop = N'{maLop}'";
            return dtbase.DataChange(sql) > 0;
        }
    }
}
