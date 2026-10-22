using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QLDSV_HTC.UI;

/// <summary>
/// Trung tâm giao diện UTC Portal: áp bộ nhận diện chung (màu navy, font, kiểu bảng, kiểu nút, ô nhập)
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

            case CheckBox chk:
                chk.ForeColor = Palette.TextSoft;
                chk.Font = Palette.FontBase;
                break;
        }

        foreach (Control child in control.Controls)
            Style(child);
    }

    /// <summary>Áp style DataGridView theo chuẩn UTC Portal: header navy, dòng xen kẽ nhẹ.</summary>
    public static void StyleGrid(DataGridView grid)
    {
        grid.EnableHeadersVisualStyles = false;
        grid.BackgroundColor = Palette.Surface;
        grid.BorderStyle = BorderStyle.None;
        grid.GridColor = ColorTranslator.FromHtml("#EBF0FA");
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        grid.RowHeadersVisible = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.MultiSelect = false;
        grid.RowTemplate.Height = 40;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        grid.ColumnHeadersHeight = 42;
        grid.AllowUserToResizeRows = false;

        // Header: Navy UTC
        var header = grid.ColumnHeadersDefaultCellStyle;
        header.BackColor = Palette.Navy;
        header.ForeColor = Color.White;
        header.Font = Palette.FontSemiBold;
        header.SelectionBackColor = Palette.Navy;
        header.SelectionForeColor = Color.White;
        header.Alignment = DataGridViewContentAlignment.MiddleLeft;
        header.Padding = new Padding(12, 0, 8, 0);
        header.WrapMode = DataGridViewTriState.False;

        // Cell style
        var cell = grid.DefaultCellStyle;
        cell.BackColor = Palette.Surface;
        cell.ForeColor = Palette.TextSoft;
        cell.SelectionBackColor = Palette.PrimarySoft;
        cell.SelectionForeColor = Palette.PrimaryDarker;
        cell.Padding = new Padding(12, 0, 8, 0);
        cell.WrapMode = DataGridViewTriState.False;

        // Alternating rows: rất nhẹ nhàng
        var alt = grid.AlternatingRowsDefaultCellStyle;
        alt.BackColor = ColorTranslator.FromHtml("#F6F9FF");
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
            pnl.Padding = new Padding(12, 8, 12, 8);
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

    /// <summary>Áp style UTC cho panel tiêu đề trang (pnlPageHeader).</summary>
    public static void StylePageHeader(Panel pnl, string title, string subtitle = "")
    {
        pnl.BackColor = Palette.Surface;
        pnl.Height = string.IsNullOrEmpty(subtitle) ? 56 : 72;

        // Xóa control cũ nếu có
        var oldTitle = pnl.Controls.Find("_pageTitle", false);
        var oldSub = pnl.Controls.Find("_pageSubtitle", false);
        foreach (var c in oldTitle) pnl.Controls.Remove(c);
        foreach (var c in oldSub) pnl.Controls.Remove(c);

        var lblTitle = new Label
        {
            Name = "_pageTitle",
            Text = title,
            Font = Palette.PageTitle,
            ForeColor = Palette.Navy,
            AutoSize = true,
            Location = new Point(20, string.IsNullOrEmpty(subtitle) ? 14 : 10)
        };
        pnl.Controls.Add(lblTitle);

        if (!string.IsNullOrEmpty(subtitle))
        {
            var lblSub = new Label
            {
                Name = "_pageSubtitle",
                Text = subtitle,
                Font = Palette.FontSmall,
                ForeColor = Palette.Muted,
                AutoSize = true,
                Location = new Point(22, 38)
            };
            pnl.Controls.Add(lblSub);
        }

        // Đường viền dưới
        pnl.Paint += (s, e) =>
        {
            using var pen = new System.Drawing.Pen(Palette.Border, 1);
            e.Graphics.DrawLine(pen, 0, pnl.Height - 1, pnl.Width, pnl.Height - 1);
        };
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
    public override Color MenuItemBorder => Palette.PrimaryMid;
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
