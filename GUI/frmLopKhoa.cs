using System;
using System.Data;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.GUI
{
    public partial class frmLopKhoa : Form
    {
        private LopDAL lopDAL = new LopDAL();
        private KhoaDAL khoaDAL = new KhoaDAL();

        private bool _isThemLop = false;
        private bool _isThemKhoa = false;

        public frmLopKhoa()
        {
            InitializeComponent();
        }

        private void frmLopKhoa_Load(object sender, EventArgs e)
        {
            LoadDataKhoa();
            LoadDataLop();
            SetLopState(false);
            SetKhoaState(false);
        }

        // ============================================================
        // QUẢN LÝ LỚP
        // ============================================================

        private void LoadDataLop()
        {
            dgvLop.DataSource = lopDAL.GetAllLopWithKhoa();
            if (dgvLop.Columns.Contains("MaLop")) dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
            if (dgvLop.Columns.Contains("TenLop")) dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp";
            if (dgvLop.Columns.Contains("KhoaHoc")) dgvLop.Columns["KhoaHoc"].HeaderText = "Khóa học";
            if (dgvLop.Columns.Contains("MaKhoa")) dgvLop.Columns["MaKhoa"].Visible = false;
            if (dgvLop.Columns.Contains("TenKhoa")) dgvLop.Columns["TenKhoa"].HeaderText = "Khoa / Viện";

            // Load ComboBox Khoa
            cboKhoaCuaLop.DataSource = khoaDAL.GetAllKhoa();
            cboKhoaCuaLop.DisplayMember = "TenKhoa";
            cboKhoaCuaLop.ValueMember = "MaKhoa";
        }

        private void SetLopState(bool isEditing)
        {
            txtMaLop.Enabled = isEditing && _isThemLop;
            txtTenLop.Enabled = isEditing;
            txtKhoaHoc.Enabled = isEditing;
            cboKhoaCuaLop.Enabled = isEditing;

            btnLuuLop.Enabled = isEditing;
            btnHuyLop.Enabled = isEditing;

            btnThemLop.Enabled = !isEditing;
            btnSuaLop.Enabled = !isEditing && dgvLop.CurrentRow != null;
            btnXoaLop.Enabled = !isEditing && dgvLop.CurrentRow != null;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvLop.CurrentRow == null) return;
            DataGridViewRow r = dgvLop.CurrentRow;
            txtMaLop.Text = r.Cells["MaLop"].Value?.ToString() ?? "";
            txtTenLop.Text = r.Cells["TenLop"].Value?.ToString() ?? "";
            txtKhoaHoc.Text = r.Cells["KhoaHoc"].Value?.ToString() ?? "";
            string maKhoa = r.Cells["MaKhoa"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(maKhoa)) cboKhoaCuaLop.SelectedValue = maKhoa;

            _isThemLop = false;
            SetLopState(false);
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            _isThemLop = true;
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoaHoc.Text = "K63";
            SetLopState(true);
            txtMaLop.Focus();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            _isThemLop = false;
            SetLopState(true);
            txtTenLop.Focus();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            if (string.IsNullOrEmpty(maLop)) return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa lớp '{maLop}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lopDAL.DeleteLop(maLop))
                {
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataLop();
                    SetLopState(false);
                }
            }
        }

        private void btnLuuLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng điền đủ Mã lớp và Tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LopDTO l = new LopDTO
            {
                MaLop = txtMaLop.Text.Trim().ToUpper(),
                TenLop = txtTenLop.Text.Trim(),
                KhoaHoc = txtKhoaHoc.Text.Trim(),
                MaKhoa = cboKhoaCuaLop.SelectedValue?.ToString() ?? ""
            };

            if (_isThemLop)
            {
                if (lopDAL.KiemTraTonTai(l.MaLop))
                {
                    MessageBox.Show("Mã lớp đã tồn tại trong CSDL!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lopDAL.InsertLop(l);
                MessageBox.Show("Thêm lớp mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lopDAL.UpdateLop(l);
                MessageBox.Show("Cập nhật lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadDataLop();
            SetLopState(false);
        }

        private void btnHuyLop_Click(object sender, EventArgs e)
        {
            SetLopState(false);
        }

        // ============================================================
        // QUẢN LÝ KHOA
        // ============================================================

        private void LoadDataKhoa()
        {
            dgvKhoa.DataSource = khoaDAL.GetAllKhoa();
            if (dgvKhoa.Columns.Contains("MaKhoa")) dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            if (dgvKhoa.Columns.Contains("TenKhoa")) dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa / Viện";
            if (dgvKhoa.Columns.Contains("VanPhong")) dgvKhoa.Columns["VanPhong"].HeaderText = "Văn phòng";
            if (dgvKhoa.Columns.Contains("SoDienThoai")) dgvKhoa.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }

        private void SetKhoaState(bool isEditing)
        {
            txtMaKhoa.Enabled = isEditing && _isThemKhoa;
            txtTenKhoa.Enabled = isEditing;
            txtVanPhong.Enabled = isEditing;
            txtSDTKhoa.Enabled = isEditing;

            btnLuuKhoa.Enabled = isEditing;
            btnHuyKhoa.Enabled = isEditing;

            btnThemKhoa.Enabled = !isEditing;
            btnSuaKhoa.Enabled = !isEditing && dgvKhoa.CurrentRow != null;
            btnXoaKhoa.Enabled = !isEditing && dgvKhoa.CurrentRow != null;
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvKhoa.CurrentRow == null) return;
            DataGridViewRow r = dgvKhoa.CurrentRow;
            txtMaKhoa.Text = r.Cells["MaKhoa"].Value?.ToString() ?? "";
            txtTenKhoa.Text = r.Cells["TenKhoa"].Value?.ToString() ?? "";
            txtVanPhong.Text = r.Cells["VanPhong"].Value?.ToString() ?? "";
            txtSDTKhoa.Text = r.Cells["SoDienThoai"].Value?.ToString() ?? "";

            _isThemKhoa = false;
            SetKhoaState(false);
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            _isThemKhoa = true;
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtVanPhong.Text = "";
            txtSDTKhoa.Text = "";
            SetKhoaState(true);
            txtMaKhoa.Focus();
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            _isThemKhoa = false;
            SetKhoaState(true);
            txtTenKhoa.Focus();
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            if (string.IsNullOrEmpty(maKhoa)) return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khoa '{maKhoa}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (khoaDAL.DeleteKhoa(maKhoa))
                {
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataKhoa();
                    SetKhoaState(false);
                }
            }
        }

        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng điền đủ Mã khoa và Tên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhoaDTO k = new KhoaDTO
            {
                MaKhoa = txtMaKhoa.Text.Trim().ToUpper(),
                TenKhoa = txtTenKhoa.Text.Trim(),
                VanPhong = txtVanPhong.Text.Trim(),
                SoDienThoai = txtSDTKhoa.Text.Trim()
            };

            if (_isThemKhoa)
            {
                if (khoaDAL.KiemTraTonTai(k.MaKhoa))
                {
                    MessageBox.Show("Mã khoa đã tồn tại trong CSDL!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                khoaDAL.InsertKhoa(k);
                MessageBox.Show("Thêm khoa mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                khoaDAL.UpdateKhoa(k);
                MessageBox.Show("Cập nhật khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadDataKhoa();
            SetKhoaState(false);
        }

        private void btnHuyKhoa_Click(object sender, EventArgs e)
        {
            SetKhoaState(false);
        }
    }
}
