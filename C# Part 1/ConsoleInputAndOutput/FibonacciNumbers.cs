using System;
using System.Numerics;



namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] fibonacci = new BigInteger[50];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < 50; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            int n = int.Parse(Console.ReadLine());
            Console.Write("0");
            for (int i = 1; i < n; i++)
            {
                Console.Write(", {0}", fibonacci[i]);
            }
            Console.WriteLine();
        }
    }
}
