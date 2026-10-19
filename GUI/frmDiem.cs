using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.BLL;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.DTO;
using BTL_QLSV_WINFORM.Helpers;

namespace BTL_QLSV_WINFORM.GUI
{
    public partial class frmDiem : Form
    {
        private DiemBLL diemBLL = new DiemBLL();
        private SinhVienDAL svDAL = new SinhVienDAL();
        private MonHocDAL mhDAL = new MonHocDAL();

        private bool _isThem = false;

        public frmDiem()
        {
            InitializeComponent();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
            SetControlState(false);
        }

        private void LoadComboBoxes()
        {
            DataTable dtSV = svDAL.GetAllSinhVien();
            cboSinhVien.DataSource = dtSV.Copy();
            cboSinhVien.DisplayMember = "HoVaTen";
            cboSinhVien.ValueMember = "MaSV";

            // Lọc sinh viên
            DataTable dtLocSV = dtSV.Copy();
            DataRow rAll = dtLocSV.NewRow();
            rAll["MaSV"] = "ALL";
            rAll["HoVaTen"] = "-- Tất cả sinh viên --";
            dtLocSV.Rows.InsertAt(rAll, 0);
            cboLocSV.DataSource = dtLocSV;
            cboLocSV.DisplayMember = "HoVaTen";
            cboLocSV.ValueMember = "MaSV";

            // Môn học
            DataTable dtMH = mhDAL.GetAllMonHoc();
            cboMonHoc.DataSource = dtMH;
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
        }

        private void LoadData()
        {
            dgvDiem.DataSource = diemBLL.LayDanhSachDiem();
            FormatGridColumns();
        }

        private void FormatGridColumns()
        {
            if (dgvDiem.Columns.Contains("MaSV")) dgvDiem.Columns["MaSV"].HeaderText = "Mã SV";
            if (dgvDiem.Columns.Contains("HoTen")) dgvDiem.Columns["HoTen"].HeaderText = "Họ và tên";
            if (dgvDiem.Columns.Contains("MaMH")) dgvDiem.Columns["MaMH"].Visible = false;
            if (dgvDiem.Columns.Contains("TenMH")) dgvDiem.Columns["TenMH"].HeaderText = "Môn học";
            if (dgvDiem.Columns.Contains("SoTinChi")) dgvDiem.Columns["SoTinChi"].HeaderText = "Số TC";
            if (dgvDiem.Columns.Contains("DiemQuaTrinh")) dgvDiem.Columns["DiemQuaTrinh"].HeaderText = "Điểm QT (30%)";
            if (dgvDiem.Columns.Contains("DiemThi")) dgvDiem.Columns["DiemThi"].HeaderText = "Điểm Thi (70%)";
            if (dgvDiem.Columns.Contains("DiemTongKet")) dgvDiem.Columns["DiemTongKet"].HeaderText = "Tổng kết";
            if (dgvDiem.Columns.Contains("DiemChu")) dgvDiem.Columns["DiemChu"].HeaderText = "Điểm chữ";
        }

        private void SetControlState(bool isEditing)
        {
            cboSinhVien.Enabled = isEditing && _isThem;
            cboMonHoc.Enabled = isEditing && _isThem;
            txtDiemQuaTrinh.Enabled = isEditing;
            txtDiemThi.Enabled = isEditing;
            btnTinhDiem.Enabled = isEditing;

            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing && dgvDiem.CurrentRow != null;
            btnXoa.Enabled = !isEditing && dgvDiem.CurrentRow != null;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvDiem.CurrentRow == null) return;
            DataGridViewRow r = dgvDiem.CurrentRow;

            string maSV = r.Cells["MaSV"].Value?.ToString() ?? "";
            string maMH = r.Cells["MaMH"].Value?.ToString() ?? "";

            if (!string.IsNullOrEmpty(maSV)) cboSinhVien.SelectedValue = maSV;
            if (!string.IsNullOrEmpty(maMH)) cboMonHoc.SelectedValue = maMH;

            txtDiemQuaTrinh.Text = r.Cells["DiemQuaTrinh"].Value?.ToString() ?? "";
            txtDiemThi.Text = r.Cells["DiemThi"].Value?.ToString() ?? "";
            txtDiemTongKet.Text = r.Cells["DiemTongKet"].Value?.ToString() ?? "";
            txtDiemChu.Text = r.Cells["DiemChu"].Value?.ToString() ?? "";

            _isThem = false;
            SetControlState(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isThem = true;
            txtDiemQuaTrinh.Text = "";
            txtDiemThi.Text = "";
            txtDiemTongKet.Text = "";
            txtDiemChu.Text = "";
            SetControlState(true);
            txtDiemQuaTrinh.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _isThem = false;
            SetControlState(true);
            txtDiemQuaTrinh.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedValue == null || cboMonHoc.SelectedValue == null) return;

            string maSV = cboSinhVien.SelectedValue.ToString()!;
            string maMH = cboMonHoc.SelectedValue.ToString()!;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa điểm môn này của sinh viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = diemBLL.XoaDiem(maSV, maMH);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    SetControlState(false);
                }
            }
        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDiemQuaTrinh.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double dqt) &&
                double.TryParse(txtDiemThi.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double dthi))
            {
                if (dqt < 0 || dqt > 10 || dthi < 0 || dthi > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong thang điểm từ 0.0 đến 10.0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DiemDTO d = new DiemDTO("", "", dqt, dthi);
                txtDiemTongKet.Text = d.DiemTongKet.ToString("0.00");
                txtDiemChu.Text = d.DiemChu;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Điểm quá trình và Điểm thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
            // Tự động tính khi người dùng nhập đủ 2 điểm hợp lệ
            if (double.TryParse(txtDiemQuaTrinh.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double dqt) &&
                double.TryParse(txtDiemThi.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double dthi))
            {
                if (dqt >= 0 && dqt <= 10 && dthi >= 0 && dthi <= 10)
                {
                    DiemDTO d = new DiemDTO("", "", dqt, dthi);
                    txtDiemTongKet.Text = d.DiemTongKet.ToString("0.00");
                    txtDiemChu.Text = d.DiemChu;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedValue == null || cboMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Sinh viên và Môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDiemQuaTrinh.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double dqt) ||
                !double.TryParse(txtDiemThi.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double dthi))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ từ 0 đến 10!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DiemDTO d = new DiemDTO(cboSinhVien.SelectedValue.ToString()!, cboMonHoc.SelectedValue.ToString()!, dqt, dthi);

            var result = diemBLL.LuuDiem(d, _isThem);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                SetControlState(false);
            }
            else
            {
                MessageBox.Show(result.Message, "Lỗi lưu điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControlState(false);
        }

        private void cboLocSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLocSV.SelectedValue == null) return;
            string maSV = cboLocSV.SelectedValue.ToString()!;
            if (maSV == "ALL")
            {
                LoadData();
            }
            else
            {
                dgvDiem.DataSource = diemBLL.LayDiemCuaSinhVien(maSV);
                FormatGridColumns();
            }
        }

        private void btnTatCaDiem_Click(object sender, EventArgs e)
        {
            if (cboLocSV.Items.Count > 0) cboLocSV.SelectedIndex = 0;
            LoadData();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridViewToExcel(dgvDiem, "BẢNG ĐIỂM CHI TIẾT SINH VIÊN", $"BangDiem_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng form Quản lý điểm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
