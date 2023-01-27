using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    // класс хранящий информацию о тексте и текст
    internal static class ChatInfo
    {
        internal static string? InitialP1 { get; set; }
        internal static string? InitialP2 { get; set; }
        internal static string? FullNameP1 { get; set; }
        internal static string? FullNameP2 { get; set; }

        internal static List<string>? WordList { get; set; }
        internal static List<string>? WordListP1 { get; set; }
        internal static List<string>? WordListP2 { get; set; }

        internal static Dictionary<string, int>? WordDict { get; set; }
        internal static Dictionary<string, int>? WordDictP1 { get; set; }
        internal static Dictionary<string, int>? WordDictP2 { get; set; }

        internal static string? Text { get; set; }
        internal static string? TextP1 { get; set; }
        internal static string? TextP2 { get; set; }

        internal static bool NewAdded { get; set; }

        internal static long? MessageCount { get; set; }
        internal static long? MessageCountP1 { get; set; }
        internal static long? MessageCountP2 { get; set; }

        /// <summary>
        /// Метод чистит всю информацию о тексте
        /// </summary>
        internal static void ClearChatInfo()
        {
            FullNameP1 = "";
            FullNameP2 = "";
            InitialP1 = "";
            InitialP2 = "";
            Text = "";
            TextP1 = "";
            TextP2 = "";
            WordList.Clear();
            WordListP1.Clear();
            WordListP2.Clear();
            WordDict.Clear();
            WordListP1.Clear();
            WordListP2.Clear();
            MessageCount = 0;
            MessageCountP1 = 0;
            MessageCountP2 = 0;
            NewAdded = false;
        }
    }
}
