﻿namespace ChatAnalyzer
{
    // класс хранящий информацию о тексте и текст
    internal static class ChatInfo
    {
        internal static string? InitialP1 { get; set; }
        internal static string? InitialP2 { get; set; }
        internal static string? FullNameP1 { get; set; }
        internal static string? FullNameP2 { get; set; }

        internal static string? InitialP1T { get; set; }
        internal static string? InitialP2T { get; set; }
        internal static string? FullNameP1T { get; set; }
        internal static string? FullNameP2T { get; set; }

        internal static List<string>? WordList { get; set; }
        internal static List<string>? WordListP1 { get; set; }
        internal static List<string>? WordListP2 { get; set; }

        internal static Dictionary<string, int>? WordDict { get; set; }
        internal static Dictionary<string, int>? WordDictP1 { get; set; }
        internal static Dictionary<string, int>? WordDictP2 { get; set; }

        internal static bool NewAdded { get; set; }

        internal static long? MessageCount { get; set; }
        internal static long? MessageCountP1 { get; set; }
        internal static long? MessageCountP2 { get; set; }

        /// <summary>
        /// Метод чистит всю информацию о тексте
        /// </summary>
        internal static void Clear()
        {
            FullNameP1 = null;
            FullNameP2 = null;
            InitialP1 = null;
            InitialP2 = null;
            WordList = null;
            WordListP1 = null;
            WordListP2 = null;
            WordDict = null;
            WordListP1 = null;
            WordListP2 = null;
            MessageCount = null;
            MessageCountP1 = null;
            MessageCountP2 = null;
            ChatInfoTemp.WordList = null;
            ChatInfoTemp.WordListP1 = null;
            ChatInfoTemp.WordListP2 = null;
            ChatInfoTemp.WordDict = null;
            ChatInfoTemp.WordDictP1 = null;
            ChatInfoTemp.WordDictP2 = null;

            GC.Collect(2, GCCollectionMode.Forced);
            NewAdded = false;
        }
    }
}
