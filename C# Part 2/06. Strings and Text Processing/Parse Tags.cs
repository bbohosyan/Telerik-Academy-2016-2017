using System;
using System.Collections.Generic;
using System.Text;

class CorrectBrackets
{

    static void Main()
    {
        string text = Console.ReadLine();
        string[] textSplit = text.Split(new[] { "<upcase>", "</upcase>" }, StringSplitOptions.None);
        var result = new StringBuilder();
        for (int i = 0; i < textSplit.Length; i++)
        {
            if (i % 2 == 0)
            {
                result.Append(textSplit[i]);
            }
            else
            {
                result.Append(textSplit[i].ToUpper());
            }
        }
        Console.WriteLine(result);
    }
}