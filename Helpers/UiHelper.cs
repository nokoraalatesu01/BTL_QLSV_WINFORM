using Microsoft.Data.SqlClient;

namespace QLDSV_HTC.Helpers;

/// <summary>Tiện ích giao diện WinForms dùng chung.</summary>
public static class UiHelper
{
    public static DataGridView CreateGrid() => new()
    {
        Dock = DockStyle.Fill,
        ReadOnly = true,
        AllowUserToAddRows = false,
        AllowUserToDeleteRows = false,
        AllowUserToResizeRows = false,
        AutoGenerateColumns = false,
        MultiSelect = false,
        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        RowHeadersVisible = false,
        BackgroundColor = Color.White,
        BorderStyle = BorderStyle.None,
    };

    public static DataGridViewTextBoxColumn AddColumn(
        DataGridView grid, string property, string header, float fillWeight = 100, string? format = null)
    {
        var col = new DataGridViewTextBoxColumn
        {
            DataPropertyName = property,
            Name = "col" + property,
            HeaderText = header,
            FillWeight = fillWeight,
            ReadOnly = true,
        };
        if (format != null)
            col.DefaultCellStyle.Format = format;
        grid.Columns.Add(col);
        return col;
    }

    public static Button CreateButton(string text) => new()
    {
        Text = text,
        AutoSize = true,
        MinimumSize = new Size(96, 32),
        Margin = new Padding(4),
    };

    public static void BindCombo(ComboBox combo, object dataSource, string displayMember, string valueMember)
    {
        combo.DropDownStyle = ComboBoxStyle.DropDownList;
        combo.DisplayMember = displayMember;
        combo.ValueMember = valueMember;
        combo.DataSource = dataSource;
    }

    public static void SetNumeric(NumericUpDown numeric, int value) =>
        numeric.Value = Math.Clamp(value, (int)numeric.Minimum, (int)numeric.Maximum);

    /// <summary>Gán danh sách vào lưới và bỏ chọn dòng (không tự chọn dòng đầu tiên).</summary>
    public static void GanLuoi<T>(DataGridView grid, List<T> data)
    {
        grid.DataSource = null;
        grid.DataSource = data;
        grid.ClearSelection();
        grid.CurrentCell = null;
    }

    /// <summary>Lấy đối tượng ở dòng đang chọn; ném BusinessException nếu chưa chọn dòng nào.</summary>
    public static T BatBuocChon<T>(DataGridView grid, string thaoTac) where T : class
    {
        if (grid.SelectedRows.Count == 0 || grid.SelectedRows[0].DataBoundItem is not T item)
            throw new BusinessException($"Hãy chọn một dòng trong danh sách để {thaoTac}.");
        return item;
    }

    public static void ShowInfo(string message) =>
        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public static void ShowWarning(string message) =>
        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

    public static bool Confirm(string message) =>
        MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    /// <summary>Hiển thị lỗi thân thiện theo loại ngoại lệ.</summary>
    public static void ShowError(Exception ex)
    {
        switch (ex)
        {
            case BusinessException:
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                break;
            case UnauthorizedAccessException:
                MessageBox.Show(ex.Message, "Không đủ quyền", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                break;
            case SqlException sql:
                MessageBox.Show(
                    $"Lỗi cơ sở dữ liệu (mã {sql.Number}): {sql.Message}\n\n" +
                    "Kiểm tra SQL Server đã chạy, chuỗi kết nối trong appsettings.json, " +
                    "và đã chạy file Database/QLDSV_HTC.sql.",
                    "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            default:
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
        }
    }

    /// <summary>Chạy một hành động và hiển thị lỗi (nếu có) thay vì làm sập chương trình.</summary>
    public static void Run(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            ShowError(ex);
        }
    }
}
