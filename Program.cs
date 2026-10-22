using QLDSV_HTC.Forms;
using QLDSV_HTC.Helpers;
using QLDSV_HTC.UI;

namespace QLDSV_HTC;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Font chuẩn của toàn bộ giao diện.
        Application.SetDefaultFont(Palette.FontBase);

        // Lỗi không lường trước trên giao diện: báo cho người dùng thay vì làm sập chương trình.
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += (_, e) => UiHelper.ShowError(e.Exception);

        while (true)
        {
            using (var dangNhap = new FrmDangNhap())
            {
                if (dangNhap.ShowDialog() != DialogResult.OK)
                    return;
            }

            using var main = new FrmMain();
            Application.Run(main);

            if (!main.DangXuat)
                return;
        }
    }
}
