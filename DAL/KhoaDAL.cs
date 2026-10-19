using System.Data;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.DAL
{
    public class KhoaDAL
    {
        private DataBaseProcess dtbase = new DataBaseProcess();

        public DataTable GetAllKhoa()
        {
            return dtbase.DataReader("SELECT * FROM tblKhoa");
        }

        public bool KiemTraTonTai(string maKhoa)
        {
            DataTable dt = dtbase.DataReader($"SELECT * FROM tblKhoa WHERE MaKhoa = '{maKhoa}'");
            return dt.Rows.Count > 0;
        }

        public bool InsertKhoa(KhoaDTO k)
        {
            string sql = $"INSERT INTO tblKhoa(MaKhoa, TenKhoa, VanPhong, SoDienThoai) VALUES(N'{k.MaKhoa}', N'{k.TenKhoa}', N'{k.VanPhong}', N'{k.SoDienThoai}')";
            return dtbase.DataChange(sql) > 0;
        }

        public bool UpdateKhoa(KhoaDTO k)
        {
            string sql = $"UPDATE tblKhoa SET TenKhoa = N'{k.TenKhoa}', VanPhong = N'{k.VanPhong}', SoDienThoai = N'{k.SoDienThoai}' WHERE MaKhoa = N'{k.MaKhoa}'";
            return dtbase.DataChange(sql) > 0;
        }

        public bool DeleteKhoa(string maKhoa)
        {
            string sql = $"DELETE FROM tblKhoa WHERE MaKhoa = N'{maKhoa}'";
            return dtbase.DataChange(sql) > 0;
        }
    }
}
