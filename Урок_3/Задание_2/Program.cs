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
            //С клавиатуры вводятся числа, пока не будет введен 0
            //(каждое число в новой строке).
            //Требуется подсчитать сумму всех нечетных положительных чисел. 
            //Сами числа и сумму вывести на экран, используя tryParse;

            bool result = false;
            int x = 0;
            int count = 0;
            int inp = 0;
            string sinp = "";
            do
            {
                Console.WriteLine("Введите положительное и нечетное число");
                sinp =Console.ReadLine();
                result= int.TryParse(sinp, out x);
                if (result) 
                {
                    inp = int.Parse(sinp);
                    Console.WriteLine("Вы введи {0}", sinp);
                };
                if (inp == 0) break;
                if (inp>0 && inp%2==1   )
                {
                    count++;
                }

            } while (result);

            Console.WriteLine("Число правильных вводов = {0}", count);

            Console.ReadKey();
        }
    }
}
