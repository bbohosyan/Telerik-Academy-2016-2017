﻿using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine((int)(word[i]) - 'a');
        }
    }
}