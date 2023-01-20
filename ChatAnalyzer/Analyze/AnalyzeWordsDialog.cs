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
    public partial class AnalyzeWordsDialog : Form
    {
        private readonly Program.IndexKindAnalyze delegat;
        public AnalyzeWordsDialog(Program.IndexKindAnalyze sender)
        {
            InitializeComponent();
            delegat = sender;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AnalyzeWords.Analyze(textBoxWord.Text.ToLower(), radioButtonKindPersonal.Checked);
            delegat(radioButtonKindPersonal.Checked);
            this.Close();
        }
    }
}
