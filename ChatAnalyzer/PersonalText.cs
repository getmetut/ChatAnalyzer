using System;
using System.Collections;
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
            var wordsList = ChatInfo.WordList;
            string person1 = ChatInfo.InitialP1, person2 = ChatInfo.InitialP2;

            for (int i = 0; i < wordsList.Count; i++)
            {
                if (Equals(wordsList[i], person1) && TextFunctions.IsTime(wordsList[i + 1]))
                {
                    for (int j = i; j < wordsList.FindIndex(i, w => Equals(w, person2)); j++)
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

            // Записываем всю информацию
            ChatInfoTemp.TextP1 = ChatInfo.TextP1 = text1.ToString();
            ChatInfoTemp.TextP2 = ChatInfo.TextP2 = text2.ToString();
            ChatInfo.WordListP1 = ChatInfo.TextP1.Split(' ').ToList();
            ChatInfo.WordListP1.RemoveAll(String.IsNullOrWhiteSpace);
            ChatInfoTemp.WordListP1 = ChatInfo.WordListP1;
            ChatInfo.WordListP2 = ChatInfo.TextP2.Split(' ').ToList();
            ChatInfo.WordListP2.RemoveAll(String.IsNullOrWhiteSpace);
            ChatInfoTemp.WordListP2 = ChatInfo.WordListP2;
            ChatInfoTemp.WordDictP1 = ChatInfo.WordDictP1 = TextFunctions.CreateDictionary(ChatInfo.TextP1, Constants.tExept);
            ChatInfoTemp.WordDictP2 = ChatInfo.WordDictP2 = TextFunctions.CreateDictionary(ChatInfo.TextP2, Constants.tExept);

            // считаем полные имена в тексте а потом присваиваем посчитаное количество в словаре
            TextFunctions.AccountFullNames(ChatInfo.WordListP1, ChatInfo.WordDictP1);
            TextFunctions.AccountFullNames(ChatInfo.WordListP2, ChatInfo.WordDictP2);

            // считаем количество сообщений
            ChatInfo.MessageCountP1 = FileOpener.MessagesCounting(ChatInfo.WordListP1);
            ChatInfo.MessageCountP2 = FileOpener.MessagesCounting(ChatInfo.WordListP2);

            ChatInfo.NewAdded = false;
        }
    }
}

