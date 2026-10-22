using System.Drawing.Drawing2D;

namespace QLDSV_HTC.UI;

public enum ThongBaoKieu
{
    Info,
    Success,
    Warning,
    Error,
    Question
}

/// <summary>Hộp thoại thông báo theo phong cách riêng (thay cho MessageBox mặc định của Windows).</summary>
public class FrmThongBao : Form
{
    private readonly Label _lblTieuDe = new();
    private readonly Label _lblNoiDung = new();
    private readonly ModernButton _btnChinh = new();
    private readonly ModernButton _btnPhu = new();
    private readonly CircleIcon _icon = new();
    private readonly ThongBaoKieu _kind;

    private FrmThongBao(string title, string message, ThongBaoKieu kind, bool canCancel)
    {
        _kind = kind;

        FormBorderStyle = FormBorderStyle.None;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(430, 232);
        BackColor = Palette.Canvas;
        Font = Palette.FontBase;
        KeyPreview = true;

        _icon.Kind = kind;
        _icon.Location = new Point(26, 24);
        _icon.Size = new Size(46, 46);
        _icon.TabStop = false;

        _lblTieuDe.Text = title;
        _lblTieuDe.Font = Palette.FontH2;
        _lblTieuDe.ForeColor = Palette.Text;
        _lblTieuDe.AutoSize = false;
        _lblTieuDe.Location = new Point(88, 24);
        _lblTieuDe.Size = new Size(316, 30);

        _lblNoiDung.Text = message;
        _lblNoiDung.ForeColor = Palette.TextSoft;
        _lblNoiDung.AutoSize = false;
        _lblNoiDung.Location = new Point(26, 86);
        _lblNoiDung.Size = new Size(378, 82);

        _btnChinh.Text = canCancel ? "Đóng" : "Đồng ý";
        _btnChinh.Variant = kind == ThongBaoKieu.Error ? ButtonVariant.Danger : ButtonVariant.Primary;
        _btnChinh.Size = new Size(122, 38);
        _btnChinh.Location = new Point(canCancel ? 180 : 282, 176);
        _btnChinh.Click += (_, _) => { DialogResult = DialogResult.OK; Close(); };

        _btnPhu.Text = "Hủy";
        _btnPhu.Variant = ButtonVariant.Secondary;
        _btnPhu.Size = new Size(112, 38);
        _btnPhu.Location = new Point(56, 176);
        _btnPhu.Visible = canCancel;
        _btnPhu.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };

        Controls.Add(_icon);
        Controls.Add(_lblTieuDe);
        Controls.Add(_lblNoiDung);
        Controls.Add(_btnPhu);
        Controls.Add(_btnChinh);
        AcceptButton = _btnChinh;
        CancelButton = _btnPhu;

        KeyDown += (_, e) =>
        {
            if (e.KeyCode == Keys.Escape && canCancel) { DialogResult = DialogResult.Cancel; Close(); }
        };
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

        using var path = Shape.RoundedPath(new Rectangle(0, 0, Width - 1, Height - 1), 16);
        using var brush = new SolidBrush(Palette.Surface);
        g.FillPath(brush, path);
        using var pen = new Pen(Palette.Border);
        g.DrawPath(pen, path);
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        _btnChinh.Focus();
    }

    public static void Show(string title, string message, ThongBaoKieu kind, Form? owner)
    {
        using var f = new FrmThongBao(title, message, kind, false);
        if (owner != null && !owner.IsDisposed) f.ShowDialog(owner);
        else f.ShowDialog();
    }

    public static bool Confirm(string title, string message, Form? owner)
    {
        using var f = new FrmThongBao(title, message, ThongBaoKieu.Question, true);
        var r = owner != null && !owner.IsDisposed ? f.ShowDialog(owner) : f.ShowDialog();
        return r == DialogResult.OK;
    }

    private sealed class CircleIcon : Control
    {
        public ThongBaoKieu Kind { get; set; } = ThongBaoKieu.Info;

        public CircleIcon()
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
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            var (color, glyph) = Kind switch
            {
                ThongBaoKieu.Success => (Palette.Success, "✓"),
                ThongBaoKieu.Warning => (Palette.Warning, "!"),
                ThongBaoKieu.Error => (Palette.Danger, "×"),
                ThongBaoKieu.Question => (Palette.Info, "?"),
                _ => (Palette.Primary, "i"),
            };

            var r = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var brush = new SolidBrush(Color.FromArgb(38, color)))
                g.FillEllipse(brush, r);
            using (var pen = new Pen(color, 2f))
                g.DrawEllipse(pen, r);

            using var font = new Font(Palette.FontFamily, 17f, FontStyle.Bold);
            var size = g.MeasureString(glyph, font);
            using var textBrush = new SolidBrush(color);
            g.DrawString(glyph, font, textBrush, (Width - size.Width) / 2f, (Height - size.Height) / 2f - 1);
        }
    }
}
