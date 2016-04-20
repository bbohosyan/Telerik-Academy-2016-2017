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
            string binary = Console.ReadLine();
            BigInteger result = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                int helper1 = 0;
                switch (binary[i])
                {
                    case '0': helper1 = 0; break;
                    case '1': helper1 = 1; break;
                    case '2': helper1 = 2; break;
                    case '3': helper1 = 3; break;
                    case '4': helper1 = 4; break;
                    case '5': helper1 = 5; break;
                    case '6': helper1 = 6; break;
                    case '7': helper1 = 7; break;
                    case '8': helper1 = 8; break;
                    case '9': helper1 = 9; break;
                    case 'A': helper1 = 10; break;
                    case 'B': helper1 = 11; break;
                    case 'C': helper1 = 12; break;
                    case 'D': helper1 = 13; break;
                    case 'E': helper1 = 14; break;
                    case 'F': helper1 = 15; break;
                }
                result += helper1 * (BigInteger)Math.Pow(16, binary.Length - i - 1);
            }
            Console.WriteLine(result);

        }
    }
}