using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChatAnalyzer.Program;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    internal class AnalyzeGeneral : IAnalyzer
    {
        public string Analyze(string text)
        {
            // Создаем словарь всех слов
            var top = TextFunctions.CreateDictionary(text, 100);
            // запишем результат
            StringBuilder result = new();
            foreach (var item in top)
                    result.Append($"{item.Key,10} {item.Value,-3}\n"); 

            return result.ToString();
        }
    }
    // Прописываем вызов формы
    public partial class Index : Form
    {
        internal void buttonAnalyzeGeneral_Click(object sender, EventArgs e)
        {
            if (ChatInfo.Text != null)
            {
                ChatInfoTemp.RefreshTemp();
                Analyze.AnalyzeGeneralDialog aGD = new(new IndexChanger(ShowResult));
                aGD.ShowDialog();
            }
        }
    }
}
