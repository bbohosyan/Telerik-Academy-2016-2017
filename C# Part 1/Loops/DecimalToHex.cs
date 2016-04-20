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
            ulong decimalNumber = ulong.Parse(Console.ReadLine());
            char[] binaryNumber = new char[32];
            int helper1 = 0;
            for (int i = 0; decimalNumber > 0; i++)
            {
                int reliqua = (int)(decimalNumber % 16);
                switch (reliqua)
                {
                    case 0: binaryNumber[i] = '0'; break;
                    case 1: binaryNumber[i] = '1'; break;
                    case 2: binaryNumber[i] = '2'; break;
                    case 3: binaryNumber[i] = '3'; break;
                    case 4: binaryNumber[i] = '4'; break;
                    case 5: binaryNumber[i] = '5'; break;
                    case 6: binaryNumber[i] = '6'; break;
                    case 7: binaryNumber[i] = '7'; break;
                    case 8: binaryNumber[i] = '8'; break;
                    case 9: binaryNumber[i] = '9'; break;
                    case 10: binaryNumber[i] = 'A'; break;
                    case 11: binaryNumber[i] = 'B'; break;
                    case 12: binaryNumber[i] = 'C'; break;
                    case 13: binaryNumber[i] = 'D'; break;
                    case 14: binaryNumber[i] = 'E'; break;
                    case 15: binaryNumber[i] = 'F'; break;
                }
                decimalNumber /= 16;
                helper1++;
            }
            for (int i = 0; i < helper1 / 2; i++)
            {
                char helper2 = binaryNumber[i];
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