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
        //делегат который будет применяться для вывода результатов на главную форму
        internal delegate void ShowDeleagat(bool isPersonal, KindAnalysis kind);
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