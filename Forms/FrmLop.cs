using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

public partial class FrmLop : BaseForm
{
    private readonly bool _coQuyenGhi;
    private bool _dangTai;

    public FrmLop()
    {
        InitializeComponent();
        _coQuyenGhi = Quyen.CoQuyen(ChucNang.Lop, HanhDong.Ghi);
    }

    // ---------------- Sự kiện ----------------
    private void FrmLop_Load(object? sender, EventArgs e) => UiHelper.Run(() =>
    {
        UiHelper.BindCombo(cboKhoa, KhoaBLL.LayDanhSach(), "TenKhoa", "MaKhoa");
        if (!_coQuyenGhi)
        {
            // Chỉ xem: ẩn ô nhập và các nút thay đổi dữ liệu.
            pnlNhap.Visible = false;
            btnNhapMoi.Visible = btnThem.Visible = btnSua.Visible = btnXoa.Visible = false;
            lblTrangThai.Text = "Bạn chỉ có quyền xem danh sách này.";
        }
        TaiDuLieu();
    });

    private void FrmLop_Shown(object? sender, EventArgs e) => UiHelper.Run(NhapMoi);
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
        if (dgv.SelectedRows[0].DataBoundItem is Lop item)
            UiHelper.Run(() => NapTruongNhap(item));
    }

    // ---------------- Nghiệp vụ giao diện ----------------
    private void TaiDuLieu()
    {
        var data = LopBLL.Tim(txtTim.Text);
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

    private void NapTruongNhap(Lop x)
    {
        txtMaLop.Text = x.MaLop;
        txtTenLop.Text = x.TenLop;
        txtKhoaHoc.Text = x.KhoaHoc;
        cboKhoa.SelectedValue = x.MaKhoa;
        txtMaLop.ReadOnly = true;
    }

    private void XoaTruongNhap()
    {
        txtMaLop.Clear();
        txtTenLop.Clear();
        txtKhoaHoc.Clear();
        if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
        txtMaLop.ReadOnly = false;
    }

    private Lop DocTruongNhap() => new()
    {
        MaLop = txtMaLop.Text,
        TenLop = txtTenLop.Text,
        KhoaHoc = txtKhoaHoc.Text,
        MaKhoa = cboKhoa.SelectedValue as string ?? "",
    };

    private void Them()
    {
        LopBLL.Them(DocTruongNhap());
        TaiDuLieu();
        lblTrangThai.Text = "Đã thêm lớp.";
    }

    private void Sua()
    {
        var chon = UiHelper.BatBuocChon<Lop>(dgv, "sửa");
        var l = DocTruongNhap();
        l.MaLop = chon.MaLop;
        LopBLL.Sua(l);
        TaiDuLieu();
        lblTrangThai.Text = "Đã cập nhật lớp.";
    }

    private void Xoa()
    {
        var chon = UiHelper.BatBuocChon<Lop>(dgv, "xóa");
        if (!UiHelper.Confirm($"Xóa lớp '{chon.TenLop}'?")) return;
        LopBLL.Xoa(chon.MaLop);
        TaiDuLieu();
        lblTrangThai.Text = "Đã xóa lớp.";
    }
}
