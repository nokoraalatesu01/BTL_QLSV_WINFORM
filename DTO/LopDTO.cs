namespace BTL_QLSV_WINFORM.DTO
{
    public class LopDTO
    {
        public string MaLop { get; set; } = string.Empty;
        public string TenLop { get; set; } = string.Empty;
        public string KhoaHoc { get; set; } = string.Empty;
        public string MaKhoa { get; set; } = string.Empty;
        public string TenKhoa { get; set; } = string.Empty;

        public LopDTO() { }

        public LopDTO(string maLop, string tenLop, string khoaHoc, string maKhoa)
        {
            MaLop = maLop;
            TenLop = tenLop;
            KhoaHoc = khoaHoc;
            MaKhoa = maKhoa;
        }
    }
}
