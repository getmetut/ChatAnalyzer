using System.Text;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    internal class AnalyzeNextWords
    {
        public static IEnumerable<KeyValuePair<string, int>> Analyze(string phrase, List<string> list, int amount, int minRepeat)
        {
            minRepeat--;
            string[] words = phrase.Split(' ');
            list[0] = "";
            for (int i = 2; i < list.Count; i++)
                try
                {
                    if ((Equals(list[i], ChatInfo.InitialP1) || Equals(list[i], ChatInfo.InitialP2)) && TextFunctions.IsTime(list[i + 1])
                        || TextFunctions.IsNecName(list, i, ChatInfo.FullNameP1) || TextFunctions.IsNecName(list, i, ChatInfo.FullNameP2))
                        list[i] = "";
                }
                catch (ArgumentOutOfRangeException e)
                {
                    break;
                }
            list.RemoveAll(String.IsNullOrWhiteSpace);

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = TextFunctions.OnlyText(list[i]).ToLower();
                if (Constants.tExeptNoInit.Contains(list[i]))
                    list[i] = "";
            }
            list.RemoveAll(String.IsNullOrWhiteSpace);

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
            if (ChatInfo.Text != null)
            {
                ChatInfoTemp.RefreshTemp();
                Analyze.AnalyzeNextWordsDialog aWD = new(new ShowResultD(ShowResult));
                aWD.ShowDialog();
            }
        }
    }
}