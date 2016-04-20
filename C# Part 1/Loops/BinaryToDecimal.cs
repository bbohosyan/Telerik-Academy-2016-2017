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
            int result = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                result += (binary[i] - '0') * (int)Math.Pow(2, binary.Length - i - 1);
            }
            Console.WriteLine(result);

        }
    }
}