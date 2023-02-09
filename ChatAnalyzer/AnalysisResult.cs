namespace ChatAnalyzer
{
    // класс привящазаный к текстовым боксам результата анали
    internal static class AnalysisResult
    {
        internal static IEnumerable<KeyValuePair<string, int>> AnalysisResultP1 { get; set; }
        internal static IEnumerable<KeyValuePair<string, int>> AnalysisResultP2 { get; set; }
        internal static List<double> RatioP1 { get; set; }
        internal static List<double> RatioP2 { get; set; }
        internal static string? ResultInfo { get;set; }


    }
}
