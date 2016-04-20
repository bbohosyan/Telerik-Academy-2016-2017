using System;


namespace TelerikPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 && x >= -1 && x <= 5 && y >= -1 && y <= 1)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) > 1.5 && x >= -1 && x <= 5 && y >= -1 && y <= 1)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) > 1.5 && (x < -1 || x > 5 || y < -1 || y > 1))
            {
                Console.WriteLine("outside circle outside rectangle");
            }
            else
            {
                Console.WriteLine("inside circle outside rectangle");
            }
        }
    }
}
