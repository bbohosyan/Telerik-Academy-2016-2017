using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        decimal inputNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine(RepeatNumber(inputNumber));
    }
    static char[] RepeatNumber(decimal inputNumber)
    {
        char[] inputNumbertex = inputNumber.ToString().Reverse().ToArray();
        return inputNumbertex;

    }
}