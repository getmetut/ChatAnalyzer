namespace ChatAnalyzer
{
    internal class ChartCreator
    {
        internal ChartCreator(ChatActivity activity, bool isPersonal, Program.KindAnalysis kind, System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[0].Points.Clear();
            ChatActivity monthActivity = CalculatePoints(activity);
            switch (kind)
            {
                case Program.KindAnalysis.General:
                    int x = 0;
                    foreach (ChatActivity.DateActivity point in monthActivity.dateActivities)
                    {
                        chart.Series[0].Points.AddXY(x, point.Activity);
                        x++;
                    }
                    break;
            }
        }

        internal ChatActivity CalculatePoints(ChatActivity dayActivity)
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
