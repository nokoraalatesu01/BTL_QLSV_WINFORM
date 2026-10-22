using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms;

public partial class FrmSinhVien : Form
{
    private readonly bool _coQuyenGhi;
    private bool _dangTai;

    public FrmSinhVien()
    {
        InitializeComponent();
        _coQuyenGhi = Quyen.CoQuyen(ChucNang.SinhVien, HanhDong.Ghi);
    }

    private void FrmSinhVien_Load(object? sender, EventArgs e) => UiHelper.Run(() =>
    {
        cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
        cboGioiTinh.SelectedIndex = 0;
        dtpNgaySinh.MinDate = new DateTime(1950, 1, 1);
        dtpNgaySinh.MaxDate = DateTime.Today;
        dtpNgaySinh.Checked = false;

        var dsLop = SinhVienBLL.LayLopChoChon();
        UiHelper.BindCombo(cboLop, new List<Lop>(dsLop), "HienThi", "MaLop");
        var dsLoc = new List<Lop> { new() { MaLop = "", TenLop = "-- Tất cả lớp --" } };
        dsLoc.AddRange(dsLop);
        UiHelper.BindCombo(cboLocLop, dsLoc, "HienThi", "MaLop");
        if (!_coQuyenGhi)
        {
            pnlNhap.Visible = false;
            btnNhapMoi.Visible = btnThem.Visible = btnSua.Visible = btnXoa.Visible = false;
            lblTrangThai.Text = "Bạn chỉ có quyền xem danh sách này.";
        }
        TaiDuLieu();
    });

    private void FrmSinhVien_Shown(object? sender, EventArgs e) => UiHelper.Run(NhapMoi);
    private void btnNhapMoi_Click(object? sender, EventArgs e) => UiHelper.Run(NhapMoi);
    private void btnTaiLai_Click(object? sender, EventArgs e) => UiHelper.Run(TaiDuLieu);
    private void btnTim_Click(object? sender, EventArgs e) => UiHelper.Run(TaiDuLieu);
    private void txtTim_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
        UiHelper.Run(TaiDuLieu);
    }
    private void btnThem_Click(object? sender, EventArgs e) => UiHelper.Run(() =>
    {
        if (dgv.SelectedRows.Count > 0)
        {
            UiHelper.ShowWarning("Đang chọn một dòng trong danh sách. Bấm 'Nhập mới' trước khi thêm bản ghi mới.");
            return;
        }
        Them();
    });
    private void btnSua_Click(object? sender, EventArgs e) => UiHelper.Run(Sua);
    private void btnXoa_Click(object? sender, EventArgs e) => UiHelper.Run(Xoa);

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        if (_dangTai || dgv.SelectedRows.Count == 0) return;
        if (dgv.SelectedRows[0].DataBoundItem is SinhVien item)
            UiHelper.Run(() => NapTruongNhap(item));
    }

    private void TaiDuLieu()
    {
        var maLop = cboLocLop.SelectedValue as string;
        var data = SinhVienBLL.Tim(txtTim.Text, string.IsNullOrEmpty(maLop) ? null : maLop);
        _dangTai = true;
        try { UiHelper.GanLuoi(dgv, data); }
        finally { _dangTai = false; }
        XoaTruongNhap();
        lblTrangThai.Text = $"{data.Count} bản ghi.";
    }

    private void NhapMoi()
    {
        dgv.ClearSelection();
        dgv.CurrentCell = null;
        XoaTruongNhap();
    }

    private void NapTruongNhap(SinhVien x)
    {
        txtMaSV.Text = x.MaSV;
        txtHo.Text = x.Ho;
        txtTen.Text = x.Ten;
        cboLop.SelectedValue = x.MaLop;
        cboGioiTinh.SelectedIndex = x.GioiTinh == "Nữ" ? 1 : 0;
        txtDiaChi.Text = x.DiaChi ?? "";
        chkNghiHoc.Checked = x.DaNghiHoc;

        if (x.NgaySinh.HasValue)
        {
            var d = x.NgaySinh.Value.Date;
            if (d < dtpNgaySinh.MinDate) d = dtpNgaySinh.MinDate;
            if (d > dtpNgaySinh.MaxDate) d = dtpNgaySinh.MaxDate;
            dtpNgaySinh.Value = d;
            dtpNgaySinh.Checked = true;
        }
        else
        {
            dtpNgaySinh.Checked = false;
        }
        txtMaSV.ReadOnly = true;
    }

    private void XoaTruongNhap()
    {
        txtMaSV.Clear();
        txtHo.Clear();
        txtTen.Clear();
        txtDiaChi.Clear();
        if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
        if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;
        dtpNgaySinh.Checked = false;
        chkNghiHoc.Checked = false;
        txtMaSV.ReadOnly = false;
    }

    private SinhVien DocTruongNhap() => new()
    {
        MaSV = txtMaSV.Text,
        Ho = txtHo.Text,
        Ten = txtTen.Text,
        MaLop = cboLop.SelectedValue as string ?? "",
        GioiTinh = cboGioiTinh.SelectedItem as string ?? "Nam",
        DiaChi = txtDiaChi.Text,
        NgaySinh = dtpNgaySinh.Checked ? dtpNgaySinh.Value.Date : (DateTime?)null,
        DaNghiHoc = chkNghiHoc.Checked,
    };

    private void Them()
    {
        SinhVienBLL.Them(DocTruongNhap());
        TaiDuLieu();
        lblTrangThai.Text = $"Đã thêm sinh viên. Tài khoản đăng nhập = mã sinh viên, mật khẩu mặc định {AppConstants.MatKhauMacDinh}.";
    }

    private void Sua()
    {
        var chon = UiHelper.BatBuocChon<SinhVien>(dgv, "sửa");
        var sv = DocTruongNhap();
        sv.MaSV = chon.MaSV;
        SinhVienBLL.Sua(sv);
        TaiDuLieu();
        lblTrangThai.Text = "Đã cập nhật sinh viên.";
    }

    private void Xoa()
    {
        var chon = UiHelper.BatBuocChon<SinhVien>(dgv, "xóa");
        if (!UiHelper.Confirm($"Xóa sinh viên {chon.MaSV} - {chon.HoTen} (cùng tài khoản đăng nhập)?")) return;
        SinhVienBLL.Xoa(chon.MaSV);
        TaiDuLieu();
        lblTrangThai.Text = "Đã xóa sinh viên.";
    }
}
