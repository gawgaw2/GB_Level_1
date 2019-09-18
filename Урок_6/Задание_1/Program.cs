using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public delegate double Fun(double x, double y);

    class Program
    {
        public static void Table(Fun F, double x, double y, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,y));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double Func_1(double x, double a)
        {
            return a * (x*x);
        }
        public static double Func_2(double x, double a)
        {
            return a * (Math.Sin(x));
        }

        static void Main(string[] args)
        {
            /*
            Изменить программу вывода таблицы функции так, 
            чтобы можно было передавать функции типа double (double, double).
            Продемонстрировать работу на функции 
            с функцией a*x^2 и функцией a*sin(x).
            */
 
            Console.WriteLine("Таблица функции a*x^2:");
            Table(new Fun(Func_1), -2, 2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new Fun(Func_2), 0, 3, 2);

            Console.ReadKey();
        }
    }
}
