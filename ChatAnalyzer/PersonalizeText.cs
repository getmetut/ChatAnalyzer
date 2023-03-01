using static ChatAnalyzer.ChatInfo;

namespace ChatAnalyzer
{
    internal class PersonalizeText
    {
        internal PersonalizeText()
        {
            // задаем необходимые переменные
            List<string> list1 = new(), list2 = new();
            string init1 = InitialP1Tag, init2 = InitialP2Tag;
            int ind1 = WordList.FindIndex(0, w => Equals(w, init1));
            int ind2 = WordList.FindIndex(0, w => Equals(w, init2));

            while (ind1 > 0 && ind2 > 0)
            { 
                if (ind2 > ind1)
                {
                    list1.AddRange(WordList.GetRange(ind1, ind2 - ind1));
                    ind1 = WordList.FindIndex(ind2, w => Equals(w, init1));
                }
                else
                {
                    list2.AddRange(WordList.GetRange(ind2, ind1 - ind2));
                    ind2 = WordList.FindIndex(ind1, w => Equals(w, init2));
                }
            }

            if (ind1 < 0)
            {
                list2.AddRange(WordList.GetRange(ind2, WordList.Count - ind2));
            }
            else
            {
                list1.AddRange(WordList.GetRange(ind1, WordList.Count - ind1));
            }

            // Записываем всю информацию
            WordListP1 = list1;
            ChatInfoTemp.WordListP1 = WordListP1.ToList();
            WordListP2 = list2;
            ChatInfoTemp.WordListP2 = WordListP2.ToList();
            WordDictP1 = TextFunctions.CreateDictionary(WordListP1, Constants.tExept);
            WordDictP2 = TextFunctions.CreateDictionary(WordListP2, Constants.tExept);

            // считаем полные имена в тексте а потом присваиваем посчитаное количество в словаре
            List<int> idxs1 = new();
            List<int> idxs2 = new();
            TextFunctions.AccountFullNames(WordListP1, WordDictP1, ref idxs1);
            TextFunctions.AccountFullNames(WordListP2, WordDictP2, ref idxs2);
            FullNameP1Indexes = idxs1;
            FullNameP2Indexes = idxs2;

            // считаем количество сообщений
            MessageCountP1 = FileOpener.GetMessagesCount(WordListP1);
            MessageCountP2 = FileOpener.GetMessagesCount(WordListP2);

            NewAdded = false;
        }
    }
}

