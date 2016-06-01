using System;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        string wantedWord = Console.ReadLine();
        string text = Console.ReadLine();
        wantedWord = wantedWord.ToLower();
        text = text.ToLower();
        int brWantedWordInText = 0;
        int nextIndex = text.IndexOf(wantedWord, 0);
        if (text.IndexOf(wantedWord, nextIndex) != -1)
        {
            brWantedWordInText++;
        }
        while (nextIndex != -1)
        {
            nextIndex = text.IndexOf(wantedWord, nextIndex + 1);
            brWantedWordInText++;
        }
        Console.WriteLine(brWantedWordInText - 1);
    }

}