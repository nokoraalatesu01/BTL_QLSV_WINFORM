using System.Drawing.Drawing2D;

namespace QLDSV_HTC.UI;

/// <summary>Ô vuông bo góc chứa biểu tượng vector, dùng cho thẻ số liệu và nút nhanh.</summary>
public class IconBox : Control
{
    private NavIcon _icon = NavIcon.Dashboard;
    private Color _iconColor = Palette.Primary;
    private int _radius = 12;

    public NavIcon Icon
    {
        get => _icon;
        set { _icon = value; Invalidate(); }
    }

    public Color IconColor
    {
        get => _iconColor;
        set { _iconColor = value; Invalidate(); }
    }

    public int Radius
    {
        get => _radius;
        set { _radius = value; Invalidate(); }
    }

    public IconBox()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                  | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
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

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using (var bg = new SolidBrush(Color.FromArgb(36, _iconColor)))
        using (var path = Shape.RoundedPath(rect, Radius))
            g.FillPath(bg, path);

        var inset = new Rectangle(
            (int)(Width * 0.22), (int)(Height * 0.22),
            (int)(Width * 0.56), (int)(Height * 0.56));
        NavIcons.Draw(g, _icon, inset, _iconColor);
    }
}
