namespace ChatAnalyzer
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Index());
        }
        //������� ������� ����� ����������� ��� ������ ����������� �� ������� �����
        internal delegate void ShowResultD(bool isPersonal, KindAnalysis kind);
        internal delegate void CreateChartD(double x);
        internal enum KindAnalysis
        {
            General, Words, NextWords
        }

        internal enum ChatKind
        {
            Telegram, Instagram, Whatsapp
        }

    }
}