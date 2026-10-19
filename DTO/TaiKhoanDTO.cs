namespace BTL_QLSV_WINFORM.DTO
{
    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string Quyen { get; set; } = "GiangVien"; // 'Admin', 'GiangVien', 'SinhVien'
        public string Email { get; set; } = string.Empty;

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string tenDangNhap, string matKhau, string hoTen, string quyen, string email = "")
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            HoTen = hoTen;
            Quyen = quyen;
            Email = email;
        }
    }
}
