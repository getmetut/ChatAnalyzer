using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatAnalyzer
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();

            buttonChatsAdd.Click += buttonChatsAdd_Click;
            buttonAnalyzeGeneral.Click += buttonAnalyzeGeneral_Click;
            openFileDialog1.Filter = "HTML files(*.html)|*.html|Text files(*.txt)|*.txt|All files(*.*)|*.*";

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OnApplicationExit(object sender, EventArgs e)
        {

        }

        private void listBoxChats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIndexAnalyze_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}