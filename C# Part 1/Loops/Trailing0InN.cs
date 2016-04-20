using System;

namespace _016.Trailing0
{
    class Trailing0
    {
        static int FindZeroes(int inputNumber, int powerOf, int zeroesAmount)
        {
            if (inputNumber < (Math.Pow(5, powerOf)))
                return zeroesAmount;
            else
                zeroesAmount += inputNumber / Convert.ToInt32(Math.Floor((Math.Pow(5, powerOf))));
            return FindZeroes(inputNumber, powerOf + 1, zeroesAmount);
        }
        static void Main()
        {
            int numAsString = FindZeroes(int.Parse(Console.ReadLine()), 1, 0);
            Console.WriteLine(numAsString);
        }
    }
}