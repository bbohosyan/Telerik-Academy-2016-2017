using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine(AskName());
    }
    static string AskName()
    {
        string inputName = Console.ReadLine();
        string sayHello = "Hello, " + inputName + "!";
        return sayHello;
    }
}