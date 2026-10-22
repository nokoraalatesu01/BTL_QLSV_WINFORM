using System;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

public partial class FrmKhoa : BaseForm
{
    public partial class FrmKhoa : Form
    {
        private readonly bool _coQuyenGhi;
        private bool _dangTai;

        public FrmKhoa()
        {
            InitializeComponent();
            this._coQuyenGhi = Quyen.CoQuyen(ChucNang.Khoa, HanhDong.Ghi);
        }

        // ---------------- Sự kiện ----------------
        private void FrmKhoa_Load(object sender, EventArgs e)
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

        private void FrmKhoa_Shown(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Lỗi thêm khoa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi sửa khoa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi xóa khoa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this._dangTai || this.dgv.SelectedRows.Count == 0) return;
            if (this.dgv.SelectedRows[0].DataBoundItem is Khoa item)
            {
                this.NapTruongNhap(item);
            }
        }

        // ---------------- Nghiệp vụ giao diện ----------------
        private void TaiDuLieu()
        {
            var data = KhoaBLL.LayDanhSach();
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
            this.txtMaKhoa.Focus();
        }

        private void NapTruongNhap(Khoa k)
        {
            this.txtMaKhoa.Text = k.MaKhoa;
            this.txtTenKhoa.Text = k.TenKhoa;
            this.txtMaKhoa.ReadOnly = true;
        }

        private void XoaTruongNhap()
        {
            this.txtMaKhoa.Text = "";
            this.txtTenKhoa.Text = "";
            this.txtMaKhoa.ReadOnly = false;
        }

        private void Them()
        {
            if (string.IsNullOrWhiteSpace(this.txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMaKhoa.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenKhoa.Focus();
                return;
            }

            var tenDangNhap = KhoaBLL.Them(new Khoa
            {
                MaKhoa = this.txtMaKhoa.Text.Trim(),
                TenKhoa = this.txtTenKhoa.Text.Trim()
            });

            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã thêm khoa. Tài khoản đăng nhập của khoa: " + tenDangNhap + " (mật khẩu mặc định " + AppConstants.MatKhauMacDinh + ").";
            MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sua()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not Khoa chon)
            {
                MessageBox.Show("Hãy chọn một khoa trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTenKhoa.Focus();
                return;
            }

            KhoaBLL.Sua(new Khoa
            {
                MaKhoa = chon.MaKhoa,
                TenKhoa = this.txtTenKhoa.Text.Trim()
            });

            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã cập nhật khoa.";
            MessageBox.Show("Cập nhật thông tin khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not Khoa chon)
            {
                MessageBox.Show("Hãy chọn một khoa trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khoa '" + chon.TenKhoa + "' (cùng tài khoản đăng nhập của khoa) không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            KhoaBLL.Xoa(chon.MaKhoa);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã xóa khoa.";
            MessageBox.Show("Đã xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
