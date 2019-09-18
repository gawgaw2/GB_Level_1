using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Переделать программу Пример использования коллекций 
            для решения следующих задач:
        а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
        в) отсортировать список по возрасту студента;
            */
            int bakalavr = 0;
            int magistr = 0;
            int age = 0;
            // Создадим необобщенный список
            ArrayList list = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                    list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    if (int.Parse(s[5]) > 18 && int.Parse(s[5]) < 22) age++; 

                }
                catch
                {
                }
            }
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Учится на 5-6 курсе:{0} студентов", magistr);
            Console.WriteLine("В возрасте 18-22:{0}", age);
           

            Console.ReadKey();


        }
      
        
      } 
    }
