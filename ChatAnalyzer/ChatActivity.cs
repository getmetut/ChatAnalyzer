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
        internal ChatActivity(List<string> list, Program.ChatKind kind)
        {
            switch (kind)
            {
                case (Program.ChatKind.Telegram):
                    this.dateActivities = TelegramAnalyzeActivity(list);
                    break;
            }
        }

        internal List<DateActivity> TelegramAnalyzeActivity(List<string> list)
        {
            int day = 0, month = 0, year = 0;
            List<DateActivity> dateActivities = new();
            for(int i = 1; i < list.Count; i++)
            {
                if (IsMessageDate(list, i, ref day, ref year))
                {
                    month = Array.IndexOf(Constants.months, list[i]) + 1;
                    dateActivities.Add(new DateActivity(new DateTime(year, month, day), 0, i));
                }

                if (IsVoiceOrVideoMessage(list, i))
                {
                    char[] wAArrayCh = new char[4]; int[] wAArrayInt = new int[4];
                    wAArrayCh = list[i + 10].Where(x => Char.IsNumber(x)).ToArray();
                    for (int j = 0; j < 4; j++)
                        wAArrayInt[j] = Int32.Parse(wAArrayCh[j].ToString());
                    double wordsAmount = ((wAArrayInt[0] * 10 + wAArrayInt[1]) * 60 + wAArrayInt[2] * 10 + wAArrayInt[3]) * 0.6;
                    dateActivities.Last().Activity += (int)wordsAmount;
                }
            }

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
        internal static int FindMessageIndex(List<int> idxs, int idx)
        { 
            int i = 0, probablyI = 0;
            while (!(idxs[i] < idx && idx < idxs[i + 1]))
            {
                probablyI = idxs.Count / 2;
                if (idx < idxs[probablyI])
                    idxs = idxs.GetRange(0, probablyI);
                else
                    idxs = idxs.GetRange(probablyI, idxs.Count - probablyI);
                i = idxs[0];
            }

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
        internal static bool IsMessageDate(List<string> list, int i, ref int day, ref int year)
        {
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
