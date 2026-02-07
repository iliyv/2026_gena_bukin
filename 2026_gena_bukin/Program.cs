using System;
using System.Windows.Forms;

namespace _2026_gena_bukin
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Мы запускаем приложение через LoginForm, так как Form1 не существует
            Application.Run(new LoginForm());
        }
    }
}