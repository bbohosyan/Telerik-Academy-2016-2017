using System;
using System.Numerics;

namespace TelerikPractice
{
    class Program
    {
        static void Main()
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = a;
            int min = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}", (double)(a + b + c) / 3);

        }
    }
}