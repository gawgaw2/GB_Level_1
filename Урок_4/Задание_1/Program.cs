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
            //Дан целочисленный массив из 20 элементов.
            //Элементы массива могут принимать целые значения 
            //от –10 000 до 10 000 включительно.
            //Написать программу, позволяющую найти и вывести 
            //количество пар элементов массива, в которых 
            //хотя бы одно число делится на 3.
            int[] mass = new int [20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(verMass(mass));

            Console.ReadKey();
        }
        /// <summary>
        /// Проверяет пары значений, которые делятся  на 3
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        static int verMass(int[] m)
        {
            int count = 0;
            for (int i=0; i<(m.Length)-1 ; i++)
               if ((m[i] % 3==0) ||( m[i + 1] % 3==0)) count++;
   
            return count;
        }
    }
}
