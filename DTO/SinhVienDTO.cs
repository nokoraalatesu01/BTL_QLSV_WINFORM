using System;

namespace BTL_QLSV_WINFORM.DTO
{
    public class SinhVienDTO
    {
        public string MaSV { get; set; } = string.Empty;
        public string HoDem { get; set; } = string.Empty;
        public string Ten { get; set; } = string.Empty;
        public string HoVaTen => $"{HoDem} {Ten}".Trim();
        public DateTime NgaySinh { get; set; } = DateTime.Today;
        public string GioiTinh { get; set; } = "Nam";
        public string QueQuan { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MaLop { get; set; } = string.Empty;
        public string TenLop { get; set; } = string.Empty;
        public string TenKhoa { get; set; } = string.Empty;
        public string AnhDaiDien { get; set; } = string.Empty;

        public SinhVienDTO() { }

        public SinhVienDTO(string maSV, string hoDem, string ten, DateTime ngaySinh, string gioiTinh, string queQuan, string sdt, string email, string maLop, string anhDaiDien = "")
        {
            MaSV = maSV;
            HoDem = hoDem;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            QueQuan = queQuan;
            SoDienThoai = sdt;
            Email = email;
            MaLop = maLop;
            AnhDaiDien = anhDaiDien;
        }
    }
}
