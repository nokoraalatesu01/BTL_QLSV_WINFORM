using QLDSV_HTC.Helpers;

namespace QLDSV_HTC.UI;

/// <summary>Form nền cho toàn bộ cửa sổ: tự động áp bộ nhận diện giao diện chung.</summary>
public class BaseForm : Form
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode) return;
        Theme.Apply(this);
    }

    /// <summary>Enter trong ô nhập liệu = nhảy sang ô kế tiếp (xem <see cref="EnterNavigation"/>).</summary>
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (!DesignMode && EnterNavigation.TryMoveNext(this, keyData))
            return true;
        return base.ProcessCmdKey(ref msg, keyData);
    }
}
