using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А2.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию VeryEven(number), которая определяет является ли число "очень четным".
    // Однозначное число "очень четное", если оно четное. Числа больше 10 "очень четные",
    // если сумма их цифр - "очень четное" число.
    //
    // Примеры:
    // VeryEven(88) => false -> 8 + 8 = 16 -> 1 + 6 = 7 => 7 - нечетное;
    // VeryEven(222) => true -> 2 + 2 + 2 = 8 => 8 - четное.
    public static class TaskA2
    {
        static int sum(int n)
        {
            int s = 0;
            while (n > 0)
            {
                s += n % 10;
                n /= 10;
            }
            if (s < 10)
                return s;
            else
                return sum(s);
        }
        
        
        public static bool VeryEven(int number)
        {
            // Здесь необходимо написать код.
            
            if (sum(number) % 2 == 1)
                return false;
            else
                return true;
        }
    }
}
