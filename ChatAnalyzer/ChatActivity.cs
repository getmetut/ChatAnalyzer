using System.Windows.Forms;

namespace ChatAnalyzer
{
    internal class ChatActivity
    {
        internal List<DateActivity> dateActivities = new List<DateActivity>();
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
            for(int i = 0; i < list.Count; i++)
            {
                if (IsMessageDate(list, i, ref day, ref year))
                {
                    month = Array.IndexOf(Constants.months, list[i]) + 1;
                    dateActivities.Add(new DateActivity(new DateTime(year, month, day), 0, i));
                }
            }
            //int idxPre = 0;
            //// ищем первую дату
            //for (int i = 1; i < list.Count; i++)

            //    if (IsMessageDate(list, i, ref day, ref year))
            //    {
            //        month = Array.IndexOf(Constants.months, list[i]) + 1;
            //        idxPre = i;
            //        dateActivities.Add(new DateActivity(new DateTime(year, month, day), 0));
            //        break;
            //    }

            //// ищем остальные прарлельно вычисляя активности пред
            //for (int i = idxPre + 1; i < list.Count; i++)

            //    if (IsMessageDate(list, i, ref day, ref year))
            //    {
            //        month = Array.IndexOf(Constants.months, list[i]) + 1;
            //        dateActivities.Last().Activity = i - idxPre;
            //        idxPre = i;
            //        dateActivities.Add(new DateActivity(new DateTime(year, month, day), 0));
            //    }
            //dateActivities.Last().Activity = list.Count - idxPre;
            return dateActivities;
        }

        private static bool IsVoiceOrVideoMessage(List<string> list, int i)
        {
            return (Equals(list[i], "Voice") || Equals(list[i], "Video")) && TextFunctions.IsTime(list[i - 2]);
        }
        private static bool IsMessageDate(List<string> list, int i, ref int day, ref int year)
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
