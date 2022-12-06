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
        internal static string? InitialsPerson1 { get; set; }
        internal static string? InitialsPerson2 { get; set; }
        internal static string? FullNamePerson1 { get; set; }
        internal static string? FullNamePerson2 { get; set; }
        internal static string? Text { get; set; }
        internal static List<string>? WordsList { get; set; }
        internal static List<string>? WordsListPerson1 { get; set; }
        internal static List<string>? WordsListPerson2 { get; set; }
        internal static Dictionary<string, int>? WordsDictionary { get; set; }
        internal static Dictionary<string, int>? WordsDictionaryPerson1 { get; set; }
        internal static Dictionary<string, int>? WordsDictionaryPerson2 { get; set; }
        internal static string? TextPerson1 { get; set; }
        internal static string? TextPerson2 { get; set; }
        internal static int FullNameCount1 { get; set; }
        internal static int FullNameCount2 { get; set; }
        internal static bool NewAdded { get; set; }

        /// <summary>
        /// Метод чистит всю информацию о тексте
        /// </summary>
        internal static void ClearChatInfo()
        {
            FullNamePerson1 = null;
            FullNamePerson2 = null;
            InitialsPerson1 = null;
            InitialsPerson2 = null;
            Text = null;
            TextPerson1 = null;
            TextPerson2 = null;
            WordsList = null;
            WordsListPerson1 = null;
            WordsListPerson2 = null;
            WordsDictionary = null;
            WordsDictionaryPerson1 = null;
            WordsDictionaryPerson2 = null;
            FullNameCount1 = 0;
            FullNameCount2 = 0;
            NewAdded = false;

        }
    }
}
