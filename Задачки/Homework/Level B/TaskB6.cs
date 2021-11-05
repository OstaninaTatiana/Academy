using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        static string rev(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
                res = s[i] + res;
            return res;
        }

        public static string Reverser(string s)
        {
            string res = "";
            string[] a = s.Split();
            for (int i = 0; i < a.Length; i++)
            {
                res += rev(a[i]) + " ";
            }
            res = res.Substring(0, res.Length - 1);
            return res;
        }
    }
}
