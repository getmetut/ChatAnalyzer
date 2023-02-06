using System.Text;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    internal class AnalyzeNextWords
    {
        public static void Analyze(string phrase, bool isPersonal, int amount, int minRepeat)
        {
            minRepeat--;
            string[] words = phrase.Split(' ');
            if (isPersonal)
            {
                // создаем перменные списков и числители
                var list1 = ChatInfoTemp.WordListP1;
                list1[0] = "";
                for (int i = 2; i < list1.Count; i++)
                    try
                    {
                        if (Equals(list1[i], ChatInfo.InitialP1) && TextFunctions.IsTime(list1[i + 1])
                            || TextFunctions.IsNecName(list1, i, ChatInfo.FullNameP1))
                            list1[i] = "";
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        break;
                    }
                list1.RemoveAll(String.IsNullOrWhiteSpace);

                for (int i = 0; i < list1.Count; i++)
                {
                    list1[i] = TextFunctions.OnlyText(list1[i]).ToLower();
                    if (Constants.tExeptNoInit.Contains(list1[i]))
                        list1[i] = "";
                }
                list1.RemoveAll(String.IsNullOrWhiteSpace);

                var list2 = ChatInfoTemp.WordListP2;
                list2[0] = "";
                for (int i = 2; i < list2.Count; i++)
                    try
                    {
                        if (Equals(list2[i], ChatInfo.InitialP2) && TextFunctions.IsTime(list2[i + 1])
                            || TextFunctions.IsNecName(list2, i, ChatInfo.FullNameP2))
                            list2[i] = "";
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        break;
                    }
                list2.RemoveAll(String.IsNullOrWhiteSpace);

                for (int i = 0; i < list2.Count; i++)
                {
                    list2[i] = TextFunctions.OnlyText(list2[i]).ToLower();
                    if (Constants.tExept.Contains(list2[i]))
                        list2[i] = "";
                }
                list2.RemoveAll(String.IsNullOrWhiteSpace);

                // делим словосочитание на слова и создаем список в который будем записывать совпадения
                List<string> coincidences1 = new();
                // находим совпадение первого слова сс
                int num = list1.IndexOf(words[0]);
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
                            if (!Equals(list1[num], words[j]))
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
                                newConc += list1[j] + " ";
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            break;
                        }
                        coincidences1.Add(newConc.Trim());
                    }

                    // ищем новое совпадение
                    num = list1.IndexOf(words[0], num);
                }

                List<string> coincidences2 = new();
                num = list2.IndexOf(words[0]);
                while (num > 0)
                {
                    bool flag = true;
                    num++;
                    for (int j = 1; j < words.Length; j++)
                    {
                        try
                        {
                            if (!Equals(list2[num], words[j]))
                                flag = false;
                            num++;

                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            break;
                        }
                    }

                    if (flag)
                    {
                        string newConc = "";
                        try
                        {
                            for (int j = num; j < num + amount; j++)
                                newConc += list2[j] + " ";
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            break;
                        }
                        coincidences2.Add(newConc.Trim());
                    }

                    num = list2.IndexOf(words[0], num);
                }

                var top1 = TextFunctions.CreateDictionary(coincidences1);
                var top2 = TextFunctions.CreateDictionary(coincidences2);

                AnalysisResult.TextPerson1 = $"Словосочитание\\слово:\n{phrase}\n\n";
                AnalysisResult.TextPerson2 = $"Словосочитание\\слово:\n{phrase}\n\n";

                StringBuilder result = new();
                var sortedTop1 = top1.Where(t => t.Value > minRepeat).OrderByDescending(t => t.Value);
                var sortedTop2 = top2.Where(t => t.Value > minRepeat).OrderByDescending(t => t.Value);

                foreach (var item in sortedTop1)
                    result.Append($"{$"{item.Value}".PadRight(7, '-')}{item.Key}\n");
                AnalysisResult.TextPerson1 += result.ToString();

                result.Clear();
                foreach (var item in sortedTop2)
                    result.Append($"{$"{item.Value}".PadRight(7, '-')}{item.Key}\n");
                AnalysisResult.TextPerson2 += result.ToString();

            }
            else
            {
                var list = ChatInfoTemp.WordList;
                for (int i = 2; i < list.Count; i++)
                    try
                    {
                        if (Equals(list[i], ChatInfo.InitialP1) && TextFunctions.IsTime(list[i + 1])
                            || Equals(list[i], ChatInfo.InitialP2) && TextFunctions.IsTime(list[i + 1])
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

                List<string> coincidences = new();
                int num = list.IndexOf(words[0]);
                while (num > 0)
                {
                    bool flag = true;
                    num++;
                    for (int j = 1; j < words.Length; j++)
                    {
                        try
                        {
                            if (!Equals(list[num], words[j]))
                                flag = false;
                            num++;

                        }
                        catch (Exception e)
                        {
                            break;
                        }
                    }

                    if (flag)
                    {
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

                    num = list.IndexOf(words[0], num);
                }

                var top = TextFunctions.CreateDictionary(coincidences);

                AnalysisResult.Text = $"Словосочитание\\слово:\n{phrase}\n\n";

                StringBuilder result = new();
                var sortedTop = top.Where(t => t.Value > minRepeat).OrderByDescending(t => t.Value);

                foreach (var item in sortedTop)
                    result.Append($"{$"{item.Value}".PadRight(7, '-')}{item.Key}\n");
                AnalysisResult.Text += result.ToString();
            }
        }
    }

    public partial class Index : Form
    {
        internal void buttonAnalyzeNextWords_Click(object sender, EventArgs e)
        {
            if (ChatInfo.Text != null)
            {
                ChatInfoTemp.RefreshTemp();
                Analyze.AnalyzeNextWordsDialog aWD = new(new IndexKindAnalyze(ShowResult));
                aWD.ShowDialog();
            }
        }
    }
}