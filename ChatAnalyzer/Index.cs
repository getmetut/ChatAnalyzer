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

        /// <summary>
        /// Метод выводит результат в главную форму
        /// </summary>
        /// <param name="isPersonal"></param>
        internal void ShowResult(bool isPersonal)
        {
            if (isPersonal)
            {
                textBoxPerson1.Text = ChatInfo.FullNamePerson1 + "\n" + AnalyzeResult.TextPerson1;
                textBoxPerson2.Text = ChatInfo.FullNamePerson2 + "\n" + AnalyzeResult.TextPerson2;
                textBoxIndexAnalyze.Visible = false;
                textBoxPerson1.Visible = true;
                textBoxPerson2.Visible = true;
            }
            else
            {
                textBoxIndexAnalyze.Text = AnalyzeResult.Text;
                textBoxPerson1.Visible = false;
                textBoxPerson2.Visible = false;
                textBoxIndexAnalyze.Visible = true;
            }
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

        private void buttonChatsClean_Click(object sender, EventArgs e)
        {
            // Чистим список
            listBoxChats.Items.Clear();
            ChatInfo.ClearChatInfo();
        }
    }
}