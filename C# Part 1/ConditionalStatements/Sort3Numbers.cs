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
            double max = a;
            double min = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.Write(max + " ");
            if ((a > c || a > b) && (a < c || a < b))
            {
                Console.Write(a + " ");
            }
            else if ((b > c || b > a) && (b < c || b < a))
            {
                Console.Write(b + " ");
            }
            else
            {
                Console.Write(c + " ");
            }
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.Write(min);
        }
    }
}