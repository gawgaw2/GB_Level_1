using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            int a = 2;
            int b = 5;
            Console.WriteLine("Начальные значения");
            Console.WriteLine("Переменная а = {0}, Переменная в = {1}", a, b);
            Console.WriteLine();

            //а) с использованием третьей переменной;
            int c = 0;
            c = a;
            a = b;
            b =c;
            Console.WriteLine("С использованием третьей переменной");
            Console.WriteLine("Переменная а = {0}, Переменная в = {1}", a, b);
            Console.WriteLine();

            //б) *без использования третьей переменной.
            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine("Без использования третьей переменной");
            Console.WriteLine("Возвращаем начальные значения");
            Console.WriteLine("Переменная а = {0}, Переменная в = {1}", a, b);
            Console.WriteLine();

            Console.ReadKey();
            qwe
            rty
            rty
        }
    }
}
