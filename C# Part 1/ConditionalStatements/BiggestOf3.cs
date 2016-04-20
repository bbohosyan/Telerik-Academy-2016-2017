using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double max1 = Math.Max(a, b);
            double max2 = Math.Max(b, c);
            if (max2 > max1)
            {
                Console.WriteLine(max2);
            }
            else
            {
                Console.WriteLine(max1);
            }




        }
    }
}