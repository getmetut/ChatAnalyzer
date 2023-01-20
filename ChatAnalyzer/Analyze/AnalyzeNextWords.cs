using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChatAnalyzer.Program;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    internal class AnalyzeNextWords
    {
        public static void Analyze(string phrase, bool isPersonal, int amount, int minRepeat)
        {
            string[] words = phrase.Split(' ');
            if (isPersonal)
            {
                // создаем перменные списков и числители
                var list1 = ChatInfoTemp.WordListP1;
                for (int i = 0; i < list1.Count; i++)
                    list1[i] = TextFunctions.OnlyText(list1[i]).ToLower();
                list1.RemoveAll(String.IsNullOrWhiteSpace);
                list1.RemoveAll(x => Equals(x, ChatInfo.InitialP1.ToLower())
                    | Equals(x, TextFunctions.OnlyText(ChatInfo.FullNameP1.ToLower())) | Constants.tExept.Contains(x));

                var list2 = ChatInfoTemp.WordListP2;
                for (int i = 0; i < list2.Count; i++)
                    list2[i] = TextFunctions.OnlyText(list2[i]).ToLower();
                list2.RemoveAll(String.IsNullOrWhiteSpace);
                list2.RemoveAll(x => Equals(x, ChatInfo.InitialP2.ToLower())
                    | Equals(x, TextFunctions.OnlyText(ChatInfo.FullNameP2.ToLower())) | Constants.tExept.Contains(x));

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
                        if (!Equals(list1[num], words[j]))
                            flag = false;
                        num++;
                    }
                    // если все ок
                    if (flag)
                    {
                        // записываем в список слова следующие за нужным словосочитанием
                        string newConc = "";
                        for (int j = num; j < num + amount; j++)
                            newConc += list1[j] + " ";
                        coincidences1.Add(newConc);
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
                        if (!Equals(list2[num], words[j]))
                            flag = false;
                        num++;
                    }

                    if (flag)
                    {
                        string newConc = "";
                        for (int j = num; j < num + amount; j++)
                            newConc += list2[j] + " ";
                        coincidences2.Add(newConc);
                    }

                    num = list2.IndexOf(words[0], num);
                }

                var top1 = TextFunctions.CreateDictionary(coincidences1);
                var top2 = TextFunctions.CreateDictionary(coincidences2);

                AnalyzeResult.TextPerson1 = $"\nСловосочитание\\слово:\n{phrase}\n\n";
                AnalyzeResult.TextPerson2 = $"\nСловосочитание\\слово:\n{phrase}\n\n";

                StringBuilder result = new();
                var sortedTop1 = top1.Where(t => t.Value > minRepeat).OrderByDescending(t => t.Value);
                var sortedTop2 = top2.Where(t => t.Value > minRepeat).OrderByDescending(t => t.Value);

                foreach (var item in sortedTop1)
                    result.Append($"{$"{item.Value}".PadRight(7, '-')}{item.Key}\n");
                AnalyzeResult.TextPerson1 += result.ToString();

                result.Clear();
                foreach (var item in sortedTop2)
                    result.Append($"{$"{item.Value}".PadRight(7, '-')}{item.Key}\n");
                AnalyzeResult.TextPerson2 += result.ToString();

            }
            else
            {
                var list = ChatInfoTemp.WordList;
                List<string> coincidences = new();

                for (int i = 0; i < list.Count; i++)
                    list[i] = TextFunctions.OnlyText(list[i]).ToLower();
                list.RemoveAll(String.IsNullOrWhiteSpace);
                list.RemoveAll(x => Equals(x, ChatInfo.InitialP1.ToLower())
                    | Equals(x, TextFunctions.OnlyText(ChatInfo.FullNameP1.ToLower())) | Constants.tExept.Contains(x));

                int num = list.IndexOf(words[0]);
                while (num > 0)
                {
                    bool flag = true;
                    num++;
                    for (int j = 1; j < words.Length; j++)
                    {
                        if (!Equals(list[num], words[j]))
                            flag = false;
                        num++;
                    }

                    if (flag)
                    {
                        string newConc = "";
                        for (int j = num; j < num + amount; j++)
                            newConc += list[j] + " ";
                        coincidences.Add(newConc);
                    }

                    num = list.IndexOf(words[0], num);
                }

                var top = TextFunctions.CreateDictionary(coincidences);

                AnalyzeResult.Text = $"Словосочитание\\слово:\n{phrase}\n\n";

                StringBuilder result = new();
                var sortedTop = top.Where(t => t.Value > minRepeat).OrderByDescending(t => t.Value);

                foreach (var item in sortedTop)
                    result.Append($"{$"{item.Value}".PadRight(7, '-')}{item.Key}\n");
                AnalyzeResult.Text += result.ToString();
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