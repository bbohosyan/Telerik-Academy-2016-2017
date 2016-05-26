using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n + 1];
        for (int i = 0; i < n + 1; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            arr[i] = currentNumber;
        }
        bool isThere = false;
        for (int i = 0; i < n; i++)
        {
            if (arr[n] == arr[i])
            {
                isThere = true;
                Console.WriteLine(i);
                break;
            }
        }
        if (isThere == false)
        {
            Console.WriteLine(-1);
        }
    }
}