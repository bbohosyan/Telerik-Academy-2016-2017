using System;
class Program
{
    static void Main()
    {

        int arrayLength = int.Parse(Console.ReadLine());
        int numCombNumbers = int.Parse(Console.ReadLine());
        int[] arr = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            arr[i] = currentNumber;
        }
        int[] arrSum = new int[numCombNumbers];
        int finalSum = 0;
        Array.Sort(arr);
        for (int i = arr.Length - 1, j = 0; j < numCombNumbers; i--, j++)
        {
            finalSum += arr[i];
        }
        Console.WriteLine(finalSum);

    }
}