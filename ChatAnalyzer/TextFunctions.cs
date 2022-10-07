﻿using System;
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
            
        }

        /// <summary>
        /// функция дает знать нужный ли мы нашли элемент в тексте по некоему символу с номером flag
        /// </summary>
        /// <param name="text"></param>
        /// <param name="i"></param>
        /// <param name="flag"></param>
        internal static bool IsNecessaryElement(string text, int i, int flag)
        {
            return Char.IsDigit(text[i + flag]);
        }
    }
}
