using System;
using System.Data;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.DAL
{
    public class TaiKhoanDAL
    {
        private DataBaseProcess dtbase = new DataBaseProcess();

        public TaiKhoanDTO? KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string sql = $"SELECT * FROM tblTaiKhoan WHERE TenDangNhap = '{tenDangNhap}' AND MatKhau = '{matKhau}'";
            DataTable dt = dtbase.DataReader(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new TaiKhoanDTO
                {
                    TenDangNhap = r["TenDangNhap"].ToString() ?? "",
                    MatKhau = r["MatKhau"].ToString() ?? "",
                    HoTen = r["HoTen"].ToString() ?? "",
                    Quyen = r["Quyen"].ToString() ?? "User",
                    Email = r["Email"].ToString() ?? ""
                };
            }
            return null;
        }

        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            string sql = $"UPDATE tblTaiKhoan SET MatKhau = '{matKhauMoi}' WHERE TenDangNhap = '{tenDangNhap}'";
            return dtbase.DataChange(sql) > 0;
        }
    }
}
