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
        public AnalyzeGeneralDialog(Form form)
        {
            InitializeComponent();

            buttonOK.Click += buttonOK_Click;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            
                AnalyzeGeneral aG = new();
                if (radioButtonKindPersonal.Checked == true)
                {
                    new ChatAnalyzer.PersonalText();
                    if (radioButtonParticalYNo.Checked == true)
                    {
                        new ChatAnalyzer.RemovePartials(true);
                    }
                    else
                    {
                        ChatInfoTemp.TextPerson1 = aG.Analyze(ChatInfoTemp.TextPerson1);
                        ChatInfoTemp.TextPerson2 = aG.Analyze(ChatInfoTemp.TextPerson2);
                    }
                    ChatInfoTemp.ShowResult(true);
                }
                else
                {
                    if (radioButtonParticalYNo.Checked == true)
                    {
                        new ChatAnalyzer.RemovePartials(false);
                    }
                    else
                    {
                        ChatInfoTemp.Text = aG.Analyze(ChatInfoTemp.Text);
                    }
                    ChatInfoTemp.ShowResult(false);
                }
                this.Close();
            
        }
    }
}
