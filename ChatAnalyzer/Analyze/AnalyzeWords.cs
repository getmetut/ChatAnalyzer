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
    internal class AnalyzeWords
    {
        public static void Analyze(string str, bool isPersonal)
        {
            // создаем список массивов строк, для последующего сравнения
            string[] phrases = str.Split(',');
            List<string[]> strList = new();
            for (int i = 0; i < phrases.Length; i++)
            {
                phrases[i] = phrases[i].Trim().ToLower();
                strList.Add(phrases[i].Split(' '));
            }  

            if (isPersonal)
            {
                // создаем перменные списков
                var list1 = ChatInfoTemp.WordListP1;
                for (int i = 0; i < list1.Count; i++)
                    list1[i] = TextFunctions.OnlyText(list1[i]).ToLower();
                var list2 = ChatInfoTemp.WordListP2;
                for (int i = 0; i < list2.Count; i++)
                    list2[i] = TextFunctions.OnlyText(list2[i]).ToLower();
                string res1 = "", res2 = "";
                // начинаем цикл сравнений
                for (int i = 0; i < strList.Count; i++)
                {
                    // числители
                    float count1 = 0, count2 = 0; 
                    // находим совпадение первого слова словосочитания
                    int num = list1.IndexOf(strList[i][0]);
                    while (num > 0)
                    {
                        // если этот флаг ложен значит, серия совпадений прервалась
                        bool flag = true;
                        num++;
                        // начинаем проверку
                        for (int j = 1; j < strList[i].Length; j++)
                        {
                            if (!Equals(list1[num], strList[i][j]))
                                flag = false;
                            num++;
                        }
                        // если все ок, увеличиваем количество совпадений
                        if (flag)
                            count1++;
                        // ищем новое совпадение
                        num = list1.IndexOf(strList[i][0], num);
                    }

                    num = list2.IndexOf(strList[i][0]);
                    while (num > 0)
                    {
                        bool flag = true;
                        num++;
                        for (int j = 1; j < strList[i].Length; j++)
                        {
                            if (!Equals(list2[num], strList[i][j]))
                                flag = false;
                            num++;
                        }
                        if (flag)
                            count2++;
                        num = list2.IndexOf(strList[i][0], num);
                    }

                    float per1 = count1 / (count1 + count2);
                    float per2 = count2 / (count1 + count2);

                    /*  string text = "{\\rtfСловосочитание/слово:\\par" + TextFunctions.OnlyText(phrases[i]).Trim() +
                          "\\par" + "Повторений: " + count1 + "; Процент употребления: {\\b" + per1 + "}%\\par}";*/

                    res1 += $"{phrases[i]}  |  {count1}  |  {per1 * 100:F2}%\n";
                    res2 += $"{phrases[i]}  |  {count2}  |  {per2 * 100:F2}%\n";

                }
                AnalysisResult.TextPerson1 = $"\nСловосочитание/слово | Повторений | Процент употребления\n\n{res1}";
                AnalysisResult.TextPerson2 = $"\nСловосочитание/слово | Повторений | Процент употребления\n\n{res2}";
            }
            else
            {
                var list = ChatInfoTemp.WordList;
                for (int i = 0; i < list.Count; i++)
                    list[i] = TextFunctions.OnlyText(list[i]).ToLower();
                float count = 0; string res = "";

                for (int i = 0; i < strList.Count; i++)
                {
                    int num = list.IndexOf(strList[i][0]);
                    while (num > 0)
                    {
                        bool flag = true;
                        num++;
                        for (int j = 1; j < strList[i].Length; j++)
                        {
                            if (!Equals(list[num], strList[i][j]))
                                flag = false;
                            num++;
                        }
                        if (flag)
                            count++;
                        num = list.IndexOf(strList[i][0], num);
                    }
                    res += $"{phrases[i]}  |  {count}\n";
                }

                AnalysisResult.Text = $"Словосочитание/слово | Повторений\n\n{res}";
            }
        }
    }

    public partial class Index : Form
    {
        internal void buttonAnalyzeWord_Click(object sender, EventArgs e)
        {
            if (ChatInfo.Text != null)
            {
                ChatInfoTemp.RefreshTemp();
                Analyze.AnalyzeWordsDialog aWD = new(new IndexKindAnalyze(ShowResult));
                aWD.ShowDialog();
            }
        }
    }
}
