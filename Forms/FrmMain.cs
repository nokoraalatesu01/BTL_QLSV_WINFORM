using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;

namespace QLDSV_HTC.Forms;

/// <summary>Form chính (MDI): menu hiển thị theo quyền của người dùng đang đăng nhập.</summary>
public partial class FrmMain : Form
{
    private readonly Dictionary<Type, Form> _formDangMo = new();

    /// <summary>true nếu người dùng chọn "Đăng xuất" (Program sẽ hiện lại màn hình đăng nhập).</summary>
    public bool DangXuat { get; private set; }

    public FrmMain()
    {
        InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            var nd = Quyen.HienTai;
            lblNguoiDung.Text = $"Người dùng: {nd.TenHienThi}  |  Vai trò: {nd.VaiTroText}  |  Tài khoản: {nd.TenDangNhap}";

            // Ẩn menu theo quyền (tầng BLL vẫn kiểm tra lại mỗi khi gọi dữ liệu).
            // Lưu ý: không đọc lại ToolStripItem.Visible của mục con (luôn false khi menu cha chưa mở),
            // nên tính quyền ra biến riêng rồi gán cho cả mục con lẫn mục cha.
            bool coKhoa = Quyen.CoQuyen(ChucNang.Khoa, HanhDong.Xem);
            bool coLop = Quyen.CoQuyen(ChucNang.Lop, HanhDong.Xem);
            bool coSinhVien = Quyen.CoQuyen(ChucNang.SinhVien, HanhDong.Xem);
            bool coMonHoc = Quyen.CoQuyen(ChucNang.MonHoc, HanhDong.Xem);
            bool coGiangVien = Quyen.CoQuyen(ChucNang.GiangVien, HanhDong.Xem);
            bool coLopTinChi = Quyen.CoQuyen(ChucNang.LopTinChi, HanhDong.Xem);
            bool coNhapDiem = Quyen.CoQuyen(ChucNang.NhapDiem, HanhDong.Xem);
            bool coDiemCaNhan = Quyen.CoQuyen(ChucNang.DiemCaNhan, HanhDong.Xem);

            mnuKhoa.Available = coKhoa;
            mnuLop.Available = coLop;
            mnuSinhVien.Available = coSinhVien;
            mnuMonHoc.Available = coMonHoc;
            mnuGiangVien.Available = coGiangVien;
            mnuLopTinChi.Available = coLopTinChi;
            mnuNhapDiem.Available = coNhapDiem;
            mnuBangDiemCaNhan.Available = coDiemCaNhan;

            mnuDanhMuc.Available = coKhoa || coLop || coSinhVien || coMonHoc || coGiangVien;
            mnuDaoTao.Available = coLopTinChi || coNhapDiem;
            mnuTaiKhoanSV.Available = coDiemCaNhan;
        });
    }

    // ---------------- Menu Hệ thống ----------------
    private void mnuDoiMatKhau_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() =>
        {
            using var f = new FrmDoiMatKhau();
            f.ShowDialog(this);
        });
    }

    private void mnuDangXuat_Click(object sender, EventArgs e)
    {
        UiHelper.Run(DangXuatTaiKhoan);
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    // ---------------- Menu chức năng ----------------
    private void mnuKhoa_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmKhoa()));
    }

    private void mnuLop_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmLop()));
    }

    private void mnuSinhVien_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmSinhVien()));
    }

    private void mnuMonHoc_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmMonHoc()));
    }

    private void mnuGiangVien_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmGiangVien()));
    }

    private void mnuLopTinChi_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmLopTinChi()));
    }

    private void mnuNhapDiem_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmNhapDiem()));
    }

    private void mnuBangDiemCaNhan_Click(object sender, EventArgs e)
    {
        UiHelper.Run(() => MoForm(() => new FrmBangDiemSV()));
    }

    // ---------------- Menu Cửa sổ ----------------
    private void mnuXepTang_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.Cascade);
    }

    private void mnuChiaNgang_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void mnuChiaDoc_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileVertical);
    }

    private void mnuDongTatCa_Click(object sender, EventArgs e)
    {
        DongTatCaCuaSoCon();
    }

    /// <summary>Mở form con; nếu loại form đó đã mở thì đưa lên phía trước.</summary>
    private void MoForm(Func<Form> tao)
    {
        var form = tao();
        var loai = form.GetType();

        if (_formDangMo.TryGetValue(loai, out var daMo) && !daMo.IsDisposed)
        {
            form.Dispose();
            daMo.Activate();
            return;
        }

        form.MdiParent = this;
        form.WindowState = FormWindowState.Maximized;
        form.FormClosed += (_, _) => _formDangMo.Remove(loai);
        _formDangMo[loai] = form;
        form.Show();
    }

    private void DongTatCaCuaSoCon()
    {
        foreach (var con in MdiChildren)
            con.Close();
    }

    private void DangXuatTaiKhoan()
    {
        if (!UiHelper.Confirm("Đăng xuất khỏi tài khoản hiện tại?")) return;

        DongTatCaCuaSoCon();
        if (MdiChildren.Length > 0) return; // một cửa sổ con từ chối đóng (còn điểm chưa lưu)

        AuthBLL.DangXuat();
        DangXuat = true;
        Close();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Đóng chương trình/đăng xuất: nếu cửa sổ con còn việc dở (nhập điểm chưa lưu) thì hủy thoát.
        foreach (var con in MdiChildren.ToArray())
        {
            con.Close();
            if (!con.IsDisposed)
            {
                e.Cancel = true;
                DangXuat = false;
                return;
            }
        }
    }
}
