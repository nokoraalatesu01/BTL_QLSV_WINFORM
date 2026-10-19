using BTL_QLSV_WINFORM.DTO;

namespace BTL_QLSV_WINFORM.Helpers
{
    public static class SessionManager
    {
        public static TaiKhoanDTO? CurrentUser { get; set; } = null;

        public static bool IsLoggedIn => CurrentUser != null;

        public static bool IsAdmin => CurrentUser != null && 
            string.Equals(CurrentUser.Quyen, "Admin", System.StringComparison.OrdinalIgnoreCase);

        public static void SetSession(TaiKhoanDTO user)
        {
            CurrentUser = user;
        }

        public static void ClearSession()
        {
            CurrentUser = null;
        }
    }
}
