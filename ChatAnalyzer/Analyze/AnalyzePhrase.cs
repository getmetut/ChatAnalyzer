using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    internal class AnalyzePhrase
    {
        public static void Analyze(string phrase, bool isPersonal)
        {
            // чистим словосочтиание и делим его на слова
            TextFunctions.OnlyText(phrase);
            string[] words = phrase.Split(' ');
            if (isPersonal)
            {
                // создаем перменные списков и числители
                var list1 = ChatInfoTemp.WordListP1;
                for (int i = 0; i < list1.Count; i++)
                    list1[i] = TextFunctions.OnlyText(list1[i]).ToLower();
                var list2 = ChatInfoTemp.WordListP2;
                for (int i = 0; i < list2.Count; i++)
                    list2[i] = TextFunctions.OnlyText(list2[i]).ToLower();
                float count1 = 0, count2 = 0;
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
                    // если все ок, увеличиваем количество совпадений
                    if (flag)
                        count1++;
                    // ищем новое совпадение
                    num = list1.IndexOf(words[0], num);
                }

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
                        count2++;
                    num = list2.IndexOf(words[0], num);
                }

                float per1 = count1 / (count1 + count2);
                float per2 = count2 / (count1 + count2);

                AnalyzeResult.TextPerson1 = $"\nСловосочитание:\n{phrase}\n\n" +
                    $"Общее колчичество повторений: \n{count1}\n\n" +
                    $"Процент от общего употребления в переписке: \n{per1 * 100:F2}%\n\n";

                AnalyzeResult.TextPerson2 = $"\nСловосочитание:\n{phrase}\n\n" +
                    $"Общее колчичество повторений: \n{count2}\n\n" +
                    $"Процент от общего употребления в переписке: \n{per2 * 100:F2}%\n\n";
            }
            else
            {
                var list = ChatInfoTemp.WordList;
                int num = list.IndexOf(words[0]);
                for (int i = 0; i < list.Count; i++)
                    list[i] = TextFunctions.OnlyText(list[i]).ToLower();
                float count = 0;
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
                        count++;
                    num = list.IndexOf(words[0], num);
                }

                AnalyzeResult.Text = $"\nСловосочитание:\n{phrase}\n\n" +
                    $"Общее колчичество повторений: \n{count}\n\n";
            }
        }
    }

    public partial class Index : Form
    {
        internal void buttonAnalyzePhrase_Click(object sender, EventArgs e)
        {
            if (ChatInfo.Text != null)
            {
                ChatInfoTemp.RefreshTemp();
                Analyze.AnalyzePhraseDialog aWD = new(new IndexKindAnalyze(ShowResult));
                aWD.ShowDialog();
            }
        }
    }
}
