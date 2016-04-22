using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainNumber = int.Parse(Console.ReadLine());
            int[] mainNumberBinary = new int[4];
            int brOccurrences = 0;
            for (int i = 3; i >= 0; i--)
            {
                mainNumberBinary[i] = mainNumber % 2;
                mainNumber /= 2;
            }
            int brNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < brNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                int[] currentNumberBinary = new int[30];
                for (int j = 29; j >= 0; j--)
                {
                    currentNumberBinary[j] = currentNumber % 2;
                    currentNumber /= 2;
                }
                /*for (int z = 0; z < 30; z++)
                {
                    Console.Write(currentNumberBinary[z]);
                }*/
                for (int p = 0; p < 27; p++)
                {
                    if ((currentNumberBinary[p] == mainNumberBinary[0]) && (currentNumberBinary[p + 1] == mainNumberBinary[1]) && (currentNumberBinary[p + 2] == mainNumberBinary[2]) && (currentNumberBinary[p + 3] == mainNumberBinary[3]))
                    {
                        brOccurrences++;
                    }
                }
                //Console.WriteLine();
            }
            Console.WriteLine(brOccurrences);
        }
    }
}