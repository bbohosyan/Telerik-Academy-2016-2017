using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", number * 0.17d);
        }
    }
}
