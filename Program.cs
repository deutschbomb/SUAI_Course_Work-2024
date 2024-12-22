namespace App
{
    internal static class Program
    {
        /// <summary>
        ///  Главная входная точка приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Чтобы настроить конфигурацию приложения, например, установить шрифт по умолчанию,
            // смотрите https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}