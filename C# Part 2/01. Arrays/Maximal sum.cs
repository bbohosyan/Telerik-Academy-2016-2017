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
        int maxValue = int.MinValue;
        int maxValueForNow = int.MinValue;
        int currentValue = 0;
        int startingPosition = 0;
        for (int i = startingPosition; i < n; i++)
        {
            for (int j = startingPosition; j < n; j++)
            {
                currentValue += array[j];
                if (maxValueForNow < currentValue)
                {
                    maxValueForNow = currentValue;
                }

            }
            if (maxValueForNow > maxValue)
            {
                maxValue = maxValueForNow;
            }
            maxValueForNow = 0;
            currentValue = 0;
            startingPosition++;
        }
        Console.WriteLine(maxValue);

    }
}