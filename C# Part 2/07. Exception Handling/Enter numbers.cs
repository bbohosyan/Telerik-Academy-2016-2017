using System;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        bool isException = false;
        if (numbers[0] > 0 && numbers[numbers.Length - 1] < 100 && numbers[0] < numbers[1])
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    isException = true;
                }
            }
            if (isException)
            {
                Console.WriteLine("Exception");
            }
            else
            {
                Console.Write(1 + " < ");
                for (int z = 0; z < numbers.Length; z++)
                {
                    Console.Write(numbers[z] + " < ");
                }
                Console.WriteLine("100");
            }
        }
        else
        {
            Console.WriteLine("Exception");
        }

    }
}