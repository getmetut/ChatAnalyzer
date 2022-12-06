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
        private readonly Program.IndexChanger d;
        public AnalyzeGeneralDialog(Program.IndexChanger sender)
        {
            InitializeComponent();
            d = sender;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            AnalyzeGeneral aG = new();
            if (radioButtonKindPersonal.Checked == true)
            {
                new PersonalText();
                AnalyzeResult.TextPerson1 = AnalyzeGeneral.Analyze(ChatInfoTemp.WordsDictionaryPerson1, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                AnalyzeResult.TextPerson2 = AnalyzeGeneral.Analyze(ChatInfoTemp.WordsDictionaryPerson2, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                d(true);
            }
            else
            {
                AnalyzeResult.Text = AnalyzeGeneral.Analyze(ChatInfoTemp.WordsDictionary, Int32.Parse(textBoxMinAmount.Text),
                    checkBoxPartials.Checked, checkBoxPrepositions.Checked, checkBoxPronouns.Checked);
                d(false);
            }
            this.Close();
        }
    }
}
