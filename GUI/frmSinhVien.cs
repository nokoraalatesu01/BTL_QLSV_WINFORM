using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.BLL;
using BTL_QLSV_WINFORM.Classes;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.DTO;
using BTL_QLSV_WINFORM.Helpers;

namespace BTL_QLSV_WINFORM.GUI
{
    /// <summary>
    /// Form Quản lý Sinh viên - Thiết kế và xây dựng theo chuẩn tư duy của cô giáo trong Tuần 4
    /// </summary>
    public partial class frmSinhVien : Form
    {
        // Khai báo đối tượng DataBaseProcess đúng như hướng dẫn tuần 4
        private DataBaseProcess dtbase = new DataBaseProcess();
        private SinhVienBLL svBLL = new SinhVienBLL();
        private LopDAL lopDAL = new LopDAL();
        private KhoaDAL khoaDAL = new KhoaDAL();

        private string _selectedImagePath = "";

        public frmSinhVien()
        {
            InitializeComponent();
        }

        // ============================================================
        // CÁC HÀM TIỆN ÍCH QUẢN LÝ TRẠNG THÁI GIAO DIỆN CHUẨN CỦA CÔ
        // ============================================================

        /// <summary>
        /// Phương thức ẩn hiện các control trong groupBox Chi tiết (chuẩn tuần 4)
        /// </summary>
        private void HienChiTiet(bool hien)
        {
            txtMaSV.Enabled = hien;
            txtHoDem.Enabled = hien;
            txtTen.Enabled = hien;
            dtpNgaySinh.Enabled = hien;
            rdoNam.Enabled = hien;
            rdoNu.Enabled = hien;
            txtQueQuan.Enabled = hien;
            txtSoDienThoai.Enabled = hien;
            txtEmail.Enabled = hien;
            cboLop.Enabled = hien;
            btnChonAnh.Enabled = hien;

            // Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        /// <summary>
        /// Xóa trắng chi tiết sản phẩm / sinh viên khi thêm mới (chuẩn tuần 4)
        /// </summary>
        private void XoaTrangChiTiet()
        {
            txtMaSV.Text = "";
            txtHoDem.Text = "";
            txtTen.Text = "";
            dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
            rdoNam.Checked = true;
            txtQueQuan.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            picAvatar.Image = null;
            _selectedImagePath = "";
            errChiTiet.Clear();
        }

        /// <summary>
        /// Nạp dữ liệu vào ComboBox Lớp và Khoa
        /// </summary>
        private void LoadComboBox()
        {
            try
            {
                // ComboBox Lớp trong chi tiết
                DataTable dtLop = lopDAL.GetAllLop();
                cboLop.DataSource = dtLop.Copy();
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";

                // ComboBox Lớp trong tìm kiếm (thêm mục Tất cả)
                DataTable dtTKLop = dtLop.Copy();
                DataRow rAllLop = dtTKLop.NewRow();
                rAllLop["MaLop"] = "Tất cả";
                rAllLop["TenLop"] = "-- Tất cả lớp --";
                dtTKLop.Rows.InsertAt(rAllLop, 0);
                cboTKLop.DataSource = dtTKLop;
                cboTKLop.DisplayMember = "TenLop";
                cboTKLop.ValueMember = "MaLop";

                // ComboBox Khoa trong tìm kiếm (thêm mục Tất cả)
                DataTable dtKhoa = khoaDAL.GetAllKhoa();
                DataTable dtTKKhoa = dtKhoa.Copy();
                DataRow rAllKhoa = dtTKKhoa.NewRow();
                rAllKhoa["MaKhoa"] = "Tất cả";
                rAllKhoa["TenKhoa"] = "-- Tất cả khoa --";
                dtTKKhoa.Rows.InsertAt(rAllKhoa, 0);
                cboTKKhoa.DataSource = dtTKKhoa;
                cboTKKhoa.DisplayMember = "TenKhoa";
                cboTKKhoa.ValueMember = "MaKhoa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nạp lại toàn bộ dữ liệu sinh viên lên DataGridView
        /// </summary>
        private void LoadData()
        {
            try
            {
                DataTable dt = svBLL.LayDanhSachSinhVien();
                dgvSinhVien.DataSource = dt;

                // Tùy chỉnh tiêu đề cột tiếng Việt rõ ràng, chuẩn đẹp
                if (dgvSinhVien.Columns.Contains("MaSV")) dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
                if (dgvSinhVien.Columns.Contains("HoDem")) dgvSinhVien.Columns["HoDem"].HeaderText = "Họ đệm";
                if (dgvSinhVien.Columns.Contains("Ten")) dgvSinhVien.Columns["Ten"].HeaderText = "Tên";
                if (dgvSinhVien.Columns.Contains("HoVaTen")) dgvSinhVien.Columns["HoVaTen"].HeaderText = "Họ và tên";
                if (dgvSinhVien.Columns.Contains("NgaySinh"))
                {
                    dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (dgvSinhVien.Columns.Contains("GioiTinh")) dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                if (dgvSinhVien.Columns.Contains("QueQuan")) dgvSinhVien.Columns["QueQuan"].HeaderText = "Quê quán";
                if (dgvSinhVien.Columns.Contains("SoDienThoai")) dgvSinhVien.Columns["SoDienThoai"].HeaderText = "SĐT";
                if (dgvSinhVien.Columns.Contains("Email")) dgvSinhVien.Columns["Email"].HeaderText = "Email";
                if (dgvSinhVien.Columns.Contains("MaLop")) dgvSinhVien.Columns["MaLop"].Visible = false;
                if (dgvSinhVien.Columns.Contains("TenLop")) dgvSinhVien.Columns["TenLop"].HeaderText = "Lớp học";
                if (dgvSinhVien.Columns.Contains("TenKhoa")) dgvSinhVien.Columns["TenKhoa"].HeaderText = "Khoa/Viện";
                if (dgvSinhVien.Columns.Contains("AnhDaiDien")) dgvSinhVien.Columns["AnhDaiDien"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // SỰ KIỆN FORM VÀ ĐIỀU KHIỂN NÚT BẤM (STATE MACHINE CÔ GIÁO)
        // ============================================================

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadComboBox();
            LoadData();

            // Theo tuần 4: Khi form hiện lên thì ẩn các nút Sửa, Xóa và ẩn GroupBox Chi tiết
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            HienChiTiet(false);
        }

        /// <summary>
        /// Khi click vào từng dòng trong DataGridView thì hiển thị chi tiết lên grbChiTiet
        /// Cho hiện nút Sửa, Xóa, ẩn nút Thêm (chuẩn tuần 4)
        /// </summary>
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvSinhVien.CurrentRow == null) return;

            // Bật nút sửa, xóa, tắt nút thêm
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            // Bắt lỗi khi người sử dụng click linh tinh lên datagrid
            try
            {
                DataGridViewRow row = dgvSinhVien.CurrentRow;
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? "";
                txtHoDem.Text = row.Cells["HoDem"].Value?.ToString() ?? "";
                txtTen.Text = row.Cells["Ten"].Value?.ToString() ?? "";

                if (row.Cells["NgaySinh"].Value != null && DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime ns))
                {
                    dtpNgaySinh.Value = ns;
                }

                string gt = row.Cells["GioiTinh"].Value?.ToString() ?? "Nam";
                if (gt == "Nữ") rdoNu.Checked = true;
                else rdoNam.Checked = true;

                txtQueQuan.Text = row.Cells["QueQuan"].Value?.ToString() ?? "";
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

                string maLop = row.Cells["MaLop"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(maLop))
                {
                    cboLop.SelectedValue = maLop;
                }

                // Ảnh đại diện
                _selectedImagePath = row.Cells["AnhDaiDien"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(_selectedImagePath) && File.Exists(_selectedImagePath))
                {
                    picAvatar.Image = Image.FromFile(_selectedImagePath);
                }
                else
                {
                    picAvatar.Image = null;
                }

                // Khi vừa chọn dòng thì chưa cho sửa cho đến khi bấm nút Sửa
                HienChiTiet(false);
                lblTieuDe.Text = "XEM CHI TIẾT SINH VIÊN: " + txtMaSV.Text;
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi click header
            }
        }

        /// <summary>
        /// Chức năng Thêm mới (chuẩn tuần 4)
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM SINH VIÊN MỚI";
            // Xóa trắng GroupBox chi tiết
            XoaTrangChiTiet();
            // Cấm nút sửa xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Hiện GroupBox chi tiết
            HienChiTiet(true);
            txtMaSV.Enabled = true;
            txtMaSV.Focus();
        }

        /// <summary>
        /// Chức năng Sửa (chuẩn tuần 4)
        /// </summary>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblTieuDe.Text = "CẬP NHẬT THÔNG TIN SINH VIÊN";
            // Ẩn hai nút Thêm và Xóa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            // Hiện GroupBox chi tiết
            HienChiTiet(true);
            // Khóa mã sinh viên không cho đổi khi sửa
            txtMaSV.Enabled = false;
            txtHoDem.Focus();
        }

        /// <summary>
        /// Chức năng Xóa (chuẩn tuần 4)
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bật MessageBox cảnh báo người dùng (đúng chuẩn tuần 4)
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtHoDem.Text + " " + txtTen.Text;
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên '{tenSV}' (Mã: {maSV}) không?", 
                "Xác nhận xóa sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                var result = svBLL.XoaSinhVien(maSV);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    XoaTrangChiTiet();
                    HienChiTiet(false);
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    lblTieuDe.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
                }
                else
                {
                    MessageBox.Show(result.Message, "Lỗi xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Chức năng Lưu (chuẩn tuần 4: xác nhận trạng thái bằng Enable của nút Thêm / Sửa)
        /// </summary>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ dữ liệu bằng ErrorProvider
            errChiTiet.Clear();

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errChiTiet.SetError(txtMaSV, "Bạn không được để trống Mã sinh viên!");
                txtMaSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoDem.Text))
            {
                errChiTiet.SetError(txtHoDem, "Bạn không được để trống Họ đệm!");
                txtHoDem.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                errChiTiet.SetError(txtTen, "Bạn không được để trống Tên!");
                txtTen.Focus();
                return;
            }

            if (dtpNgaySinh.Value > DateTime.Now.AddYears(-15))
            {
                errChiTiet.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ (Sinh viên phải từ 15 tuổi trở lên)!");
                dtpNgaySinh.Focus();
                return;
            }

            if (cboLop.SelectedValue == null)
            {
                errChiTiet.SetError(cboLop, "Vui lòng chọn Lớp học!");
                cboLop.Focus();
                return;
            }

            // Tạo DTO
            SinhVienDTO sv = new SinhVienDTO
            {
                MaSV = txtMaSV.Text.Trim().ToUpper(),
                HoDem = txtHoDem.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                QueQuan = txtQueQuan.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MaLop = cboLop.SelectedValue?.ToString() ?? "",
                AnhDaiDien = _selectedImagePath
            };

            // Nếu nút Thêm enable thì thực hiện Thêm mới (chuẩn tuần 4)
            if (btnThem.Enabled == true || txtMaSV.Enabled == true)
            {
                var result = svBLL.ThemSinhVien(sv);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    HienChiTiet(false);
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    lblTieuDe.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
                }
                else
                {
                    errChiTiet.SetError(txtMaSV, result.Message);
                    MessageBox.Show(result.Message, "Lỗi thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // Nếu nút Sửa enable thì thực hiện Cập nhật dữ liệu (chuẩn tuần 4)
            else if (btnSua.Enabled == true)
            {
                var result = svBLL.CapNhatSinhVien(sv);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    HienChiTiet(false);
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    lblTieuDe.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
                }
                else
                {
                    MessageBox.Show(result.Message, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Chức năng Hủy (chuẩn tuần 4)
        /// </summary>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Thiết lập lại các nút như ban đầu (chuẩn tuần 4)
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            // Xóa trắng chi tiết
            XoaTrangChiTiet();
            // Cấm nhập vào GroupBox chi tiết
            HienChiTiet(false);
            lblTieuDe.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
        }

        /// <summary>
        /// Chức năng Tìm kiếm
        /// </summary>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TÌM KIẾM SINH VIÊN";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            HienChiTiet(false);
            txtTKMaSV.Focus();
        }

        private void btnThucHienTK_Click(object sender, EventArgs e)
        {
            string maSV = txtTKMaSV.Text.Trim();
            string hoTen = txtTKHoTen.Text.Trim();
            string maLop = cboTKLop.SelectedValue?.ToString() ?? "Tất cả";
            string maKhoa = cboTKKhoa.SelectedValue?.ToString() ?? "Tất cả";

            DataTable dt = svBLL.TimKiem(maSV, hoTen, maLop, maKhoa);
            dgvSinhVien.DataSource = dt;
            lblTieuDe.Text = $"KẾT QUẢ TÌM KIẾM ({dt.Rows.Count} sinh viên)";
        }

        private void cboTKLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Visible) btnThucHienTK.PerformClick();
        }

        private void cboTKKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Visible) btnThucHienTK.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTKMaSV.Clear();
            txtTKHoTen.Clear();
            if (cboTKLop.Items.Count > 0) cboTKLop.SelectedIndex = 0;
            if (cboTKKhoa.Items.Count > 0) cboTKKhoa.SelectedIndex = 0;
            LoadData();
            XoaTrangChiTiet();
            HienChiTiet(false);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblTieuDe.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridViewToExcel(dgvSinhVien, "DANH SÁCH SINH VIÊN", $"DanhSachSinhVien_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";
                ofd.Title = "Chọn ảnh chân dung sinh viên";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    picAvatar.Image = Image.FromFile(_selectedImagePath);
                }
            }
        }

        /// <summary>
        /// Chỉ cho phép nhập số vào ô số điện thoại (chuẩn tuần 2 & tuần 4)
        /// </summary>
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Chức năng Thoát (chuẩn tuần 1, 2, 4)
        /// </summary>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng form Quản lý sinh viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
