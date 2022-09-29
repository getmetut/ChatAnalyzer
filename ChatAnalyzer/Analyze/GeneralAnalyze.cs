using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatAnalyzer.Analyze;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    internal class AnalyzeGeneral : IAnalyzer
    {
        public string Analyze(string text)
        {
            
            var top = new Dictionary<string, int>();
            int last, first; string word;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    first = i++; last = i;
                    while (char.IsLetter(text[last]))
                    {
                        last++;
                    }
                    i = last--;

                    word = text.Substring(first, last - first + 1).ToLower();
                    if (top.ContainsKey(word))
                    {
                        top[word]++;
                    }
                    else
                    {
                        top[word] = 1;
                    }
                }
            }
            var sortedTop = top.Where(t => t.Value > 100 && t.Key.Length > 2).OrderByDescending(t => t.Value);
            StringBuilder result = new();
            string[] exept = {"игорь", "дудосов", "насвай", "data", "not", "change" +
                "included", "exporting", "settings", "download", "message", "voice", "video", "this", "reply",
                "photo", "file", "https", "sticker", "www", "outgoing", "change", "included",    
                "com", "seconds", "messages", "tiktok", "amp"};
            int exeptFlag = 0;
            foreach (var item in sortedTop)
            {
                if (exeptFlag < exept.Length && !exept.Contains(item.Key))
                    result.Append($"{item.Key,10} {item.Value}\n");
                else
                {
                    exeptFlag++;
                    continue;
                }
            }
            return result.ToString();
        }
    }

    public partial class Index : Form
    {
        void buttonAnalyzeGeneral_Click(object sender, EventArgs e)
        {
            if (ChatInfo.Text != null)
            {
                GeneralAnalyzeDialog generalAnalyzeDialog = new GeneralAnalyzeDialog();
                generalAnalyzeDialog.ShowDialog();
                AnalyzeGeneral a = new();

                textBoxIndexAnalyze.Text = a.Analyze(ChatInfo.Text);
            }
        }
    }
}
