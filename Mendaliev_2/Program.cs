﻿using System;

namespace Mendaliev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от языка системы дробные числа с точкой не конвертируются из строк
            //поэтому точки вручную заменяем на запятые
            //.Replace(".", ",")

            Console.WriteLine("Введите m: ");
            double m = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите n: ");
            double n = double.Parse(Console.ReadLine().Replace(".", ","));

            double b;
            if (m > n)
            {
                b = m;
            }
            else
            {
                b = m * m * n;
            }

            double a;
            if (b > 5)
            {
                a = Math.Cos(b);
            }
            else
            {
                if (b < 0)
                {
                    Console.WriteLine("Ошибка! b < 0");
                    return;
                }
                else
                {
                    a = b * b - b * Math.Sqrt(b);
                }
            }

            double s = Math.Sqrt(a * a + b);
            if (s == Math.PI / 2 || s == 3 * Math.PI / 2)
            {
                Console.WriteLine("Ошибка! a * a + b = 0");
                return;
            }

            double t = Math.Tan(s);
            if (t == a)
            {
                Console.WriteLine("Ошибка! a = tg(a * a + b)");
                return;
            }

            double Z = (a * a + Math.Cos(a)) / (a - t);
            Console.WriteLine("Z = " + Z);
        }
    }
}