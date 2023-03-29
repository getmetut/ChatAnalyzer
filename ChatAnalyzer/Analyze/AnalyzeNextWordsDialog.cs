namespace ChatAnalyzer.Analyze
{
    public partial class AnalyzeNextWordsDialog : Form
    {
        private readonly Program.ShowDeleagat delegat;
        internal AnalyzeNextWordsDialog(Program.ShowDeleagat sender)
        {
            InitializeComponent();
            delegat = sender;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AnalysisResult.Clean();
            if (radioButtonKindPersonal.Checked)
            {
                AnalysisResult.ResultP1 = AnalyzeNextWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP1,
                    Int32.Parse(textBoxAmountWords.Text), Int32.Parse(textBoxMinRepeat.Text));
                AnalysisResult.ResultP2 = AnalyzeNextWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordListP2,
                    Int32.Parse(textBoxAmountWords.Text), Int32.Parse(textBoxMinRepeat.Text));
            }
            else
            {
                AnalysisResult.ResultP1 = AnalyzeNextWords.Analyze(textBoxWord.Text.ToLower(), ChatInfoTemp.WordList,
                    Int32.Parse(textBoxAmountWords.Text), Int32.Parse(textBoxMinRepeat.Text));
            }
            AnalysisResult.ResultInfo = "Тип анализа: На последующие слова\n" +
                $"Начальные слова: {textBoxWord.Text}";

            delegat(radioButtonKindPersonal.Checked, Program.KindAnalysis.NextWords);
            
            this.Close();
        }
    }
}
