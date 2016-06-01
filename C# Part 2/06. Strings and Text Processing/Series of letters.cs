using System;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        string letters = Console.ReadLine();
        if (letters.Length > 0)
        {
            char currentLetter = letters[0];
            Console.Write(letters[0]);
            for (int l = 1; l < letters.Length; l++)
            {
                if (letters[l] != currentLetter)
                {
                    Console.Write(letters[l]);
                    currentLetter = letters[l];
                }
            }
        }
        else
        {
            Console.WriteLine(string.Empty);
        }
    }

}