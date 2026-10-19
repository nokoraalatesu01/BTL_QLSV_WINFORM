using System.Data;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.DAL
{
    public class MonHocDAL
    {
        private DataBaseProcess dtbase = new DataBaseProcess();

        public DataTable GetAllMonHoc()
        {
            return dtbase.DataReader("SELECT * FROM tblMonHoc");
        }

        public bool KiemTraTonTai(string maMH)
        {
            DataTable dt = dtbase.DataReader($"SELECT * FROM tblMonHoc WHERE MaMH = '{maMH}'");
            return dt.Rows.Count > 0;
        }

        public bool InsertMonHoc(MonHocDTO mh)
        {
            string sql = $"INSERT INTO tblMonHoc(MaMH, TenMH, SoTinChi, SoTietLT, SoTietTH, HocKy) VALUES(N'{mh.MaMH}', N'{mh.TenMH}', {mh.SoTinChi}, {mh.SoTietLT}, {mh.SoTietTH}, {mh.HocKy})";
            return dtbase.DataChange(sql) > 0;
        }

        public bool UpdateMonHoc(MonHocDTO mh)
        {
            string sql = $"UPDATE tblMonHoc SET TenMH = N'{mh.TenMH}', SoTinChi = {mh.SoTinChi}, SoTietLT = {mh.SoTietLT}, SoTietTH = {mh.SoTietTH}, HocKy = {mh.HocKy} WHERE MaMH = N'{mh.MaMH}'";
            return dtbase.DataChange(sql) > 0;
        }

        public bool DeleteMonHoc(string maMH)
        {
            string sql = $"DELETE FROM tblMonHoc WHERE MaMH = N'{maMH}'";
            return dtbase.DataChange(sql) > 0;
        }
    }
}
