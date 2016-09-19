using System;

namespace TelerikPractise
{

    class Program
    {
        static void Main(string[] args)
        {
            uint mainNumber = uint.Parse(Console.ReadLine());
            string mainNumberBinary = Convert.ToString(mainNumber, 2);
            uint countOtherNumbers = uint.Parse(Console.ReadLine());
            uint currentBiggestNumber = 0;
            uint countMaxTeeth = 0;

            for (uint i = 0; i < countOtherNumbers; i++)
            {
                uint currentNumber = uint.Parse(Console.ReadLine());
                uint brTeeth = 0;
                uint copyCurrentNumber = currentNumber;
                if ((currentNumber & mainNumber) == 0)
                {
                    while (currentNumber > 0)
                    {
                        if (currentNumber % 2 == 1)
                        {
                            brTeeth++;
                        }
                        currentNumber /= 2;
                    }

                }
                if (countMaxTeeth < brTeeth)
                {
                    countMaxTeeth = brTeeth;
                    currentBiggestNumber = copyCurrentNumber;
                }

            }
            Console.WriteLine(currentBiggestNumber);
        }

    }
}