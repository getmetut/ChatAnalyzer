namespace ChatAnalyzer
{
    // класс для промежуточного изменения текста
    internal static class ChatInfoTemp
    {
        internal static string? Text { get; set; }
        internal static string? TextP1 { get; set; }
        internal static string? TextP2 { get; set; }
        internal static List<string>? WordList { get; set; }
        internal static List<string>? WordListP1 { get; set; }
        internal static List<string>? WordListP2 { get; set; }
        internal static Dictionary<string, int>? WordDict { get; set; }
        internal static Dictionary<string, int>? WordDictP1 { get; set; }
        internal static Dictionary<string, int>? WordDictP2 { get; set; }

        /// <summary>
        /// функция возврата промежуточного текста к начальному
        /// </summary>
        internal static void RefreshTemp()
        {
            Text = ChatInfo.Text;
            TextP1 = ChatInfo.TextP1;
            TextP2 = ChatInfo.TextP2;
            WordList = ChatInfo.WordList.ToList();
            WordListP1 = ChatInfo.WordListP1.ToList();
            WordListP2 = ChatInfo.WordListP2.ToList();
        }
    }
}
