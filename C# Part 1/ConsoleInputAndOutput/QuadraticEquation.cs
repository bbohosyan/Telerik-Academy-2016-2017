using System;
using System.Numerics;



namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((b * b - 4 * a * c) < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {

                double d = Math.Sqrt(b * b - 4 * a * c);
                if (Math.Min((-b - d) / (2 * a), (-b + d) / (2 * a)) != Math.Max((-b - d) / (2 * a), (-b + d) / (2 * a)))
                {
                    Console.WriteLine("{0:F2}", Math.Min((-b - d) / (2 * a), (-b + d) / (2 * a)));
                    Console.WriteLine("{0:F2}", Math.Max((-b - d) / (2 * a), (-b + d) / (2 * a)));
                }
                else
                {
                    Console.WriteLine("{0:F2}", Math.Min((-b - d) / (2 * a), (-b + d) / (2 * a)));
                }
            }
        }
    }

}
