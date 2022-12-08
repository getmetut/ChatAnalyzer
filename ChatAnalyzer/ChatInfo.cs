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
            FullNameP1 = null;
            FullNameP2 = null;
            InitialP1 = null;
            InitialP2 = null;
            Text = null;
            TextP1 = null;
            TextP2 = null;
            WordList = null;
            WordListP1 = null;
            WordListP2 = null;
            WordDict = null;
            WordListP1 = null;
            WordListP2 = null;
            NewAdded = false;

        }
    }
}
