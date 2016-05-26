using System;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int maxLength = 1;
            int currentLength = 1;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                array[i] = currentNumber;
            }
            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;

                    }
                    currentLength = 1;
                }
            }
            Console.WriteLine(Math.Max(maxLength, currentLength));
        }
    }
}