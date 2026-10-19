using System;
using System.Data;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.BLL
{
    public class SinhVienBLL
    {
        private SinhVienDAL svDAL = new SinhVienDAL();

        public DataTable LayDanhSachSinhVien()
        {
            return svDAL.GetAllSinhVien();
        }

        public (bool Success, string Message) ThemSinhVien(SinhVienDTO sv)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV))
                return (false, "Mã sinh viên không được để trống!");

            if (string.IsNullOrWhiteSpace(sv.HoDem) || string.IsNullOrWhiteSpace(sv.Ten))
                return (false, "Họ đệm và Tên sinh viên không được để trống!");

            if (sv.NgaySinh > DateTime.Now.AddYears(-15))
                return (false, "Ngày sinh không hợp lệ (Sinh viên phải từ 15 tuổi trở lên)!");

            if (svDAL.KiemTraTonTai(sv.MaSV))
                return (false, $"Mã sinh viên '{sv.MaSV}' đã tồn tại trong cơ sở dữ liệu!");

            bool ok = svDAL.InsertSinhVien(sv);
            return ok ? (true, "Thêm sinh viên thành công!") : (false, "Có lỗi khi thêm sinh viên vào CSDL!");
        }

        public (bool Success, string Message) CapNhatSinhVien(SinhVienDTO sv)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV))
                return (false, "Mã sinh viên không hợp lệ!");

            if (string.IsNullOrWhiteSpace(sv.HoDem) || string.IsNullOrWhiteSpace(sv.Ten))
                return (false, "Họ đệm và Tên sinh viên không được để trống!");

            if (!svDAL.KiemTraTonTai(sv.MaSV))
                return (false, $"Không tìm thấy sinh viên có mã '{sv.MaSV}' để cập nhật!");

            bool ok = svDAL.UpdateSinhVien(sv);
            return ok ? (true, "Cập nhật thông tin sinh viên thành công!") : (false, "Có lỗi khi cập nhật sinh viên!");
        }

        public (bool Success, string Message) XoaSinhVien(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                return (false, "Vui lòng chọn sinh viên cần xóa!");

            if (!svDAL.KiemTraTonTai(maSV))
                return (false, $"Sinh viên '{maSV}' không tồn tại!");

            bool ok = svDAL.DeleteSinhVien(maSV);
            return ok ? (true, "Xóa sinh viên thành công!") : (false, "Có lỗi khi xóa sinh viên!");
        }

        public DataTable TimKiem(string maSV, string hoTen, string maLop, string maKhoa)
        {
            return svDAL.TimKiemSinhVien(maSV, hoTen, maLop, maKhoa);
        }
    }
}
