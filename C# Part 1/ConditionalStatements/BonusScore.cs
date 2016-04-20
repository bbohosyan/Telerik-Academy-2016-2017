using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= 0 || number > 9)
            {
                Console.WriteLine("invalid score");
            }
            else if (number >= 1 && number <= 3)
            {
                Console.WriteLine(number * 10);
            }
            else if (number >= 4 && number <= 6)
            {
                Console.WriteLine(number * 100);
            }
            else if (number >= 7 && number <= 9)
            {
                Console.WriteLine(number * 1000);
            }

        }
    }
}