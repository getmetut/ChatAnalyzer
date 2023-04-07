namespace ChatAnalyzer
{
    // класс для промежуточного изменения текста
    internal static class ChatInfoTemp
    {
        internal static List<string>? WordList { get; set; }
        internal static List<string>? WordListP1 { get; set; }
        internal static List<string>? WordListP2 { get; set; }
        internal static Dictionary<string, int>? WordDict { get; set; }
        internal static Dictionary<string, int>? WordDictP1 { get; set; }
        internal static Dictionary<string, int>? WordDictP2 { get; set; }
        internal static ChatActivity DateIndexes { get; set; }
        internal static ChatActivity DateP1Indexes { get; set; }
        internal static ChatActivity DateP2Indexes { get; set; }

        /// <summary>
        /// функция возврата промежуточного текста к начальному
        /// </summary>
        internal static void Refresh()
        {
            WordList = ChatInfo.WordList.ToList();
            WordListP1 = ChatInfo.WordListP1.ToList();
            WordListP2 = ChatInfo.WordListP2.ToList();
        }
    }
}
