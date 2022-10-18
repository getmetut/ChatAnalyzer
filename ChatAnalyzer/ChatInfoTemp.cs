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

        /// <summary>
        /// функция возврата промежуточного текста к чистому
        /// </summary>
        internal static void RefreshTemp()
        {
            ChatInfoTemp.Text = ChatInfo.Text;
            ChatInfoTemp.TextPerson1 = ChatInfo.TextPerson1;
            ChatInfoTemp.TextPerson2 = ChatInfo.TextPerson2;
        }
    }
}
