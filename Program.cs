namespace App
{
    internal static class Program
    {
        /// <summary>
        ///  ������� ������� ����� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ����� ��������� ������������ ����������, ��������, ���������� ����� �� ���������,
            // �������� https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}