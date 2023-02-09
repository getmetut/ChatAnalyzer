using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using static ChatAnalyzer.Program;

namespace ChatAnalyzer
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            InitializeCharts();
            buttonChatsAdd.Click += buttonChatsAdd_Click;
            buttonAnalyzeGeneral.Click += buttonAnalyzeGeneral_Click;
            buttonAnalyzeWord.Click += buttonAnalyzeWord_Click;
            buttonAnalyzeNextWord.Click += buttonAnalyzeNextWords_Click;
            openFileDialog1.Filter = "HTML files(*.html)|*.html|Text files(*.txt)|*.txt|All files(*.*)|*.*";

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        /// <summary>
        /// Метод выводит результат в главную форму
        /// </summary>
        /// <param name="isPersonal"></param>
        /// <param name="kind"></param>
        internal void ShowResult(bool isPersonal, KindAnalysis kind)
        {
            var result1 = AnalysisResult.AnalysisResultP1.ToList();
            int count1 = result1.Count;
            List<KeyValuePair<string, int>> result2 = new();
            int count2 = 0;
            if (AnalysisResult.AnalysisResultP2 is not null)
            {
                result2 = AnalysisResult.AnalysisResultP2.ToList();
                count2 = result2.Count;
            }
            textBoxResultInfo.Text = AnalysisResult.ResultInfo;
            dataGridViewResultP1.Rows.Clear();
            dataGridViewResultP2.Rows.Clear();
            if (isPersonal)
            {

                labelNameP1.Text = ChatInfo.FullNameP1;
                labelNameP2.Text = ChatInfo.FullNameP2;
                for (int i = 0; i < count1; i++)
                {
                    dataGridViewResultP1.Rows.Add(result1[i].Key, result1[i].Value);
                    dataGridViewResultP1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                for (int i = 0; i < count2; i++)
                {
                    dataGridViewResultP2.Rows.Add(result2[i].Key, result2[i].Value);
                    dataGridViewResultP2.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            else
            {
                labelNameP1.Text = "Общий";
                labelNameP2.Text = "";
                for (int i = 0; i < count1; i++)
                {
                    dataGridViewResultP1.Rows.Add(result1[i].Key, result1[i].Value);
                    dataGridViewResultP1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            switch (kind)
            {
                case KindAnalysis.General:

                    dataGridP1ColumnRatio.Visible = false;
                    dataGridP2ColumnRatio.Visible = false;

                    break;

                case KindAnalysis.Words:

                    dataGridP1ColumnRatio.Visible = true;
                    dataGridP2ColumnRatio.Visible = true;

                    foreach (DataGridViewRow rat in dataGridViewResultP1.Rows)
                    {
                        rat.Cells[2].Value = AnalysisResult.RatioP1[rat.Index] + "%";
                    }
                    foreach (DataGridViewRow rat in dataGridViewResultP2.Rows)
                    {
                        rat.Cells[2].Value = AnalysisResult.RatioP2[rat.Index] + "%";
                    }
                    break;

                case KindAnalysis.NextWords:

                    dataGridP1ColumnRatio.Visible = false;
                    dataGridP2ColumnRatio.Visible = false;

                    break;
            }
        }

        internal void CreateChart(double x)
        {
            double y;
            this.chart.Series[0].Points.Clear();
            while (x <= 10)
            {
                y = Math.Cos(x);
                this.chart.Series[0].Points.AddXY(x, y);
                x += 0.1;
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

        private void dataGridViewResultP1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void Index_ResizeEnd(object sender, EventArgs e)
        //{
        //    Form index = (Form)sender;

        //    textBoxResultInfo.Height -= height - index.Height;
        //    textBoxResultInfo.Width -= width - index.Width;
        //    textBoxPerson1.Height -= height - index.Height;
        //    textBoxPerson1.Width -= (width - index.Width) / 2;
        //    textBoxPerson2.Location = new Point(textBoxPerson2.Location.X - (width - index.Width) / 2, 53);
        //    textBoxPerson2.Height -= height - index.Height;
        //    textBoxPerson2.Width -= (width - index.Width) / 2;
        //    listBoxChats.Height = textBoxResultInfo.Height;
        //    buttonResultSave.Location = new Point(buttonResultSave.Location.X - (width - index.Width),
        //        buttonResultSave.Location.Y - (height - index.Height));
        //}

        //private void Index_ResizeBegin(object sender, EventArgs e)
        //{
        //    Form form = (Form)sender;

        //    height = form.Height;
        //    width = form.Width;
        //}
    }
}