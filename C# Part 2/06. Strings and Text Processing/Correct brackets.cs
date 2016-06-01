using System;

namespace _03_Correct_Brackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            var toCheck = Console.ReadLine();

            var win = "Correct";
            var notwin = "Incorrect";

            var openBrackets = 0;
            var closeBrackets = 0;

            foreach (var element in toCheck)
            {
                if (element == '(')
                {
                    openBrackets++;

                    continue;
                }

                if (element == ')')
                {
                    closeBrackets++;

                    continue;
                }
            }

            if (openBrackets == closeBrackets)
            {
                Console.WriteLine(win);
            }
            else
            {
                Console.WriteLine(notwin);
            }
        }
    }
}