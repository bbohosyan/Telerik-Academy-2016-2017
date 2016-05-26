using System;

class Program
{
    static void Main()
    {

        int arrayLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            arr[i] = currentNumber;
        }
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


    }
}