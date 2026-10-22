namespace QLDSV_HTC.UI;

/// <summary>
/// DataGridView dùng cho nhập liệu: bấm Enter sẽ chốt giá trị ô hiện tại rồi nhảy sang ô kế bên (bên phải);
/// hết hàng thì xuống ô sửa được đầu tiên của hàng kế tiếp. Bỏ qua các cột chỉ đọc.
/// </summary>
public class EnterGridView : DataGridView
{
    protected override bool ProcessDialogKey(Keys keyData)
    {
        if ((keyData & Keys.KeyCode) == Keys.Enter && (keyData & (Keys.Control | Keys.Alt)) == 0)
            return NhayOKeTiep();
        return base.ProcessDialogKey(keyData);
    }

    protected override bool ProcessDataGridViewKey(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && !e.Control && !e.Alt)
            return NhayOKeTiep();
        return base.ProcessDataGridViewKey(e);
    }

    private bool NhayOKeTiep()
    {
        if (CurrentCell == null) return true;

        // Chốt ô đang gõ; nếu không chốt được thì ở lại ô này.
        if (IsCurrentCellInEditMode && !EndEdit()) return true;

        int hang = CurrentCell.RowIndex;
        int cot = CurrentCell.ColumnIndex;

        for (int r = hang; r < RowCount; r++)
        {
            for (int c = (r == hang ? cot + 1 : 0); c < ColumnCount; c++)
            {
                var col = Columns[c];
                if (!col.Visible || col.ReadOnly || Rows[r].ReadOnly) continue;
                CurrentCell = Rows[r].Cells[c]; // EditMode = EditOnEnter nên vào ô là gõ được ngay
                return true;
            }
        }
        return true; // đang ở ô cuối cùng của bảng: đứng yên
    }
}
