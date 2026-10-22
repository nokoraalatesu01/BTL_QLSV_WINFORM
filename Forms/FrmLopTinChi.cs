using System;
using System.Windows.Forms;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

public partial class FrmLopTinChi : BaseForm
{
    public partial class FrmLopTinChi : Form
    {
        private readonly bool _coQuyenGhi;
        private bool _dangTai;
        private const string TatCa = "(Tất cả)";

        public FrmLopTinChi()
        {
            InitializeComponent();
            this._coQuyenGhi = Quyen.CoQuyen(ChucNang.LopTinChi, HanhDong.Ghi);
        }

        // ---------------- Sự kiện ----------------
        private void FrmLopTinChi_Load(object sender, EventArgs e)
        {
            try
            {
                this.cboMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cboMonHoc.DisplayMember = "HienThi";
                this.cboMonHoc.ValueMember = "MaMH";
                this.cboMonHoc.DataSource = LopTinChiBLL.LayMonHocChoChon();

                this.cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cboKhoa.DisplayMember = "TenKhoa";
                this.cboKhoa.ValueMember = "MaKhoa";
                this.cboKhoa.DataSource = LopTinChiBLL.LayKhoaChoChon();

                this.NapGiangVienTheoKhoa();

                this.cboLocHocKy.Items.Clear();
                this.cboLocHocKy.Items.AddRange(new object[] { TatCa, "1", "2", "3" });
                this.cboLocHocKy.SelectedIndex = 0;
                this.NapBoLocNienKhoa();

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

        private void FrmLopTinChi_Shown(object sender, EventArgs e)
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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                this.TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi lọc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi thêm lớp tín chỉ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi sửa lớp tín chỉ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Lỗi xóa lớp tín chỉ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.NapGiangVienTheoKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nạp giảng viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (this._dangTai || this.dgv.SelectedRows.Count == 0) return;
            if (this.dgv.SelectedRows[0].DataBoundItem is LopTinChi item)
            {
                this.NapTruongNhap(item);
            }
        }

        // ---------------- Nghiệp vụ giao diện ----------------
        private void TaiDuLieu()
        {
            this.NapBoLocNienKhoa();

            var nk = this.cboLocNienKhoa.SelectedItem as string;
            string? nienKhoa = (nk == null || nk == TatCa) ? null : nk;

            int? hocKy = null;
            if (this.cboLocHocKy.SelectedItem is string hk && hk != TatCa)
            {
                hocKy = int.Parse(hk);
            }

            var data = LopTinChiBLL.Tim(nienKhoa, hocKy);
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
            this.txtNienKhoa.Focus();
        }

        private void NapTruongNhap(LopTinChi x)
        {
            this.txtMaLTC.Text = x.MaLTC.ToString();
            this.txtNienKhoa.Text = x.NienKhoa;
            this.numHocKy.Value = Math.Clamp(x.HocKy, (int)this.numHocKy.Minimum, (int)this.numHocKy.Maximum);
            this.numNhom.Value = Math.Clamp(x.Nhom, (int)this.numNhom.Minimum, (int)this.numNhom.Maximum);
            this.cboMonHoc.SelectedValue = x.MaMH;
            this.cboKhoa.SelectedValue = x.MaKhoa;      // kích hoạt nạp lại danh sách giảng viên
            this.cboGiangVien.SelectedValue = x.MaGV;
            this.numSVToiThieu.Value = Math.Clamp(x.SoSVToiThieu, (int)this.numSVToiThieu.Minimum, (int)this.numSVToiThieu.Maximum);
            this.chkHuyLop.Checked = x.HuyLop;
        }

        private void XoaTruongNhap()
        {
            this.txtMaLTC.Text = "";
            this.txtNienKhoa.Text = "";
            this.numHocKy.Value = 1;
            this.numNhom.Value = 1;
            if (this.cboMonHoc.Items.Count > 0) this.cboMonHoc.SelectedIndex = 0;
            if (this.cboKhoa.Items.Count > 0) this.cboKhoa.SelectedIndex = 0;
            if (this.cboGiangVien.Items.Count > 0) this.cboGiangVien.SelectedIndex = 0;
            this.numSVToiThieu.Value = 0;
            this.chkHuyLop.Checked = false;
        }

        private LopTinChi DocTruongNhap()
        {
            return new LopTinChi
            {
                NienKhoa = this.txtNienKhoa.Text.Trim(),
                HocKy = (int)this.numHocKy.Value,
                MaMH = this.cboMonHoc.SelectedValue as string ?? "",
                Nhom = (int)this.numNhom.Value,
                MaGV = this.cboGiangVien.SelectedValue as string ?? "",
                MaKhoa = this.cboKhoa.SelectedValue as string ?? "",
                SoSVToiThieu = (int)this.numSVToiThieu.Value,
                HuyLop = this.chkHuyLop.Checked
            };
        }

        private void Them()
        {
            if (string.IsNullOrWhiteSpace(this.txtNienKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập niên khóa (ví dụ: 2023-2024)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNienKhoa.Focus();
                return;
            }

            int ma = LopTinChiBLL.Them(this.DocTruongNhap());
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã tạo lớp tín chỉ mã " + ma + ".";
            MessageBox.Show("Thêm lớp tín chỉ thành công (Mã: " + ma + ")!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sua()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not LopTinChi chon)
            {
                MessageBox.Show("Hãy chọn một lớp tín chỉ trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtNienKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập niên khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNienKhoa.Focus();
                return;
            }

            var t = this.DocTruongNhap();
            t.MaLTC = chon.MaLTC;
            LopTinChiBLL.Sua(t);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã cập nhật lớp tín chỉ.";
            MessageBox.Show("Cập nhật lớp tín chỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa()
        {
            if (this.dgv.SelectedRows.Count == 0 || this.dgv.SelectedRows[0].DataBoundItem is not LopTinChi chon)
            {
                MessageBox.Show("Hãy chọn một lớp tín chỉ trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp tín chỉ mã " + chon.MaLTC + " (" + chon.TenMH + " - nhóm " + chon.Nhom + ") không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            LopTinChiBLL.Xoa(chon.MaLTC);
            this.TaiDuLieu();
            this.lblTrangThai.Text = "Đã xóa lớp tín chỉ.";
            MessageBox.Show("Đã xóa lớp tín chỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NapGiangVienTheoKhoa()
        {
            var maKhoa = this.cboKhoa.SelectedValue as string;
            this.cboGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboGiangVien.DisplayMember = "HienThi";
            this.cboGiangVien.ValueMember = "MaGV";
            this.cboGiangVien.DataSource = LopTinChiBLL.LayGiangVienTheoKhoa(maKhoa);
        }

        /// <summary>Nạp lại danh sách niên khóa của bộ lọc, giữ nguyên lựa chọn hiện tại nếu còn.</summary>
        private void NapBoLocNienKhoa()
        {
            var dangChon = this.cboLocNienKhoa.SelectedItem as string;
            this.cboLocNienKhoa.Items.Clear();
            this.cboLocNienKhoa.Items.Add(TatCa);
            foreach (var nk in LopTinChiBLL.LayNienKhoa())
            {
                this.cboLocNienKhoa.Items.Add(nk);
            }

            int vt = (dangChon == null) ? 0 : this.cboLocNienKhoa.Items.IndexOf(dangChon);
            this.cboLocNienKhoa.SelectedIndex = (vt < 0) ? 0 : vt;
        }
    }
}
