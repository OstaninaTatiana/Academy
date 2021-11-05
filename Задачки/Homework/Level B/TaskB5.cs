using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        static int find_max_lengt(List<string> text)
        {
            int max = 0;
            foreach (string i in text)
            {
                if (i.Length > max)
                    max = i.Length;
            }
            return max;
        }


        public static string Frame(List<string> text, char symbol)
        {
            // Здесь необходимо написать код.
            int len = find_max_lengt(text) + 4;
            string s="";
            for (int i = 0; i < len; i++)
                s += symbol;
            s += "\n";
            foreach (string i in text)
            {
                s += symbol + " ";
                s += i;
                for (int k = 0; k < len - i.Length - 4; k++)
                    s += " ";
                s += " " + symbol + "\n";
            }
            for (int i = 0; i < len; i++)
                s += symbol;
            return s;
        }
    }
}
