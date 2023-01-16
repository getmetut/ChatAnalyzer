using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatAnalyzer
{
    public partial class Index : Form
    {
        int height = 0, width = 0;
        public Index()
        {
            InitializeComponent();

            this.ResizeBegin += Index_ResizeBegin;
            this.ResizeEnd += Index_ResizeEnd;
            buttonChatsAdd.Click += buttonChatsAdd_Click;
            buttonAnalyzeGeneral.Click += buttonAnalyzeGeneral_Click;
            buttonAnalyzeWord.Click += buttonAnalyzeWord_Click;
            buttonAnalyzePhrase.Click += buttonAnalyzePhrase_Click;
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
                textBoxPerson1.Text = ChatInfo.FullNameP1 + "\n" + AnalyzeResult.TextPerson1;
                textBoxPerson2.Text = ChatInfo.FullNameP2 + "\n" + AnalyzeResult.TextPerson2;
                textBoxPerson1.Visible = true;
                textBoxPerson2.Visible = true;
                textBoxIndexGeneral.Visible = false;
            }
            else
            {
                textBoxIndexGeneral.Text = AnalyzeResult.Text;
                textBoxPerson1.Visible = false;
                textBoxPerson2.Visible = false;
                textBoxIndexGeneral.Visible = true;
            }
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OnApplicationExit(object sender, EventArgs e)
        {

        }

        private void buttonChatsClean_Click(object sender, EventArgs e)
        {
            // Чистим список
            listBoxChats.Items.Clear();
            ChatInfo.ClearChatInfo();
        }

        private void Index_ResizeEnd(object sender, EventArgs e)
        {
            Form index = (Form)sender;

            textBoxIndexGeneral.Height -= height - index.Height;
            textBoxIndexGeneral.Width -= width - index.Width;
            textBoxPerson1.Height -= height - index.Height;
            textBoxPerson1.Width -= (width - index.Width) / 2;
            textBoxPerson2.Location = new Point(textBoxPerson2.Location.X - (width - index.Width) / 2, 53);
            textBoxPerson2.Height -= height - index.Height;
            textBoxPerson2.Width -= (width - index.Width) / 2;
            listBoxChats.Height = textBoxIndexGeneral.Height;
            buttonResultSave.Location = new Point(buttonResultSave.Location.X - (width - index.Width),
                buttonResultSave.Location.Y - (height - index.Height));
        }

        private void Index_ResizeBegin(object sender, EventArgs e)
        {
            Form form = (Form)sender;

            height = form.Height;
            width = form.Width;
        }
    }
}