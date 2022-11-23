using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ChatAnalyzer
{
    internal interface IAnalyzer
    {
        string Analyze(string text);
        string Analyze(string text, int amount);
    }
}
