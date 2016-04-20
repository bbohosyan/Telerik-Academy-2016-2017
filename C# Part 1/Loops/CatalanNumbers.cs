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
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger up = 1;
            BigInteger down1 = 1;
            BigInteger down2 = 1;
            for (BigInteger i = 1; i <= 2 * n; i++)
            {
                up *= i;
            }
            for (BigInteger i = 1; i <= n + 1; i++)
            {
                down1 *= i;
            }
            for (BigInteger i = 1; i <= n; i++)
            {
                down2 *= i;
            }
            BigInteger down = down1 * down2;
            BigInteger result = up / down;
            Console.WriteLine(result);
        }
    }
}