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
        Console.WriteLine(RepeatNumber(lengthArray, array));
    }
    static int RepeatNumber(int lengthArray, int[] array)
    {
        int numElements = 0;
        for (int i = 1; i < lengthArray - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
            }
        }
        return -1;
    }
}