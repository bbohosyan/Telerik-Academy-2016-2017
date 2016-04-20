using System;
using System.Numerics;



namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong number = ulong.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int bitValue = int.Parse(Console.ReadLine());

            ulong mask = 1;
            mask = mask << position;
            if (bitValue == 1)
            {
                number = number | mask;
            }
            else
            {
                mask = ~mask;
                number = number & mask;
            }
            Console.WriteLine(number);



        }
    }

}
