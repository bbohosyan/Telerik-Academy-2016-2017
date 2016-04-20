using System;


namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint[] numberArr = new uint[32];
            for (int i = 0; i < 32; i++)
            {
                numberArr[i] = number % 2;
                number /= 2;
            }
            Console.WriteLine(numberArr[3]);
        }
    }
}

