namespace ChatAnalyzer
{
    internal class ChartCreator
    {
        internal ChartCreator(ChatActivity activity, int i, Program.KindAnalysis kind, System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[i].Points.Clear();
            ChatActivity monthActivity = CalculatePointsMonth(activity);
            switch (kind)
            {
                case Program.KindAnalysis.General:
                    {
                        int x = 0;
                        foreach (ChatActivity.DateActivity point in monthActivity.dateActivities)
                        {
                            chart.Series[i].Points.AddXY(x, point.Activity);
                            x++;
                        }
                        break;
                    }

                case Program.KindAnalysis.Words:
                    {
                        int x = 0;
                        foreach (ChatActivity.DateActivity point in monthActivity.dateActivities)
                        {
                            chart.Series[i].Points.AddXY(x, point.Activity);
                            x++;
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Функция высчитывает точку для графика считая месячную активность
        /// </summary>
        /// <param name="dayActivity"></param>
        /// <returns></returns>
        internal ChatActivity CalculatePointsMonth(ChatActivity dayActivity)
        {
            ChatActivity monthActivity = new();
            monthActivity.dateActivities.Add(dayActivity.dateActivities[0]);
            foreach (ChatActivity.DateActivity day in dayActivity.dateActivities)
            {
                if (day.Day.Month != monthActivity.dateActivities.Last().Day.Month)
                {
                    monthActivity.dateActivities.Add(day);
                }
                else
                {
                    monthActivity.dateActivities.Last().Activity += day.Activity;
                }
            }
            return monthActivity;
        }
    }
}
