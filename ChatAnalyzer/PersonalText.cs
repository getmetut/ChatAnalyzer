using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    internal class PersonalText
    {
        internal PersonalText()
        {
            // задаем необходимые переменные
            StringBuilder text1 = new(), text2 = new();
            var wordsList = ChatInfo.WordsList;
            string person1 = ChatInfo.InitialsPerson1, person2 = ChatInfo.InitialsPerson2;
            
            for(int i = 0; i < wordsList.Count; i++)
            {
                if (Equals(wordsList[i], person1) && TextFunctions.IsTime(wordsList[i + 1]))
                {
                    for(int j = i; j < wordsList.FindIndex(i, w => Equals(w, person2)); j++)
                    {
                        text1.Append(" " + wordsList[j]);
                    }
                }

                if (Equals(wordsList[i], person2) && TextFunctions.IsTime(wordsList[i + 1]))
                {
                    for (int j = i; j < wordsList.FindIndex(i, w => Equals(w, person1)); j++)
                    {
                        text2.Append(" " + wordsList[j]);
                    }
                }
            }
            ChatInfo.TextPerson1 = text1.ToString();
            ChatInfo.TextPerson2 = text2.ToString();
            ChatInfoTemp.TextPerson1 = ChatInfo.TextPerson1;
            ChatInfoTemp.TextPerson2 = ChatInfo.TextPerson2;
            ChatInfo.WordsListPerson1 = ChatInfo.TextPerson1.Split(' ').ToList();
            ChatInfo.WordsListPerson2 = ChatInfo.TextPerson2.Split(' ').ToList();
            ChatInfoTemp.WordsListPerson1 = ChatInfo.WordsListPerson1;
            ChatInfoTemp.WordsListPerson2 = ChatInfo.WordsListPerson2;
            ChatInfo.WordsDictionaryPerson1 = TextFunctions.CreateDictionary(ChatInfo.TextPerson1, Constants.tExept);
            ChatInfo.WordsDictionaryPerson2 = TextFunctions.CreateDictionary(ChatInfo.TextPerson2, Constants.tExept);
            ChatInfoTemp.WordsDictionaryPerson1 = ChatInfo.WordsDictionaryPerson1;
            ChatInfoTemp.WordsDictionaryPerson2 = ChatInfo.WordsDictionaryPerson2;
        }
    }
}
