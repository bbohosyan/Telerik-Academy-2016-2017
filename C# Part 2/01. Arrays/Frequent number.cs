using System;

class Program
{
    static void Main()
    {
        int numNumbers = int.Parse(Console.ReadLine());
        int[] allNumbers = new int[numNumbers];
        for (int i = 0; i < numNumbers; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            allNumbers[i] = currentNumber;
        }
        int specialNumberIndex = 0;
        int currentNumTimes = 0;
        int specialNumberNumTimes = 0;
        for (int i = 0; i < numNumbers; i++)
        {
            for (int j = 0; j < numNumbers; j++)
            {
                if (allNumbers[i] == allNumbers[j])
                {
                    currentNumTimes++;
                }
            }
            if (currentNumTimes > specialNumberNumTimes)
            {
                specialNumberIndex = i;
                specialNumberNumTimes = currentNumTimes;
            }
            currentNumTimes = 0;
        }
        Console.WriteLine("{0} ({1} times)", allNumbers[specialNumberIndex], specialNumberNumTimes);
    }
}