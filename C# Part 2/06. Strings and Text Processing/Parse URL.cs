using System;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        string URLAddress = Console.ReadLine();
        string[] seperateProtocol = URLAddress.Split(new[] { "://" }, StringSplitOptions.None);
        string protocol = seperateProtocol[0];//http://telerikacademy.com/Courses/Courses/Details/212
        string server = seperateProtocol[1].Substring(0, seperateProtocol[1].IndexOf('/'));
        string resource = seperateProtocol[1].Substring(seperateProtocol[1].IndexOf('/'), seperateProtocol[1].Length - server.Length);
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }

}