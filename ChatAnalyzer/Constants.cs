namespace ChatAnalyzer
{
    internal struct Constants
    {
        public static string[] partials = { "ли", "разве", "неужели", "что", "а", "вон", "вот", "именно", "точно", "ровно", "подлинно", "как", "просто",
                "прямо", "еще", "и", "же", "лишь", "уж", "ведь", "даже", "просто", "прямо", "все",
                "только","лишь","исключительно","только","всего","хоть","бы","единственно","разве","неужели","вряд","едва","навряд",
                "авось","да","ну","так","точно","либо","нибудь","то","кое", "не",
                "но", "это", "че", "ещё", "уже", "там", "тоже", "шо", "или", "ага", "тут", "та", "ща"};
        public static string[] prepositions = {"в", "к", "до", "через", "после", "течение", "изза", "за", "к", "над", "под", "перед", "у", "через",
        "возле", "мимо", "около", "от", "по", "ради", "благодаря", "ввиду", "вследствие", "для", "на", "вопреки", "об", "обо", "о", "про",
        "насчет", "с", "вроде", "наподобие", "как", "без", "когда", "из"};
        public static string[] pronouns = {"я", "ты", "он", "она", "оно", "мы", "вы", "они", "себя", "мой", "твой", "ваш", "наш", "свой", "его",
        "ее","её","их","этот","тот","такой","такое","столько","сей","оный","сам","самый","весь","всякий","каждый","любой","другой",
        "иной","всяк","всяческий","кто","что","какой","который","чей","сколько","те","никто","ничто","некого","нечего","никакой","ничей","некто",
        "нечто","некоторый","некий","нескольео","либо", "мне", "нас"
        , "меня", "тебя", "тебе"};
        public static string[] tExept = {"data", "not", "change", "", "exported", "kb", "to", ChatInfo.InitialP1T.ToLower(), ChatInfo.InitialP2T.ToLower(),
                ChatInfo.FullNameP1T.ToLower(), ChatInfo.FullNameP2T.ToLower(), ChatInfo.InitialP1T, ChatInfo.InitialP2T,
                ChatInfo.FullNameP1T, ChatInfo.FullNameP2T, TextFunctions.OnlyText(ChatInfo.FullNameP1T, new char[] {'-'}).ToLower(),
                TextFunctions.OnlyText(ChatInfo.FullNameP2T, new char[] {'-'}).ToLower(), ChatInfo.InitialP1.ToLower(), ChatInfo.InitialP2.ToLower(),
                "included", "exporting", "settings", "download", "message", "voice", "video", "this", "reply", "location",
                "photo", "file", "https", "sticker", "www", "outgoing", "change", "included", "december", "january", "february",
                "march", "april", "may", "june", "july", "august", "september", "october", "november", "previous", "cancelled",
                "com", "seconds", "messages", "tiktok", "amp", "in", "960×1280", "853×1280", "591×1280", "mb", "720×1280", "576×1280", "2022"};
        public static string[] tExeptNoInit = {"data", "not", "change", "", "exported", "kb", "to",
                "included", "exporting", "settings", "download", "message", "voice", "video", "this", "reply", "location",
                "photo", "file", "https", "sticker", "www", "outgoing", "change", "included", "december", "january", "february",
                "march", "april", "may", "june", "july", "august", "september", "october", "november", "previous", "cancelled",
                "com", "seconds", "messages", "tiktok", "amp", "in", "960×1280", "853×1280", "591×1280", "mb", "720×1280", "576×1280", "2022"};
    }
}
