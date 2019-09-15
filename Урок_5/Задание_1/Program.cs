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
            /*
           Создать программу, которая проверяет корректность ввода логина. 
           Корректным логином будет строка от 2 до 10 символов, 
           содержащая только буквы латинского алфавита или цифры, 
           при этом цифра не может быть первой:
           */
            
            bool flag = false;
                        
            do
            {
                Console.WriteLine("Введите логин");
                Console.WriteLine("");
                string log = Console.ReadLine();
                char st = log[0];
                if (char.IsDigit(st) || log.Length < 2 || log.Length > 10)
                {
                    Console.WriteLine("Логин неверен ");
                }
                else if (pass(log))
                {
                    Console.WriteLine("Логин верен ");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Логин неверен ");
                }
            } while (!flag);
           
           


            Console.ReadKey();
        }
       static bool pass(string a)
        {
            bool result = false;
            int k = 0;
           foreach (var i in a)
            {
                if (char.IsDigit(a[k]) || char.IsLetter(a[k]))
                {
                    result = true;
                }
                k++;
            }

            return  result;
        }
    }
}
