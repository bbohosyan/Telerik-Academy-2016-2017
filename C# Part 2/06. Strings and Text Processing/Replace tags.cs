using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitted = input.Split(new[] { "<a href=\"", "</a>" }, StringSplitOptions.None);
        for (int i = 1; i < splitted.Length; i += 2)
        {
            int index = splitted[i].IndexOf("\">");
            string URL = splitted[i].Substring(0, index);
            string TEXT = splitted[i].Substring(index + 2, splitted[i].Length - index - 2);
            splitted[i] = "[" + TEXT + "]" + "(" + URL + ")";
        }
        Console.WriteLine(string.Join(string.Empty, splitted));

    }
}