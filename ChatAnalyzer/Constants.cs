using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    internal struct Constants
    {
        public static string[] partials = { "ли", "разве", "неужели", "что", "а", "вон", "вот", "именно", "точно", "ровно", "подлинно", "как", "просто",
                "прямо", "еще", "и", "же", "лишь", "уж", "ведь", "даже", "просто", "прямо", "все",
                "только","лишь","исключительно","только","всего","хоть","бы","единственно","разве","неужели","вряд","едва","навряд",
                "авось","да","ну","так","точно"};
        public static string[] tExept = {"data", "not", "change",
                "included", "exporting", "settings", "download", "message", "voice", "video", "this", "reply",
                "photo", "file", "https", "sticker", "www", "outgoing", "change", "included",
                "com", "seconds", "messages", "tiktok", "amp"};
    }
}
