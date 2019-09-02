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
            //Реализовать метод проверки логина и пароля. 
            //На вход подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, 
            //если не прошел (Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, 
            //написать программу: пользователь вводит логин и пароль, 
            //программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            string log = "";
            string pass = "";
            int cou = 0;

            do
            {
                Console.WriteLine("Введите логин");
                log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                pass = Console.ReadLine();
                if (verifi(log,pass))
                {
                    Console.WriteLine("Вы вошли!");
                    break;
                }else
                {
                    Console.WriteLine("Введны неправильные логин или пароль");
                }
                cou++;
            } while (cou < 3);

            Console.ReadKey();
        }


       static bool verifi(string log, string pass)
        {
            string login = "root";
            string password = "GeekBrains";
            bool res = false;

            if (login == log && password == pass) 
            {
                res=true;
            }else
            {
                res=false;
            };
            return res;
        }
    }
}
