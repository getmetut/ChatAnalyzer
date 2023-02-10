using System.Collections.Generic;
using System.Xml.Linq;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    internal class AnalyzeWords
    {
        internal static IEnumerable<KeyValuePair<string, int>> Analyze(string str, List<string> list)
        {
            Dictionary<string, int> result = new();
            // создаем список массивов строк, для последующего сравнения
            string[] phrases = str.Split(',');
            List<string[]> strList = new();
            for (int i = 0; i < phrases.Length; i++)
            {
                phrases[i] = phrases[i].Trim().ToLower();
                strList.Add(phrases[i].Split(' '));
            }
            for (int i = 0; i < list.Count; i++)
                list[i] = TextFunctions.OnlyText(list[i]).ToLower();

            // начинаем цикл сравнений
            for (int i = 0; i < strList.Count; i++)
            {
                // числитель
                int count = 0;
                // находим совпадение первого слова словосочитания
                int num = list.IndexOf(strList[i][0]);
                while (num > 0)
                {
                    // если этот флаг ложен значит, серия совпадений прервалась
                    bool flag = true;
                    num++;
                    // начинаем проверку на совпадения
                    for (int j = 1; j < strList[i].Length; j++)
                    {
                        try
                        {
                            if (!Equals(list[num], strList[i][j]))
                                flag = false;
                            num++;
                        }
                        catch (Exception e) 
                        {   
                            flag = false;
                            break;
                        }
                    }
                    // если все ок, увеличиваем количество совпадений
                    if (flag)
                        count++;
                    // ищем новое совпадение
                    num = list.IndexOf(strList[i][0], num);
                }
                result[phrases[i]] = count;
            }

            return result;
        }

        internal static List<double> CalulateRatio(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            List<double> result = new();

            foreach (var elem in dict1)
            {
                double a = elem.Value / (elem.Value + (double)dict2[elem.Key]) * 100;
                result.Add(Math.Round(a, 2));
            }

            return result;
        }
    }

    public partial class Index : Form
    {
        internal void buttonAnalyzeWord_Click(object sender, EventArgs e)
        {
            if (ChatInfo.Text != null)
            {
                ChatInfoTemp.Refresh();
                Analyze.AnalyzeWordsDialog aWD = new(new ShowResultD(ShowResult), new CreateChartD(CreateChart));
                aWD.ShowDialog();
            }
        }
    }
}
