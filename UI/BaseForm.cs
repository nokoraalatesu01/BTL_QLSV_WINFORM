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
}
