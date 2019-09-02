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
            //Написать программу «Анкета».
            //Последовательно задаются вопросы
            //(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.
            Console.WriteLine("Введите свое имя");
            string name=Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите свой рост");
            string growth = Console.ReadLine();
            Console.WriteLine("Введите свой вес");
            string mass = Console.ReadLine();

            Console.WriteLine();
            //а) используя склеивание;
            Console.WriteLine("Имя - " + name + ", Фамилия - " + surname + ", Возраст - " + age + ", Рост - " + growth + ", Вес - " + mass + ".");
            //б) используя форматированный вывод;
            Console.WriteLine("Имя - {0}, Фамилия - {1}, Возраст - {2}, Рост - {3}, Вес - {4}.", name, surname, age, growth, mass);
            //в) используя вывод со знаком $.
            // Не преподавался
            Console.ReadKey();
        }
    }
}
