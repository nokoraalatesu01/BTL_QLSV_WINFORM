using System.Data;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.BLL
{
    public class DiemBLL
    {
        private DiemDAL diemDAL = new DiemDAL();

        public DataTable LayDanhSachDiem()
        {
            return diemDAL.GetAllDiem();
        }

        public DataTable LayDiemCuaSinhVien(string maSV)
        {
            return diemDAL.GetDiemBySinhVien(maSV);
        }

        public (bool Success, string Message) LuuDiem(DiemDTO d, bool isThem)
        {
            if (string.IsNullOrWhiteSpace(d.MaSV))
                return (false, "Vui lòng chọn sinh viên!");

            if (string.IsNullOrWhiteSpace(d.MaMH))
                return (false, "Vui lòng chọn môn học!");

            if (d.DiemQuaTrinh < 0 || d.DiemQuaTrinh > 10)
                return (false, "Điểm quá trình phải từ 0 đến 10!");

            if (d.DiemThi < 0 || d.DiemThi > 10)
                return (false, "Điểm thi phải từ 0 đến 10!");

            d.TinhDiemTongKet();

            bool tonTai = diemDAL.KiemTraTonTai(d.MaSV, d.MaMH);

            if (isThem)
            {
                if (tonTai)
                    return (false, "Sinh viên này đã có điểm môn học này rồi! Vui lòng chọn sửa.");
                bool ok = diemDAL.InsertDiem(d);
                return ok ? (true, "Thêm điểm thành công!") : (false, "Có lỗi khi thêm điểm!");
            }
            else
            {
                if (!tonTai)
                    return (false, "Bản ghi điểm không tồn tại để cập nhật!");
                bool ok = diemDAL.UpdateDiem(d);
                return ok ? (true, "Cập nhật điểm thành công!") : (false, "Có lỗi khi cập nhật điểm!");
            }
        }

        public (bool Success, string Message) XoaDiem(string maSV, string maMH)
        {
            if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(maMH))
                return (false, "Vui lòng chọn bản ghi điểm cần xóa!");

            bool ok = diemDAL.DeleteDiem(maSV, maMH);
            return ok ? (true, "Xóa điểm thành công!") : (false, "Có lỗi khi xóa điểm!");
        }
    }
}
