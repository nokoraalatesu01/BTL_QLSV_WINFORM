using System;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms
{
    public partial class FrmMonHoc : Form
    {
        private readonly bool _coQuyenGhi;
        private bool _dangTai;

        public FrmMonHoc()
        {
            InitializeComponent();
            this._coQuyenGhi = Quyen.CoQuyen(ChucNang.MonHoc, HanhDong.Ghi);
        }

        // ---------------- Sự kiện ----------------
        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this._coQuyenGhi)
                {
                    // Chỉ xem: ẩn ô nhập và các nút thay đổi dữ liệu
                    this.pnlNhap.Visible = false;
                    this.btnNhapMoi.Visible = false;
                    this.btnThem.Visible = false;
                    this.btnSua.Visible = false;
                    this.btnXoa.Visible = false;
                    this.lblTrangThai.Text = "Bạn chỉ có quyền xem danh sách này.";
                }
                this.TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nạp dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMonHoc_Shown(object sender, EventArgs e)
        {
            this.NhapMoi();
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            this.NhapMoi();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                this.TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tải lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                this.TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            try
            {
                this.TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv.SelectedRows.Count > 0)
                {
                    MessageBox.Show("Đang chọn một dòng trong danh sách. Bấm 'Nhập mới' trước khi thêm bản ghi mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.Them();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                this.Xoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xóa môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this._dangTai || this.dgv.SelectedRows.Count == 0) return;
            if (this.dgv.SelectedRows[0].DataBoundItem is MonHoc item)
            {
                this.NapTruongNhap(item);
            }
        }

        // ---------------- Nghiệp vụ giao diện ----------------
        private void TaiDuLieu()
        {
            var data = MonHocBLL.Tim(this.txtTim.Text);
            this._dangTai = true;
            try
            {
                this.dgv.DataSource = null;
                this.dgv.DataSource = data;
                this.dgv.ClearSelection();
                this.dgv.CurrentCell = null;
            }
            finally
            {
                this._dangTai = false;
            }
            this.XoaTruongNhap();
            this.lblTrangThai.Text = data.Count + " bản ghi.";
        }

        private void NhapMoi()
        {
            this.dgv.ClearSelection();
            this.dgv.CurrentCell = null;
            this.XoaTruongNhap();
            this.txtMaMH.Focus();
        }

        private void NapTruongNhap(MonHoc x)
        {
            this.txtMaMH.Text = x.MaMH;
            this.txtTenMH.Text = x.TenMH;
            this.numSoTietLT.Value = Math.Clamp(x.SoTietLT, (int)this.numSoTietLT.Minimum, (int)this.numSoTietLT.Maximum);
            this.numSoTietTH.Value = Math.Clamp(x.SoTietTH, (int)this.numSoTietTH.Minimum, (int)this.numSoTietTH.Maximum);
            this.txtMaMH.ReadOnly = true;
        }

        private void XoaTruongNhap()
        {
            this.txtMaMH.Text = "";
            this.txtTenMH.Text = "";
            this.numSoTietLT.Value = 0;
            this.numSoTietTH.Value = 0;
            this.txtMaMH.ReadOnly = false;
        }

        private MonHoc DocTruongNhap()
        {
            return new MonHoc
            {
                MaMH = this.txtMaMH.Text.Trim(),
                TenMH = this.txtTenMH.Text.Trim(),
                SoTietLT = (int)this.numSoTietLT.Value,
                SoTietTH = (int)this.numSoTietTH.Value
            };
        }

        private void Them()
        {
            if (string.IsNullOrWhiteSpace(this.txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMaMH.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTenMH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenMH.Focus();
                return;
            }

            MonHocBLL.Them(this.DocTruongNhap());
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã thêm môn học thành công.";
            MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sua()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not MonHoc chon)
            {
                MessageBox.Show("Hãy chọn một môn học trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTenMH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenMH.Focus();
                return;
            }

            var m = this.DocTruongNhap();
            m.MaMH = chon.MaMH;
            MonHocBLL.Sua(m);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã cập nhật môn học.";
            MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not MonHoc chon)
            {
                MessageBox.Show("Hãy chọn một môn học trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn học '" + chon.TenMH + "' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            MonHocBLL.Xoa(chon.MaMH);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã xóa môn học.";
            MessageBox.Show("Đã xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
