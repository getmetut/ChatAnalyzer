namespace ChatAnalyzer.Analyze
{
    public partial class AnalyzeWordsDialog : Form
    {
        private readonly Program.ShowResultD delegat;
        private readonly Program.CreateChartD delegat2;
        internal AnalyzeWordsDialog(Program.ShowResultD sender, Program.CreateChartD sender2)
        {
            InitializeComponent();
            delegat = sender;
            delegat2 = sender2;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonKindPersonal.Checked)
            {
                AnalysisResult.AnalysisResultP1 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP1);
                AnalysisResult.AnalysisResultP2 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP2);
                AnalysisResult.RatioP1 = AnalyzeWords.CalulateRatio((Dictionary<string, int>)AnalysisResult.AnalysisResultP1,
                    (Dictionary<string, int>)AnalysisResult.AnalysisResultP2);
                AnalysisResult.RatioP2 = AnalyzeWords.CalulateRatio((Dictionary<string, int>)AnalysisResult.AnalysisResultP2,
                    (Dictionary<string, int>)AnalysisResult.AnalysisResultP1);
            }
            else
            {
                AnalysisResult.AnalysisResultP1 = AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordList);
            }
            AnalysisResult.ResultInfo = "Тип анализа: По словам/словосочитаниям\n";

            delegat(radioButtonKindPersonal.Checked, Program.KindAnalysis.Words);
            delegat2(-10);
            this.Close();

        }
    }
}
