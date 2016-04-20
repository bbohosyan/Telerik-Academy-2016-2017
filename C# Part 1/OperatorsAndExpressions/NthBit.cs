using System;


namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long numberinB = long.Parse(Console.ReadLine());
            long[] numberArr = new long[64];
            for (int i = 0; i < 64; i++)
            {
                numberArr[i] = number % 2;
                number /= 2;
            }
            Console.WriteLine(numberArr[numberinB]);
        }

    }

}
