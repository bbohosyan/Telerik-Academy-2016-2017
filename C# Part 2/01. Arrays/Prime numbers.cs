using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = n; i >= 2; i--)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}