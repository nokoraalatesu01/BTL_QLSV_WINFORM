namespace BTL_QLSV_WINFORM.DTO
{
    public class MonHocDTO
    {
        public string MaMH { get; set; } = string.Empty;
        public string TenMH { get; set; } = string.Empty;
        public int SoTinChi { get; set; } = 3;
        public int SoTietLT { get; set; } = 30;
        public int SoTietTH { get; set; } = 15;
        public int HocKy { get; set; } = 1;

        public MonHocDTO() { }

        public MonHocDTO(string maMH, string tenMH, int soTinChi, int soTietLT = 30, int soTietTH = 15, int hocKy = 1)
        {
            MaMH = maMH;
            TenMH = tenMH;
            SoTinChi = soTinChi;
            SoTietLT = soTietLT;
            SoTietTH = soTietTH;
            HocKy = hocKy;
        }
    }
}
