using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    internal static class TextFunctions
    {
        /// <summary>
        /// Создает словарь всех слов в тексте.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        internal static Dictionary<string, int> CreateDictionary(string text, string[] exept)
        {
            var top = new Dictionary<string, int>();
            string[] words = text.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i].Trim();
                if (TextFunctions.IsTime(word))
                    continue;
                word = OnlyText(word);
                if (top.ContainsKey(word = word.Trim()))
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

            top["-"] = 0;

            return top;
        }

        internal static Dictionary<string, int> CreateDictionary(List<string> list)
        {
            var top = new Dictionary<string, int>();
          //  string[] words = text.ToLower().Split(' ');
            for (int i = 0; i < list.Count; i++)
            {
                var element = list[i].Trim();
                if (top.ContainsKey(element))
                {
                    top[element]++;
                }
                else
                {
                    top[element] = 1;
                }
            }
            return top;
        }

        /// <summary>
        /// Функция читстит получаему строку от знаков припинания
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        internal static string OnlyText(string s)
        {
            string snew = "";
            for (int j = 0; j < s.Length; j++)
                if (Char.IsLetter(s[j]) || Equals(s[j], '-'))
                    snew += s[j];
            return snew;
        }

        /// <summary>
        /// Функция получает строку и номер элемента и начная с этого элемента записывает слово и возвращает его.
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
        /// проверяет является ли элемент временем формата XX:XX.
        /// </summary>
        /// <param name="wordsList"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        internal static bool IsTime(string word)
        {
            return word.Length == 5 && Char.IsDigit(word[0]) && Char.IsDigit(word[1]) && Char.IsPunctuation(word[2]) &&
                Char.IsDigit(word[3]) && Char.IsDigit(word[4]);
        }

        internal static bool IsDate(string word)
        {
            return word.Length == 10 && Char.IsDigit(word[0]) && Char.IsDigit(word[1]) && Char.IsPunctuation(word[2]) &&
                Char.IsDigit(word[3]) && Char.IsDigit(word[4]);
        }
        /// <summary>
        /// Присвоение именам в словаре нужного количества.
        /// </summary>
        /// <param name="dict"></param>
        internal static void AssignFullNames(Dictionary<string, int> dict, string name, int сount)
        {
            var nameMas = name.Split(' ');

            for (int i = 0; i < nameMas.Length; i++)
                if (dict.ContainsKey(nameMas[i].ToLower()))
                    dict[nameMas[i].ToLower()] -= сount;
        }

        /// <summary>
        /// Подсчет нужных имен.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static int NecNamesCount(List<string> list, string name)
        {
            int count = 0;


            for (int i = 2; i < list.Count; i++)
                try
                {
                    if (IsNecName(list, i, name))
                    {
                        count++;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                }
            return count;
        }

        internal static bool IsNecName(List<string> list, int i, string name)
        {
            return (Equals(list[i], name)
                    & (TextFunctions.IsTime(list[i - 1]) || TextFunctions.IsDate(list[i + 1]) || Equals(list[i - 1], "Data")
                    || Equals(list[i + 1], "Declined") || Equals(list[i + 1], "Missed") || Equals(list[i + 1], "Cancelled")
                    || Equals(list[i + 1], "Outgoing") || Equals(list[i + 1], "Incoming") || Equals(list[i + 1], "pinned")
                    || Equals(list[i - 1], "list") || Equals(list[i + 1], "changed") || Equals(list[i - 2], "Exported")));
        }

        /// <summary>
        /// Подсчет и присвоение полных имен.
        /// </summary>
        /// <param name="newList"></param>
        internal static void AccountFullNames(List<string> newList, Dictionary<string, int> dict)
        {
            var name1 = ChatInfo.FullNameP1;
            var name2 = ChatInfo.FullNameP2;
            var unite = UniteFullNames(newList, name1);
            unite = UniteFullNames(unite, name2);
            int count1 = TextFunctions.NecNamesCount(unite, name1);
            int count2 = TextFunctions.NecNamesCount(unite, name2);
            TextFunctions.AssignFullNames(dict, name1, count1);
            TextFunctions.AssignFullNames(dict, name2, count2);
            newList.RemoveAll(String.IsNullOrWhiteSpace);
        }

        /// <summary>
        /// Слияния полных имен в единый элемент списка.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static List<string> UniteFullNames(List<string> list, string name) 
        {
            List<string> unite = list;
            var nameMas = name.Split(' ');


            for (int i = 0; i < unite.Count; i++)
            {
                if (Equals(nameMas[0], unite[i]))
                {
                    try
                    {
                        bool flag = true;
                        for (int j = 0; j < nameMas.Length; j++)

                            if (!Equals(unite[i + j], nameMas[j]))
                                flag = false;


                        if (flag)
                        {
                            for (int j = 1; j < nameMas.Length; j++)
                            {
                                unite[i] += $" {nameMas[j]}";
                                unite[i + j] = "";
                            }
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        break;
                    }
                }
            }

            return unite;
        }
    }
}
