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
        public AnalyzeGeneralDialog()
        {
            InitializeComponent();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (buttonOK.DialogResult == DialogResult.OK && radioButtonKindPersonal.Checked == true 
                && radioButtonParticalYNo.Checked == true)
            {
                new ChatAnalyzer.PersonalText();
                new ChatAnalyzer.RemovePartials(true);

                
            }
        }
    }
}
