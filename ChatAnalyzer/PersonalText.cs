using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    internal class PersonalText
    {
        internal PersonalText()
        {
            StringBuilder text1 = new(), text2 = new();
            string text = ChatInfo.Text;
            string person1 = ChatInfo.Person1, person2 = ChatInfo.Person2;
            int counter1 = 0, counter2 = 0;
            int index1 = text.IndexOf(person1, counter1), index2 = text.IndexOf(person2, counter2);
            bool indexFlag1 = Char.IsDigit(text[index1 + 2]), indexFlag2 = Char.IsDigit(text[index2 + 2]);

            if (!File.Exists("temp\\text1.txt") || !File.Exists("temp\\text2.txt"))
            {
                while ( index1 != -1 || index2 != -1 )
                {
                    if (indexFlag1 && indexFlag2)
                        if ( index1 < index2 )
                        {
                            text1.Append(text.Substring(index1, index2).Trim());
                            counter1 = index2 + person2.Length;
                        }
                        else
                        {
                            text1.Append(text.Substring(index2, index1).Trim());
                            counter2 = index1 + person1.Length;
                        }
                    else
                    {
                       if (indexFlag1)
                        {
                            counter2 = index1 + person1.Length;
                        }
                       else
                        {
                            counter1 = index2 + person2.Length;
                        }
                    }
                }
                File.WriteAllText("temp\\text1.txt", text1.ToString(), Encoding.Unicode);
                File.WriteAllText("temp\\text2.txt", text2.ToString(), Encoding.Unicode);

                ChatInfo.TextPerson1 = text1.ToString();
                ChatInfo.TextPerson2 = text2.ToString();
            }
        }
    }
}
