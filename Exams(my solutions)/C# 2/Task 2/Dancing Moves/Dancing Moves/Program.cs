using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string firstNumber = Console.ReadLine();//"markoncykyanogi";
            string firstNumberNumeric = string.Empty;

            char operation = char.Parse(Console.ReadLine());

            string secondNumber = Console.ReadLine();//"cykyan";
            string secondNumberNumeric = string.Empty;

            for (int i = 0; i < firstNumber.Length; i+=3)
            {
                string value = string.Empty;
                switch (firstNumber.Substring(i,3))
                {
                    case "cad": value = "0"; break;
                    case "xoz": value = "1"; break;
                    case "nop": value = "2"; break;
                    case "cyk": value = "3"; break;
                    case "min": value = "4"; break;
                    case "mar": value = "5"; break;
                    case "kon": value = "6"; break;
                    case "iva": value = "7"; break;
                    case "ogi": value = "8"; break;
                    case "yan": value = "9"; break;
                }
                firstNumberNumeric += value;
            }

            for (int i = 0; i < secondNumber.Length; i += 3)
            {
                string value = string.Empty;
                switch (secondNumber.Substring(i, 3))
                {
                    case "cad": value = "0"; break;
                    case "xoz": value = "1"; break;
                    case "nop": value = "2"; break;
                    case "cyk": value = "3"; break;
                    case "min": value = "4"; break;
                    case "mar": value = "5"; break;
                    case "kon": value = "6"; break;
                    case "iva": value = "7"; break;
                    case "ogi": value = "8"; break;
                    case "yan": value = "9"; break;
                }
                secondNumberNumeric += value;
            }

            if (operation == '+')
            {
                StringBuilder sum = new StringBuilder();

                int n1 = firstNumberNumeric.Length;

                int n2 = secondNumberNumeric.Length;

                int carry = 0;

                int n = (n1 > n2) ? n1 : n2;

                if (n1 > n2)

                    secondNumberNumeric = secondNumberNumeric.PadLeft(n1, '0');

                else

                    firstNumberNumeric = firstNumberNumeric.PadLeft(n2, '0');

                for (int i = n - 1; i >= 0; i--)

                {

                    int value = (carry + firstNumberNumeric[i] - 48 + secondNumberNumeric[i] - 48) % 10;

                    sum.Append(value);

                    carry = (carry + firstNumberNumeric[i] - 48 + secondNumberNumeric[i] - 48) / 10;

                }

                char[] c = sum.ToString().ToCharArray();

                Array.Reverse(c);

                Console.WriteLine(c);
            }
            else
            {

                StringBuilder sum = new StringBuilder();

                int n1 = firstNumberNumeric.Length;

                int n2 = secondNumberNumeric.Length;

                int carry = 0;

                if (firstNumberNumeric[firstNumberNumeric.Length - 1] - 48 > secondNumberNumeric[secondNumberNumeric.Length - 1] - 48)
                {
                    carry = (firstNumberNumeric[firstNumberNumeric.Length - 1] - 48 - secondNumberNumeric[secondNumberNumeric.Length - 1] + 48) + 10;
                }

                int n = (n1 > n2) ? n1 : n2;

                if (n1 > n2)

                    secondNumberNumeric = secondNumberNumeric.PadLeft(n1, '0');

                else

                    firstNumberNumeric = firstNumberNumeric.PadLeft(n2, '0');

                Console.WriteLine(secondNumberNumeric);
                Console.WriteLine(firstNumberNumeric);

                for (int i = n - 1; i >= 0; i--)

                {

                    int value = (firstNumberNumeric[i] - 48 - secondNumberNumeric[i] + 48 - carry) % 10;

                    sum.Append(value);

                    carry = (carry + firstNumberNumeric[i] - 48 - secondNumberNumeric[i] + 48) / 10;

                }

                char[] c = sum.ToString().ToCharArray();

                Array.Reverse(c);

                Console.WriteLine(c);
            }
            
    */
            ulong br = 0;
            int currentPosition = 0;
            ulong result = 0;
            string path = Console.ReadLine();
            string[] pathToString = path.Split(' ');
            ulong[] pathToNumber = new ulong[pathToString.Length];
            for (int i = 0; i < pathToString.Length; i++)
            {
                pathToNumber[i] = ulong.Parse(pathToString[i]);
            }
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "stop")
                {
                    break;
                }
                br++;
                string[] inputLineToArr = inputLine.Split(' ');
                int numMoves = int.Parse(inputLineToArr[0]);
                string destination = inputLineToArr[1];
                int preskachane = int.Parse(inputLineToArr[2]);
                while (preskachane >= pathToNumber.Length)
                {
                    preskachane -= pathToNumber.Length;
                }
                for (int i = 0; i < numMoves; i++)
                {
                    if (destination == "right")
                    {
                        if (currentPosition + preskachane > pathToNumber.Length - 1)
                        {
                            currentPosition = preskachane - (pathToNumber.Length - 1 - currentPosition) - 1;
                            result += pathToNumber[currentPosition];
                        }
                        else
                        {
                            currentPosition += preskachane;
                            result += pathToNumber[currentPosition];
                        }
                    }
                    else
                    {
                        if (currentPosition - preskachane < 0)
                        {

                            currentPosition = (pathToNumber.Length - 1 - preskachane) + currentPosition + 1;
                            result += pathToNumber[currentPosition];
                        }
                        else
                        {
                            currentPosition -= preskachane;
                            result += pathToNumber[currentPosition];
                        }
                    }
                }
            }
            Console.WriteLine("{0:F1}", result / (double)br);
        }
    }
}