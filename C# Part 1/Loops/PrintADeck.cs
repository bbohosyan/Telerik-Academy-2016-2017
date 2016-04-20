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
            string n = Console.ReadLine();
            int h = 0;
            string[] cardSigns = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < 13; i++)
            {
                if (n == cardSigns[i])
                {
                    h = i;
                }
            }
            for (int i = 0; i <= h; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cardSigns[i]);
            }
        }
    }
}