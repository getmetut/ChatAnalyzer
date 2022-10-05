using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    internal static class TextFunctions
    {
        /// <summary>
        /// Создает словарь всех слов с указанием их количества в тексте
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static Dictionary<string, int> CreateDictionary(string text)
        {
            var top = new Dictionary<string, int>();
            int last, first; string word;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    first = i++; last = i;
                    while (char.IsLetter(text[last]))
                    {
                        last++;
                    }
                    i = last--;

                    word = text.Substring(first, last - first + 1).Trim().ToLower();

                    if (top.ContainsKey(word))
                    {
                        top[word]++;
                    }
                    else
                    {
                        top[word] = 1;
                    }
                }
            }
            return top;
        }

        /// <summary>
        /// функция получает строку и номер элемента и начная с этого элемента записывает слово и возвращает его
        /// </summary>
        /// <param name="text"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        internal static string GetWord(string text, int i)
        {
            StringBuilder word = new();
            while (char.IsLetter(text[i]))
            {
                word.Append(text[i]);
                i++;
            }
            return word.ToString();
        }

        internal static void ExeptWords()
        {
            string[] exept = {ChatInfo.FullNamePerson1, "дудосов", "насвай", "data", "not", "change" +
                "included", "exporting", "settings", "download", "message", "voice", "video", "this", "reply",
                "photo", "file", "https", "sticker", "www", "outgoing", "change", "included",
                "com", "seconds", "messages", "tiktok", "amp"};
            int exeptFlag = 0;
            foreach (var item in sortedTop)
            {
                if (exeptFlag < exept.Length && !exept.Contains(item.Key))
                    result.Append($"{item.Key,10} {item.Value}\n");
                else
                {
                    exeptFlag++;
                    continue;
                }
            }
        }
    }
}
