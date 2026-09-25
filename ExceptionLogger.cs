using System;
using System.IO;
using System.Windows.Forms;

namespace lab1forms
{
    /// <summary>
    /// Глобальный логгер исключений (требование задания п.1):
    /// пишет обработанные и необработанные исключения на главную форму
    /// (TextBox) и в текстовый файл с указанием даты/времени, сообщения
    /// и стека вызовов. Используется из Program.cs (глобальные обработчики)
    /// и из catch-блоков во всех модулях лабораторных работ.
    /// </summary>
    public static class ExceptionLogger
    {
        private static TextBox _logBox;
        private static string _logFilePath = "exceptions_log.txt";
        private static readonly object _fileLock = new object();

        /// <summary>Вызывается один раз в конструкторе Form1.</summary>
        public static void Initialize(TextBox logBox, string logFilePath = null)
        {
            _logBox = logBox;
            if (!string.IsNullOrEmpty(logFilePath))
                _logFilePath = logFilePath;
        }

        public static void LogException(Exception ex)
        {
            if (ex == null) return;

            string entry = string.Format(
                "[{0:dd.MM.yyyy HH:mm:ss}] {1}: {2}\r\nСтек вызовов:\r\n{3}\r\n{4}\r\n",
                DateTime.Now, ex.GetType().Name, ex.Message, ex.StackTrace,
                new string('-', 70));

            AppendToTextBox(entry);
            AppendToFile(entry);
        }

        private static void AppendToTextBox(string entry)
        {
            if (_logBox == null || _logBox.IsDisposed) return;

            void Append() => _logBox.AppendText(entry + Environment.NewLine);

            try
            {
                if (_logBox.InvokeRequired)
                    _logBox.Invoke((Action)Append);
                else
                    Append();
            }
            catch
            {
                // форма могла быть уже закрыта на момент логирования — не роняем приложение
            }
        }

        private static void AppendToFile(string entry)
        {
            lock (_fileLock)
            {
                try
                {
                    File.AppendAllText(_logFilePath, entry);
                }
                catch
                {
                    // если файл недоступен (нет прав, диск занят и т.п.) — не роняем приложение
                }
            }
        }
    }
}
