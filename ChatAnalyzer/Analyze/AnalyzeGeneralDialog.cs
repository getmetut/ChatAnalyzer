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
                if (radioButtonParticalYNo.Checked == true)
                {
                    AnalyzeResult.TextPerson1 = aG.Analyze(ChatInfoTemp.TextPerson1);
                    AnalyzeResult.TextPerson2 = aG.Analyze(ChatInfoTemp.TextPerson2);
                    new RemovePartials(true);
                }
                else
                {
                    AnalyzeResult.TextPerson1 = aG.Analyze(ChatInfoTemp.TextPerson1);
                    AnalyzeResult.TextPerson2 = aG.Analyze(ChatInfoTemp.TextPerson2);
                }
                d(true);
            }
            else
            {
                if (radioButtonParticalYNo.Checked == true)
                {
                    AnalyzeResult.Text = aG.Analyze(ChatInfoTemp.Text);
                    new RemovePartials(false);
                }
                else
                {
                    AnalyzeResult.Text = aG.Analyze(ChatInfoTemp.Text);
                }
                d(false);
            }
            this.Close();
        }
    }
}
