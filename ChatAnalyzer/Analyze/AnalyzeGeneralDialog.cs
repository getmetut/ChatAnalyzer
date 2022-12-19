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
                new PersonalText();
                AnalyzeResult.TextPerson1 = AnalyzeGeneral.Analyze(ChatInfoTemp.WordDictP1, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                AnalyzeResult.TextPerson2 = AnalyzeGeneral.Analyze(ChatInfoTemp.WordDictP2, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                delegat(true);
            }
            else
            {
                AnalyzeResult.Text = AnalyzeGeneral.Analyze(ChatInfoTemp.WordDict, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                delegat(false);
            }
            this.Close();
        }
    }
}
