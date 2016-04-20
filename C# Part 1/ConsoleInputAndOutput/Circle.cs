using System;
using System.Numerics;



namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2} {1:F2}", 2.0 * Math.PI * r, Math.PI * r * r);
        }
    }

}
