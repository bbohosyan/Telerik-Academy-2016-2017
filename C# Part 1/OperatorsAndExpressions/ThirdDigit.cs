using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + (number / 100) % 10);
            }

        }
    }
}
