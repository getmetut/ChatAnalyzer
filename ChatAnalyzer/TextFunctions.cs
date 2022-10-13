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
        /// Создает словарь всех слов не меньше длины 2 в тексте, количество которых больше amount
        /// </summary>
        /// <param name="text"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        internal static Dictionary<string, int> CreateDictionary(string text, int amount)
        {
            var top = new Dictionary<string, int>();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Count(); i++)
            {
                if (top.ContainsKey(words[i]))
                {
                    top[words[i]]++;
                }
                else
                {
                    top[words[i]] = 1;
                }
            }
            
            // Исклюсчаем ненужные слова (для телеги)
            string[] exept = {"data", "not", "change",
                "included", "exporting", "settings", "download", "message", "voice", "video", "this", "reply",
                "photo", "file", "https", "sticker", "www", "outgoing", "change", "included",
                "com", "seconds", "messages", "tiktok", "amp"};
            foreach (var item in top)
            {
                if (exept.Contains(item.Key))
                    top.Remove(item.Key);
            }
            // Соритруем словарь и возвращаем
            return top.Where(t => t.Value > amount && t.Key.Length > 2).OrderByDescending(t => t.Value).ToDictionary(t => t.Key, t => t.Value);
        }

        /// <summary>
        /// Функция получает строку и номер элемента и начная с этого элемента записывает слово и возвращает его
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

        internal static bool IsTime(List<string> wordsList, int i)
        {
            return wordsList[i].Length > 4 && Char.IsDigit(wordsList[i][0]) && Char.IsDigit(wordsList[i][1]) &&
                Char.IsDigit(wordsList[i][3]) && Char.IsDigit(wordsList[i][4]);
        }
    }
}
