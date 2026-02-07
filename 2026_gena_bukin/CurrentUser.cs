namespace _2026_gena_bukin
{
    public static class CurrentUser
    {
        public static string FullName { get; set; }
        public static string RoleName { get; set; } // "Клиент", "Менеджер", "Администратор" или "Гость"
        public static int RoleId { get; set; } // 1, 2, 3 или 0 для гостя
    }
}