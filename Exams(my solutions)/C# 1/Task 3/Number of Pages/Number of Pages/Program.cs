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
            int d = int.Parse(Console.ReadLine());
            int copyD = d;
            int currentPage = 1;
            while (copyD > 0)
            {
                int brDigitsCurrentPage = 0;
                int copyCurrentPage = currentPage;
                while (copyCurrentPage > 0)
                {
                    copyCurrentPage /= 10;
                    brDigitsCurrentPage++;
                }
                currentPage++;
                copyD -= brDigitsCurrentPage;
            }
            Console.WriteLine(currentPage - 1);

        }

    }
}