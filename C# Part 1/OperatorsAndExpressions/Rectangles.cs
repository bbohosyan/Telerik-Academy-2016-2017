using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{1:F2} {0:F2}", 2 * width + 2 * height, width * height);

        }
    }
}
