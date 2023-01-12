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
    public partial class AnalyzePhraseDialog : Form
    {
        private readonly Program.IndexKindAnalyze delegat;
        public AnalyzePhraseDialog(Program.IndexKindAnalyze sender)
        {
            InitializeComponent();
            delegat = sender;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonKindPersonal.Checked == true)
            {
                new PersonalText();
                AnalyzePhrase.Analyze(textBoxWord.Text.ToLower(), true);
                delegat(true);
            }
            else
            {
                AnalyzePhrase.Analyze(textBoxWord.Text.ToLower(), false);
                delegat(false);
            }
            this.Close();
        }
    }
}
