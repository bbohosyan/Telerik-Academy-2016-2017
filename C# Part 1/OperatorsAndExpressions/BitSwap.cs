using System;


namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int startP = p;
            int startQ = q;
            int mask = 1;
            int value1;
            int value2;
            while (true)
            {
                if (startP + k - 1 < p)
                {
                    break;
                }
                mask = mask << p;
                if ((mask | n) == n)
                {
                    value1 = 1;
                }
                else
                {
                    value1 = 0;
                }
                mask = 1;
                mask = mask << q;
                if ((mask | n) == n)
                {
                    value2 = 1;
                }
                else
                {
                    value2 = 0;
                }
                mask = 1;
                mask = mask << p;
                if (value2 == 1)
                {
                    n = n | mask;
                }
                else
                {
                    mask = ~mask;
                    n = n & mask;
                }
                mask = 1;
                mask = mask << q;
                if (value1 == 1)
                {
                    n = n | mask;
                }
                else
                {
                    mask = ~mask;
                    n = n & mask;
                }
                p++;
                q++;
                mask = 1;


            }
            Console.WriteLine(n);


        }
    }

}
