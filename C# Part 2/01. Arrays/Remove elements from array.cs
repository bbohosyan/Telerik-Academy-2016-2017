using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            int newMemberArray = int.Parse(Console.ReadLine());
            array[i] = newMemberArray;
        }
        int[] array2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            array2[i] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if ((array[j] <= array[i]) && (array2[i] < array2[j] + 1))
                {
                    array2[i] = array2[j] + 1;
                }
            }
        }
        /*for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array2[i]);
        }*/
        int result = 1;
        for (int i = 0; i < n; i++)
        {
            if (array2[i] > result)
            {
                result = array2[i];
            }
        }
        Console.WriteLine(n - result);

    }
}