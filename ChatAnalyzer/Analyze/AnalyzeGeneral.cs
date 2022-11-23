using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChatAnalyzer.Program;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    internal class AnalyzeGeneral
    {
        public string Analyze(Dictionary<string, int> top, int amount, bool isRemovePartials, bool isRemovePrepositions, bool isRemovePronouns)
        {
            // запишем результат
            StringBuilder result = new();
            var sortedTop = top.Where(t => t.Value > amount && !Constants.partials.Contains(t.Key)).OrderByDescending(t => t.Value);
            IEnumerable<KeyValuePair<string, int>> helpTop = sortedTop;
            string isRemove = isRemovePartials.ToString() + isRemovePrepositions.ToString() + isRemovePronouns.ToString();
            switch (isRemove)
            {
                case "FalseFalseTrue":
                    helpTop = sortedTop.Where(t => !Constants.pronouns.Contains(t.Key));
                    break;
                case "FalseTrueFalse":
                    helpTop = sortedTop.Where(t => !Constants.prepositions.Contains(t.Key));
                    break;
                case "TrueFalseFalse":
                    helpTop = sortedTop.Where(t => !Constants.partials.Contains(t.Key));
                    break;
                case "FalseTrueTrue":
                    helpTop = sortedTop.Where(t => !Constants.prepositions.Contains(t.Key) && !Constants.pronouns.Contains(t.Key));
                    break;
                case "TrueTrueFalse":
                    helpTop = sortedTop.Where(t => !Constants.partials.Contains(t.Key) && !Constants.prepositions.Contains(t.Key));
                    break;
                case "TrueFalseTrue":
                    helpTop = sortedTop.Where(t => !Constants.partials.Contains(t.Key) && !Constants.pronouns.Contains(t.Key));
                    break;
                case "TrueTrueTrue":
                    helpTop = sortedTop.Where(t => !Constants.partials.Contains(t.Key) && !Constants.prepositions.Contains(t.Key)
                     && !Constants.pronouns.Contains(t.Key));
                    break;
            }

            foreach (var item in helpTop)
                result.Append($"{item.Key,10} {item.Value,-3}\n");

            return result.ToString();
        }
    }
    // Прописываем вызов формы
    public partial class Index : Form
    {
        internal void buttonAnalyzeGeneral_Click(object sender, EventArgs e)
        {
            if (ChatInfo.Text != null)
            {
                ChatInfoTemp.RefreshTemp();
                Analyze.AnalyzeGeneralDialog aGD = new(new IndexChanger(ShowResult));
                aGD.ShowDialog();
            }
        }
    }
}
