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
            /*uint mainNumber = uint.Parse(Console.ReadLine());
            int mainNumberLong
            uint numberCombs = uint.Parse(Console.ReadLine());
            uint[] mainNumberBinary = new uint[32];
            for (int i = 0; i < length; i++)
            {

            }*/
            int numberInputs = int.Parse(Console.ReadLine());
            bool isFirstNumber = true;
            int numberGroups = 0;

            int[] numbers = new int[numberInputs];
            for (int i = 0; i < numberInputs; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            int currentLeaderGroup = numbers[0];
            for (int i = 1; i < numberInputs; i++)
            {
                if (currentLeaderGroup >= numbers[i])
                {
                    numberGroups++;
                    currentLeaderGroup = numbers[i];
                }
            }
            Console.WriteLine(numberGroups + 1);

        }

    }
}