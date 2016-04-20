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
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            int helperN = 1;
            double sum = 1;
            int fact = 1;
            while (helperN <= n)
            {
                fact = 1;
                for (int i = 1; i <= helperN; i++)
                {
                    fact *= i;
                }
                sum += fact / Math.Pow(x, (double)helperN);
                helperN++;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}