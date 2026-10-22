using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms;

public partial class FrmKhoa : Form
{
    private readonly bool _coQuyenGhi;
    private bool _dangTai;

    public FrmKhoa()
    {
        InitializeComponent();
        _coQuyenGhi = Quyen.CoQuyen(ChucNang.Khoa, HanhDong.Ghi);
    }

    // ---------------- Sự kiện ----------------
    private void FrmKhoa_Load(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            if (!_coQuyenGhi)
            {
                // Chỉ xem: ẩn ô nhập và các nút thay đổi dữ liệu.
                pnlNhap.Visible = false;
                btnNhapMoi.Visible = btnThem.Visible = btnSua.Visible = btnXoa.Visible = false;
                lblTrangThai.Text = "Bạn chỉ có quyền xem danh sách này.";
            }
            TaiDuLieu();
        });
    }

    private void FrmKhoa_Shown(object sender, EventArgs e)
    {
        UiHelper.Run(NhapMoi);
    }

    private void btnNhapMoi_Click(object sender, EventArgs e)
    {
        UiHelper.Run(NhapMoi);
    }

    private void btnTaiLai_Click(object sender, EventArgs e)
    {
        UiHelper.Run(TaiDuLieu);
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            if (dgv.SelectedRows.Count > 0)
            {
                UiHelper.ShowWarning("Đang chọn một dòng trong danh sách. Bấm 'Nhập mới' trước khi thêm bản ghi mới.");
                return;
            }
            Them();
        });
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        UiHelper.Run(Sua);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        UiHelper.Run(Xoa);
    }

    private void dgv_SelectionChanged(object sender, EventArgs e)
    {
        if (_dangTai || dgv.SelectedRows.Count == 0) return;
        if (dgv.SelectedRows[0].DataBoundItem is Khoa item)
            UiHelper.Run(() => NapTruongNhap(item));
    }

    // ---------------- Nghiệp vụ giao diện ----------------
    private void TaiDuLieu()
    {
        var data = KhoaBLL.LayDanhSach();
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

    private void NapTruongNhap(Khoa k)
    {
        txtMaKhoa.Text = k.MaKhoa;
        txtTenKhoa.Text = k.TenKhoa;
        txtMaKhoa.ReadOnly = true;
    }

    private void XoaTruongNhap()
    {
        txtMaKhoa.Clear();
        txtTenKhoa.Clear();
        txtMaKhoa.ReadOnly = false;
    }

    private void Them()
    {
        var tenDangNhap = KhoaBLL.Them(new Khoa { MaKhoa = txtMaKhoa.Text, TenKhoa = txtTenKhoa.Text });
        TaiDuLieu();
        lblTrangThai.Text = $"Đã thêm khoa. Tài khoản đăng nhập của khoa: {tenDangNhap} (mật khẩu mặc định {AppConstants.MatKhauMacDinh}).";
    }

    private void Sua()
    {
        var chon = UiHelper.BatBuocChon<Khoa>(dgv, "sửa");
        KhoaBLL.Sua(new Khoa { MaKhoa = chon.MaKhoa, TenKhoa = txtTenKhoa.Text });
        TaiDuLieu();
        lblTrangThai.Text = "Đã cập nhật khoa.";
    }

    private void Xoa()
    {
        var chon = UiHelper.BatBuocChon<Khoa>(dgv, "xóa");
        if (!UiHelper.Confirm($"Xóa khoa '{chon.TenKhoa}' (cùng tài khoản đăng nhập của khoa)?")) return;
        KhoaBLL.Xoa(chon.MaKhoa);
        TaiDuLieu();
        lblTrangThai.Text = "Đã xóa khoa.";
    }
}
