using System;


namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int mask = 1;
            int value3;
            mask = mask << 3;
            if ((mask | number) == number)
            {
                value3 = 1;
            }
            else
            {
                value3 = 0;
            }
            mask = 1;
            int value4;
            mask = mask << 4;
            if ((mask | number) == number)
            {
                value4 = 1;
            }
            else
            {
                value4 = 0;
            }
            mask = 1;
            int value5;
            mask = mask << 5;
            if ((mask | number) == number)
            {
                value5 = 1;
            }
            else
            {
                value5 = 0;
            }
            mask = 1;
            int value24;
            mask = mask << 24;
            if ((mask | number) == number)
            {
                value24 = 1;
            }
            else
            {
                value24 = 0;
            }
            mask = 1;
            int value25;
            mask = mask << 25;
            if ((mask | number) == number)
            {
                value25 = 1;
            }
            else
            {
                value25 = 0;
            }
            mask = 1;
            int value26;
            mask = mask << 26;
            if ((mask | number) == number)
            {
                value26 = 1;
            }
            else
            {
                value26 = 0;
            }
            mask = 1;
            mask = mask << 3;
            if (value24 == 1)
            {
                number = number | mask;
            }
            else
            {
                mask = ~mask;
                number = number & mask;
            }
            mask = 1;
            mask = mask << 4;
            if (value25 == 1)
            {
                number = number | mask;
            }
            else
            {
                mask = ~mask;
                number = number & mask;
            }
            mask = 1;
            mask = mask << 5;
            if (value26 == 1)
            {
                number = number | mask;
            }
            else
            {
                mask = ~mask;
                number = number & mask;
            }
            mask = 1;
            mask = mask << 24;
            if (value3 == 1)
            {
                number = number | mask;
            }
            else
            {
                mask = ~mask;
                number = number & mask;
            }
            mask = 1;
            mask = mask << 25;
            if (value4 == 1)
            {
                number = number | mask;
            }
            else
            {
                mask = ~mask;
                number = number & mask;
            }
            mask = 1;
            mask = mask << 26;
            if (value5 == 1)
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
