using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Text.RegularExpressions;

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
        internal static string JustFileName(string fileName)
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
            StringBuilder sb = new ();
            foreach (var t in fSplit)
            {
                // проверяем на отстутсвие текста, если его нет то пропускаем, есть записываем
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
        internal static string[] ChatInitsNames(List<string> wordsList)
        {
            // создаем массив первые два элемента инициалы вторые имена
            string[] initsNames = new string[4];
            // начием идти по всем словам листа
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
                listBoxChats.Items.Add(FileOpener.JustFileName(filename));
                // чистим текст от дивов и пробелов
                fileText = FileOpener.CleanText(fileText);
                text.Append(fileText);
            }

            // запоминаем list и чиcтим стринг билдер шобы пересобрать его уже без имен
            List<string> newList = text.ToString().Split(" ").ToList();
            text.Clear();

            // получаем инициалы и полные имена
            string[] initsNames = new string[4];
            if (ChatInfo.InitialsPerson1 == null || ChatInfo.InitialsPerson1 == null
                || ChatInfo.InitialsPerson1 == null || ChatInfo.InitialsPerson1 == null)
            {
                initsNames = FileOpener.ChatInitsNames(newList);
                ChatInfo.InitialsPerson1 = initsNames[0];
                ChatInfo.InitialsPerson2 = initsNames[1];
                ChatInfo.FullNamePerson1 = initsNames[2];
                ChatInfo.FullNamePerson2 = initsNames[3];
            }
           
            // записываем лист в статику 
            if (ChatInfo.WordsList == null)
                ChatInfo.WordsList = newList;
            else
                foreach (var word in newList)
                    ChatInfo.WordsList.Add(word);

            // пересобираем текст и записываем в сnатику его и словарь
            foreach (string word in newList)
                text.Append(" " + word);

            ChatInfo.Text += text.ToString();
            ChatInfo.WordsDictionary = TextFunctions.CreateDictionary(ChatInfo.Text, Constants.tExept);

            // считаем полные имена в тексте а потом присваиваем посчитаное количество в словаре
            TextFunctions.AccountFullNames(ChatInfo.WordsList, ChatInfo.WordsDictionary);

            // Флаг обозначающий что, произошло добавление
            ChatInfo.NewAdded = true;
        }
    }
}