using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        string threeNumbers = Console.ReadLine();
        string[] threeNumbersArray = threeNumbers.Split(' ');
        Console.WriteLine(GetMax(int.Parse(threeNumbersArray[0]), int.Parse(threeNumbersArray[1]), int.Parse(threeNumbersArray[2])));
    }
    static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
    {
        int max = firstNumber;
        if (max < secondNumber)
        {
            max = secondNumber;
        }
        if (max < thirdNumber)
        {
            max = thirdNumber;
        }
        return max;
    }
}