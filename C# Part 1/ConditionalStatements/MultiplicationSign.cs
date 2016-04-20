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
            int brLessThanZero = 0;
            if (a < 0)
            {
                brLessThanZero++;
            }
            if (b < 0)
            {
                brLessThanZero++;
            }
            if (c < 0)
            {
                brLessThanZero++;
            }
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else if (brLessThanZero % 2 == 0)
            {
                Console.WriteLine('+');
            }
            else
            {
                Console.WriteLine('-');
            }



        }
    }
}