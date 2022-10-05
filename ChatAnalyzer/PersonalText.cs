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
            // задаем необходимые переменные
            StringBuilder text1 = new(), text2 = new();
            string text = ChatInfoTemp.Text;
            string person1 = ChatInfo.InitialsPerson1, person2 = ChatInfo.InitialsPerson2;
            // выше все понятно, а ниже переменные по которым мы будем определять встречание инициалов
            // и то подходит ли данное встречание или нет
            int index1 = text.IndexOf(person1), index2 = text.IndexOf(person2);
            bool indexFlag1 = Char.IsDigit(text[index1 + person1.Length + 1]), indexFlag2 = Char.IsDigit(text[index2 + person2.Length + 1]);
            
            if (ChatInfo.TextPerson1 == null || ChatInfo.TextPerson2 == null)
            {
                while (index1 != -1 && index2 != -1)
                {
                    if (indexFlag1 && indexFlag2)
                    {
                        if (index1 < index2)
                        {
                            text1.Append(text.Substring(index1, index2 - index1 - 1).Trim()).Append(' ');
                            index1 = text.IndexOf(person1, index1 + person1.Length);
                            indexFlag1 = Char.IsDigit(text[index1 + person1.Length + 1]);
                        }
                        else
                        {
                            text2.Append(text.Substring(index2, index1 - index2 - 1).Trim()).Append(' ');
                            index2 = text.IndexOf(person2, index2 + person2.Length);
                            indexFlag2 = Char.IsDigit(text[index2 + person2.Length + 1]);
                        }
                    }
                    else
                    {
                        if (indexFlag1)
                        {
                            index2 = text.IndexOf(person2, index2 + person2.Length);
                            indexFlag2 = Char.IsDigit(text[index2 + person2.Length + 1]);
                        }
                        else
                        {
                            index1 = text.IndexOf(person1, index1 + person1.Length);
                            indexFlag1 = Char.IsDigit(text[index1 + person1.Length + 1]);
                        }
                    }

                    ChatInfo.TextPerson1 = text1.ToString();
                    ChatInfo.TextPerson2 = text2.ToString();
                }
            }
        }
    }
}
