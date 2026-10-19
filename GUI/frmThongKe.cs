using System;
using System.Data;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.BLL;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.Helpers;

namespace BTL_QLSV_WINFORM.GUI
{
    public partial class frmThongKe : Form
    {
        private SinhVienDAL svDAL = new SinhVienDAL();
        private LopDAL lopDAL = new LopDAL();
        private KhoaDAL khoaDAL = new KhoaDAL();
        private DiemDAL diemDAL = new DiemDAL();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            ThongKeTheoKhoa();
            ThongKeTheoLop();
            ThongKeXepLoaiHocTap();
        }

        private void ThongKeTheoKhoa()
        {
            DataTable dtKhoa = khoaDAL.GetAllKhoa();
            DataTable dtSV = svDAL.GetAllSinhVien();

            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("MaKhoa", typeof(string));
            dtResult.Columns.Add("TenKhoa", typeof(string));
            dtResult.Columns.Add("SoLuongLop", typeof(int));
            dtResult.Columns.Add("SoLuongSV", typeof(int));
            dtResult.Columns.Add("SoSVNam", typeof(int));
            dtResult.Columns.Add("SoSVNu", typeof(int));

            DataTable dtLop = lopDAL.GetAllLop();

            foreach (DataRow rK in dtKhoa.Rows)
            {
                string maKhoa = rK["MaKhoa"].ToString()!;
                string tenKhoa = rK["TenKhoa"].ToString()!;

                int soLop = dtLop.Select($"MaKhoa = '{maKhoa}'").Length;
                DataRow[] svCuaKhoa = dtSV.Select($"TenKhoa = '{tenKhoa}'");
                int soSV = svCuaKhoa.Length;
                int soNam = 0;
                int soNu = 0;
                foreach (var r in svCuaKhoa)
                {
                    if (r["GioiTinh"]?.ToString() == "Nữ") soNu++;
                    else soNam++;
                }

                dtResult.Rows.Add(maKhoa, tenKhoa, soLop, soSV, soNam, soNu);
            }

            dgvThongKeKhoa.DataSource = dtResult;
            if (dgvThongKeKhoa.Columns.Contains("MaKhoa")) dgvThongKeKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            if (dgvThongKeKhoa.Columns.Contains("TenKhoa")) dgvThongKeKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa / Viện";
            if (dgvThongKeKhoa.Columns.Contains("SoLuongLop")) dgvThongKeKhoa.Columns["SoLuongLop"].HeaderText = "Số lớp";
            if (dgvThongKeKhoa.Columns.Contains("SoLuongSV")) dgvThongKeKhoa.Columns["SoLuongSV"].HeaderText = "Tổng số SV";
            if (dgvThongKeKhoa.Columns.Contains("SoSVNam")) dgvThongKeKhoa.Columns["SoSVNam"].HeaderText = "Nam";
            if (dgvThongKeKhoa.Columns.Contains("SoSVNu")) dgvThongKeKhoa.Columns["SoSVNu"].HeaderText = "Nữ";
        }

        private void ThongKeTheoLop()
        {
            DataTable dtLop = lopDAL.GetAllLopWithKhoa();
            DataTable dtSV = svDAL.GetAllSinhVien();

            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("MaLop", typeof(string));
            dtResult.Columns.Add("TenLop", typeof(string));
            dtResult.Columns.Add("TenKhoa", typeof(string));
            dtResult.Columns.Add("KhoaHoc", typeof(string));
            dtResult.Columns.Add("SoLuongSV", typeof(int));

            foreach (DataRow rL in dtLop.Rows)
            {
                string maLop = rL["MaLop"].ToString()!;
                string tenLop = rL["TenLop"].ToString()!;
                string tenKhoa = rL["TenKhoa"]?.ToString() ?? "";
                string khoaHoc = rL["KhoaHoc"]?.ToString() ?? "";

                int soSV = dtSV.Select($"MaLop = '{maLop}'").Length;
                dtResult.Rows.Add(maLop, tenLop, tenKhoa, khoaHoc, soSV);
            }

            dgvThongKeLop.DataSource = dtResult;
            if (dgvThongKeLop.Columns.Contains("MaLop")) dgvThongKeLop.Columns["MaLop"].HeaderText = "Mã Lớp";
            if (dgvThongKeLop.Columns.Contains("TenLop")) dgvThongKeLop.Columns["TenLop"].HeaderText = "Tên Lớp";
            if (dgvThongKeLop.Columns.Contains("TenKhoa")) dgvThongKeLop.Columns["TenKhoa"].HeaderText = "Khoa";
            if (dgvThongKeLop.Columns.Contains("KhoaHoc")) dgvThongKeLop.Columns["KhoaHoc"].HeaderText = "Khóa";
            if (dgvThongKeLop.Columns.Contains("SoLuongSV")) dgvThongKeLop.Columns["SoLuongSV"].HeaderText = "Số sinh viên";
        }

        private void ThongKeXepLoaiHocTap()
        {
            DataTable dtSV = svDAL.GetAllSinhVien();
            DataTable dtDiem = diemDAL.GetAllDiem();

            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("MaSV", typeof(string));
            dtResult.Columns.Add("HoVaTen", typeof(string));
            dtResult.Columns.Add("TenLop", typeof(string));
            dtResult.Columns.Add("DiemTB", typeof(double));
            dtResult.Columns.Add("XepLoai", typeof(string));

            int xuatSac = 0, gioi = 0, kha = 0, trungBinh = 0, yeu = 0;

            foreach (DataRow rSV in dtSV.Rows)
            {
                string maSV = rSV["MaSV"].ToString()!;
                string hoTen = rSV["HoVaTen"]?.ToString() ?? $"{rSV["HoDem"]} {rSV["Ten"]}";
                string tenLop = rSV["TenLop"]?.ToString() ?? "";

                DataRow[] diemCuaSV = dtDiem.Select($"MaSV = '{maSV}'");
                double diemTB = 0;
                string xepLoai = "Chưa có điểm";

                if (diemCuaSV.Length > 0)
                {
                    double tong = 0;
                    foreach (var d in diemCuaSV)
                    {
                        tong += Convert.ToDouble(d["DiemTongKet"]);
                    }
                    diemTB = Math.Round(tong / diemCuaSV.Length, 2);

                    if (diemTB >= 9.0) { xepLoai = "Xuất sắc"; xuatSac++; }
                    else if (diemTB >= 8.0) { xepLoai = "Giỏi"; gioi++; }
                    else if (diemTB >= 6.5) { xepLoai = "Khá"; kha++; }
                    else if (diemTB >= 5.0) { xepLoai = "Trung bình"; trungBinh++; }
                    else { xepLoai = "Yếu"; yeu++; }
                }

                dtResult.Rows.Add(maSV, hoTen, tenLop, diemTB, xepLoai);
            }

            dgvXepLoai.DataSource = dtResult;
            if (dgvXepLoai.Columns.Contains("MaSV")) dgvXepLoai.Columns["MaSV"].HeaderText = "Mã SV";
            if (dgvXepLoai.Columns.Contains("HoVaTen")) dgvXepLoai.Columns["HoVaTen"].HeaderText = "Họ và tên";
            if (dgvXepLoai.Columns.Contains("TenLop")) dgvXepLoai.Columns["TenLop"].HeaderText = "Lớp";
            if (dgvXepLoai.Columns.Contains("DiemTB")) dgvXepLoai.Columns["DiemTB"].HeaderText = "Điểm TB";
            if (dgvXepLoai.Columns.Contains("XepLoai")) dgvXepLoai.Columns["XepLoai"].HeaderText = "Xếp loại học lực";

            // Cập nhật card tổng quan
            lblTongSinhVien.Text = $"Tổng sinh viên:\r\n{dtSV.Rows.Count} SV";
            lblXuatSac.Text = $"Xuất sắc (>=9.0):\r\n{xuatSac} SV";
            lblGioi.Text = $"Giỏi (8.0 - 8.9):\r\n{gioi} SV";
            lblKha.Text = $"Khá (6.5 - 7.9):\r\n{kha} SV";
            lblTrungBinh.Text = $"Trung bình:\r\n{trungBinh} SV";
            lblYeu.Text = $"Yếu (<5.0):\r\n{yeu} SV";
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabKhoaLop)
            {
                ExcelHelper.ExportDataGridViewToExcel(dgvThongKeKhoa, "BÁO CÁO THỐNG KÊ SINH VIÊN THEO KHOA", $"ThongKe_Khoa_{DateTime.Now:yyyyMMdd}.xlsx");
            }
            else
            {
                ExcelHelper.ExportDataGridViewToExcel(dgvXepLoai, "BÁO CÁO XẾP LOẠI HỌC LỰC SINH VIÊN", $"XepLoai_SinhVien_{DateTime.Now:yyyyMMdd}.xlsx");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
