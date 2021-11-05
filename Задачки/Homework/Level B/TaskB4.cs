using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            // Здесь необходимо написать код.
            string k = "";
            foreach (char i in s)
            {
                if (i == '(')
                    k += i;
                else if (i == ')')
                    if (k == "")
                        return false;
                    else if (k[k.Length - 1] != '(')
                    {
                        return false;
                    }
                    else
                        k = k.Substring(0, k.Length - 1);
                else if (i == '{')
                    k += i;
                else if (i == '}')
                    if (k == "")
                        return false;
                    else if (k[k.Length - 1] != '{')
                        {
                            return false;
                        }
                    else
                        k = k.Substring(0, k.Length - 1);
                else if (i == '[')
                    k += i;
                else if (i == ']')
                    if (k == "")
                        return false;
                    else if (k[k.Length - 1] != '[')
                    {
                        return false;
                    }
                    else
                        k = k.Substring(0, k.Length - 1);
                else if (i == '<')
                    k += i;
                else if (i == '>')
                    if (k == "")
                        return false;
                    else if (k[k.Length - 1] != '<')
                    {
                        return false;
                    }
                    else
                        k = k.Substring(0, k.Length - 1);
            }
            return true;
        }
    }
}
