namespace ChatAnalyzer.Analyze
{
    internal partial class AnalyzeGeneralDialog : Form
    {
        private readonly Program.ShowResultD delegat;
        internal AnalyzeGeneralDialog(Program.ShowResultD sender)
        {
            InitializeComponent();
            delegat = sender;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonKindPersonal.Checked == true)
            {
                AnalysisResult.AnalysisResultP1 = AnalyzeGeneral.Analyze(ChatInfo.WordDictP1, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                AnalysisResult.AnalysisResultP2 = AnalyzeGeneral.Analyze(ChatInfo.WordDictP2, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);          
            }
            else
            {
                AnalysisResult.AnalysisResultP1 = AnalyzeGeneral.Analyze(ChatInfo.WordDict, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
            }
            AnalysisResult.ResultInfo = "Тип анализа: Общий\n";

            delegat(radioButtonKindPersonal.Checked, Program.KindAnalysis.General);
            this.Close();
        }
    }
}
