using System;
using System.Numerics;



namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbersArr = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbersArr[i] = double.Parse(Console.ReadLine());
            }
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result += numbersArr[i];
            }
            Console.WriteLine(result);
        }
    }
}
