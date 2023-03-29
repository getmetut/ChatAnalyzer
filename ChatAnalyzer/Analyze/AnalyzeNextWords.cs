using System.Text;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    internal class AnalyzeNextWords
    {
        public static IEnumerable<KeyValuePair<string, int>> Analyze(string phrase, List<string> list, int amount, int minRepeat)
        {
            // убавляем минимальное количетво повторений шобы совпадало, то что ввел пользак и работа алгоритма
            minRepeat--;
            string[] words = phrase.Split(' ');
            // чистим список от мусора
            TextFunctions.CleanAndNormalizeList(list, new char[] { '-' }, Constants.tExept);

            // делим словосочитание на слова и создаем список в который будем записывать совпадения
            List<string> coincidences = new();
            // находим совпадение первого слова сс
            int num = list.IndexOf(words[0]);
            while (num > 0)
            {
                // если этот флаг ложен значит, серия совпадений прервалась
                bool flag = true;
                num++;
                // начинаем проверку
                for (int j = 1; j < words.Length; j++)
                {
                    try
                    {
                        if (!Equals(list[num], words[j]))
                            flag = false;
                        num++;
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        break;
                    }
                }
                // если все ок
                if (flag)
                {
                    // записываем в список слова следующие за нужным словосочитанием
                    string newConc = "";
                    try
                    {
                        for (int j = num; j < num + amount; j++)
                            newConc += list[j] + " ";
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        break;
                    }
                    coincidences.Add(newConc.Trim());
                }

                // ищем новое совпадение
                num = list.IndexOf(words[0], num);
            }

            var top = TextFunctions.CreateDictionary(coincidences);
            var sortedtop = top.Where(t => t.Value > minRepeat).OrderByDescending(t => t.Value);

            return sortedtop;
        }
    }

    public partial class Index : Form
    {
        internal void buttonAnalyzeNextWords_Click(object sender, EventArgs e)
        {
            if (ChatInfo.WordList != null)
            {
                ChatInfoTemp.Refresh();
                Analyze.AnalyzeNextWordsDialog aWD = new(new ShowDeleagat(ShowResult));
                aWD.ShowDialog();
            }
        }
    }
}