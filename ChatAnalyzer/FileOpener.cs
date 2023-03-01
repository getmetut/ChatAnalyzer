using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using static ChatAnalyzer.ChatInfo;

namespace ChatAnalyzer
{
    internal class FileOpener
    {
        #region может пригодится
        /*    public string? WordFromEnd(string? text, int index)   МЕТОД ВОЗВРАЩАЕТ СЛОВО С КОНЦА ПО УКАЗАННОМУ ИНДЕКСУ
            {
                int last = 0, first = 0; byte flag = 0;
                if (String.IsNullOrEmpty(text) == false)
                {
                    char[] arr = text.ToCharArray();
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {

                        if (Char.IsLetter(arr[i]))
                        {
                            last = i;
                            first = i;
                            while ((first > -1) && (Char.IsLetter(arr[first])))
                            {
                                first--;
                            }
                            first++;
                            flag++;
                        }
                        else continue;

                        if (flag == index) { break; }

                        i = first;
                    }

                    if (flag < index)
                    {
                        return null;
                    }
                    else
                    {
                        string s = "";
                        for (int i = first; i <= last; i++)
                        {
                            s = String.Concat(s, arr[i]);
                        }
                        return s;
                    }
                }
                else
                {
                    return null;
                }
            } */
        #endregion
        /// <summary>
        /// функция опеределния имени файла с расширением
        /// </summary>
        /// <param names="fileName"></param>
        /// <returns></returns>
        internal static string GetJustFileName(string fileName)
        {
            int lastSeparator = fileName.LastIndexOf('\\');
            return fileName[(lastSeparator + 1)..];
        }
        /// <summary>
        /// функция отчистки текста от дивов и пробелов
        /// </summary>
        /// <param text="text"></param>
        /// <returns></returns>
        internal static string CleanText(string text)
        {
            // проводим первый спит
            var fSplit = text.Split(">");
            StringBuilder sb = new();
            foreach (var t in fSplit)
            {
                // проверяем на отстутсвие текста, если его нет то пропускаем, есть - записываем
                if (Equals(t[0], "<"))
                    continue;
                else
                {
                    var sSplit = t.Split("<");
                    sb.Append(sSplit[0]);
                }
            }
            string sbStr = sb.ToString();
            // чистим служебные символы
            sbStr = Regex.Replace(sbStr, @"\s+", " ");

            return sbStr;
        }

        /// <summary>
        /// Функция определения инициалов и полных имен
        /// </summary>
        /// <param wordsList="wordsList"></param>
        /// <returns></returns>
        internal static string[] GetChatInitsNames(List<string> wordsList)
        {
            // создаем массив первые два элемента инициалы вторые имена
            string[] initsNames = new string[4];
            // начинаем идти по всем словам листа
            for (int i = 1; i < wordsList.Count; i++)
                // находим жлемент массива который обозначает время отправки сообщения
                if (TextFunctions.IsTime(wordsList[i]))
                {
                    bool flag = true;
                    // и проверяем является ли найденный эелемент инициалами 
                    for (int j = 0; j < wordsList[i - 1].Length; j++)
                        if (!Equals(wordsList[i - 1][j], wordsList[i + j + 1][0]))
                            flag = false;
                    // если все верно записываем инициалы и имена в массив
                    if (flag)
                    {
                        initsNames[0] = wordsList[i - 1];
                        for (int j = 0; j < initsNames[0].Length; j++)
                        {
                            initsNames[2] += " " + wordsList[i + j + 1];
                        }
                        initsNames[2] = initsNames[2].Trim();
                        break;
                    }
                }

            // повторяем все но с проверкой на несовпадение с уже найдеными инициалами
            for (int i = 1; i < wordsList.Count; i++)
                if (TextFunctions.IsTime(wordsList[i]) && !Equals(wordsList[i - 1], initsNames[0]))
                {
                    bool flag = true;
                    for (int j = 0; j < wordsList[i - 1].Length; j++)
                        if (!Equals(wordsList[i - 1][j], wordsList[i + j + 1][0]))
                            flag = false;
                    if (flag)
                    {
                        initsNames[1] = wordsList[i - 1];
                        for (int k = 0; k < initsNames[1].Length; k++)
                        {
                            initsNames[3] += " " + wordsList[i + k + 1];
                        }
                        initsNames[3] = initsNames[3].Trim();
                        break;
                    }
                }
            return initsNames;
        }

        /// <summary>
        /// Счиатет количество сообщений
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static int GetMessagesCount(List<string> list)
        {
            int count = 0;
            foreach (string s in list)
                if (TextFunctions.IsTime(s))
                    count++;
            return count;
        }
    }

    public partial class Index : Form
    {
        void buttonChatsAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранные файлы
            string[] filenames = openFileDialog1.FileNames;

            // создаем стринг билдер для объеденения файлов
            StringBuilder text = new();
            // читаем файлы в строку и записываем в список их имена
            foreach (string filename in filenames)
            {
                string fileText = File.ReadAllText(filename);
                listBoxChats.Items.Add(FileOpener.GetJustFileName(filename));
                // чистим текст от дивов и пробелов
                fileText = FileOpener.CleanText(fileText);
                text.Append(fileText);
            }

            // запоминаем list и чиcтим стринг билдер шобы пересобрать его уже без имен
            List<string> newList = text.ToString().Split(" ").ToList();
            text.Clear();

            // получаем инициалы и полные имена
            string[] initsNames = new string[4];
            if (InitialP1 == null || InitialP2 == null
                || FullNameP1 == null || FullNameP2 == null)
            {
                initsNames = FileOpener.GetChatInitsNames(newList);
                InitialP1 = initsNames[0];
                InitialP2 = initsNames[1];
                FullNameP1 = initsNames[2];
                FullNameP2 = initsNames[3];
            }

            FullNameP1Tag = FullNameP1 + "-name";
            FullNameP2Tag = FullNameP2 + "-name";
            InitialP1Tag = InitialP1 + "-init";
            InitialP2Tag = InitialP2 + "-init";

            // записываем лист в статику 
            if (WordList == null)
                WordList = newList;
            else
                WordList.AddRange(newList);
            WordList.RemoveAll(String.IsNullOrWhiteSpace);

            WordDict = TextFunctions.CreateDictionary(WordList, Constants.tExept);

            // считаем полные имена в тексте а потом присваиваем посчитаное количество в словаре, а так же тегируем имена, инициалы и время сообщения 
            TextFunctions.AccountFullNames(WordList, WordDict, FullNameIndexes, new string[] {FullNameP1, FullNameP2});

            // Разбиваем текст по персоналям
            new PersonalizeText();

            //ChatActivity ca = new(WordList, Program.ChatKind.Telegram);
            //StringBuilder test = new ();
            //foreach(var item in ca.dateActivities)
            //{
            //    test.Append($"{item.Day.ToString()} - {item.Activity.ToString()}\n");
            //}
            //File.WriteAllText("1.txt", test.ToString());

            // Счиатем количество сообщений
            MessageCount = FileOpener.GetMessagesCount(WordList);
        }
    }
}