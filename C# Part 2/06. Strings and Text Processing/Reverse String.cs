using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] toArrayText = text.ToCharArray();
        Array.Reverse(toArrayText);
        Console.WriteLine(string.Join(string.Empty, toArrayText));
    }

}
