using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChatAnalyzer
{
    internal class ChatActivity
    {
        internal List<DateActivity> dateActivities = new List<DateActivity>();
        internal ChatActivity()
        {
        }

        internal ChatActivity(List<string> list, Program.ChatKind kind, bool isNeedVoices)
        {
            switch (kind)
            {
                case (Program.ChatKind.Telegram):
                    dateActivities = CalculateActivityGeneral(CreateDateActivitiesTelegram(list, isNeedVoices), list);
                    break;
            }
        }
        
        /// <summary>
        /// Функция возвращает список элементов типа DateActivity в которых содержится информация о 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>

        internal List<DateActivity> CreateDateActivitiesTelegram(List<string> list, bool isNeedVoices)
        {
            int day = 0, month = 0, year = 0;
            List<DateActivity> dateActivities = new();
            if (isNeedVoices)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (IsMessageDate(list, i, ref day, ref year))
                    {
                        month = Array.IndexOf(Constants.months, list[i]) + 1;
                        dateActivities.Add(new DateActivity(new DateTime(year, month, day), 0, i));
                    }

                    if (IsVoiceOrVideoMessage(list, i))
                    {
                        char[] timeCh = new char[4]; int[] timeInt = new int[4];
                        timeCh = list[i + 10].Where(x => Char.IsNumber(x)).ToArray();
                        for (int j = 0; j < 4; j++)
                            timeInt[j] = Int32.Parse(timeCh[j].ToString());
                        double wordsAmount = ((timeInt[0] * 10 + timeInt[1]) * 60 + timeInt[2] * 10 + timeInt[3]) * 0.6;
                        dateActivities.Last().Activity += (int)wordsAmount;
                    }
                }
            }
            else
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (IsMessageDate(list, i, ref day, ref year))
                    {
                        month = Array.IndexOf(Constants.months, list[i]) + 1;
                        dateActivities.Add(new DateActivity(new DateTime(year, month, day), 0, i));
                    }
                }
            }
            
            return dateActivities;
        }

        internal List<DateActivity> CalculateActivityGeneral(List<DateActivity> dateActivities, List<string> list)
        {
            for (int i = 1; i < dateActivities.Count; i++)
            {
                dateActivities[i - 1].Activity += dateActivities[i].ListIdx - dateActivities[i - 1].ListIdx;
            }

            dateActivities.Last().Activity += list.Count - dateActivities[dateActivities.Count - 1].ListIdx;
            return dateActivities;
        }
        /// <summary>
        /// Ищет индекс в списке, после котрого следует данное число
        /// </summary>
        /// <param name="idxs"></param>
        /// <param name="idx"></param>
        /// <returns></returns>
        internal int FindMessageIndex(List<int> idxs, int idx)
        { 
            int i = 0, probablyI = 0; List<int> idxsCopy = idxs.ToList();
            while (idxsCopy.Count > 1)
            {
                probablyI = idxsCopy.Count / 2;
                if (idx < idxsCopy[probablyI])
                    idxsCopy = idxsCopy.GetRange(0, probablyI);
                else
                    idxsCopy = idxsCopy.GetRange(probablyI, idxsCopy.Count - probablyI);
                probablyI = idxsCopy[0];
            }

            i = probablyI;
            return i;
        }
        /// <summary>
        /// Определяет является ли элемент информацией об видео/аудиосообщением
        /// </summary>
        /// <param name="list"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        internal static bool IsVoiceOrVideoMessage(List<string> list, int i)
        {
            return (Equals(list[i], "Voice") || Equals(list[i], "Video")) && TextFunctions.IsTime(list[i - 2]);
        }

        /// <summary>
        /// Определяет является ли элемент информацией о дате сообщений
        /// </summary>
        /// <param name="list"></param>
        /// <param name="i"></param>
        /// <param name="day"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        internal bool IsMessageDate(List<string> list, int i, ref int day, ref int year)
        {
            return (Constants.months.Contains(list[i]) && Int32.TryParse(list[i - 1], out day) && (list[i - 1].Length == 1 || list[i - 1].Length == 2) &&
                                    Int32.TryParse(list[i + 1], out year) && list[i + 1].Length == 4);
        }

        internal bool IsMessageDate(List<string> list, int i)
        {
            int day, year;
            return (Constants.months.Contains(list[i]) && Int32.TryParse(list[i - 1], out day) && (list[i - 1].Length == 1 || list[i - 1].Length == 2) &&
                                    Int32.TryParse(list[i + 1], out year) && list[i + 1].Length == 4);
        }
        internal class DateActivity
        {
            internal DateActivity(DateTime date, int activity, int idx)
            {
                Day = date;
                Activity = activity;
                ListIdx = idx;
            }

            internal int Activity { get; set; }
            internal DateTime Day { get; }
            internal int ListIdx { get; }
        }
    }
}
