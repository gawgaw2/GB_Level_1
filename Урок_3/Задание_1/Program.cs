using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    //Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    //Продемонстрировать работу структуры;
    struct Complex
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        //  Пример вычитания двух комплексных чисел
        public Complex sub(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine("При сложении re = {0}, im = {1}", result.re, result.im);

            result = complex1.sub(complex2);
            Console.WriteLine("При вычитании re = {0}, im = {1}", result.re, result.im);

            result = complex1.Multi(complex2);
            Console.WriteLine("При умножении re = {0}, im = {1}", result.re, result.im);

            Console.ReadKey();
        }
    }
}
