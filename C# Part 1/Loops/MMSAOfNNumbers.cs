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
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }

            }
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum / (double)n);
        }
    }
}