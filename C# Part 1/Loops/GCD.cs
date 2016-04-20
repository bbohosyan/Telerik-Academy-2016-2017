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
            string ab = Console.ReadLine();
            string[] aAndB = ab.Split(' ');
            int a = int.Parse(aAndB[0]);
            int b = int.Parse(aAndB[1]);
            for (int i = Math.Max(a, b); i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}