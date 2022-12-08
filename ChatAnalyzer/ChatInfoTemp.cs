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
        internal static string? TextP1 { get; set; }
        internal static string? TextP2 { get; set; }
        internal static List<string>? WordList { get; set; }
        internal static List<string>? WordListP1 { get; set; }
        internal static List<string>? WordListP2 { get; set; }
        internal static Dictionary<string, int>? WordDict { get; set; }
        internal static Dictionary<string, int>? WordDictP1 { get; set; }
        internal static Dictionary<string, int>? WordDictP2 { get; set; }

        /// <summary>
        /// функция возврата промежуточного текста к чистому
        /// </summary>
        internal static void RefreshTemp()
        {
            Text = ChatInfo.Text;
            TextP1 = ChatInfo.TextP1;
            TextP2 = ChatInfo.TextP2;
            WordList = ChatInfo.WordList;
            WordDict = ChatInfo.WordDict;
            WordDictP1 = ChatInfo.WordDictP1;
            WordDictP2 = ChatInfo.WordDictP2;
        }
    }
}
