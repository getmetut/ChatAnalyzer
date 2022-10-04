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

        internal static string JustFileName(string fileName)
        {
            int lastSeparator = fileName.LastIndexOf('\\');
            return fileName.Substring(lastSeparator + 1);
        }

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

        internal static string[] ChatNames(string text)
        {
            string[] names = new string[2];
            int i = text.IndexOf("initials");
            if (i != -1)
            {
                while (!Equals(text[i], '>'))
                    i++;
                i++;

                names[0] = text.Substring(i, 5);

                int j = text.IndexOf("initials", i);
                while (!Equals(text[j], '>'))
                    j++;
                j++;

                names[1] = text.Substring(j, 5);

                names[0] = names[0].Trim();
                names[1] = names[1].Trim();

            }
            else
            {
                MessageBox.Show("Вы открыли неподходяший файл. Персональный вид анализа будет недоступен или анализ будет работать некорректно", "Предупреждение");
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
            string text = "";
            // читаем файлы в строку и записываем в список их имена
            foreach (string filename in filenames)
            {
                string fileText = File.ReadAllText(filename);
                listBoxChats.Items.Add(FileOpener.JustFileName(filename));
                // чистим текст от дивов и пробелов
                fileText = FileOpener.CleanText(fileText);
                text += fileText;
            }
            // записываем их во временный файл
            if (listBoxChats.Items == null)
            {
                File.WriteAllText("temp\\text.txt", text.ToString(), Encoding.Unicode);
            }
            else
            {
                File.AppendAllText("temp\\text.txt", text.ToString(), Encoding.Unicode);
            }
            // записываем все в класс
            ChatInfo.Person1 = names[0];
            ChatInfo.Person2 = names[1];
            ChatInfo.Text = text;
        }
    }
}




