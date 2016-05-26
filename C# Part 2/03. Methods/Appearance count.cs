using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        int lengthArray = int.Parse(Console.ReadLine());
        int[] array = new int[lengthArray];
        string arrayNumbersInput = Console.ReadLine();
        string[] arrayNumbersArray = arrayNumbersInput.Split(' ');
        for (int i = 0; i < arrayNumbersArray.Length; i++)
        {
            array[i] = int.Parse(arrayNumbersArray[i]);
        }
        int searchedNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(RepeatNumber(lengthArray, array, searchedNumber));
    }
    static int RepeatNumber(int lengthArray, int[] array, int searchedNumber)
    {
        int timesFound = 0;
        for (int i = 0; i < lengthArray; i++)
        {
            if (array[i] == searchedNumber)
            {
                timesFound++;
            }
        }
        return timesFound;
    }
}