using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (Math.Abs(number % 2) == 0)
            {
                Console.WriteLine("even " + number);
            }
            else
            {
                Console.WriteLine("odd " + number);
            }
        }
    }
}
