using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1forms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// Запуск с параметром --console открывает консольную версию ЛР1
        /// (устраняет отсутствие связи ConsoleApp.cs с точкой входа).
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && string.Equals(args[0], "--console", StringComparison.OrdinalIgnoreCase))
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                ConsoleApp.Run();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ── Глобальная обработка необработанных исключений (требование п.1) ──

            // Исключения в потоке UI (Windows Forms message loop)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) => ExceptionLogger.LogException(e.Exception);

            // Исключения в любых других потоках / фатальные исключения домена приложения
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                    ExceptionLogger.LogException(ex);
            };

            // Необработанные исключения в Task/async-задачах (Lab4/Lab5 работают асинхронно)
            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                ExceptionLogger.LogException(e.Exception);
                e.SetObserved();
            };

            Application.Run(new Form1());
        }
    }
}
