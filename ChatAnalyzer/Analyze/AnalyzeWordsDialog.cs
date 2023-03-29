namespace ChatAnalyzer.Analyze
{
    public partial class AnalyzeWordsDialog : Form
    {
        private readonly Program.ShowDeleagat delegatRes;
        internal AnalyzeWordsDialog(Program.ShowDeleagat sender)
        {
            InitializeComponent();
            delegatRes = sender;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AnalysisResult.Clean();
            if (radioButtonKindPersonal.Checked)
            {
                AnalysisResult.ResultP1 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP1);
                AnalysisResult.ResultP2 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP2);
                AnalysisResult.RatioP1 = AnalyzeWords.CalulateRatio((Dictionary<string, int>)AnalysisResult.ResultP1,
                    (Dictionary<string, int>)AnalysisResult.ResultP2);
                AnalysisResult.RatioP2 = AnalyzeWords.CalulateRatio((Dictionary<string, int>)AnalysisResult.ResultP2,
                    (Dictionary<string, int>)AnalysisResult.ResultP1);
            }
            else
            {
                AnalysisResult.ResultP1 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordList);
            }
            AnalysisResult.ResultInfo = "Тип анализа: По словам/словосочитаниям\n";

            delegatRes(radioButtonKindPersonal.Checked, Program.KindAnalysis.Words);
            this.Close();

        }
    }
}
