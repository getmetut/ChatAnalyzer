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
                var dict1 = TextFunctions.CreateDictionary(ChatInfo.TextPerson1);
                var dict2 = TextFunctions.CreateDictionary(ChatInfo.TextPerson2);
                ChatInfoTemp.TextPerson1 = Remove(dict1);
                ChatInfoTemp.TextPerson2 = Remove(dict2);
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
                "только","лишь","исключительно","только","всего","хоть","","бы","единственно","разве","неужели","вряд","едва","навряд",
                "авось","да","ну","так","точно"};
            int exeptFlag = 0;
            foreach (var item in dict)
            {
                if (exeptFlag < partials.Length && !partials.Contains(item.Key))
                    result.Append($"{item.Key,10} {item.Value}\n");
                else
                {
                    exeptFlag++;
                    continue;
                }
            }
            return result.ToString();
        }
    }
}