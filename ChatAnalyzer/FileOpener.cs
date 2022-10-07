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
        internal static string[] ChatNames(string text)
        {
            // вычисляем инициалы
            string[] names = new string[4];
            int i = text.IndexOf("initials");
            if (i != -1)
            {
                while (!Equals(text[i], '>'))
                    i++;
                i++;

                names[0] = text.Substring(i, 5).Trim();

                int j = text.IndexOf("initials", i);
                while (!Equals(text[j], '>'))
                    j++;
                j++;

                names[1] = text.Substring(j, 5).Trim();
            }
            else
            {
                MessageBox.Show("Вы открыли неподходяший файл. Персональный вид анализа будет недоступен или анализ будет работать некорректно", "Предупреждение");
            }

            // вычисляем полные имена
            names[2] = TextFunctions.GetWord(text, text.IndexOf(names[0]) + names[0].Length + 7);
            for (int j = 1; j < names[0].Length; j++)
            {
                names[2] += $" {TextFunctions.GetWord(text, text.IndexOf(names[0]) + names[0].Length + 8 + names[2].Length)}";
            }
            names[3] = TextFunctions.GetWord(text, text.IndexOf(names[1]) + names[1].Length + 7);
            for (int j = 1; j < names[1].Length; j++)
            {
                names[3] = $" {TextFunctions.GetWord(text, text.IndexOf(names[1]) + names[1].Length + 8 + names[3].Length)}";
            }

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
            string[] names = FileOpener.ChatNames(File.ReadAllText(filenames[0]));
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
            if (names != null)
            {
                ChatInfo.InitialsPerson1 = names[0];
                ChatInfo.InitialsPerson2 = names[1];
                ChatInfo.FullNamePerson1 = names[2];
                ChatInfo.FullNamePerson2 = names[3];

                // исключаем из текста полные имена
                int index1 = ChatInfo.Text.IndexOf(names[2]), index2 = ChatInfo.Text.IndexOf(names[3]);
                while (index1 != -1 && index2 != -1)
                {
                    if (TextFunctions.IsNecessaryElement(ChatInfo.Text, index1, -1))
                    {
                        ChatInfo.Text.Remove(index1, names[2].Length);
                        index1 = ChatInfo.Text.IndexOf(names[2], index1 + 1);
                    }
                    else
                    {
                        index1 = ChatInfo.Text.IndexOf(names[2], index1 + 1);
                    }

                    if (TextFunctions.IsNecessaryElement(ChatInfo.Text, index1, -1))
                    {
                        ChatInfo.Text.Remove(index1, names[3].Length);
                        index2 = ChatInfo.Text.IndexOf(names[3], index2 + 1);
                    }
                    else
                    {
                        index2 = ChatInfo.Text.IndexOf(names[3], index2 + 1);
                    }
                }
            }

            ChatInfoTemp.Text = ChatInfo.Text;
        }
    }
}