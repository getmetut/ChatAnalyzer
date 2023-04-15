using static ChatAnalyzer.AnalysisResult;
namespace ChatAnalyzer.Analyze
{
    public partial class AnalyzeWordsDialog : Form
    {
        private readonly Program.ShowDeleagat delegat;
        internal AnalyzeWordsDialog(Program.ShowDeleagat sender)
        {
            InitializeComponent();
            delegat = sender;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Clean();
            if (radioButtonKindPersonal.Checked)
            {
                ResultP1 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP1);
                ResultP2 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP2);
                RatioP1 = AnalyzeWords.CalulateRatio((Dictionary<string, int>)ResultP1,
                    (Dictionary<string, int>)ResultP2);
                RatioP2 = AnalyzeWords.CalulateRatio((Dictionary<string, int>)ResultP2,
                    (Dictionary<string, int>)ResultP1);
            }
            else
            {
                ResultP1 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordList);
            }
            ResultInfo = "Тип анализа: По словам/словосочитаниям\n";

            delegat(radioButtonKindPersonal.Checked, Program.KindAnalysis.Words);
            this.Close();

        }
    }
}
