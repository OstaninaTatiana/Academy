using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        static int sum(int n)
        {
            int s = 0;
            while (n > 0)
            {
                s += n % 10;
                n /= 10;
            }
            return s;
        }

        public static List<int> OrderWeight(List<int> list)
        {
            // Здесь необходимо написать код.
            int a;
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i; j++)
                {
                    if (sum(list[j]) > sum(list[j + 1]))
                    {
                        a = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = a;
                    }
                    if ((sum(list[j]) == sum(list[j + 1])) && (Convert.ToString(list[j])[0] > Convert.ToString(list[j+1])[0]))
                    {
                        a = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = a;
                    }
                }
            }
            return list;
        }
    }
}
