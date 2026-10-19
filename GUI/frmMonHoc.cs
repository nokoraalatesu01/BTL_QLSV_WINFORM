using System;
using System.Data;
using System.Windows.Forms;
using BTL_QLSV_WINFORM.DAL;
using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.GUI
{
    public partial class frmMonHoc : Form
    {
        private MonHocDAL mhDAL = new MonHocDAL();
        private bool _isThem = false;

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControlState(false);
        }

        private void LoadData()
        {
            dgvMonHoc.DataSource = mhDAL.GetAllMonHoc();
            if (dgvMonHoc.Columns.Contains("MaMH")) dgvMonHoc.Columns["MaMH"].HeaderText = "Mã Môn";
            if (dgvMonHoc.Columns.Contains("TenMH")) dgvMonHoc.Columns["TenMH"].HeaderText = "Tên Môn Học";
            if (dgvMonHoc.Columns.Contains("SoTinChi")) dgvMonHoc.Columns["SoTinChi"].HeaderText = "Số TC";
            if (dgvMonHoc.Columns.Contains("SoTietLT")) dgvMonHoc.Columns["SoTietLT"].HeaderText = "Tiết LT";
            if (dgvMonHoc.Columns.Contains("SoTietTH")) dgvMonHoc.Columns["SoTietTH"].HeaderText = "Tiết TH";
            if (dgvMonHoc.Columns.Contains("HocKy")) dgvMonHoc.Columns["HocKy"].HeaderText = "Học kỳ";
        }

        private void SetControlState(bool isEditing)
        {
            txtMaMH.Enabled = isEditing && _isThem;
            txtTenMH.Enabled = isEditing;
            numSoTinChi.Enabled = isEditing;
            numSoTietLT.Enabled = isEditing;
            numSoTietTH.Enabled = isEditing;
            numHocKy.Enabled = isEditing;

            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing && dgvMonHoc.CurrentRow != null;
            btnXoa.Enabled = !isEditing && dgvMonHoc.CurrentRow != null;
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMonHoc.CurrentRow == null) return;
            DataGridViewRow r = dgvMonHoc.CurrentRow;
            txtMaMH.Text = r.Cells["MaMH"].Value?.ToString() ?? "";
            txtTenMH.Text = r.Cells["TenMH"].Value?.ToString() ?? "";
            numSoTinChi.Value = Convert.ToDecimal(r.Cells["SoTinChi"].Value ?? 3);
            numSoTietLT.Value = Convert.ToDecimal(r.Cells["SoTietLT"].Value ?? 30);
            numSoTietTH.Value = Convert.ToDecimal(r.Cells["SoTietTH"].Value ?? 15);
            numHocKy.Value = Convert.ToDecimal(r.Cells["HocKy"].Value ?? 1);

            _isThem = false;
            SetControlState(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isThem = true;
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            numSoTinChi.Value = 3;
            numSoTietLT.Value = 30;
            numSoTietTH.Value = 15;
            numHocKy.Value = 1;
            SetControlState(true);
            txtMaMH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _isThem = false;
            SetControlState(true);
            txtTenMH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text.Trim();
            if (string.IsNullOrEmpty(maMH)) return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa môn học '{maMH}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (mhDAL.DeleteMonHoc(maMH))
                {
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    SetControlState(false);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Vui lòng điền đủ Mã môn học và Tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MonHocDTO mh = new MonHocDTO
            {
                MaMH = txtMaMH.Text.Trim().ToUpper(),
                TenMH = txtTenMH.Text.Trim(),
                SoTinChi = (int)numSoTinChi.Value,
                SoTietLT = (int)numSoTietLT.Value,
                SoTietTH = (int)numSoTietTH.Value,
                HocKy = (int)numHocKy.Value
            };

            if (_isThem)
            {
                if (mhDAL.KiemTraTonTai(mh.MaMH))
                {
                    MessageBox.Show("Mã môn học đã tồn tại trong CSDL!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                mhDAL.InsertMonHoc(mh);
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mhDAL.UpdateMonHoc(mh);
                MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadData();
            SetControlState(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControlState(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng form Môn học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
