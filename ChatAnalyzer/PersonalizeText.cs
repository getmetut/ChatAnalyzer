using System.Windows.Forms;
using static ChatAnalyzer.ChatInfo;

namespace ChatAnalyzer
{
    internal class PersonalizeText
    {
        internal PersonalizeText()
        {
            // задаем необходимые переменные
            List<string> list1 = new(), list2 = new();
            // создаем список индексов дат
            List<int> idxs = DateIndexes.dateActivities.Select(d => d.ListIdx).ToList();
            string init1 = InitialP1Tag, init2 = InitialP2Tag;
            // находим первые индексы инициалов
            int ind1 = WordList.FindIndex(0, w => Equals(w, init1));
            int ind2 = WordList.FindIndex(0, w => Equals(w, init2));
            
            // пока оба индекса находятся записываем текст в отдельные списки для каждого
            while (ind1 > 0 && ind2 > 0)
            { 
                if (ind2 > ind1)
                {
                    AddDate(WordList, list1, idxs, ind1);
                    list1.AddRange(WordList.GetRange(ind1, ind2 - ind1));
                    ind1 = WordList.FindIndex(ind2, w => Equals(w, init1));
                }
                else
                {
                    AddDate(WordList, list2, idxs, ind2);
                    list2.AddRange(WordList.GetRange(ind2, ind1 - ind2));
                    ind2 = WordList.FindIndex(ind1, w => Equals(w, init2));
                }
            }

            // записываем в список послдений незаписанный текст
            if (ind1 < 0)
            {
                AddDate(WordList, list2, idxs, ind2);
                list2.AddRange(WordList.GetRange(ind2, WordList.Count - ind2));
            }
            else
            {
                AddDate(WordList, list1, idxs, ind1);
                list1.AddRange(WordList.GetRange(ind1, WordList.Count - ind1));
            }

            // Записываем всю информацию в глобальные свойства
            WordListP1 = list1;
            ChatInfoTemp.WordListP1 = WordListP1.ToList();
            WordListP2 = list2;
            ChatInfoTemp.WordListP2 = WordListP2.ToList();
            WordDictP1 = TextFunctions.CreateDictionary(WordListP1, Constants.tExept);
            WordDictP2 = TextFunctions.CreateDictionary(WordListP2, Constants.tExept);

            // считаем полные имена в тексте и присваиваем посчитаное количество в словаре, а так же записываем индексы полных имен
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
        /// <summary>
        /// Метод ищет и добавляет дату в список
        /// </summary>
        /// <param name="list"></param>
        /// <param name="idxs"></param>
        /// <param name="ind"></param>
        internal void AddDate(List<string> list, List<string> listPerson, List<int> idxs, int ind)
        {
            // если перед началом сообщений есть дата, то сначала добавляем ее в список
            if (DateIndexes.IsMessageDate(list, ind - 2))
            {
                for (int i = 0; i < 3; i++)
                    listPerson.Add(WordList[ind - 3 + i]);
            }
            // если нет то ищем ближайщую верхнюю дату
            else
            {
                int j = DateIndexes.FindMessageIndex(idxs, ind);
                for (int i = 0; i < 3; i++)
                    listPerson.Add(WordList[j - 1 + i]);
            }
        }
    }
}

