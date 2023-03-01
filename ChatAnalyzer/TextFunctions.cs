using System.Diagnostics.Metrics;
using System.Text;

namespace ChatAnalyzer
{
    internal static class TextFunctions
    {
        /// <summary>
        /// Возвращает словарь сдланынй на основе списка, исключая из него строки из указанного массива.
        /// </summary>
        /// <param name="list">Входной список</param>
        /// <param name="exept">Массив строк для исключения</param>
        /// <returns></returns>
        internal static Dictionary<string, int> CreateDictionary(List<string> list, string[] exept)
        {
            char[] exeptChar = { '-', ' ' };
            var top = new Dictionary<string, int>();
            foreach (string word in list)
            {
                string nword = word.Trim().ToLower();
                if (TextFunctions.IsTime(nword))
                    continue;
                nword = OnlyText(nword, exeptChar).Trim();
                if (top.ContainsKey(nword))
                {
                    top[nword]++;
                }
                else
                {
                    top[nword] = 1;
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
        /// Возвращает словарь сдланынй на основе списка.
        /// </summary>
        /// <param name="list">Входной писок</param>
        /// <returns></returns>
        internal static Dictionary<string, int> CreateDictionary(List<string> list)
        {
            var top = new Dictionary<string, int>();
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
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="exeptChars"></param>
        /// <param name="exeptWords"></param>
        /// <returns></returns>
        internal static void CleanAndNormalizeList(List<string> list, char[] exeptChars, string[] exeptWords)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = TextFunctions.OnlyText(list[i].Trim(), exeptChars).ToLower();
                if (exeptWords.Contains(list[i]))
                {
                    list[i] = "";
                    continue;
                }
            }

            list.RemoveAll(String.IsNullOrWhiteSpace);
        }
        /// <summary>
        /// Функция читстит получаему строку от всего помимо букв, и указанных в массиве знаков
        /// </summary>
        /// <param name="s"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        internal static string OnlyText(string s, char[] chars)
        {
            string snew = "";
            for (int j = 0; j < s.Length; j++)
                if (Char.IsLetter(s[j]) || chars.Contains(s[j]))
                    snew += s[j];
            return snew;
        }

        /// <summary>
        /// Gроверяет является ли элемент временем формата XX:XX.
        /// </summary>
        /// <param name="wordsList"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        internal static bool IsTime(string word)
        {
            return word.Length == 5 && Char.IsDigit(word[0]) && Char.IsDigit(word[1]) && Char.IsPunctuation(word[2]) &&
                Char.IsDigit(word[3]) && Char.IsDigit(word[4]);
        }

        /// <summary>
        /// проверяет является ли строка датой формата ХХ.ХХ.ХХХХХ
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        internal static bool IsDate(string word)
        {
            return word.Length == 10 && Char.IsDigit(word[0]) && Char.IsDigit(word[1]) && Char.IsPunctuation(word[2]) &&
                Char.IsDigit(word[3]) && Char.IsDigit(word[4]);
        }

        /// <summary>
        /// Слияния полных имен в единый элемент списка 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static List<string> UniteFullNames(List<string> list, string name)
        {
            var nameMas = name.Split(' ');

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (Equals(nameMas[0], list[i]))
                {
                    try
                    {
                        bool flag = true;
                        for (int j = 0; j < nameMas.Length; j++)

                            if (!Equals(list[i + j], nameMas[j]))
                                flag = false;


                        if (flag)
                        {
                            for (int j = 1; j < nameMas.Length; j++)
                            {
                                list[i] += $" {nameMas[j]}";
                                list[i + j] = "";
                            }
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        break;
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Подсчет нужных имен и их тегирование (а так же тегирование инициалов), а еще индексирование)), засунул все в одну функцию чтобы все проиходило за один цикл
        /// </summary>
        /// <param name="list"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static int[] GetNecNamesCountAndTaggingAndIndexing(List<string> list, out List<int> idxs, string[] names)
        {
            int[] count = new int[names.Length]; string[] arrName; idxs = new();

            for (int i = 2; i < list.Count; i++)
                try
                {
                    // Тегаем имя и записываем его индекс
                    if (IsNecName(list, i, names))
                    {
                        count[names.ToList().IndexOf(list[i])]++;
                        list[i] += "-name";
                        idxs.Add(i);
                    }
                    else
                    // Разъеденяем не нужные имена
                    if (names.Contains(list[i]))
                    {
                        arrName = list[i].Split(' ');
                        for (int j = 1; i < arrName.Length; i++)
                            list[i + j] = arrName[j];
                        list[i] = arrName[0];
                    }
                        
                    // Тегаем инициалы
                    if ((Equals(list[i], ChatInfo.InitialP1) || Equals(list[i], ChatInfo.InitialP2)) && TextFunctions.IsTime(list[i + 1]))
                        list[i] += "-init";
                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                }
            return count;
        }

        internal static int GetNecNamesCountAndIndexing(List<string> list, ref List<int> idxs, out string name)
        {
            int count = 0;
            name = list.First(el => el.EndsWith("-name"));

            for (int i = 0; i < list.Count; i++)
                try
                {
                    if (Equals(name, list[i]))
                    {
                        idxs.Add(i);
                        count++;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                }
            return count;
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
        /// Вычисляем системмное ли это имя
        /// </summary>
        /// <param name="list"></param>
        /// <param name="i"></param>
        /// <param name="names"></param>
        /// <returns></returns>
        internal static bool IsNecName(List<string> list, int i, string[] names)
        {
            return (names.Contains(list[i])
                    && (TextFunctions.IsTime(list[i - 1]) || TextFunctions.IsDate(list[i + 1]) || Equals(list[i - 1], "Data")
                    || Equals(list[i + 1], "Declined") || Equals(list[i + 1], "Missed") || Equals(list[i + 1], "Cancelled")
                    || Equals(list[i + 1], "Outgoing") || Equals(list[i + 1], "Incoming") || Equals(list[i + 1], "pinned")
                    || Equals(list[i - 1], "list") || Equals(list[i + 1], "changed") || Equals(list[i - 2], "Exported")));
        }

        internal static bool IsNecName(List<string> list, int i, string name)
        {
            return (Equals(list[i], name)
                    && (TextFunctions.IsTime(list[i - 1]) || TextFunctions.IsDate(list[i + 1]) || Equals(list[i - 1], "Data")
                    || Equals(list[i + 1], "Declined") || Equals(list[i + 1], "Missed") || Equals(list[i + 1], "Cancelled")
                    || Equals(list[i + 1], "Outgoing") || Equals(list[i + 1], "Incoming") || Equals(list[i + 1], "pinned")
                    || Equals(list[i - 1], "list") || Equals(list[i + 1], "changed") || Equals(list[i - 2], "Exported")));
        }

        /// <summary>
        /// Подсчет, тэгирование, индексирование и присвоение нового значения в словаре.
        /// </summary>
        /// <param name="newList"></param>
        internal static void AccountFullNames(List<string> list, Dictionary<string, int> dict, List<int> idxs, string[] names)
        {
            List<string> newList = list; ;
            foreach (string name in names)
            {
                newList = UniteFullNames(newList, name);
            }
            
            int[] counts = GetNecNamesCountAndTaggingAndIndexing(newList, out idxs, names);

            foreach (string name in names)
            {
                foreach (int count in counts)
                {
                    AssignFullNames(dict, name, count);
                }
            }
            newList.RemoveAll(String.IsNullOrWhiteSpace);
        }

        internal static void AccountFullNames(List<string> list, Dictionary<string, int> dict, ref List<int> idxs)
        {
            string name;
            int count = GetNecNamesCountAndIndexing(list, ref idxs, out name);
            AssignFullNames(dict, name, count);
            list.RemoveAll(String.IsNullOrWhiteSpace);
        }
    }
}