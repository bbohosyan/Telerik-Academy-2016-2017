using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("{0:F2}", (text[i] * secret + 1000) / 100d);
                    }
                    else
                    {
                        Console.WriteLine((text[i] * secret + 1000) * 100);
                    }
                }
                else if (text[i] >= '0' && text[i] <= '9')
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", (text[i] + secret + 500) / 100d);
                    }
                    else
                    {
                        Console.WriteLine((text[i] + secret + 500) * 100);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", (text[i] - secret) / 100d);
                    }
                    else
                    {
                        Console.WriteLine((text[i] - secret) * 100);
                    }
                }
            }
        }
    }
}