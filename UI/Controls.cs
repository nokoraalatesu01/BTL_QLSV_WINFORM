using System.Drawing.Drawing2D;

namespace QLDSV_HTC.UI;

/// <summary>Panel bo góc, dùng làm "card" nền cho nội dung.</summary>
public class RoundedPanel : Panel
{
    private int _radius = 10;
    private Color _borderColor = Palette.Border;
    private int _borderSize = 1;

    public int Radius
    {
        get => _radius;
        set { _radius = value; UpdateRegion(); Invalidate(); }
    }

    public Color BorderColor
    {
        get => _borderColor;
        set { _borderColor = value; Invalidate(); }
    }

    public int BorderSize
    {
        get => _borderSize;
        set { _borderSize = value; UpdateRegion(); Invalidate(); }
    }

    public RoundedPanel()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                  | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
        Padding = new Padding(0);
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        if (DesignMode) return;
        UpdateRegion();
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        if (DesignMode) return;
        UpdateRegion();
    }

    private void UpdateRegion()
    {
        if (IsDisposed || !IsHandleCreated || Width <= 0 || Height <= 0) return;
        using var path = Shape.RoundedPath(new Rectangle(0, 0, Width, Height), Radius);
        Region = new Region(path);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (DesignMode || BorderSize <= 0) return;

        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        using var path = Shape.RoundedPath(new Rectangle(0, 0, Width - 1, Height - 1), Radius);
        using var pen = new Pen(BorderColor, BorderSize);
        g.DrawPath(pen, path);
    }
}

/// <summary>Panel nền gradient (dùng cho sidebar UTC Navy).</summary>
public class GradientPanel : Panel
{
    private Color _start = Palette.SidebarTop;
    private Color _end = Palette.SidebarBottom;
    private bool _decorations = true;

    public Color StartColor
    {
        get => _start;
        set { _start = value; Invalidate(); }
    }

    public Color EndColor
    {
        get => _end;
        set { _end = value; Invalidate(); }
    }

    public bool Decorations
    {
        get => _decorations;
        set { _decorations = value; Invalidate(); }
    }

    public GradientPanel()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                  | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        BackColor = _end;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (DesignMode)
        {
            base.OnPaint(e);
            return;
        }
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (var brush = new LinearGradientBrush(
                   new Rectangle(0, 0, Math.Max(Width, 1), Math.Max(Height, 1)),
                   _start, _end, LinearGradientMode.Vertical))
        {
            g.FillRectangle(brush, 0, 0, Width, Height);
        }

        if (!_decorations) return;

        // Hiệu ứng nhẹ: vầng sáng phía trên
        using var halo = new SolidBrush(Color.FromArgb(18, 255, 255, 255));
        g.FillEllipse(halo, -Width / 4, -Height / 4, (int)(Width * 0.8), (int)(Width * 0.8));
    }
}

/// <summary>Các kiểu hiển thị của <see cref="ModernButton"/>.</summary>
public enum ButtonVariant
{
    Primary,
    Secondary,
    Soft,
    Ghost,
    Danger,
    Success,
    Dark
}

/// <summary>Nút phẳng bo góc tự vẽ, có hover / pressed / disabled. Màu UTC Blue.</summary>
public class ModernButton : Button
{
    private bool _hover;
    private bool _pressed;

    public ButtonVariant Variant { get; set; } = ButtonVariant.Primary;

    public int CornerRadius { get; set; } = 6;

    public ModernButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                  | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        FlatStyle = FlatStyle.Flat;
        Font = Palette.FontSemiBold;
        Cursor = Cursors.Hand;
        UseVisualStyleBackColor = false;
        SetStyle(ControlStyles.Selectable, false);
    }

    protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
    protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
    protected override void OnMouseDown(MouseEventArgs e) { _pressed = true; Invalidate(); base.OnMouseDown(e); }
    protected override void OnMouseUp(MouseEventArgs e) { _pressed = false; Invalidate(); base.OnMouseUp(e); }
    protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (DesignMode)
        {
            base.OnPaint(e);
            return;
        }
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var parentColor = Parent?.BackColor ?? Palette.Canvas;
        if (parentColor.A != 255) parentColor = Palette.Canvas;
        g.Clear(parentColor);

        var rect = new Rectangle(0, 0, Width, Height);
        var (bg, fg, border) = ResolveColors();

        if (bg.A > 0)
        {
            using var brush = new SolidBrush(bg);
            using var path = Shape.RoundedPath(rect, CornerRadius);
            g.FillPath(brush, path);
        }

        if (border.A > 0)
        {
            using var pen = new Pen(border);
            using var path = Shape.RoundedPath(rect, CornerRadius);
            g.DrawPath(pen, path);
        }

        var textRect = new Rectangle(0, 0, Width, Height);
        TextRenderer.DrawText(g, Text, Font, textRect, fg,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
    }

    private (Color bg, Color fg, Color border) ResolveColors()
    {
        if (!Enabled)
            return (_hover ? Palette.SurfaceAlt : Palette.Surface, Palette.MutedLight, Palette.Border);

        return Variant switch
        {
            // UTC Primary Blue
            ButtonVariant.Primary => (
                _pressed ? Palette.PrimaryDarker : _hover ? Palette.PrimaryDark : Palette.Primary,
                Color.White,
                Color.Transparent),
            // Secondary: outline trắng
            ButtonVariant.Secondary => (
                _hover ? Palette.SurfaceAlt : Palette.Surface,
                Palette.TextSoft,
                Palette.Border),
            // Soft: nền xanh nhạt
            ButtonVariant.Soft => (
                _hover ? Palette.PrimaryMid : Palette.PrimarySoft,
                Palette.Primary,
                Color.Transparent),
            ButtonVariant.Ghost => (
                _hover ? ColorTranslator.FromHtml("#EDF0F7") : Color.Transparent,
                Palette.Muted,
                Color.Transparent),
            // Danger: đỏ
            ButtonVariant.Danger => (
                _pressed ? ColorTranslator.FromHtml("#B91C1C") : _hover ? ColorTranslator.FromHtml("#DC2626") : Palette.Danger,
                Color.White,
                Color.Transparent),
            ButtonVariant.Success => (
                _pressed ? ColorTranslator.FromHtml("#059669") : _hover ? ColorTranslator.FromHtml("#059669") : Palette.Success,
                Color.White,
                Color.Transparent),
            ButtonVariant.Dark => (
                _hover ? ColorTranslator.FromHtml("#1F2937") : ColorTranslator.FromHtml("#374151"),
                Color.White,
                Color.Transparent),
            _ => (Palette.Primary, Color.White, Color.Transparent),
        };
    }
}

/// <summary>Các biểu tượng vector vẽ bằng GDI+ (không phụ thuộc font).</summary>
public enum NavIcon
{
    Dashboard,
    Khoa,
    Lop,
    SinhVien,
    MonHoc,
    GiangVien,
    LopTinChi,
    NhapDiem,
    BangDiem,
    DoiMatKhau,
    Logout
}

/// <summary>Nút điều hướng trên sidebar UTC: icon vector + nhãn + trạng thái active (navy/blue).</summary>
public class SidebarButton : Button
{
    private bool _hover;
    private bool _active;

    public NavIcon Icon { get; set; } = NavIcon.Dashboard;

    public bool Active
    {
        get => _active;
        set { _active = value; Invalidate(); }
    }

    public bool ShowIcon { get; set; } = true;

    public SidebarButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                  | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        FlatStyle = FlatStyle.Flat;
        Font = Palette.FontBase;
        ForeColor = Palette.SidebarText;
        Cursor = Cursors.Hand;
        TextAlign = ContentAlignment.MiddleLeft;
        SetStyle(ControlStyles.Selectable, false);
    }

    protected override void OnMouseEnter(EventArgs e) { if (!Enabled) return; _hover = true; Invalidate(); base.OnMouseEnter(e); }
    protected override void OnMouseLeave(EventArgs e) { if (!Enabled) return; _hover = false; Invalidate(); base.OnMouseLeave(e); }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (DesignMode)
        {
            base.OnPaint(e);
            return;
        }
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Palette.SidebarBottom);

        // Vẽ nền nút
        Color bg;
        Color fg;

        if (!Enabled)
        {
            bg = Color.Transparent;
            fg = Palette.MutedLight;
        }
        else if (_active)
        {
            // Active: dải xanh Primary Blue bên phải, nền trái nhạt
            bg = Palette.SidebarActive;
            fg = Color.White;
        }
        else if (_hover)
        {
            bg = Palette.SidebarHover;
            fg = Color.White;
        }
        else
        {
            bg = Color.Transparent;
            fg = Palette.SidebarText;
        }

        var rect = new Rectangle(4, 2, Width - 8, Height - 4);
        using var path = Shape.RoundedPath(rect, 6);

        if (bg.A > 0)
        {
            using var brush = new SolidBrush(bg);
            g.FillPath(brush, path);
        }

        // Active indicator: dải dọc bên trái
        if (_active)
        {
            using var accentBrush = new SolidBrush(Color.White);
            g.FillRectangle(accentBrush, 4, 8, 3, Height - 16);
        }

        // Icon
        var iconSize = 16;
        var left = 20;
        if (ShowIcon)
        {
            var iconBox = new Rectangle(left, (Height - iconSize) / 2, iconSize, iconSize);
            NavIcons.Draw(g, Icon, iconBox, fg);
            left += iconSize + 10;
        }

        // Text
        var textRect = new Rectangle(left, 0, Width - left - 8, Height);
        TextRenderer.DrawText(g, Text, Font, textRect, fg,
            TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
    }
}

/// <summary>Thẻ thống kê Dashboard: hiển thị icon, nhãn, con số và màu nhấn.</summary>
public class StatCard : Panel
{
    private string _label = "";
    private string _value = "0";
    private Color _accentColor = Palette.StatBlue;
    private NavIcon _icon = NavIcon.Dashboard;

    public string Label
    {
        get => _label;
        set { _label = value; Invalidate(); }
    }

    public string Value
    {
        get => _value;
        set { _value = value; Invalidate(); }
    }

    public Color AccentColor
    {
        get => _accentColor;
        set { _accentColor = value; Invalidate(); }
    }

    public NavIcon CardIcon
    {
        get => _icon;
        set { _icon = value; Invalidate(); }
    }

    public StatCard()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                  | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        BackColor = Palette.Surface;
        Size = new Size(240, 110);
        Cursor = Cursors.Default;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (DesignMode) { base.OnPaint(e); return; }
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

        // Nền trắng bo góc
        using var bgBrush = new SolidBrush(Palette.Surface);
        using var bgPath = Shape.RoundedPath(new Rectangle(0, 0, Width - 1, Height - 1), 8);
        g.FillPath(bgBrush, bgPath);

        // Viền mảnh
        using var borderPen = new Pen(Palette.Border);
        g.DrawPath(borderPen, bgPath);

        // Dải màu bên trái
        using var accentBrush = new SolidBrush(_accentColor);
        using var accentPath = Shape.RoundedPath(new Rectangle(0, 0, 4, Height - 1), 2);
        g.FillPath(accentBrush, accentPath);

        // Icon background circle
        var iconBg = Color.FromArgb(28, _accentColor);
        var iconRect = new Rectangle(Width - 58, 18, 40, 40);
        using var iconBgBrush = new SolidBrush(iconBg);
        g.FillEllipse(iconBgBrush, iconRect);
        NavIcons.Draw(g, _icon, new Rectangle(iconRect.X + 10, iconRect.Y + 10, 20, 20), _accentColor);

        // Label
        using var labelFont = new Font(Palette.FontFamily, 8.5F, FontStyle.Regular);
        using var labelBrush = new SolidBrush(Palette.Muted);
        g.DrawString(_label.ToUpperInvariant(), labelFont, labelBrush, new PointF(16, 18));

        // Value
        using var valFont = new Font(Palette.FontFamily, 26F, FontStyle.Bold);
        using var valBrush = new SolidBrush(Palette.Text);
        g.DrawString(_value, valFont, valBrush, new PointF(14, 40));

        // Đường nhấn dưới cùng
        using var accentLineBrush = new SolidBrush(Color.FromArgb(40, _accentColor));
        g.FillRectangle(accentLineBrush, 0, Height - 5, Width, 5);
    }
}

/// <summary>Tiện ích vẽ hình dùng chung.</summary>
public static class Shape
{
    public static GraphicsPath RoundedPath(Rectangle r, int radius)
    {
        var path = new GraphicsPath();
        if (r.Width <= 0 || r.Height <= 0) return path;

        if (radius <= 0)
        {
            path.AddRectangle(r);
            return path;
        }

        int d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));
        path.AddArc(r.X, r.Y, d, d, 180, 90);
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}

/// <summary>Vẽ bộ biểu tượng giao diện bằng đường nét.</summary>
public static class NavIcons
{
    public static void Draw(Graphics g, NavIcon icon, Rectangle box, Color color)
    {
        var pen = new Pen(color, 1.7f) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round };
        var x = box.X;
        var y = box.Y;
        var w = box.Width;
        var h = box.Height;

        switch (icon)
        {
            case NavIcon.Dashboard:
                Fill(g, pen, new Rectangle(x, y, w / 2 - 2, h / 2 - 2));
                Fill(g, pen, new Rectangle(x + w / 2 + 2, y, w / 2 - 2, h / 2 - 2));
                Fill(g, pen, new Rectangle(x, y + h / 2 + 2, w / 2 - 2, h / 2 - 2));
                Fill(g, pen, new Rectangle(x + w / 2 + 2, y + h / 2 + 2, w / 2 - 2, h / 2 - 2));
                break;

            case NavIcon.Khoa:
                g.DrawLines(pen, new[]
                {
                    new PointF(x + 1, y + 7),
                    new PointF(x + w / 2f, y + 1),
                    new PointF(x + w - 1, y + 7),
                });
                g.DrawRectangle(pen, x + 3, y + 7, w - 6, h - 8);
                g.DrawLine(pen, x + w / 2f, y + 10, x + w / 2f, y + h - 1);
                break;

            case NavIcon.Lop:
                g.DrawRectangle(pen, x + 1, y + 2, w - 2, h - 6);
                g.DrawLine(pen, x + 4, y + 6, x + w - 4, y + 6);
                g.DrawLine(pen, x + w / 2f - 2, y + h - 4, x + w / 2f + 2, y + h - 4);
                break;

            case NavIcon.SinhVien:
                g.DrawEllipse(pen, x + w / 2f - 4.5f, y + 1, 9, 9);
                g.DrawArc(pen, x + 2, y + 10, w - 4, 12, 200, 140);
                break;

            case NavIcon.MonHoc:
                g.DrawRectangle(pen, x + 1, y + 2, w - 2, h - 4);
                g.DrawLine(pen, x + w / 2f, y + 2, x + w / 2f, y + h - 2);
                break;

            case NavIcon.GiangVien:
                g.DrawLines(pen, new[]
                {
                    new PointF(x + w / 2f, y + 2),
                    new PointF(x + w - 1, y + 6),
                    new PointF(x + w / 2f, y + 10),
                    new PointF(x + 1, y + 6),
                    new PointF(x + w / 2f, y + 2),
                });
                g.DrawLine(pen, x + w / 2f, y + 10, x + w / 2f, y + h - 2);
                break;

            case NavIcon.LopTinChi:
                g.DrawRectangle(pen, x + 1, y + 3, w - 2, h - 4);
                g.DrawLine(pen, x + 1, y + 7, x + w - 1, y + 7);
                g.DrawLine(pen, x + 5, y + 1, x + 5, y + 4);
                g.DrawLine(pen, x + w - 5, y + 1, x + w - 5, y + 4);
                break;

            case NavIcon.NhapDiem:
                g.DrawRectangle(pen, x + 1, y + 1, w - 2, h - 2);
                g.DrawLines(pen, new[]
                {
                    new PointF(x + 4, y + h / 2f),
                    new PointF(x + 6.5f, y + h / 2f + 2.5f),
                    new PointF(x + w - 4, y + 4),
                });
                break;

            case NavIcon.BangDiem:
                g.DrawLine(pen, x + 1, y + h - 1, x + w - 1, y + h - 1);
                g.DrawLine(pen, x + 3, y + h - 5, x + 3, y + h - 1);
                g.DrawLine(pen, x + w / 2f, y + 3, x + w / 2f, y + h - 1);
                g.DrawLine(pen, x + w - 3, y + h - 7, x + w - 3, y + h - 1);
                break;

            case NavIcon.DoiMatKhau:
                g.DrawRectangle(pen, x + 3, y + 7, w - 6, h - 8);
                g.DrawArc(pen, x + 5, y + 1, w - 10, 12, 180, 180);
                break;

            case NavIcon.Logout:
                g.DrawLine(pen, x + 1, y + h / 2f, x + w - 6, y + h / 2f);
                g.DrawLines(pen, new[]
                {
                    new PointF(x + w - 10, y + h / 2f - 4),
                    new PointF(x + w - 6, y + h / 2f),
                    new PointF(x + w - 10, y + h / 2f + 4),
                });
                g.DrawLine(pen, x + 4, y + 2, x + 4, y + h - 2);
                break;
        }

        pen.Dispose();
    }

    private static void Fill(Graphics g, Pen pen, Rectangle r)
    {
        using var brush = new SolidBrush(pen.Color);
        using var path = Shape.RoundedPath(r, 2);
        g.FillPath(brush, path);
    }
}
