using System.Drawing.Drawing2D;

namespace QLDSV_HTC.UI;

public enum ToastKieu
{
    Info,
    Success,
    Warning,
    Error
}

/// <summary>Thông báo nhỏ góc màn hình, tự mờ dần và tự đóng.</summary>
public static class Toast
{
    public static void Show(string message, ToastKieu kind = ToastKieu.Success, Form? owner = null)
    {
        try
        {
            var f = new FrmToast(message, kind);
            var area = owner is { IsDisposed: false } ? owner.Bounds : (Screen.PrimaryScreen?.WorkingArea ?? Screen.GetWorkingArea(Point.Empty));
            f.Location = new Point(Math.Max(area.Left, area.Right - f.Width - 24), area.Top + 24);
            f.Show();
        }
        catch
        {
            // Thông báo làm đẹp, lỗi ở đây không làm sập chương trình.
        }
    }
}

internal sealed class FrmToast : Form
{
    private readonly System.Windows.Forms.Timer _timer = new() { Interval = 60 };
    private readonly System.Windows.Forms.Timer _closeTimer = new() { Interval = 2600 };
    private double _opacity;

    public FrmToast(string message, ToastKieu kind)
    {
        FormBorderStyle = FormBorderStyle.None;
        ShowInTaskbar = false;
        TopMost = true;
        Size = new Size(340, 74);
        BackColor = Palette.Canvas;
        DoubleBuffered = true;

        var (color, glyph) = kind switch
        {
            ToastKieu.Success => (Palette.Success, "✓"),
            ToastKieu.Warning => (Palette.Warning, "!"),
            ToastKieu.Error => (Palette.Danger, "×"),
            _ => (Palette.Primary, "i"),
        };

        var lbl = new Label
        {
            Text = message,
            ForeColor = Palette.TextSoft,
            Font = Palette.FontBase,
            AutoSize = false,
            Location = new Point(56, 24),
            Size = new Size(262, 30),
            TextAlign = ContentAlignment.MiddleLeft,
        };

        var lblIcon = new Label
        {
            Text = glyph,
            ForeColor = color,
            Font = new Font(Palette.FontFamily, 16f, FontStyle.Bold),
            AutoSize = false,
            Location = new Point(22, 22),
            Size = new Size(26, 30),
            TextAlign = ContentAlignment.MiddleCenter,
        };

        Controls.Add(lbl);
        Controls.Add(lblIcon);
        Tag = color;

        using var path = Shape.RoundedPath(new Rectangle(0, 0, Width - 1, Height - 1), 14);
        Region = new Region(path);

        _timer.Tick += (_, _) =>
        {
            _opacity += 0.12;
            if (_opacity >= 1) { _opacity = 1; _timer.Stop(); }
            Opacity = _opacity;
        };

        _closeTimer.Tick += (_, _) =>
        {
            _closeTimer.Stop();
            Close();
        };

        _timer.Start();
        _closeTimer.Start();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (DesignMode)
        {
            base.OnPaint(e);
            return;
        }
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using var path = Shape.RoundedPath(new Rectangle(0, 0, Width - 1, Height - 1), 14);
        using var brush = new SolidBrush(Palette.Surface);
        g.FillPath(brush, path);

        var accent = Tag is Color c ? c : Palette.Primary;
        using var pen = new Pen(Palette.Border);
        g.DrawPath(pen, path);

        using var bar = new SolidBrush(accent);
        g.FillRectangle(bar, 0, 12, 4, Height - 24);
    }
}
