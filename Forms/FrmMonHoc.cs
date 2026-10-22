using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms;

public partial class FrmMonHoc : Form
{
    private readonly bool _coQuyenGhi;
    private bool _dangTai;

    public FrmMonHoc()
    {
        InitializeComponent();
        _coQuyenGhi = Quyen.CoQuyen(ChucNang.MonHoc, HanhDong.Ghi);
    }

    // ---------------- Sự kiện ----------------
    private void FrmMonHoc_Load(object sender, EventArgs e)
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

    private void FrmMonHoc_Shown(object sender, EventArgs e)
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

    private void btnTim_Click(object sender, EventArgs e)
    {
        UiHelper.Run(TaiDuLieu);
    }

    private void txtTim_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
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
        if (dgv.SelectedRows[0].DataBoundItem is MonHoc item)
            UiHelper.Run(() => NapTruongNhap(item));
    }

    // ---------------- Nghiệp vụ giao diện ----------------
    private void TaiDuLieu()
    {
        var data = MonHocBLL.Tim(txtTim.Text);
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

    private void NapTruongNhap(MonHoc x)
    {
        txtMaMH.Text = x.MaMH;
        txtTenMH.Text = x.TenMH;
        UiHelper.SetNumeric(numSoTietLT, x.SoTietLT);
        UiHelper.SetNumeric(numSoTietTH, x.SoTietTH);
        txtMaMH.ReadOnly = true;
    }

    private void XoaTruongNhap()
    {
        txtMaMH.Clear();
        txtTenMH.Clear();
        numSoTietLT.Value = 0;
        numSoTietTH.Value = 0;
        txtMaMH.ReadOnly = false;
    }

    private MonHoc DocTruongNhap() => new()
    {
        MaMH = txtMaMH.Text,
        TenMH = txtTenMH.Text,
        SoTietLT = (int)numSoTietLT.Value,
        SoTietTH = (int)numSoTietTH.Value,
    };

    private void Them()
    {
        MonHocBLL.Them(DocTruongNhap());
        TaiDuLieu();
        lblTrangThai.Text = "Đã thêm môn học.";
    }

    private void Sua()
    {
        var chon = UiHelper.BatBuocChon<MonHoc>(dgv, "sửa");
        var m = DocTruongNhap();
        m.MaMH = chon.MaMH;
        MonHocBLL.Sua(m);
        TaiDuLieu();
        lblTrangThai.Text = "Đã cập nhật môn học.";
    }

    private void Xoa()
    {
        var chon = UiHelper.BatBuocChon<MonHoc>(dgv, "xóa");
        if (!UiHelper.Confirm($"Xóa môn học '{chon.TenMH}'?")) return;
        MonHocBLL.Xoa(chon.MaMH);
        TaiDuLieu();
        lblTrangThai.Text = "Đã xóa môn học.";
    }
}
