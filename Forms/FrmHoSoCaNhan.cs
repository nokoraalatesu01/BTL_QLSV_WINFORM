using System.Drawing.Drawing2D;
using System.Globalization;
using QLDSV_HTC.BLL;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.Models;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

/// <summary>
/// Hồ sơ cá nhân của sinh viên theo phong cách cổng thông tin UTC: cột trái là ảnh + thông tin cơ bản,
/// cột phải là bảng NHÓM / TÊN THÔNG TIN / DỮ LIỆU. Các dòng được dựng từ cấu trúc CSDL thực tế:
/// trường không có cột trong CSDL thì không xuất hiện.
/// Giao diện được dựng bằng code (giống FrmDashboard) và dựng SAU base.OnLoad để giữ kiểu riêng của form.
/// </summary>
public class FrmHoSoCaNhan : BaseForm
{
    /// <summary>Phát ra sau khi lưu ảnh thành công để FrmMain cập nhật ảnh trên thanh tài khoản.</summary>
    public event Action<Image?>? AnhDaiDienDaCapNhat;

    private const int RongCotTrai = 330;
    private const int CanhAnh = 168;
    private const int CaoDong = 50;

    private sealed class OTruong
    {
        public TruongHoSo Truong = null!;
        public TextBox Tb = null!;
        public RoundedPanel Khung = null!;
    }

    private HoSoSinhVien? _hoSo;
    private byte[]? _anhChoLuu;
    private bool _dangSua;
    private readonly List<OTruong> _oNhap = new();

    private Panel _cuon = null!;
    private TableLayoutPanel _luoiTrai = null!;
    private TableLayoutPanel _bangDuLieu = null!;
    private PictureBox _picAnh = null!;
    private ModernButton _btnCamera = null!;
    private ModernButton _btnSua = null!;
    private ModernButton _btnLuu = null!;
    private ModernButton _btnHuy = null!;
    private ModernButton _btnTaiAnh = null!;
    private readonly ToolTip _goiY = new();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);               // Theme.Apply chạy trên form còn trống; giao diện dựng sau để không bị ghi đè style
        if (DesignMode) return;
        try
        {
            DungGiaoDien();
            NapDuLieu();
        }
        catch (Exception ex)
        {
            UiHelper.ShowError(ex);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _picAnh?.Image?.Dispose();
            _goiY.Dispose();
        }
        base.Dispose(disposing);
    }

    // ── Dựng giao diện ─────────────────────────────────────────────────────

    private static TableLayoutPanel TaoThe(int soCot)
    {
        var the = new TableLayoutPanel
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            ColumnCount = soCot,
            BackColor = Palette.Surface,
            Margin = new Padding(0),
        };
        the.Paint += (_, e) =>
        {
            using var pen = new Pen(Palette.Border);
            e.Graphics.DrawRectangle(pen, 0, 0, the.Width - 1, the.Height - 1);
        };
        return the;
    }

    private static ModernButton TaoNut(string chu, ButtonVariant kieu, int rong) => new()
    {
        Text = chu,
        Variant = kieu,
        Tag = "co-dinh",
        Size = new Size(rong, 38),
        Margin = new Padding(0, 0, 10, 0),
    };

    private void DungGiaoDien()
    {
        SuspendLayout();

        _cuon = new Panel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = Palette.Canvas };
        _cuon.AutoScrollMinSize = new Size(860, 0);

        var bang = new TableLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            ColumnCount = 2,
            RowCount = 1,
            BackColor = Palette.Canvas,
            Padding = new Padding(0, 0, 0, 16),
        };
        bang.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, RongCotTrai));
        bang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        bang.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        // ---- Cột trái: ảnh + thông tin cơ bản ----
        var theTrai = TaoThe(1);
        theTrai.Margin = new Padding(0, 0, 16, 0);
        theTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        theTrai.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        theTrai.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        _picAnh = new PictureBox
        {
            Size = new Size(CanhAnh, CanhAnh),
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Palette.PrimarySoft,
            BorderStyle = BorderStyle.FixedSingle,
            Anchor = AnchorStyles.None,
            Margin = new Padding(0, 24, 0, 12),
        };

        _btnCamera = new ModernButton
        {
            Text = "📷",
            Variant = ButtonVariant.Primary,
            Tag = "co-dinh",
            Font = new Font("Segoe UI Emoji", 11F),
            Size = new Size(36, 36),
            CornerRadius = 18,
            Location = new Point(CanhAnh - 42, CanhAnh - 42),
        };
        AnhHelper.CatTron(_btnCamera);
        _goiY.SetToolTip(_btnCamera, "Thay ảnh đại diện");
        _btnCamera.Click += (_, _) => ChonAnh();
        _picAnh.Controls.Add(_btnCamera);

        _luoiTrai = new TableLayoutPanel
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            ColumnCount = 2,
            BackColor = Palette.Surface,
            Margin = new Padding(16, 4, 16, 20),
        };
        _luoiTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104));
        _luoiTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

        theTrai.Controls.Add(_picAnh, 0, 0);
        theTrai.Controls.Add(_luoiTrai, 0, 1);

        // ---- Cột phải: tiêu đề + bảng dữ liệu + nút ----
        var thePhai = TaoThe(1);
        thePhai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        thePhai.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        thePhai.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        thePhai.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        var banner = new Panel { Dock = DockStyle.Fill, Height = 52, BackColor = Palette.Navy, Margin = new Padding(0) };
        banner.Paint += (_, e) =>
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            NavIcons.Draw(g, NavIcon.SinhVien, new Rectangle(18, 14, 24, 24), Color.White);
            TextRenderer.DrawText(g, "Hồ sơ cá nhân", Palette.FontH3,
                new Rectangle(54, 0, Math.Max(10, banner.Width - 60), banner.Height), Color.White,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis);
        };

        _bangDuLieu = new TableLayoutPanel
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            ColumnCount = 3,
            BackColor = Palette.Surface,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            Margin = new Padding(0),
        };
        _bangDuLieu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160));
        _bangDuLieu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220));
        _bangDuLieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

        var nut = new FlowLayoutPanel
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            WrapContents = true,
            BackColor = Palette.Surface,
            Padding = new Padding(14, 14, 14, 8),
            Margin = new Padding(0),
        };
        _btnSua = TaoNut("Chỉnh sửa", ButtonVariant.Primary, 120);
        _btnLuu = TaoNut("Lưu", ButtonVariant.Success, 100);
        _btnHuy = TaoNut("Hủy", ButtonVariant.Secondary, 100);
        _btnTaiAnh = TaoNut("Tải ảnh lên", ButtonVariant.Soft, 130);
        _btnSua.Click += (_, _) => DatCheDoSua(true);
        _btnLuu.Click += (_, _) => Luu();
        _btnHuy.Click += (_, _) => Huy();
        _btnTaiAnh.Click += (_, _) => ChonAnh();
        nut.Controls.AddRange(new Control[] { _btnSua, _btnLuu, _btnHuy, _btnTaiAnh });

        thePhai.Controls.Add(banner, 0, 0);
        thePhai.Controls.Add(_bangDuLieu, 0, 1);
        thePhai.Controls.Add(nut, 0, 2);

        bang.Controls.Add(theTrai, 0, 0);
        bang.Controls.Add(thePhai, 1, 0);
        _cuon.Controls.Add(bang);
        Controls.Add(_cuon);

        ResumeLayout(true);
    }

    // ── Nạp dữ liệu ────────────────────────────────────────────────────────

    private void NapDuLieu()
    {
        _hoSo = HoSoSinhVienBLL.LayHoSo();
        _anhChoLuu = null;

        DungThongTinTrai();
        DungBangDuLieu();
        HienAnh(_hoSo.Anh);
        DatCheDoSua(false);

        bool coGiDeSua = _hoSo.Truong.Any(t => t.CoTheSua) || _hoSo.CoCotAnh;
        _btnSua.Enabled = coGiDeSua;
        _goiY.SetToolTip(_btnSua, coGiDeSua ? "Bật chế độ chỉnh sửa" : "CSDL hiện chưa có trường nào cho phép chỉnh sửa");
    }

    private static void XoaHet(TableLayoutPanel luoi)
    {
        foreach (var c in luoi.Controls.OfType<Control>().ToList())
        {
            luoi.Controls.Remove(c);
            c.Dispose();
        }
        luoi.RowStyles.Clear();
        luoi.RowCount = 0;
    }

    private static int ThemHang(TableLayoutPanel luoi, SizeType kieu, float cao)
    {
        luoi.RowStyles.Add(new RowStyle(kieu, cao));
        luoi.RowCount = luoi.RowStyles.Count;
        return luoi.RowStyles.Count - 1;
    }

    private void DungThongTinTrai()
    {
        var h = _hoSo!;
        _luoiTrai.SuspendLayout();
        XoaHet(_luoiTrai);

        ThemDongTrai("Họ và tên", h.HoTen, true);
        if (h.NgaySinh.HasValue)
            ThemDongTrai("Ngày sinh", h.NgaySinh.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), false);
        if (!string.IsNullOrWhiteSpace(h.SoGiayTo))
            ThemDongTrai(h.NhanSoGiayTo, h.SoGiayTo!, false);
        ThemDongTrai("Mã sinh viên", h.MaSV, false);
        if (!string.IsNullOrWhiteSpace(h.TenKhoa))
            ThemDongTrai("Khoa", h.TenKhoa, false);
        if (!string.IsNullOrWhiteSpace(h.TenLop))
            ThemDongTrai("Lớp quản lý", h.TenLop, false);

        _luoiTrai.ResumeLayout(true);
    }

    private void ThemDongTrai(string nhan, string giaTri, bool inDam)
    {
        int hang = ThemHang(_luoiTrai, SizeType.AutoSize, 0);
        _luoiTrai.Controls.Add(new Label
        {
            Text = nhan,
            AutoSize = true,
            Font = Palette.FontSmall,
            ForeColor = Palette.Muted,
            Anchor = AnchorStyles.Left | AnchorStyles.Top,
            Margin = new Padding(0, 8, 8, 8),
        }, 0, hang);
        _luoiTrai.Controls.Add(new Label
        {
            Text = giaTri,
            AutoSize = true,
            MaximumSize = new Size(RongCotTrai - 32 - 104 - 8, 0),
            Font = inDam ? Palette.FontSemiBold : Palette.FontBase,
            ForeColor = inDam ? Palette.Navy : Palette.Text,
            Anchor = AnchorStyles.Left | AnchorStyles.Top,
            Margin = new Padding(0, 8, 0, 8),
        }, 1, hang);
    }

    private Label TaoNhanBang(string chu, bool dam, Color nen, Color chuMau)
    {
        return new Label
        {
            Text = chu,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(12, 0, 6, 0),
            Margin = new Padding(0),
            BackColor = nen,
            ForeColor = chuMau,
            Font = dam ? new Font(Palette.FontFamily, 8.75F, FontStyle.Bold) : Palette.FontBase,
            AutoEllipsis = true,
        };
    }

    private OTruong TaoO(TruongHoSo t)
    {
        var khung = new RoundedPanel
        {
            Dock = DockStyle.Fill,
            Radius = 8,
            BorderColor = Palette.BorderStrong,
            BackColor = Palette.SurfaceAlt,
            Margin = new Padding(8, 6, 10, 6),
        };
        var tb = new TextBox
        {
            BorderStyle = BorderStyle.None,
            Font = Palette.FontBase,
            ForeColor = Palette.Text,
            ReadOnly = true,
            MaxLength = t.DoDaiToiDa,
            Text = t.GiaTri,
            TabStop = t.CoTheSua,
        };
        tb.BackColor = Palette.SurfaceAlt;
        khung.Controls.Add(tb);

        void CanGiua() => tb.SetBounds(10, Math.Max(0, (khung.Height - tb.Height) / 2), Math.Max(10, khung.Width - 20), tb.Height);
        khung.SizeChanged += (_, _) => CanGiua();
        CanGiua();

        return new OTruong { Truong = t, Tb = tb, Khung = khung };
    }

    private void DungBangDuLieu()
    {
        var h = _hoSo!;
        _bangDuLieu.SuspendLayout();
        XoaHet(_bangDuLieu);
        _oNhap.Clear();

        // Hàng tiêu đề cột
        int hang = ThemHang(_bangDuLieu, SizeType.Absolute, 40);
        _bangDuLieu.Controls.Add(TaoNhanBang("NHÓM", true, Palette.PrimarySoft, Palette.Navy), 0, hang);
        _bangDuLieu.Controls.Add(TaoNhanBang("TÊN THÔNG TIN", true, Palette.PrimarySoft, Palette.Navy), 1, hang);
        _bangDuLieu.Controls.Add(TaoNhanBang("DỮ LIỆU CẦN NHẬP", true, Palette.PrimarySoft, Palette.Navy), 2, hang);

        if (h.Truong.Count == 0)
        {
            hang = ThemHang(_bangDuLieu, SizeType.Absolute, CaoDong);
            var trong = TaoNhanBang("Chưa có thông tin hồ sơ nào để hiển thị.", false, Palette.Surface, Palette.Muted);
            _bangDuLieu.Controls.Add(trong, 0, hang);
            _bangDuLieu.SetColumnSpan(trong, 3);
        }

        string? nhomTruoc = null;
        foreach (var t in h.Truong)
        {
            hang = ThemHang(_bangDuLieu, SizeType.Absolute, CaoDong);
            bool dauNhom = t.Nhom != nhomTruoc;
            nhomTruoc = t.Nhom;

            _bangDuLieu.Controls.Add(
                TaoNhanBang(dauNhom ? t.Nhom : "", true, Palette.Surface, Palette.Navy), 0, hang);
            _bangDuLieu.Controls.Add(
                TaoNhanBang(t.Ten, false, Palette.Surface, Palette.TextSoft), 1, hang);

            var o = TaoO(t);
            _oNhap.Add(o);
            _bangDuLieu.Controls.Add(o.Khung, 2, hang);
        }

        _bangDuLieu.ResumeLayout(true);
    }

    private void HienAnh(byte[]? data)
    {
        Image moi;
        try
        {
            moi = data != null ? AnhHelper.TuBytes(data) : AnhHelper.TaoAnhMacDinh(CanhAnh);
        }
        catch
        {
            moi = AnhHelper.TaoAnhMacDinh(CanhAnh);   // dữ liệu ảnh hỏng: dùng ảnh mặc định chung
        }
        var cu = _picAnh.Image;
        _picAnh.Image = moi;
        cu?.Dispose();
    }

    // ── Chế độ xem / sửa ───────────────────────────────────────────────────

    private void DatCheDoSua(bool sua)
    {
        _dangSua = sua;
        foreach (var o in _oNhap)
        {
            bool bat = sua && o.Truong.CoTheSua;
            o.Tb.ReadOnly = !bat;
            var nen = bat ? Palette.Surface : Palette.SurfaceAlt;
            o.Tb.BackColor = nen;
            o.Khung.BackColor = nen;
            o.Khung.BorderColor = bat ? Palette.Primary : Palette.BorderStrong;
        }

        _btnSua.Visible = !sua;
        _btnLuu.Visible = sua;
        _btnHuy.Visible = sua;

        if (sua)
            _oNhap.FirstOrDefault(x => x.Truong.CoTheSua)?.Tb.Focus();
    }

    private void Huy()
    {
        if (_hoSo == null) return;
        _anhChoLuu = null;
        foreach (var o in _oNhap)
            o.Tb.Text = o.Truong.GiaTri;
        HienAnh(_hoSo.Anh);
        DatCheDoSua(false);
    }

    private void ChonAnh()
    {
        try
        {
            if (_hoSo == null) return;

            if (!_hoSo.CoCotAnh)
            {
                UiHelper.ShowInfo(
                    "Cơ sở dữ liệu chưa có cột lưu ảnh đại diện (Sinhvien.ANHDAIDIEN) nên chưa thể lưu ảnh.\n\n" +
                    "Hãy chạy script Database\\ThemAnhDaiDien.sql rồi mở lại màn hình này.");
                return;
            }

            using var hop = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Ảnh JPG, JPEG, PNG (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
                CheckFileExists = true,
                Multiselect = false,
            };
            if (hop.ShowDialog(this) != DialogResult.OK) return;

            var du = AnhHelper.ChuanHoaTuTep(hop.FileName);   // kiểm tra định dạng, dung lượng, thu nhỏ
            var anh = AnhHelper.TuBytes(du);

            var cu = _picAnh.Image;
            _picAnh.Image = anh;                              // xem trước
            cu?.Dispose();
            _anhChoLuu = du;

            if (!_dangSua) DatCheDoSua(true);                 // ảnh chỉ được lưu khi bấm "Lưu"
        }
        catch (Exception ex)
        {
            UiHelper.ShowError(ex);
        }
    }

    private void Luu()
    {
        try
        {
            var doi = new Dictionary<string, string?>(StringComparer.OrdinalIgnoreCase);
            foreach (var o in _oNhap.Where(x => x.Truong.CoTheSua && x.Truong.TenCot != null))
            {
                var moi = o.Tb.Text.Trim();
                if (moi != o.Truong.GiaTri.Trim())
                    doi[o.Truong.TenCot!] = moi;
            }

            if (doi.Count == 0 && _anhChoLuu == null)
            {
                UiHelper.ShowInfo("Bạn chưa thay đổi thông tin nào.");
                DatCheDoSua(false);
                return;
            }

            bool doiAnh = _anhChoLuu != null;
            HoSoSinhVienBLL.Luu(doi, _anhChoLuu);             // ném lỗi nếu không lưu được -> không báo thành công giả

            UiHelper.ShowSuccess("Đã cập nhật hồ sơ thành công.");
            NapDuLieu();

            if (doiAnh)
                AnhDaiDienDaCapNhat?.Invoke(_picAnh.Image == null ? null : new Bitmap(_picAnh.Image));
        }
        catch (Exception ex)
        {
            UiHelper.ShowError(ex);
        }
    }
}
