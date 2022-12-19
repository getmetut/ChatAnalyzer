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
    public partial class AnalyzeWordDialog : Form
    {
        private readonly Program.IndexKindAnalyze delegat;
        public AnalyzeWordDialog(Program.IndexKindAnalyze sender)
        {
            InitializeComponent();
            delegat = sender;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonKindPersonal.Checked == true)
            {
                new PersonalText();
                AnalyzeWord.Analyze(textBoxWord.Text.ToLower(), true);
                delegat(true);
            }
            else
            {
                AnalyzeWord.Analyze(textBoxWord.Text.ToLower(), false);
                delegat(false);
            }
            this.Close();
        }
    }
}
