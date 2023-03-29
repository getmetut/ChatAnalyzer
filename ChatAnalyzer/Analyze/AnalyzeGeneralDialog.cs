using System;

namespace ChatAnalyzer.Analyze
{
    internal partial class AnalyzeGeneralDialog : Form
    {
        private readonly Program.ShowDeleagat delegat;
        internal AnalyzeGeneralDialog(Program.ShowDeleagat sender)
        {
            InitializeComponent();
            delegat = sender;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            AnalysisResult.Clean();
            if (radioButtonKindPersonal.Checked == true)
            {
                AnalysisResult.ResultP1 = AnalyzeGeneral.Analyze(ChatInfo.WordDictP1, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                AnalysisResult.ResultP2 = AnalyzeGeneral.Analyze(ChatInfo.WordDictP2, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);    
                
            }
            else
            {
                AnalysisResult.ResultP1 = AnalyzeGeneral.Analyze(ChatInfo.WordDict, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                AnalysisResult.ChartInfoP1 = new ChatActivity(ChatInfo.WordList, Program.ChatKind.Telegram);
            }
            AnalysisResult.ResultInfo = "Тип анализа: Общий\n";

            delegat(radioButtonKindPersonal.Checked, Program.KindAnalysis.General);
            this.Close();
        }
    }
}
