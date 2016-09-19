using System;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char someChar = char.Parse(Console.ReadLine());
            int firstPart = n;
            int firstPartSpaces = 0;
            int middleTimes = 1;
            int nSome = 5;
            while (nSome < n)
            {
                middleTimes++;
                nSome += 2;
            }
            for (int i = 0; i < middleTimes; i++)
            {
                Console.Write(new string(' ', firstPartSpaces));
                Console.Write(new string(someChar, firstPart));
                Console.Write(new string(' ', n));
                Console.Write(new string(someChar, firstPart));
                firstPart--;
                firstPartSpaces++;
                Console.WriteLine();
            }
            Console.Write(new string(' ', firstPartSpaces));
            Console.Write(new string(someChar, firstPart));
            Console.Write(new string(' ', (n - 3) / 2));
            Console.Write(someChar);
            Console.Write(' ');
            Console.Write(someChar);
            Console.Write(new string(' ', (n - 3) / 2));
            Console.WriteLine(new string(someChar, firstPart));
            firstPartSpaces += 1;

            for (int i = 0; i < n / 3; i++)
            {
                Console.Write(new string(' ', firstPartSpaces));
                Console.Write(new string(someChar, 3 * n - 2 * firstPartSpaces));
                Console.WriteLine();
            }
            int lastPart = n - 2;
            int lastPartSpaces = ((n * 2 + 1) - lastPart) / 2;
            for (int i = 0; i < middleTimes + 1; i++)
            {
                Console.Write(new string(' ', lastPartSpaces + firstPartSpaces));
                lastPartSpaces++;
                Console.Write(new string(someChar, lastPart));
                lastPart -= 2;
                Console.WriteLine();
            }


        }

    }
}