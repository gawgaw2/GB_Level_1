using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, возвращающий минимальное из трех чисел.
            int a = 5;
            int b = 7;
            int c = 8;
            int minimum = 0;
            minimum = minValue(a, b, c);
            Console.WriteLine("Минимальное число = " + minimum);
            Console.ReadKey();

        }
        static int minValue(int a, int b, int c)
        {
            int res = c;
            if (a<res)
            {
                res = a;
            }
             else if (b<res)
            {
                res = b;
            };
     
            return res;
        }
    }
}
