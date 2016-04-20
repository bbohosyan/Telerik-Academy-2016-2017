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
            int decimalNumber = int.Parse(Console.ReadLine());
            int[] binaryNumber = new int[32];
            int helper1 = 0;
            for (int i = 0; decimalNumber > 0; i++)
            {
                binaryNumber[i] = decimalNumber % 2;
                decimalNumber /= 2;
                helper1++;
            }
            for (int i = 0; i < helper1 / 2; i++)
            {
                int helper2 = binaryNumber[i];
                binaryNumber[i] = binaryNumber[helper1 - 1 - i];
                binaryNumber[helper1 - 1 - i] = helper2;
            }
            for (int i = 0; i < helper1; i++)
            {
                Console.Write(binaryNumber[i]);
            }
        }
    }
}