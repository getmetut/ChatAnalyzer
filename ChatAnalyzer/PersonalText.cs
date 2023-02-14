using System.Text;

namespace ChatAnalyzer
{
    internal class PersonalText
    {
        internal PersonalText()
        {
            // задаем необходимые переменные
            List<string> list1 = new(), list2 = new();
            var list = ChatInfo.WordList;
            string init1 = ChatInfo.InitialP1T, init2 = ChatInfo.InitialP2T;
            int ind1 = list.FindIndex(0, w => Equals(w, init1));
            int ind2 = list.FindIndex(0, w => Equals(w, init2));

            while (ind1 > 0 && ind2 > 0)
            { 
                if (ind2 > ind1)
                {
                    list1.AddRange(list.GetRange(ind1, ind2 - ind1));
                    ind1 = list.FindIndex(ind2, w => Equals(w, init1));
                }
                else
                {
                    list2.AddRange(list.GetRange(ind2, ind1 - ind2));
                    ind2 = list.FindIndex(ind1, w => Equals(w, init2));
                }
            }

            if (ind1 < 0)
            {
                list2.AddRange(list.GetRange(ind2, list.Count - ind2));
            }
            else
            {
                list1.AddRange(list.GetRange(ind1, list.Count - ind1));
            }

            // Записываем всю информацию
            ChatInfo.WordListP1 = list1;
            ChatInfoTemp.WordListP1 = ChatInfo.WordListP1.ToList();
            ChatInfo.WordListP2 = list2;
            ChatInfoTemp.WordListP2 = ChatInfo.WordListP2.ToList();
            ChatInfo.WordDictP1 = TextFunctions.CreateDictionary(ChatInfo.WordListP1, Constants.tExept);
            ChatInfo.WordDictP2 = TextFunctions.CreateDictionary(ChatInfo.WordListP2, Constants.tExept);

            // считаем полные имена в тексте а потом присваиваем посчитаное количество в словаре
            TextFunctions.AccountFullNames(ChatInfo.WordListP1, ChatInfo.WordDictP1);
            TextFunctions.AccountFullNames(ChatInfo.WordListP2, ChatInfo.WordDictP2);

            // считаем количество сообщений
            ChatInfo.MessageCountP1 = FileOpener.GetMessagesCount(ChatInfo.WordListP1);
            ChatInfo.MessageCountP2 = FileOpener.GetMessagesCount(ChatInfo.WordListP2);

            ChatInfo.NewAdded = false;
        }
    }
}

