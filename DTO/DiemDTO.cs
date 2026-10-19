using System;

namespace BTL_QLSV_WINFORM.DTO
{
    public class DiemDTO
    {
        public string MaSV { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string MaMH { get; set; } = string.Empty;
        public string TenMH { get; set; } = string.Empty;
        public int SoTinChi { get; set; } = 3;
        public double DiemQuaTrinh { get; set; } = 0.0;
        public double DiemThi { get; set; } = 0.0;
        public double DiemTongKet { get; set; } = 0.0;
        public string DiemChu { get; set; } = "F";

        public DiemDTO() { }

        public DiemDTO(string maSV, string maMH, double diemQT, double diemThi)
        {
            MaSV = maSV;
            MaMH = maMH;
            DiemQuaTrinh = diemQT;
            DiemThi = diemThi;
            TinhDiemTongKet();
        }

        public void TinhDiemTongKet()
        {
            // Trọng số chuẩn: Điểm quá trình 30%, Điểm thi 70%
            DiemTongKet = Math.Round((DiemQuaTrinh * 0.3) + (DiemThi * 0.7), 2);

            if (DiemTongKet >= 9.0) DiemChu = "A+";
            else if (DiemTongKet >= 8.5) DiemChu = "A";
            else if (DiemTongKet >= 8.0) DiemChu = "B+";
            else if (DiemTongKet >= 7.0) DiemChu = "B";
            else if (DiemTongKet >= 6.5) DiemChu = "C+";
            else if (DiemTongKet >= 5.5) DiemChu = "C";
            else if (DiemTongKet >= 5.0) DiemChu = "D+";
            else if (DiemTongKet >= 4.0) DiemChu = "D";
            else DiemChu = "F";
        }
    }
}
