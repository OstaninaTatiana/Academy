using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B3.
    // Кол-во стингеров: ½🔹
    //
    // Написать функцию Decrypt(string key), которая подсчитывает количество вхождений символов с 'a' до 'z' и 
    // возвращает строку длиной 26 символов, где на каждой позиции - количетво вхождений этой буквы в строке. 
    // Буквы должны быть упорядочены, как в алфавите.
    //
    // Примеры:
    // decrypt('$aaaa#bbb*cc^fff!z') ==> '43200300000000000000000001'
    //           ^    ^   ^  ^  ^         ^^^  ^                   ^
    //          [4]  [3] [2][3][1]        abc  f                   z
    public static class TaskB3
    {
        public static string Decrypt(string key)
        {
            // Здесь необходимо написать код.
            int[] res = new int[26];
            for (int i=0; i < 26; i++)
            {
                res[i] = 0;
            }
            string alf = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < key.Length; i++)
            {
                if (alf.IndexOf(key[i]) >= 0)
                    res[alf.IndexOf(key[i])] += 1;
            }
            return string.Join("", res);
        }
    }
}
