using System;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms
{
    public partial class FrmGiangVien : Form
    {
        private readonly bool _coQuyenGhi;
        private bool _dangTai;

        public FrmGiangVien()
        {
            InitializeComponent();
            this._coQuyenGhi = Quyen.CoQuyen(ChucNang.GiangVien, HanhDong.Ghi);
        }

        // ---------------- Sự kiện ----------------
        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                this.cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cboKhoa.DisplayMember = "TenKhoa";
                this.cboKhoa.ValueMember = "MaKhoa";
                this.cboKhoa.DataSource = GiangVienBLL.LayKhoaChoChon();

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

        private void FrmGiangVien_Shown(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Lỗi thêm giảng viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi sửa giảng viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi xóa giảng viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this._dangTai || this.dgv.SelectedRows.Count == 0) return;
            if (this.dgv.SelectedRows[0].DataBoundItem is GiangVien item)
            {
                this.NapTruongNhap(item);
            }
        }

        // ---------------- Nghiệp vụ giao diện ----------------
        private void TaiDuLieu()
        {
            var data = GiangVienBLL.Tim(this.txtTim.Text);
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
            this.txtMaGV.Focus();
        }

        private void NapTruongNhap(GiangVien x)
        {
            this.txtMaGV.Text = x.MaGV;
            this.cboKhoa.SelectedValue = x.MaKhoa;
            this.txtHo.Text = x.Ho;
            this.txtTen.Text = x.Ten;
            this.txtHocVi.Text = x.HocVi ?? "";
            this.txtHocHam.Text = x.HocHam ?? "";
            this.txtChuyenMon.Text = x.ChuyenMon ?? "";
            this.txtMaGV.ReadOnly = true;
        }

        private void XoaTruongNhap()
        {
            this.txtMaGV.Text = "";
            if (this.cboKhoa.Items.Count > 0) this.cboKhoa.SelectedIndex = 0;
            this.txtHo.Text = "";
            this.txtTen.Text = "";
            this.txtHocVi.Text = "";
            this.txtHocHam.Text = "";
            this.txtChuyenMon.Text = "";
            this.txtMaGV.ReadOnly = false;
        }

        private GiangVien DocTruongNhap()
        {
            return new GiangVien
            {
                MaGV = this.txtMaGV.Text.Trim(),
                MaKhoa = this.cboKhoa.SelectedValue as string ?? "",
                Ho = this.txtHo.Text.Trim(),
                Ten = this.txtTen.Text.Trim(),
                HocVi = this.txtHocVi.Text.Trim(),
                HocHam = this.txtHocHam.Text.Trim(),
                ChuyenMon = this.txtChuyenMon.Text.Trim()
            };
        }

        private void Them()
        {
            if (string.IsNullOrWhiteSpace(this.txtMaGV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMaGV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHo.Text))
            {
                MessageBox.Show("Vui lòng nhập họ đệm giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTen.Focus();
                return;
            }

            GiangVienBLL.Them(this.DocTruongNhap());
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã thêm giảng viên. Tài khoản đăng nhập = mã giảng viên, mật khẩu mặc định " + AppConstants.MatKhauMacDinh + ".";
            MessageBox.Show("Thêm giảng viên thành công!\nTài khoản đăng nhập = mã giảng viên, mật khẩu mặc định " + AppConstants.MatKhauMacDinh + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sua()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not GiangVien chon)
            {
                MessageBox.Show("Hãy chọn một giảng viên trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHo.Text))
            {
                MessageBox.Show("Vui lòng nhập họ đệm giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTen.Focus();
                return;
            }

            var g = this.DocTruongNhap();
            g.MaGV = chon.MaGV;
            GiangVienBLL.Sua(g);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã cập nhật giảng viên.";
            MessageBox.Show("Cập nhật giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not GiangVien chon)
            {
                MessageBox.Show("Hãy chọn một giảng viên trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên " + chon.MaGV + " - " + chon.HoTen + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            GiangVienBLL.Xoa(chon.MaGV);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã xóa giảng viên.";
            MessageBox.Show("Đã xóa giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
