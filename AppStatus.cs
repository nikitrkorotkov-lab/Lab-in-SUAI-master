using System;

namespace lab1forms
{
    /// <summary>
    /// Шина событий для строки статуса на главной форме (требование п.3):
    /// любая панель лабораторной работы может сообщить, какой процесс
    /// сейчас выполняется и с каким прогрессом, не имея прямой ссылки на Form1.
    /// </summary>
    public static class AppStatus
    {
        /// <summary>
        /// name — название текущего процесса.
        /// percent — 0..100 для определённого прогресса,
        /// либо -1 для индикатора неопределённого выполнения (marquee).
        /// </summary>
        public static event Action<string, int> Changed;

        public static void Report(string name, int percent)
        {
            Changed?.Invoke(name, percent);
        }

        public static void Complete(string name)
        {
            Changed?.Invoke(name, 100);
        }

        public static void Idle()
        {
            Changed?.Invoke("Ожидание", 0);
        }
    }
}
