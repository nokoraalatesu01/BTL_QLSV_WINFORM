namespace BTL_QLSV_WINFORM.DTO
{
    public class KhoaDTO
    {
        public string MaKhoa { get; set; } = string.Empty;
        public string TenKhoa { get; set; } = string.Empty;
        public string VanPhong { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;

        public KhoaDTO() { }

        public KhoaDTO(string maKhoa, string tenKhoa, string vanPhong = "", string sdt = "")
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            VanPhong = vanPhong;
            SoDienThoai = sdt;
        }
    }
}
