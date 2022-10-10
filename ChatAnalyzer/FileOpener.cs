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
        /// <param name="fileName"></param>
        /// <returns></returns>
        internal static string JustFileName(string fileName)
        {
            int lastSeparator = fileName.LastIndexOf('\\');
            return fileName[(lastSeparator + 1)..];
        }
        /// <summary>
        /// функция отчистки текста от дивов и пробелов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string CleanText(string text)
        {
            int first, amount;
            while (text.IndexOf('<') != -1)
            {
                first = text.IndexOf('<');
                amount = text.IndexOf('>') - first + 1;
                text = text.Remove(first, amount);
            }
            text = Regex.Replace(text, @"\s+", " ");

            return text;
        }

        /// <summary>
        /// функция определения инициалов и полных имен
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string[] ChatInits(string text)
        {
            // вычисляем инициалы
            string[] inits = new string[2];
            int i = text.IndexOf("initials");
            if (i != -1)
            {
                while (!Equals(text[i], '>'))
                    i++;
                i++;

                inits[0] = text.Substring(i, 5).Trim();

                int j = text.IndexOf("initials", i);
                while (!Equals(text[j], '>'))
                    j++;
                j++;

                inits[1] = text.Substring(j, 5).Trim();
            }
            else
            {
                MessageBox.Show("Вы открыли неподходяший файл. Персональный вид анализа будет недоступен или анализ будет работать некорректно", "Предупреждение");
            }

            return inits;
        }

        /// <summary>
        /// вычислем полные имена
        /// </summary>
        /// <param name="text"></param>
        /// <param name="inits"></param>
        /// <returns></returns>
        internal static string[] ChatFullNames(List<string> wordsList, string[] inits)
        {
            string[] names = new string[2] {"", ""};
            for(int i = 2; i < wordsList.Count; i++)
            {
                if (TextFunctions.IsNecessaryElementString(wordsList.ToArray(), i, -2, inits[0]))
                {
                    for(int j = 0; j < inits[0].Length; j++)
                    {
                        names[0] += " " + wordsList[i + j];
                    }
                    break;
                }
            }

            for (int i = 2; i < wordsList.Count; i++)
            {
                if (TextFunctions.IsNecessaryElementString(wordsList.ToArray(), i, -2, inits[1]))
                {
                    for (int j = 0; j < inits[1].Length; j++)
                    {
                        names[1] += " " + wordsList[i + j];
                    }
                    break;
                }
            }

            names[0].Trim();
            names[1].Trim();
            return names;
        }
    }

    public partial class Index : Form
    {
        void buttonChatsAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // объект обработчика открытых файлов
            // получаем выбранные файлы
            string[] filenames = openFileDialog1.FileNames;
            // получаем инициалы
            string[] inits = FileOpener.ChatInits(File.ReadAllText(filenames[0]));
            // создаем строку для объеденения файлов
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

            // записываем все в класс
            ChatInfo.Text = text.ToString();
            text.Clear();
            ChatInfo.WordsList = ChatInfo.Text.Split(" ").ToList();
            string[] names = FileOpener.ChatFullNames(ChatInfo.WordsList, inits);

            if (names != null)
            {
                ChatInfo.InitialsPerson1 = inits[0];
                ChatInfo.InitialsPerson2 = inits[1];
                ChatInfo.FullNamePerson1 = names[0];
                ChatInfo.FullNamePerson2 = names[1];

                // исключаем из текста полные имена
                text.Append(ChatInfo.WordsList[0]).Append(ChatInfo.WordsList[1]);
                for (int i = 2; i < ChatInfo.WordsList.Count; i++)
                {
                    if (TextFunctions.IsNecessaryElementString(ChatInfo.WordsList.ToArray(), i, -2, inits[1]))
                    {
                        ChatInfo.WordsList.Remove(ChatInfo.WordsList[i]);
                    }
                    else
                    {
                        text.Append(ChatInfo.WordsList[i] + " ");
                    }
                }
                ChatInfo.Text = text.ToString().Trim();
            }
        }
    }
}