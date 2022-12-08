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

                float freq1 = count1 / (float)ChatInfo.MessageCountP1;
                float freq2 = count2 / (float)ChatInfo.MessageCountP2;
                float per1 = count1 / (count1 + count2);
                float per2 = count2 / (count1 + count2);

                AnalyzeResult.TextPerson1 = $"Слово:\n{word}\n\n" +
                    $"Общее колчичество повторений: \n{count1}\n\n" +
                    $"Частота употребления: \n{freq1:F20} на сообщение\n\n" +
                    $"Процент от общего употребления в переписке: \n{per1*100:F2}%\n\n";

                AnalyzeResult.TextPerson2 = $"Слово:\n{word}\n\n" +
                    $"Общее колчичество повторений: \n{count2}\n\n" +
                    $"Частота употребления: \n{freq2:F20} на сообщение\n\n" +
                    $"Процент от общего употребления в переписке: \n{per2*100:F2}%\n\n";
            }
            else
            {
                var dict = ChatInfo.WordDict;
                float count = 0;
                if (dict.ContainsKey(word))
                    count = (float)dict[word];
                float freq = dict[word] / (long)ChatInfo.MessageCount;

                AnalyzeResult.TextPerson1 = $"Слово:\n{word}\n\n" +
                    $"Общее колчичество повторений: \n{count}\n\n" +
                    $"Частота употребления: \n{freq:F20} на сообщение\n\n";
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
                Analyze.AnalyzeWordDialog aWD = new(new IndexChanger(ShowResult));
                aWD.ShowDialog();
            }
        }
    }
}
