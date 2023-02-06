using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAnalyzer.Analyze
{
    public partial class AnalyzeGeneralDialog : Form
    {
        private readonly Program.IndexKindAnalyze delegat;
        public AnalyzeGeneralDialog(Program.IndexKindAnalyze sender)
        {
            InitializeComponent();
            delegat = sender;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonKindPersonal.Checked == true)
            {
                AnalysisResult.TextPerson1 = AnalyzeGeneral.Analyze(ChatInfo.WordDictP1, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                AnalysisResult.TextPerson2 = AnalyzeGeneral.Analyze(ChatInfo.WordDictP2, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                delegat(true);
            }
            else
            {
                AnalysisResult.Text = AnalyzeGeneral.Analyze(ChatInfo.WordDict, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                delegat(false);
            }
            this.Close();
        }
    }
}
