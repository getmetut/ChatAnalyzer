namespace ChatAnalyzer
{
    // класс привящазаный к текстовым боксам результата анали
    internal static class AnalysisResult
    {
        internal static IEnumerable<KeyValuePair<string, int>> ResultP1 { get; set; }
        internal static IEnumerable<KeyValuePair<string, int>> ResultP2 { get; set; }
        internal static List<double> RatioP1 { get; set; }
        internal static List<double> RatioP2 { get; set; }
        internal static string? ResultInfo { get;set; }
        internal static ChatActivity ChartInfoP1 { get; set; }
        internal static ChatActivity ChartInfoP2 { get; set; }
        internal static List<ChatActivity> chatActivities { get; set; }

        internal static void Clean()
        {
            ResultP1 = null;
            ResultP2 = null;
            RatioP1 = null;
            RatioP2 = null;
            ResultInfo = null;
            ChartInfoP1 = null;
            ChartInfoP2 = null;
        }
    }
}
