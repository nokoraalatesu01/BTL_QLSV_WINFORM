using System.Drawing.Drawing2D;
using QLDSV_HTC.BLL;
using QLDSV_HTC.UI;

namespace QLDSV_HTC.Forms;

/// <summary>
/// Dashboard tổng quan: thẻ thống kê thực tế từ database + thông tin người dùng.
/// Sử dụng như Panel nội dung trong FrmMain sidebar.
/// </summary>
public class FrmDashboard : Panel
{
    private readonly FlowLayoutPanel _cardFlow;
    private readonly Panel _bannerPanel;
    private readonly Label _lblWelcome;
    private readonly Label _lblUser;
    private readonly Label _lblDesc;

    public FrmDashboard()
    {
        BackColor = Palette.Canvas;
        Padding = new Padding(28, 24, 28, 24);
        AutoScroll = true;

        // ---- Banner chào mừng ----
        _bannerPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 90,
            BackColor = Palette.Navy,
            Padding = new Padding(24, 0, 24, 0),
            Margin = new Padding(0, 0, 0, 20)
        };
        _bannerPanel.Paint += BannerPanel_Paint;

        _lblWelcome = new Label
        {
            Text = "Tổng quan hệ thống",
            Font = new Font(Palette.FontFamily, 18F, FontStyle.Bold),
            ForeColor = Color.White,
            AutoSize = true,
            Location = new Point(24, 18)
        };

        _lblUser = new Label
        {
            Text = "",
            Font = Palette.FontBase,
            ForeColor = Color.FromArgb(180, 210, 255),
            AutoSize = true,
            Location = new Point(26, 48)
        };

        _lblDesc = new Label
        {
            Text = "Quản lý sinh viên — Trường Đại học Giao thông Vận tải",
            Font = Palette.FontSmall,
            ForeColor = Color.FromArgb(160, 200, 255),
            AutoSize = true,
            Location = new Point(26, 64)
        };

        _bannerPanel.Controls.Add(_lblWelcome);
        _bannerPanel.Controls.Add(_lblUser);
        _bannerPanel.Controls.Add(_lblDesc);

        // ---- FlowLayout cho cards ----
        _cardFlow = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            Height = 130,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            AutoScroll = false,
            BackColor = Palette.Canvas,
            Padding = new Padding(0, 12, 0, 0),
            Margin = new Padding(0)
        };

        Controls.Add(_cardFlow);
        Controls.Add(_bannerPanel);
    }

    /// <summary>Nạp dữ liệu thống kê từ database và cập nhật giao diện.</summary>
    public void TaiDuLieu()
    {
        try
        {
            // Thông tin người dùng
            try
            {
                var nd = Quyen.HienTai;
                _lblUser.Text = $"Xin chào, {nd.TenHienThi}  |  Vai trò: {nd.VaiTroText}";
            }
            catch { _lblUser.Text = ""; }

            // Thống kê thực từ DB
            _cardFlow.Controls.Clear();

            int soSinhVien = 0, soKhoa = 0, soLop = 0, soGiangVien = 0, soMonHoc = 0;

            try
            {
                soSinhVien = SinhVienBLL.Tim(null, null).Count;
            }
            catch { }

            try
            {
                soKhoa = KhoaBLL.LayDanhSach().Count;
            }
            catch { }

            try
            {
                soLop = LopBLL.Tim(null).Count;
            }
            catch { }

            try
            {
                soGiangVien = GiangVienBLL.Tim(null).Count;
            }
            catch { }

            try
            {
                soMonHoc = MonHocBLL.Tim(null).Count;
            }
            catch { }

            // Tạo card
            _cardFlow.Controls.Add(TaoCard("Sinh viên", soSinhVien.ToString(), Palette.StatBlue, NavIcon.SinhVien));
            _cardFlow.Controls.Add(TaoCard("Khoa", soKhoa.ToString(), Palette.StatGreen, NavIcon.Khoa));
            _cardFlow.Controls.Add(TaoCard("Lớp học", soLop.ToString(), Palette.StatOrange, NavIcon.Lop));
            _cardFlow.Controls.Add(TaoCard("Giảng viên", soGiangVien.ToString(), Palette.StatPurple, NavIcon.GiangVien));
            _cardFlow.Controls.Add(TaoCard("Môn học", soMonHoc.ToString(), Palette.Navy, NavIcon.MonHoc));
        }
        catch (Exception ex)
        {
            // Không crash dashboard nếu không có quyền đọc một số module
            _ = ex;
        }
    }

    private static StatCard TaoCard(string label, string value, Color accent, NavIcon icon)
    {
        return new StatCard
        {
            Label = label,
            Value = value,
            AccentColor = accent,
            CardIcon = icon,
            Size = new Size(210, 108),
            Margin = new Padding(0, 0, 16, 0),
            BackColor = Palette.Surface
        };
    }

    private void BannerPanel_Paint(object? sender, PaintEventArgs e)
    {
        if (DesignMode) return;
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var w = _bannerPanel.Width;
        var h = _bannerPanel.Height;

        // Gradient navy
        using var grad = new LinearGradientBrush(
            new Rectangle(0, 0, Math.Max(w, 1), Math.Max(h, 1)),
            Palette.Navy, Palette.NavyDark, LinearGradientMode.Horizontal);
        g.FillRectangle(grad, 0, 0, w, h);

        // Halo trang trí
        using var halo1 = new SolidBrush(Color.FromArgb(15, 255, 255, 255));
        g.FillEllipse(halo1, w - 160, -40, 200, 160);
        using var halo2 = new SolidBrush(Color.FromArgb(10, 100, 160, 255));
        g.FillEllipse(halo2, w - 80, 20, 120, 120);
    }
}
