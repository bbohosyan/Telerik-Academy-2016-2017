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
            int brNumbers = int.Parse(Console.ReadLine());
            string seperatedNumbers = Console.ReadLine();
            string[] numbers = seperatedNumbers.Split(' ');
            BigInteger productOdd = 1;
            BigInteger productEven = 1;
            for (int i = 0; i < brNumbers; i++)
            {
                int currentNumberFromArr = int.Parse(numbers[i]);
                if ((i + 1) % 2 == 0)
                {
                    productEven *= currentNumberFromArr;
                }
                else
                {
                    productOdd *= currentNumberFromArr;
                }
            }
            if (productOdd == productEven)
            {
                Console.WriteLine("yes {0}", productEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd, productEven);
            }
        }
    }
}