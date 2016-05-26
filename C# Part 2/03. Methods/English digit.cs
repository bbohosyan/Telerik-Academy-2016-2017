using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(number));
    }
    static string GetLastDigitAsWord(int number)
    {
        string asEnglishWord = string.Empty;
        switch (number % 10)
        {
            case 0: asEnglishWord = "zero"; break;
            case 1: asEnglishWord = "one"; break;
            case 2: asEnglishWord = "two"; break;
            case 3: asEnglishWord = "three"; break;
            case 4: asEnglishWord = "four"; break;
            case 5: asEnglishWord = "five"; break;
            case 6: asEnglishWord = "six"; break;
            case 7: asEnglishWord = "seven"; break;
            case 8: asEnglishWord = "eight"; break;
            case 9: asEnglishWord = "nine"; break;
        }
        return asEnglishWord;
    }
}
