using System.Drawing;

namespace QLDSV_HTC.UI;

/// <summary>
/// Bảng màu + typography dùng chung cho toàn bộ giao diện WinForms.
/// Một nguồn sự thật duy nhất để mọi form trông đồng bộ.
/// </summary>
public static class Palette
{
    // ---- Màu chủ đạo ----
    public static readonly Color Primary = ColorTranslator.FromHtml("#4F46E5");
    public static readonly Color PrimaryDark = ColorTranslator.FromHtml("#4338CA");
    public static readonly Color PrimaryDarker = ColorTranslator.FromHtml("#3730A3");
    public static readonly Color PrimarySoft = ColorTranslator.FromHtml("#EEF0FE");
    public static readonly Color Accent = ColorTranslator.FromHtml("#0EA5E9");
    public static readonly Color AccentSoft = ColorTranslator.FromHtml("#E0F2FE");

    // ---- Trạng thái ----
    public static readonly Color Success = ColorTranslator.FromHtml("#10B981");
    public static readonly Color SuccessSoft = ColorTranslator.FromHtml("#ECFDF5");
    public static readonly Color Warning = ColorTranslator.FromHtml("#F59E0B");
    public static readonly Color WarningSoft = ColorTranslator.FromHtml("#FFFBEB");
    public static readonly Color Danger = ColorTranslator.FromHtml("#EF4444");
    public static readonly Color DangerSoft = ColorTranslator.FromHtml("#FEF2F2");
    public static readonly Color Info = ColorTranslator.FromHtml("#3B82F6");
    public static readonly Color InfoSoft = ColorTranslator.FromHtml("#EFF6FF");

    // ---- Nền & chữ ----
    public static readonly Color Canvas = ColorTranslator.FromHtml("#F4F6FB");
    public static readonly Color Surface = Color.White;
    public static readonly Color SurfaceAlt = ColorTranslator.FromHtml("#FAFBFE");
    public static readonly Color Border = ColorTranslator.FromHtml("#E5E9F2");
    public static readonly Color BorderStrong = ColorTranslator.FromHtml("#D3D9E6");
    public static readonly Color Text = ColorTranslator.FromHtml("#111827");
    public static readonly Color TextSoft = ColorTranslator.FromHtml("#374151");
    public static readonly Color Muted = ColorTranslator.FromHtml("#6B7280");
    public static readonly Color MutedLight = ColorTranslator.FromHtml("#9CA3AF");

    // ---- Sidebar ----
    public static readonly Color SidebarTop = ColorTranslator.FromHtml("#1B2440");
    public static readonly Color SidebarBottom = ColorTranslator.FromHtml("#10182D");
    public static readonly Color SidebarText = ColorTranslator.FromHtml("#C3CCDE");
    public static readonly Color SidebarTextActive = Color.White;
    public static readonly Color SidebarHover = ColorTranslator.FromHtml("#243052");

    // ---- Typography ----
    public const string FontFamily = "Segoe UI";

    public static readonly Font FontBase = new(FontFamily, 9.75F, FontStyle.Regular);
    public static readonly Font FontSmall = new(FontFamily, 8.75F, FontStyle.Regular);
    public static readonly Font FontSemiBold = new(FontFamily, 9.75F, FontStyle.Bold);
    public static readonly Font FontH1 = new(FontFamily, 22F, FontStyle.Bold);
    public static readonly Font FontH2 = new(FontFamily, 15F, FontStyle.Bold);
    public static readonly Font StatValue = new(FontFamily, 26F, FontStyle.Bold);
}
