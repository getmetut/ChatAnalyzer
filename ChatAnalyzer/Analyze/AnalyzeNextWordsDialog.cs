namespace ChatAnalyzer.Analyze
{
    public partial class AnalyzeNextWordsDialog : Form
    {
        private readonly Program.IndexKindAnalyze delegat;
        public AnalyzeNextWordsDialog(Program.IndexKindAnalyze sender)
        {
            InitializeComponent();
            delegat = sender;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AnalyzeNextWords.Analyze(textBoxWord.Text.ToLower(), radioButtonKindPersonal.Checked,
                Int32.Parse(textBoxAmountWords.Text), Int32.Parse(textBoxMinRepeat.Text));
            delegat(radioButtonKindPersonal.Checked);
            this.Close();
        }
    }
}
