using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //С клавиатуры вводятся числа, пока не будет введен 0.
            //Подсчитать сумму всех нечетных положительных чисел.
            int count = 0;
            string mes = "";
            int intMes = 0;

            do
            {
                Console.WriteLine("Введите число");
                mes=Console.ReadLine();
                intMes = int.Parse(mes);
                if (intMes > 0 && (intMes % 2 != 0)) count++;
              
            } while (intMes != 0);
            Console.WriteLine("Количество положительных и нечетных чисел = " + count);
            Console.ReadKey();
        }
    }
}
