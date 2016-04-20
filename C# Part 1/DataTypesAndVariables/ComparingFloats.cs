using System;

namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            //double number1V2 = Math.Round(number1, 6);
            //double number2V2 = Math.Round(number2, 6);
            if (number1 - number2 > 0.000001 || number2 - number1 > 0.000001)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
