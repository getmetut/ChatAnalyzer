using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    // класс для промежуточного изменения текста
    internal static class ChatInfoTemp
    {
        internal static string? Text { get; set; }
        internal static string? TextPerson1 { get; set; }
        internal static string? TextPerson2 { get; set; }
        internal static List<string>? WordsList { get; set; }
        internal static List<string>? WordsListPerson1 { get; set; }
        internal static List<string>? WordsListPerson2 { get; set; }
        internal static Dictionary<string, int>? WordsDictionary { get; set; }
        internal static Dictionary<string, int>? WordsDictionaryPerson1 { get; set; }
        internal static Dictionary<string, int>? WordsDictionaryPerson2 { get; set; }

        /// <summary>
        /// функция возврата промежуточного текста к чистому
        /// </summary>
        internal static void RefreshTemp()
        {
            Text = ChatInfo.Text;
            TextPerson1 = ChatInfo.TextPerson1;
            TextPerson2 = ChatInfo.TextPerson2;
            WordsList = ChatInfo.WordsList;
            WordsDictionary = ChatInfo.WordsDictionary;
        }
    }
}
