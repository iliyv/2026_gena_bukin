using Npgsql;

namespace _2026_gena_bukin
{
    public static class DatabaseService
    {
        public static string ConnStr = "Host=localhost;Port=5432;Database=Ekzamen_shoe_store_BD;Username=postgres;Password=postgres";

        public static NpgsqlConnection GetConnection() => new NpgsqlConnection(ConnStr);
    }

}