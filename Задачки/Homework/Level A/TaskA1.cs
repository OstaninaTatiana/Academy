﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А1.
    // Кол-во стингеров: ⅓🔹
    //
    // Напишите функцию NumberOfSquares(int limit), которая будет возвращать,
    // сколько целых (начиная с 1, 2 ...) чисел, возведенных в степень 2,
    // а затем суммированных, меньше некоторого заданного числа в качестве
    // параметра limit.
    //
    // Примеры:
    // NumberOfSquares(6) => 2 -> 1 ^ 2 + 2 ^ 2 = 1 + 4 = 5 и 5 < 6;
    // NumberOfSquares(15) => 3 -> 1 ^ 2 + 2 ^ 2 + 3 ^ 2 = 1 + 4 + 9 = 14 и 14 < 15.
    public static class TaskA1
    {
        public static int NumberOfSquares(int limit)
        {
            // Здесь необходимо написать код.
            int s = 0;
            int i;
            for (i=0; s < limit; i++)
            {
                s += i * i;
            }
            return i - 2; //При некотором значении i начинает превышать заданное число => вычитаем 1.
                          //Кроме того, на следующем круге прибавляется ещё 1 => вновь вычитаем 1. Итого вычитаем 2
        }
    }
}
