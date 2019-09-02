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
            //Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела (ИМТ)по формуле 
            //I = m / (h * h); где
            //m — масса тела в килограммах, 
            //h — рост в метрах.

            Console.WriteLine("Введите свой рост в метрах");
            string growth = Console.ReadLine();
            Console.WriteLine("Введите свой вес в киллограммах");
            string mass = Console.ReadLine();
            Console.WriteLine();

            double h = double.Parse(growth);
            double m = double.Parse(mass);
            double I = m / (h * h);
          
            Console.WriteLine("ИМТ = " + I);
            Console.ReadKey();
        }
    }
}
