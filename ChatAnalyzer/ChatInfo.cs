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
        internal static string? TextPerson1 { get; set; }
        internal static string? TextPerson2 { get; set; }
    }
}
