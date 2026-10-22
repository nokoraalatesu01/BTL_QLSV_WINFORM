using System.Drawing;

namespace QLDSV_HTC.UI;

/// <summary>
/// Bảng màu + typography theo phong cách UTC Portal (Navy #20396F / Blue #2864E8).
/// Một nguồn sự thật duy nhất để mọi form trông đồng bộ.
/// </summary>
public static class Palette
{
    // ---- Màu chủ đạo UTC ----
    public static readonly Color Navy = ColorTranslator.FromHtml("#20396F");       // Navy UTC – sidebar, header
    public static readonly Color NavyDark = ColorTranslator.FromHtml("#162B55");    // Hover/pressed trên navy
    public static readonly Color NavyLight = ColorTranslator.FromHtml("#2A4A8A");   // Hover item sidebar

    public static readonly Color Primary = ColorTranslator.FromHtml("#2864E8");     // Primary Blue UTC
    public static readonly Color PrimaryDark = ColorTranslator.FromHtml("#1E50C0"); // Hover/pressed nút chính
    public static readonly Color PrimaryDarker = ColorTranslator.FromHtml("#163E9A");
    public static readonly Color PrimarySoft = ColorTranslator.FromHtml("#E8EFFD"); // Background nhẹ blue
    public static readonly Color PrimaryMid = ColorTranslator.FromHtml("#C5D8F8");  // Border blue nhạt

    // ---- Trạng thái ----
    public static readonly Color Success = ColorTranslator.FromHtml("#10B981");
    public static readonly Color SuccessSoft = ColorTranslator.FromHtml("#ECFDF5");
    public static readonly Color Warning = ColorTranslator.FromHtml("#F59E0B");
    public static readonly Color WarningSoft = ColorTranslator.FromHtml("#FFFBEB");
    public static readonly Color Danger = ColorTranslator.FromHtml("#EF4444");
    public static readonly Color DangerSoft = ColorTranslator.FromHtml("#FEF2F2");
    public static readonly Color Info = ColorTranslator.FromHtml("#2864E8");
    public static readonly Color InfoSoft = ColorTranslator.FromHtml("#E8EFFD");

    // ---- Nền & chữ ----
    public static readonly Color Canvas = ColorTranslator.FromHtml("#F2F5FC");      // Nền trang chính UTC
    public static readonly Color Surface = Color.White;
    public static readonly Color SurfaceAlt = ColorTranslator.FromHtml("#F8FAFF");
    public static readonly Color Border = ColorTranslator.FromHtml("#DCE4F2");      // Viền UTC
    public static readonly Color BorderStrong = ColorTranslator.FromHtml("#B8C8E8");
    public static readonly Color Text = ColorTranslator.FromHtml("#1F2937");        // Chữ chính
    public static readonly Color TextSoft = ColorTranslator.FromHtml("#374151");
    public static readonly Color Muted = ColorTranslator.FromHtml("#718096");       // Chữ phụ UTC
    public static readonly Color MutedLight = ColorTranslator.FromHtml("#9CA3AF");

    // ---- Sidebar UTC Navy ----
    public static readonly Color SidebarTop = ColorTranslator.FromHtml("#20396F");    // Navy UTC
    public static readonly Color SidebarBottom = ColorTranslator.FromHtml("#162B55"); // Darker navy
    public static readonly Color SidebarText = ColorTranslator.FromHtml("#B8C9E8");   // Chữ sidebar (xanh nhạt)
    public static readonly Color SidebarTextActive = Color.White;
    public static readonly Color SidebarHover = ColorTranslator.FromHtml("#2A4A8A");  // Hover navy sáng hơn
    public static readonly Color SidebarActive = ColorTranslator.FromHtml("#2864E8"); // Active = Primary Blue

    // ---- Thẻ thống kê Dashboard ----
    public static readonly Color StatBlue = ColorTranslator.FromHtml("#2864E8");
    public static readonly Color StatGreen = ColorTranslator.FromHtml("#10B981");
    public static readonly Color StatOrange = ColorTranslator.FromHtml("#F59E0B");
    public static readonly Color StatPurple = ColorTranslator.FromHtml("#8B5CF6");

    // ---- Typography ----
    public const string FontFamily = "Segoe UI";

    public static readonly Font FontBase = new(FontFamily, 9.75F, FontStyle.Regular);
    public static readonly Font FontSmall = new(FontFamily, 8.75F, FontStyle.Regular);
    public static readonly Font FontSemiBold = new(FontFamily, 9.75F, FontStyle.Bold);
    public static readonly Font FontH1 = new(FontFamily, 20F, FontStyle.Bold);
    public static readonly Font FontH2 = new(FontFamily, 14F, FontStyle.Bold);
    public static readonly Font FontH3 = new(FontFamily, 12F, FontStyle.Bold);
    public static readonly Font FontCaption = new(FontFamily, 8F, FontStyle.Regular);
    public static readonly Font StatValue = new(FontFamily, 24F, FontStyle.Bold);
    public static readonly Font PageTitle = new(FontFamily, 18F, FontStyle.Bold);
}
