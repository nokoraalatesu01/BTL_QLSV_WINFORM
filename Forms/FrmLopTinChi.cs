using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;

namespace QLDSV_HTC.Forms;

public partial class FrmLopTinChi : Form
{
    private readonly bool _coQuyenGhi;
    private bool _dangTai;
    private const string TatCa = "(Tất cả)";

    public FrmLopTinChi()
    {
        InitializeComponent();
        _coQuyenGhi = Quyen.CoQuyen(ChucNang.LopTinChi, HanhDong.Ghi);
    }

    // ---------------- Sự kiện ----------------
    private void FrmLopTinChi_Load(object? sender, EventArgs e) => UiHelper.Run(() =>
    {
        UiHelper.BindCombo(cboMonHoc, LopTinChiBLL.LayMonHocChoChon(), "HienThi", "MaMH");
        UiHelper.BindCombo(cboKhoa, LopTinChiBLL.LayKhoaChoChon(), "TenKhoa", "MaKhoa");
        NapGiangVienTheoKhoa();

        cboLocHocKy.Items.AddRange(new object[] { TatCa, "1", "2", "3" });
        cboLocHocKy.SelectedIndex = 0;
        NapBoLocNienKhoa();
        if (!_coQuyenGhi)
        {
            // Chỉ xem: ẩn ô nhập và các nút thay đổi dữ liệu.
            pnlNhap.Visible = false;
            btnNhapMoi.Visible = btnThem.Visible = btnSua.Visible = btnXoa.Visible = false;
            lblTrangThai.Text = "Bạn chỉ có quyền xem danh sách này.";
        }
        TaiDuLieu();
    });

    private void FrmLopTinChi_Shown(object? sender, EventArgs e) => UiHelper.Run(NhapMoi);
    private void btnNhapMoi_Click(object? sender, EventArgs e) => UiHelper.Run(NhapMoi);
    private void btnTaiLai_Click(object? sender, EventArgs e) => UiHelper.Run(TaiDuLieu);
    private void btnLoc_Click(object? sender, EventArgs e) => UiHelper.Run(TaiDuLieu);
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
    private void cboKhoa_SelectedIndexChanged(object? sender, EventArgs e) => UiHelper.Run(NapGiangVienTheoKhoa);

    private void dgv_SelectionChanged(object? sender, EventArgs e)
    {
        if (_dangTai || dgv.SelectedRows.Count == 0) return;
        if (dgv.SelectedRows[0].DataBoundItem is LopTinChi item)
            UiHelper.Run(() => NapTruongNhap(item));
    }

    // ---------------- Nghiệp vụ giao diện ----------------
    private void TaiDuLieu()
    {
        NapBoLocNienKhoa();

        var nk = cboLocNienKhoa.SelectedItem as string;
        string? nienKhoa = nk == null || nk == TatCa ? null : nk;

        int? hocKy = null;
        if (cboLocHocKy.SelectedItem is string hk && hk != TatCa)
            hocKy = int.Parse(hk);

        var data = LopTinChiBLL.Tim(nienKhoa, hocKy);
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

    private void NapTruongNhap(LopTinChi x)
    {
        txtMaLTC.Text = x.MaLTC.ToString();
        txtNienKhoa.Text = x.NienKhoa;
        UiHelper.SetNumeric(numHocKy, x.HocKy);
        UiHelper.SetNumeric(numNhom, x.Nhom);
        cboMonHoc.SelectedValue = x.MaMH;
        cboKhoa.SelectedValue = x.MaKhoa;      // kích hoạt nạp lại danh sách giảng viên
        cboGiangVien.SelectedValue = x.MaGV;
        UiHelper.SetNumeric(numSVToiThieu, x.SoSVToiThieu);
        chkHuyLop.Checked = x.HuyLop;
    }

    private void XoaTruongNhap()
    {
        txtMaLTC.Clear();
        txtNienKhoa.Clear();
        numHocKy.Value = 1;
        numNhom.Value = 1;
        if (cboMonHoc.Items.Count > 0) cboMonHoc.SelectedIndex = 0;
        if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
        if (cboGiangVien.Items.Count > 0) cboGiangVien.SelectedIndex = 0;
        numSVToiThieu.Value = 0;
        chkHuyLop.Checked = false;
    }

    private LopTinChi DocTruongNhap() => new()
    {
        NienKhoa = txtNienKhoa.Text,
        HocKy = (int)numHocKy.Value,
        MaMH = cboMonHoc.SelectedValue as string ?? "",
        Nhom = (int)numNhom.Value,
        MaGV = cboGiangVien.SelectedValue as string ?? "",
        MaKhoa = cboKhoa.SelectedValue as string ?? "",
        SoSVToiThieu = (int)numSVToiThieu.Value,
        HuyLop = chkHuyLop.Checked,
    };

    private void Them()
    {
        int ma = LopTinChiBLL.Them(DocTruongNhap());
        TaiDuLieu();
        lblTrangThai.Text = $"Đã tạo lớp tín chỉ mã {ma}.";
    }

    private void Sua()
    {
        var chon = UiHelper.BatBuocChon<LopTinChi>(dgv, "sửa");
        var t = DocTruongNhap();
        t.MaLTC = chon.MaLTC;
        LopTinChiBLL.Sua(t);
        TaiDuLieu();
        lblTrangThai.Text = "Đã cập nhật lớp tín chỉ.";
    }

    private void Xoa()
    {
        var chon = UiHelper.BatBuocChon<LopTinChi>(dgv, "xóa");
        if (!UiHelper.Confirm($"Xóa lớp tín chỉ {chon.MaLTC} ({chon.TenMH} - nhóm {chon.Nhom})?")) return;
        LopTinChiBLL.Xoa(chon.MaLTC);
        TaiDuLieu();
        lblTrangThai.Text = "Đã xóa lớp tín chỉ.";
    }

    private void NapGiangVienTheoKhoa()
    {
        var maKhoa = cboKhoa.SelectedValue as string;
        UiHelper.BindCombo(cboGiangVien, LopTinChiBLL.LayGiangVienTheoKhoa(maKhoa), "HienThi", "MaGV");
    }

    /// <summary>Nạp lại danh sách niên khóa của bộ lọc, giữ nguyên lựa chọn hiện tại nếu còn.</summary>
    private void NapBoLocNienKhoa()
    {
        var dangChon = cboLocNienKhoa.SelectedItem as string;
        cboLocNienKhoa.Items.Clear();
        cboLocNienKhoa.Items.Add(TatCa);
        foreach (var nk in LopTinChiBLL.LayNienKhoa())
            cboLocNienKhoa.Items.Add(nk);

        int vt = dangChon == null ? 0 : cboLocNienKhoa.Items.IndexOf(dangChon);
        cboLocNienKhoa.SelectedIndex = vt < 0 ? 0 : vt;
    }
}
