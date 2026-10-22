using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

public partial class FrmSinhVien : BaseForm
{
    public partial class FrmSinhVien : Form
    {
        private readonly bool _coQuyenGhi;
        private bool _dangTai;

        public FrmSinhVien()
        {
            InitializeComponent();
            this._coQuyenGhi = Quyen.CoQuyen(ChucNang.SinhVien, HanhDong.Ghi);
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                this.cboGioiTinh.Items.Clear();
                this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
                this.cboGioiTinh.SelectedIndex = 0;
                this.dtpNgaySinh.MinDate = new DateTime(1950, 1, 1);
                this.dtpNgaySinh.MaxDate = DateTime.Today;
                this.dtpNgaySinh.Checked = false;

                var dsLop = SinhVienBLL.LayLopChoChon();

                this.cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cboLop.DisplayMember = "HienThi";
                this.cboLop.ValueMember = "MaLop";
                this.cboLop.DataSource = new List<Lop>(dsLop);

                var dsLoc = new List<Lop> { new Lop { MaLop = "", TenLop = "-- Tất cả lớp --" } };
                dsLoc.AddRange(dsLop);
                this.cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cboLocLop.DisplayMember = "HienThi";
                this.cboLocLop.ValueMember = "MaLop";
                this.cboLocLop.DataSource = dsLoc;

                if (!this._coQuyenGhi)
                {
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

        private void FrmSinhVien_Shown(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Lỗi thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi sửa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this._dangTai || this.dgv.SelectedRows.Count == 0) return;
            if (this.dgv.SelectedRows[0].DataBoundItem is SinhVien item)
            {
                this.NapTruongNhap(item);
            }
        }

        private void TaiDuLieu()
        {
            var maLop = this.cboLocLop.SelectedValue as string;
            var data = SinhVienBLL.Tim(this.txtTim.Text, string.IsNullOrEmpty(maLop) ? null : maLop);
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
            this.txtMaSV.Focus();
        }

        private void NapTruongNhap(SinhVien x)
        {
            this.txtMaSV.Text = x.MaSV;
            this.txtHo.Text = x.Ho;
            this.txtTen.Text = x.Ten;
            this.cboLop.SelectedValue = x.MaLop;
            this.cboGioiTinh.SelectedIndex = x.GioiTinh == "Nữ" ? 1 : 0;
            this.txtDiaChi.Text = x.DiaChi ?? "";
            this.chkNghiHoc.Checked = x.DaNghiHoc;

            if (x.NgaySinh.HasValue)
            {
                var d = x.NgaySinh.Value.Date;
                if (d < this.dtpNgaySinh.MinDate) d = this.dtpNgaySinh.MinDate;
                if (d > this.dtpNgaySinh.MaxDate) d = this.dtpNgaySinh.MaxDate;
                this.dtpNgaySinh.Value = d;
                this.dtpNgaySinh.Checked = true;
            }
            else
            {
                this.dtpNgaySinh.Checked = false;
            }
            this.txtMaSV.ReadOnly = true;
        }

        private void XoaTruongNhap()
        {
            this.txtMaSV.Text = "";
            this.txtHo.Text = "";
            this.txtTen.Text = "";
            this.txtDiaChi.Text = "";
            if (this.cboLop.Items.Count > 0) this.cboLop.SelectedIndex = 0;
            if (this.cboGioiTinh.Items.Count > 0) this.cboGioiTinh.SelectedIndex = 0;
            this.dtpNgaySinh.Checked = false;
            this.chkNghiHoc.Checked = false;
            this.txtMaSV.ReadOnly = false;
        }

        private SinhVien DocTruongNhap()
        {
            return new SinhVien
            {
                MaSV = this.txtMaSV.Text.Trim(),
                Ho = this.txtHo.Text.Trim(),
                Ten = this.txtTen.Text.Trim(),
                MaLop = this.cboLop.SelectedValue as string ?? "",
                GioiTinh = this.cboGioiTinh.SelectedItem as string ?? "Nam",
                DiaChi = this.txtDiaChi.Text.Trim(),
                NgaySinh = this.dtpNgaySinh.Checked ? this.dtpNgaySinh.Value.Date : (DateTime?)null,
                DaNghiHoc = this.chkNghiHoc.Checked
            };
        }

        private void Them()
        {
            if (string.IsNullOrWhiteSpace(this.txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMaSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHo.Text))
            {
                MessageBox.Show("Vui lòng nhập họ đệm sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTen.Focus();
                return;
            }

            SinhVienBLL.Them(this.DocTruongNhap());
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã thêm sinh viên. Tài khoản đăng nhập = mã sinh viên, mật khẩu mặc định " + AppConstants.MatKhauMacDinh + ".";
            MessageBox.Show("Thêm sinh viên thành công!\nTài khoản đăng nhập = mã sinh viên, mật khẩu mặc định " + AppConstants.MatKhauMacDinh + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sua()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not SinhVien chon)
            {
                MessageBox.Show("Hãy chọn một sinh viên trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtHo.Text))
            {
                MessageBox.Show("Vui lòng nhập họ đệm sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTen.Focus();
                return;
            }

            var sv = this.DocTruongNhap();
            sv.MaSV = chon.MaSV;
            SinhVienBLL.Sua(sv);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã cập nhật sinh viên.";
            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not SinhVien chon)
            {
                MessageBox.Show("Hãy chọn một sinh viên trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + chon.MaSV + " - " + chon.HoTen + " (cùng tài khoản đăng nhập) không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            SinhVienBLL.Xoa(chon.MaSV);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã xóa sinh viên.";
            MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
