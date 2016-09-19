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
            uint b = uint.Parse(Console.ReadLine());
            uint f = uint.Parse(Console.ReadLine());
            double average = f / (double)b;
            if (b % 2 == 0)
            {
                Console.WriteLine("{0:F4}", average * 123123123123d);
            }
            else
            {
                Console.WriteLine("{0:F4}", average / 317d);
            }

        }

    }
}
