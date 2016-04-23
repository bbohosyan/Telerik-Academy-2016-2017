
namespace TelerikPractise
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main()
        {
            BigInteger result1 = 1;
            BigInteger result2 = 1;
            BigInteger index = 0;
            while (true)
            {
                string inputText = Console.ReadLine();
                BigInteger number;
                if (inputText!="END")
                {
                    number = BigInteger.Parse(inputText);
                }
                else
                {
                    break;
                }
                if (index % 2 == 0)
                {
                    if (index < 10)
                    {
                        while (number > 0)
                        {
                            if (number % 10 != 0)
                            {
                                result1 *= number % 10;
                            }
                            number /= 10;
                        }
                    }
                    else
                    {
                        while (number > 0)
                        {
                            if (number % 10 != 0)
                            {
                                result2 *= number % 10;
                            }
                            number /= 10;
                        }
                    }

                }
                index++;

            }
            Console.WriteLine(result1);
            if (index > 10)
            {
                Console.WriteLine(result2);
            }

        }
    }
}