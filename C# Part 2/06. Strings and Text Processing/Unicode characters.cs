using System;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            int currentInt = text[i];
            string currentHexa = currentInt.ToString("X");
            Console.Write("\\u{0}", currentHexa.PadLeft(4, '0'));
        }
    }

}