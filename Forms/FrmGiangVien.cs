using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms;

public partial class FrmGiangVien : Form
{
    private readonly bool _coQuyenGhi;
    private bool _dangTai;

    public FrmGiangVien()
    {
        InitializeComponent();
        _coQuyenGhi = Quyen.CoQuyen(ChucNang.GiangVien, HanhDong.Ghi);
    }

    // ---------------- Sự kiện ----------------
    private void FrmGiangVien_Load(object? sender, EventArgs e) => UiHelper.Run(() =>
    {
        UiHelper.BindCombo(cboKhoa, GiangVienBLL.LayKhoaChoChon(), "TenKhoa", "MaKhoa");
        if (!_coQuyenGhi)
        {
            // Chỉ xem: ẩn ô nhập và các nút thay đổi dữ liệu.
            pnlNhap.Visible = false;
            btnNhapMoi.Visible = btnThem.Visible = btnSua.Visible = btnXoa.Visible = false;
            lblTrangThai.Text = "Bạn chỉ có quyền xem danh sách này.";
        }
        TaiDuLieu();
    });

    private void FrmGiangVien_Shown(object? sender, EventArgs e) => UiHelper.Run(NhapMoi);
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
        if (dgv.SelectedRows[0].DataBoundItem is GiangVien item)
            UiHelper.Run(() => NapTruongNhap(item));
    }

    // ---------------- Nghiệp vụ giao diện ----------------
    private void TaiDuLieu()
    {
        var data = GiangVienBLL.Tim(txtTim.Text);
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

    private void NapTruongNhap(GiangVien x)
    {
        txtMaGV.Text = x.MaGV;
        cboKhoa.SelectedValue = x.MaKhoa;
        txtHo.Text = x.Ho;
        txtTen.Text = x.Ten;
        txtHocVi.Text = x.HocVi ?? "";
        txtHocHam.Text = x.HocHam ?? "";
        txtChuyenMon.Text = x.ChuyenMon ?? "";
        txtMaGV.ReadOnly = true;
    }

    private void XoaTruongNhap()
    {
        txtMaGV.Clear();
        if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
        txtHo.Clear();
        txtTen.Clear();
        txtHocVi.Clear();
        txtHocHam.Clear();
        txtChuyenMon.Clear();
        txtMaGV.ReadOnly = false;
    }

    private GiangVien DocTruongNhap() => new()
    {
        MaGV = txtMaGV.Text,
        MaKhoa = cboKhoa.SelectedValue as string ?? "",
        Ho = txtHo.Text,
        Ten = txtTen.Text,
        HocVi = txtHocVi.Text,
        HocHam = txtHocHam.Text,
        ChuyenMon = txtChuyenMon.Text,
    };

    private void Them()
    {
        GiangVienBLL.Them(DocTruongNhap());
        TaiDuLieu();
        lblTrangThai.Text = $"Đã thêm giảng viên. Tài khoản đăng nhập = mã giảng viên, mật khẩu mặc định {AppConstants.MatKhauMacDinh}.";
    }

    private void Sua()
    {
        var chon = UiHelper.BatBuocChon<GiangVien>(dgv, "sửa");
        var g = DocTruongNhap();
        g.MaGV = chon.MaGV;
        GiangVienBLL.Sua(g);
        TaiDuLieu();
        lblTrangThai.Text = "Đã cập nhật giảng viên.";
    }

    private void Xoa()
    {
        var chon = UiHelper.BatBuocChon<GiangVien>(dgv, "xóa");
        if (!UiHelper.Confirm($"Xóa giảng viên {chon.MaGV} - {chon.HoTen}?")) return;
        GiangVienBLL.Xoa(chon.MaGV);
        TaiDuLieu();
        lblTrangThai.Text = "Đã xóa giảng viên.";
    }
}
