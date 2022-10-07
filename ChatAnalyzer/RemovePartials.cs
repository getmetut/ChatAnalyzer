using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    internal class RemovePartials
    {
        internal RemovePartials(bool isPersonalAnalyze)
        {
            if (isPersonalAnalyze)
            {
                ChatInfoTemp.TextPerson1 = Remove(TextFunctions.CreateDictionary(ChatInfo.TextPerson1, 100));
                ChatInfoTemp.TextPerson2 = Remove(TextFunctions.CreateDictionary(ChatInfo.TextPerson2, 100));
            }
            else
            {
                ChatInfoTemp.Text = Remove(TextFunctions.CreateDictionary(ChatInfo.Text, 100));
            }
        }

        /// <summary>
        /// Удаляет частицы из текста
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        private static string Remove(Dictionary<string, int> dict)
        {
            StringBuilder result = new();
            string[] partials = { "ли", "разве", "неужели", "что", "а", "вон", "вот", "именно", "точно", "ровно", "подлинно", "как", "просто",
                "прямо", "еще", "и", "же", "лишь", "уж", "ведь", "даже", "просто", "прямо", "все",
                "только","лишь","исключительно","только","всего","хоть","бы","единственно","разве","неужели","вряд","едва","навряд",
                "авось","да","ну","так","точно"};
            int exeptFlag = 0;
            foreach (var item in dict)
            {
                if (exeptFlag < partials.Length && !partials.Contains(item.Key))
                    result.Append($"{item.Key,10} {item.Value, -3}\n");
                else
                {
                    exeptFlag++;
                    if (exeptFlag == partials.Length)
                        break;
                }
            }
            return result.ToString();
        }
    }
}