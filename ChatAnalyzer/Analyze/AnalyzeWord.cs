using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    internal class AnalyzeWord
    {
        public static void Analyze(string word, bool isPersonal)
        {
          //  float freq1, freq2, per1, per2;
            if (isPersonal)
            {
                var dict1 = ChatInfo.WordDictP1;
                var dict2 = ChatInfo.WordDictP2;
                float count1 = 0, count2 = 0;
                if (dict1.ContainsKey(word))
                    count1 = (float)dict1[word];
                if (dict2.ContainsKey(word))
                    count2 = (float)dict2[word];

                float per1 = count1 / (count1 + count2);
                float per2 = count2 / (count1 + count2);

                AnalyzeResult.TextPerson1 = $"\nСлово:\n{word}\n\n" +
                    $"Общее колчичество повторений: \n{count1}\n\n" +
                    $"Процент от общего употребления в переписке: \n{per1*100:F2}%\n\n";

                AnalyzeResult.TextPerson2 = $"\nСлово:\n{word}\n\n" +
                    $"Общее колчичество повторений: \n{count2}\n\n" +
                    $"Процент от общего употребления в переписке: \n{per2*100:F2}%\n\n";
            }
            else
            {
                var dict = ChatInfo.WordDict;
                float count = 0;
                if (dict.ContainsKey(word))
                    count = (float)dict[word];

                AnalyzeResult.Text = $"\nСлово:\n{word}\n\n" +
                    $"Общее колчичество повторений: \n{count}\n\n";
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
                Analyze.AnalyzeWordDialog aWD = new(new IndexKindAnalyze(ShowResult));
                aWD.ShowDialog();
            }
        }
    }
}
