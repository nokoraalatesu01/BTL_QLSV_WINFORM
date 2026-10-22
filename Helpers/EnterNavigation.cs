namespace QLDSV_HTC.Helpers;

/// <summary>
/// Phím Enter trong ô nhập liệu = chuyển sang ô nhập kế tiếp (theo thứ tự TabIndex),
/// giống phím Tab. Ở ô cuối cùng (kế tiếp là nút bấm) thì giữ nguyên hành vi mặc định
/// của form (ví dụ AcceptButton của form đăng nhập / đổi mật khẩu).
/// Gọi từ <c>ProcessCmdKey</c> của form vì với form có AcceptButton, sự kiện KeyDown của Enter không được phát sinh.
/// </summary>
public static class EnterNavigation
{
    /// <summary>Trả về true nếu đã xử lý phím (đã chuyển ô); false nếu để form xử lý mặc định.</summary>
    public static bool TryMoveNext(Form form, Keys keyData)
    {
        if (keyData != Keys.Enter) return false;

        var current = form.ActiveControl;
        if (current == null || !LaOCoTheNhay(current)) return false;

        var next = TimOKeTiep(form, current);
        if (next == null || next is Button) return false;

        next.Focus();
        if (next is TextBox tb) tb.SelectAll();
        return true;
    }

    private static bool LaOCoTheNhay(Control c)
    {
        switch (c)
        {
            case TextBox tb:
                // Ô tìm kiếm tự xử lý Enter (bấm Enter để tìm); ô nhiều dòng cần Enter để xuống dòng.
                return !tb.Multiline && !tb.Name.StartsWith("txtTim", StringComparison.Ordinal);
            case ComboBox cb:
                return !cb.DroppedDown; // đang mở danh sách thì Enter dùng để chọn mục
            case NumericUpDown:
            case DateTimePicker:
                return true;
            default:
                return false;
        }
    }

    private static Control? TimOKeTiep(Form form, Control current)
    {
        var c = form.GetNextControl(current, true);
        while (c != null && c != current)
        {
            if (c.Enabled && c.Visible && c.TabStop && c.CanSelect) return c;
            c = form.GetNextControl(c, true);
        }
        return null;
    }
}
