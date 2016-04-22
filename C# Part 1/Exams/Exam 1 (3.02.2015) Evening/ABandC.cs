using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine(max);
            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine(min);
            Console.WriteLine("{0:F3}", (a + b + c) / 3d);
        }
    }
}