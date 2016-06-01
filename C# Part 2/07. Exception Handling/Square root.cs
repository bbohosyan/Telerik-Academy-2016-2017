using System;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        string a = Console.ReadLine();
        double b;
        if (double.TryParse(a, out b) == false)
        {
            Console.WriteLine("Invalid number");
            Console.WriteLine("Good bye");
        }
        else
        {
            b = double.Parse(a);
            if (b < 0)
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Good bye");
            }
            else
            {
                Console.WriteLine("{0:F3}", Math.Sqrt(b));
                Console.WriteLine("Good bye");
            }
        }
    }
}