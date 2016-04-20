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
            string type = Console.ReadLine();
            string result = Console.ReadLine();
            if (type == "integer")
            {
                int intResult = int.Parse(result);
                Console.WriteLine(intResult + 1);
            }
            else if (type == "real")
            {
                double doubleResult = double.Parse(result);
                Console.WriteLine("{0:F2}", doubleResult + 1);
            }
            else if (type == "text")
            {
                Console.WriteLine(result + '*');
            }
        }
    }
}