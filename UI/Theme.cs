using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QLDSV_HTC.UI;

/// <summary>
/// Trung tâm giao diện: áp bộ nhận diện chung (màu, font, kiểu bảng, kiểu nút, ô nhập)
/// cho mọi form nên không phải chỉnh tay từng control trong Designer.
/// </summary>
public static class Theme
{
    /// <summary>Áp theme cho một form (gọi tự động bởi <see cref="BaseForm"/>).</summary>
    public static void Apply(Form form)
    {
        if (form == null) return;
        form.BackColor = Palette.Canvas;
        form.Font = Palette.FontBase;
        form.ForeColor = Palette.Text;

        foreach (Control c in form.Controls)
            Style(c);

        foreach (Control c in form.Controls)
            if (c is DataGridView grid) StyleGrid(grid);
    }

    /// <summary>Đệ quy áp style cho một control và các control con.</summary>
    public static void Style(Control control)
    {
        if (control == null) return;

        switch (control)
        {
            case DataGridView grid:
                StyleGrid(grid);
                break;

            case ModernButton mb:
                StyleModernButton(mb);
                break;

            case Button btn:
                StyleFlatButton(btn);
                break;

            case TextBox tb:
                StyleTextBox(tb);
                break;

            case ComboBox cb:
                StyleComboBox(cb);
                break;

            case DateTimePicker dtp:
                StyleDatePicker(dtp);
                break;

            case NumericUpDown num:
                num.BorderStyle = BorderStyle.FixedSingle;
                num.BackColor = Palette.Surface;
                num.ForeColor = Palette.Text;
                break;

            case Label lbl:
                StyleLabel(lbl);
                break;

            case Panel pnl:
                StylePanel(pnl);
                break;

            case StatusStrip strip:
                strip.BackColor = Palette.Surface;
                strip.ForeColor = Palette.Muted;
                strip.SizingGrip = false;
                strip.Font = Palette.FontSmall;
                strip.Padding = new Padding(8, 0, 8, 0);
                break;

            case MenuStrip menu:
                StyleMenu(menu);
                break;

            case GroupBox gb:
                gb.ForeColor = Palette.TextSoft;
                gb.BackColor = Palette.Surface;
                break;
        }

        foreach (Control child in control.Controls)
            Style(child);
    }

    public static void StyleGrid(DataGridView grid)
    {
        grid.EnableHeadersVisualStyles = false;
        grid.BackgroundColor = Palette.Surface;
        grid.BorderStyle = BorderStyle.None;
        grid.GridColor = ColorTranslator.FromHtml("#EEF1F7");
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        grid.RowHeadersVisible = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.MultiSelect = false;
        grid.RowTemplate.Height = 36;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        grid.ColumnHeadersHeight = 40;

        var header = grid.ColumnHeadersDefaultCellStyle;
        header.BackColor = Palette.Primary;
        header.ForeColor = Color.White;
        header.Font = Palette.FontSemiBold;
        header.SelectionBackColor = Palette.Primary;
        header.SelectionForeColor = Color.White;
        header.Alignment = DataGridViewContentAlignment.MiddleLeft;
        header.Padding = new Padding(10, 0, 8, 0);
        header.WrapMode = DataGridViewTriState.False;

        var cell = grid.DefaultCellStyle;
        cell.BackColor = Palette.Surface;
        cell.ForeColor = Palette.TextSoft;
        cell.SelectionBackColor = Palette.PrimarySoft;
        cell.SelectionForeColor = Palette.PrimaryDarker;
        cell.Padding = new Padding(10, 0, 8, 0);
        cell.WrapMode = DataGridViewTriState.False;

        var alt = grid.AlternatingRowsDefaultCellStyle;
        alt.BackColor = Palette.SurfaceAlt;
        alt.ForeColor = Palette.TextSoft;
        alt.SelectionBackColor = Palette.PrimarySoft;
        alt.SelectionForeColor = Palette.PrimaryDarker;

        grid.DefaultCellStyle.NullValue = "—";
    }

    private static void StyleModernButton(ModernButton btn)
    {
        if (btn.Variant == ButtonVariant.Primary && btn.Tag == null)
            btn.Variant = GuessVariant(btn.Text);

        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
        btn.Font = Palette.FontSemiBold;
        btn.Cursor = Cursors.Hand;
        btn.Height = Math.Max(btn.Height, 34);
    }

    private static void StyleFlatButton(Button btn)
    {
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 1;
        btn.FlatAppearance.BorderColor = Palette.Border;
        btn.FlatAppearance.MouseOverBackColor = Palette.SurfaceAlt;
        btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#EEF1F7");
        btn.BackColor = Palette.Surface;
        btn.ForeColor = Palette.TextSoft;
        btn.Font = Palette.FontSemiBold;
        btn.Cursor = Cursors.Hand;
        btn.Height = Math.Max(btn.Height, 34);
    }

    public static ButtonVariant GuessVariant(string text)
    {
        var t = (text ?? "").Trim().ToLowerInvariant();

        if (t.Contains("xoá") || t.Contains("xóa") || t.Contains("hủy lớp"))
            return ButtonVariant.Danger;

        if (t.Contains("thêm") || t.Contains("sửa") || t.Contains("lưu") || t.Contains("đăng nhập")
            || t.Contains("xác nhận") || t.Contains("ghi"))
            return ButtonVariant.Primary;

        if (t.Contains("nhập mới") || t.Contains("tải lại") || t.Contains("tìm") || t.Contains("thoát")
            || t.Contains("hủy") || t.Contains("quay lại"))
            return ButtonVariant.Secondary;

        return ButtonVariant.Secondary;
    }

    private static void StyleTextBox(TextBox tb)
    {
        tb.BorderStyle = BorderStyle.FixedSingle;
        tb.BackColor = Palette.Surface;
        tb.ForeColor = Palette.Text;
        tb.Font = Palette.FontBase;
    }

    private static void StyleComboBox(ComboBox cb)
    {
        cb.FlatStyle = FlatStyle.Flat;
        cb.BackColor = Palette.Surface;
        cb.ForeColor = Palette.Text;
        cb.Font = Palette.FontBase;
        cb.DropDownWidth = Math.Max(cb.DropDownWidth, cb.Width);
    }

    private static void StyleDatePicker(DateTimePicker dtp)
    {
        dtp.BackColor = Palette.Surface;
        dtp.ForeColor = Palette.Text;
        dtp.Font = Palette.FontBase;
    }

    private static void StyleLabel(Label lbl)
    {
        if (lbl.ForeColor == Color.Empty || lbl.ForeColor == Control.DefaultForeColor)
            lbl.ForeColor = Palette.TextSoft;

        if (lbl.AutoSize && lbl.Font == null)
            lbl.Font = Palette.FontBase;
    }

    private static void StylePanel(Panel pnl)
    {
        var ten = pnl.Name ?? "";
        if (ten.StartsWith("pnlNhap", StringComparison.OrdinalIgnoreCase)
            || ten.StartsWith("pnlTim", StringComparison.OrdinalIgnoreCase)
            || ten.StartsWith("pnlNut", StringComparison.OrdinalIgnoreCase)
            || ten.StartsWith("pnlLoc", StringComparison.OrdinalIgnoreCase))
        {
            pnl.BackColor = Palette.Surface;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Padding = new Padding(10, 6, 10, 6);
        }
    }

    private static void StyleMenu(MenuStrip menu)
    {
        menu.BackColor = Palette.Surface;
        menu.ForeColor = Palette.TextSoft;
        menu.Font = Palette.FontBase;
        menu.Renderer = new ThemeMenuRenderer();
        menu.Padding = new Padding(8, 4, 8, 4);
    }
}

public class ThemeColorTable : ProfessionalColorTable
{
    public override Color ToolStripGradientBegin => Palette.Surface;
    public override Color ToolStripGradientMiddle => Palette.Surface;
    public override Color ToolStripGradientEnd => Palette.Surface;
    public override Color MenuItemSelected => Palette.PrimarySoft;
    public override Color MenuItemSelectedGradientBegin => Palette.PrimarySoft;
    public override Color MenuItemSelectedGradientEnd => Palette.PrimarySoft;
    public override Color MenuItemBorder => Palette.PrimarySoft;
    public override Color MenuBorder => Palette.Border;
    public override Color ImageMarginGradientBegin => Palette.Surface;
    public override Color ImageMarginGradientMiddle => Palette.Surface;
    public override Color ImageMarginGradientEnd => Palette.Surface;
    public override Color SeparatorDark => Palette.Border;
    public override Color SeparatorLight => Palette.Surface;
}

public class ThemeMenuRenderer : ToolStripProfessionalRenderer
{
    public ThemeMenuRenderer() : base(new ThemeColorTable()) { }
}
