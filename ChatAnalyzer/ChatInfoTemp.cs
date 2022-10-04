using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    internal static class ChatInfoTemp
    {
        internal static string? Text { get; set; }
        internal static string? TextPerson1 { get; set; }
        internal static string? TextPerson2 { get; set; }

        internal static void CreateTemp()
        {
            ChatInfoTemp.Text = ChatInfo.Text;
            ChatInfoTemp.TextPerson1 = ChatInfo.TextPerson1;
            ChatInfoTemp.TextPerson2 = ChatInfo.TextPerson2;
        }
    }
}
