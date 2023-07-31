//using Excel = Microsoft.Office.Interop.Excel;
using static ChatAnalyzer.Program;
using System.Runtime.InteropServices;
using System.Text;
//using Microsoft.Office.Interop.Excel;

namespace ChatAnalyzer
{
    public partial class Index : Form
    {
        bool lastIsPersonal;
        KindAnalysis lastKind;
        public Index()
        {
            InitializeComponent();
            InitializeCharts();
            buttonChatsAdd.Click += buttonChatsAdd_Click;
            buttonAnalyzeGeneral.Click += buttonAnalyzeGeneral_Click;
            buttonAnalyzeWords.Click += buttonAnalyzeWord_Click;
            buttonAnalyzeNextWords.Click += buttonAnalyzeNextWords_Click;
            openFileDialog1.Filter = "HTML files(*.html)|*.html|Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Excel files(*.xls)|*.xls";

            System.Windows.Forms.Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        /// <summary>
        /// Метод выводит результат в главную форму
        /// </summary>
        /// <param name="isPersonal"></param>
        /// <param name="kind"></param>
        internal void ShowResult(bool isPersonal, KindAnalysis kind)
        {
            lastIsPersonal = isPersonal;
            lastKind = kind;
            var result1 = AnalysisResult.ResultP1.ToList();
            int count1 = result1.Count;
            List<KeyValuePair<string, int>> result2 = new();
            int count2 = 0;
            if (AnalysisResult.ResultP2 is not null)
            {
                result2 = AnalysisResult.ResultP2.ToList();
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

                    if (AnalysisResult.RatioP1 is not null || AnalysisResult.RatioP1 is not null)
                    {
                        foreach (DataGridViewRow rat in dataGridViewResultP1.Rows)
                        {
                            rat.Cells[2].Value = AnalysisResult.RatioP1[rat.Index] + "%";
                        }
                        foreach (DataGridViewRow rat in dataGridViewResultP2.Rows)
                        {
                            rat.Cells[2].Value = AnalysisResult.RatioP2[rat.Index] + "%";
                        }
                    }
                    break;

                case KindAnalysis.NextWords:

                    dataGridP1ColumnRatio.Visible = false;
                    dataGridP2ColumnRatio.Visible = false;

                    break;
            }
        }

        internal void ShowChart(bool isPersonal, KindAnalysis kind)
        {
            lastIsPersonal = isPersonal;
            lastKind = kind;
            new ChartCreator(AnalysisResult.ChartInfoP1, 0, kind, chart);
            chart.Series[0].Name = "Общая активность";
            if (isPersonal)
            {
                new ChartCreator(AnalysisResult.ChartInfoP2, 1, kind, chart);
                chart.Series.Last().IsVisibleInLegend = true;
                chart.Series[0].Name = ChatInfo.FullNameP1;
                chart.Series[1].Name = ChatInfo.FullNameP2;
            }
            else
            {
                chart.Series[1].Points.Clear();
                chart.Series[1].IsVisibleInLegend = false;
            }
            switch (kind)
            {
                case KindAnalysis.NextWords:
                    break;
                case KindAnalysis.General:
                    listBoxCharts.Visible = false;
                    break;
                case KindAnalysis.Words:

                    listBoxCharts.Visible = true;
                    foreach (DataGridViewRow row in dataGridViewResultP1.Rows)
                        listBoxCharts.Items.Add(row.Cells[0].Value);

                    break;
                    
            }
        }

        private void listBoxChartsSelectedIndexChanged (object sender, EventArgs e)
        {
            if (lastIsPersonal)
            {
                new ChartCreator(AnalysisResult.ChartInfoP1, 0, lastKind, chart);
                new ChartCreator(AnalysisResult.ChartInfoP2, 1, lastKind, chart);
            }
            else
                new ChartCreator(AnalysisResult.ChartInfoP1, 0, lastKind, chart);
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {

        }

        private void buttonChatsClean_Click(object sender, EventArgs e)
        {
            // Чистим список
            listBoxChats.Items.Clear();
            ChatInfo.Clear();
        }

        private void buttonResultSave_Click(object sender, EventArgs e)
        {
          /*  if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                var columnCount = dataGridViewResultP1.ColumnCount + 1;
                worksheet.Columns[1].ColumnWidth = 30;

                if (this.lastIsPersonal)
                {
                    worksheet.Rows[1].Columns[1] = ChatInfo.FullNameP1;
                    worksheet.Rows[1].Columns[columnCount - 1] = ChatInfo.FullNameP2;
                }
                
                for (int i = 2; i < dataGridViewResultP1.RowCount + 1; i++)
                {
                    for (int j = 1; j < columnCount; j++)
                    {
                        worksheet.Rows[i].Columns[j] = dataGridViewResultP1.Rows[i - 1].Cells[j - 1].Value;
                    }
                }

                if (dataGridViewResultP2 != null)
                {
                    worksheet.Columns[columnCount - 1].ColumnWidth = 30;

                    for (int i = 2; i < dataGridViewResultP2.RowCount + 1; i++)
                    {
                        for (int j = 1; j < columnCount; j++)
                        {
                            worksheet.Rows[i].Columns[j + columnCount - 2] = dataGridViewResultP2.Rows[i - 1].Cells[j - 1].Value;
                        }
                    }
                }

                excelapp.AlertBeforeOverwriting = false;
                SaveXLS(workbook);
                workbook.Close();
                workbook = null;
                worksheet = null;
                excelapp.Quit();
                excelapp = null;
            }*/
        }

     /*   private void SaveXLS(Workbook workbook)
        {
            try
            {
                workbook.SaveAs($"{saveFileDialog1.FileName}");
            }
            catch (COMException ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Retry)
                {
                    SaveXLS(workbook);
                }
            }
        }*/

        private void toolStripMenuItemAnalyzeGeneral_Click(object sender, EventArgs e)
        {
            buttonAnalyzeGeneral_Click(sender, e);
        }

        private void toolStripMenuItemAnalyzeWords_Click(object sender, EventArgs e)
        {
            buttonAnalyzeWord_Click(sender, e);
        }

        private void toolStripMenuItemAnalyzeNextWords_Click(object sender, EventArgs e)
        {
            buttonAnalyzeNextWords_Click(sender, e);
        }

        private void toolStripMenuItemResultSave_Click(object sender, EventArgs e)
        {
            buttonResultSave_Click(sender, e);
        }

        private void excelFilexlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonResultSave_Click(sender, e);
        }

        private void textFiletxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder result = new();
                var columnCount = dataGridViewResultP1.ColumnCount + 1;

                for (int i = 0; i < dataGridViewResultP1.RowCount + 1; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        result.Append(dataGridViewResultP1.Rows[i - 1].Cells[j - 1].Value.ToString().PadLeft(-40));
                    }
                }

                //if (dataGridViewResultP2 != null)
                //{
                //    worksheet.Columns[columnCount - 1].ColumnWidth = 30;

                //    for (int i = 2; i < dataGridViewResultP2.RowCount + 1; i++)
                //    {
                //        for (int j = 1; j < columnCount; j++)
                //        {
                //            worksheet.Rows[i].Columns[j + columnCount - 2] = dataGridViewResultP2.Rows[i - 1].Cells[j - 1].Value;
                //        }
                //    }
                //}
            }
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