using System.Text;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    internal class AnalyzeGeneral
    {
        public static IEnumerable<KeyValuePair<string, int>> Analyze(Dictionary<string, int> top, int amount, bool isRemovePartials, bool isRemovePrepositions, bool isRemovePronouns)
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
            return helpTop;
        }
    }

    // Прописываем вызов формы
    public partial class Index : Form
    {
        internal void buttonAnalyzeGeneral_Click(object sender, EventArgs e)
        {
            if (ChatInfo.WordList != null)
            {
                ChatInfoTemp.Refresh();
                ShowDeleagat delegat = new(ShowResult);
                delegat += ShowChart;
                Analyze.AnalyzeGeneralDialog aGD = new(delegat);
                aGD.ShowDialog();
            }
        }
    }
}
