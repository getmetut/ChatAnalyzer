using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    internal class RemovePartials // надо переписывать эту хуйню
    {
        internal RemovePartials(bool isPersonalAnalyze)
        {
            if (isPersonalAnalyze)
            {
                AnalyzeResult.TextPerson1 = Remove(TextFunctions.CreateDictionary(AnalyzeResult.TextPerson1, Constants.tExept), Constants.partials);
                AnalyzeResult.TextPerson2 = Remove(TextFunctions.CreateDictionary(AnalyzeResult.TextPerson2, Constants.tExept), Constants.partials);
            }
            else
            {
                AnalyzeResult.Text = Remove(TextFunctions.CreateDictionary(AnalyzeResult.Text, Constants.tExept), Constants.partials);
            }
        }

        /// <summary>
        /// Удаляет частицы из текста
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        private static string Remove(Dictionary<string, int> dict, string[] partials)
        {
            StringBuilder result = new();
            foreach (var item in dict)
            {
                if (!partials.Contains(item.Key))
                    result.Append($"{item.Key,10} {item.Value, -3}\n");
            }
            return result.ToString();
        }
    }
}