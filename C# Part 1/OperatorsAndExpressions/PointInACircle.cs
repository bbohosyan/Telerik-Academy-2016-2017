using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) > 2)
            {
                Console.WriteLine("no {0:F2}", Math.Sqrt(x * x + y * y));
            }
            else
            {
                Console.WriteLine("yes {0:F2}", Math.Sqrt(x * x + y * y));
            }

        }
    }
}
