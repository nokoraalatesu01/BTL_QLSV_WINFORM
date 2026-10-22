using System;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

public partial class FrmLop : BaseForm
{
    public partial class FrmLop : Form
    {
        private readonly bool _coQuyenGhi;
        private bool _dangTai;

        public FrmLop()
        {
            InitializeComponent();
            this._coQuyenGhi = Quyen.CoQuyen(ChucNang.Lop, HanhDong.Ghi);
        }

        // ---------------- Sự kiện ----------------
        private void FrmLop_Load(object sender, EventArgs e)
        {
            try
            {
                this.cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cboKhoa.DisplayMember = "TenKhoa";
                this.cboKhoa.ValueMember = "MaKhoa";
                this.cboKhoa.DataSource = KhoaBLL.LayDanhSach();

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

        private void FrmLop_Shown(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Lỗi thêm lớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi sửa lớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi xóa lớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this._dangTai || this.dgv.SelectedRows.Count == 0) return;
            if (this.dgv.SelectedRows[0].DataBoundItem is Lop item)
            {
                this.NapTruongNhap(item);
            }
        }

        // ---------------- Nghiệp vụ giao diện ----------------
        private void TaiDuLieu()
        {
            var data = LopBLL.Tim(this.txtTim.Text);
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
            this.txtMaLop.Focus();
        }

        private void NapTruongNhap(Lop x)
        {
            this.txtMaLop.Text = x.MaLop;
            this.txtTenLop.Text = x.TenLop;
            this.txtKhoaHoc.Text = x.KhoaHoc;
            this.cboKhoa.SelectedValue = x.MaKhoa;
            this.txtMaLop.ReadOnly = true;
        }

        private void XoaTruongNhap()
        {
            this.txtMaLop.Text = "";
            this.txtTenLop.Text = "";
            this.txtKhoaHoc.Text = "";
            if (this.cboKhoa.Items.Count > 0) this.cboKhoa.SelectedIndex = 0;
            this.txtMaLop.ReadOnly = false;
        }

        private Lop DocTruongNhap()
        {
            return new Lop
            {
                MaLop = this.txtMaLop.Text.Trim(),
                TenLop = this.txtTenLop.Text.Trim(),
                KhoaHoc = this.txtKhoaHoc.Text.Trim(),
                MaKhoa = this.cboKhoa.SelectedValue as string ?? ""
            };
        }

        private void Them()
        {
            if (string.IsNullOrWhiteSpace(this.txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMaLop.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenLop.Focus();
                return;
            }

            LopBLL.Them(this.DocTruongNhap());
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã thêm lớp thành công.";
            MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sua()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not Lop chon)
            {
                MessageBox.Show("Hãy chọn một lớp trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenLop.Focus();
                return;
            }

            var l = this.DocTruongNhap();
            l.MaLop = chon.MaLop;
            LopBLL.Sua(l);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã cập nhật lớp.";
            MessageBox.Show("Cập nhật thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not Lop chon)
            {
                MessageBox.Show("Hãy chọn một lớp trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp '" + chon.TenLop + "' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            LopBLL.Xoa(chon.MaLop);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã xóa lớp.";
            MessageBox.Show("Đã xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
