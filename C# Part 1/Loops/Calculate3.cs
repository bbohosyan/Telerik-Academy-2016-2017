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
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger factNMinusK = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                factK *= i;
            }
            for (int i = 1; i <= n - k; i++)
            {
                factNMinusK *= i;
            }
            Console.WriteLine(factN / (factK * factNMinusK));
        }
    }
}