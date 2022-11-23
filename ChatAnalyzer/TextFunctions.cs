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
        /// Создает словарь всех слов в тексте
        /// </summary>
        /// <param name="text"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        internal static Dictionary<string, int> CreateDictionary(string text, string[] exept)
        {
            var top = new Dictionary<string, int>();
            string[] words = text.ToLower().Split(' ');
            for (int i = 0; i < words.Count(); i++)
            {
                var word = words[i].Trim();
                if (TextFunctions.IsTime(word))
                    continue;
                for (int j = 0; j < word.Length; j++)
                    if (Char.IsPunctuation(word[j]))
                        word = word.Remove(j, 1);
                if (top.ContainsKey(word.Trim()))
                {
                    top[word]++;
                }
                else
                {
                    top[word] = 1;
                }
            }
            
            // Исключаем ненужные слова
            foreach (var item in top)
            {
                if (exept.Contains(item.Key))
                    top.Remove(item.Key);
            }
            return top;
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

        /// <summary>
        /// проверяет является ли элемент временем формата XX:XX
        /// </summary>
        /// <param name="wordsList"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        internal static bool IsTime(string word)
        {
            return word.Length > 4 && Char.IsDigit(word[0]) && Char.IsDigit(word[1]) &&
                Char.IsDigit(word[3]) && Char.IsDigit(word[4]);
        }
    }
}
