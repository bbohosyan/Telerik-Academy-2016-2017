using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int brHashtag = 0;
            int dots = 2 * n - 3 - 2 * d;
            int brSpaces = 2 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('#', brHashtag));
                Console.Write('\\');
                if (dots >= 1)
                {
                    Console.Write(new string(' ', d));
                    Console.Write('\\');
                    Console.Write(new string('.', dots));
                    Console.Write('/');
                    Console.Write(new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', brSpaces));
                }
                Console.Write('/');
                Console.Write(new string('#', brHashtag));
                brSpaces -= 2;
                brHashtag += 1;
                dots -= 2;
                Console.WriteLine();
            }
            Console.Write(new string('#', n));
            Console.Write('X');
            Console.Write(new string('#', n));
            Console.WriteLine();
            brHashtag = n - 1;
            brSpaces = 1;
            dots = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('#', brHashtag));
                Console.Write('/');
                if (2 * n - 3 - 2 * brHashtag - 2 * d >= 1)
                {
                    //Console.Write(new string('#', brHashtag));
                    //Console.Write('/');
                    Console.Write(new string(' ', d));
                    Console.Write('/');
                    Console.Write(new string('.', dots));
                    Console.Write('\\');
                    Console.Write(new string(' ', d));
                    //Console.Write('\\');
                    //Console.Write(new string('#', brHashtag));
                    dots += 2;
                }
                else
                {
                    //Console.Write(new string('#', brHashtag));
                    //Console.Write('/');
                    Console.Write(new string(' ', brSpaces));
                    //Console.Write('\\');
                    //Console.Write(new string('#', brHashtag));
                }
                Console.Write('\\');
                Console.Write(new string('#', brHashtag));
                brHashtag -= 1;
                brSpaces += 2;
                Console.WriteLine();
            }
        }
    }
}