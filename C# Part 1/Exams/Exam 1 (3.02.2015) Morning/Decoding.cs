using System;
using System.Numerics;

namespace TelerikPractice
{
    class Program
    {
        static void Main()
        {

            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if ((text[i] >= 'a' && text[i] <= 'z') || (text[i] >= 'A' && text[i] <= 'Z'))
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", (double)(((double)text[i] * salt + 1000) / 100));
                    }
                    else
                    {
                        Console.WriteLine(((int)text[i] * salt + 1000) * 100);
                    }
                }
                else if (text[i] >= '1' && text[i] <= '9')
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", (double)(((double)text[i] + salt + 500) / 100));
                    }
                    else
                    {
                        Console.WriteLine(((int)text[i] + salt + 500) * 100);
                    }

                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", (double)(((double)text[i] - salt) / 100));
                    }
                    else
                    {
                        Console.WriteLine(((int)text[i] - salt) * 100);
                    }

                }
            }
        }
    }
}