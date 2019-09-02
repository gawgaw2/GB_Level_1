using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод подсчета количества цифр числа.
            int a = 123456789;
            int res = 0;
            res = coun(a);
            Console.WriteLine("Количество цифр = " + res);

            Console.ReadKey();
        }

        static int coun(int a)
        {
            int res = 0;
            string f = Convert.ToString(a);

            foreach (char i in f)
            {
                res++;
            };

            return res;
        }
    }
}
