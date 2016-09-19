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
            string firstNumber = Console.ReadLine();
            //"markoncykyanogi";
            string firstNumberNumeric = string.Empty;

            char operation = char.Parse(Console.ReadLine());

            string secondNumber = Console.ReadLine();
            //"cykyan";
            string secondNumberNumeric = string.Empty;

            for (int i = 0; i < firstNumber.Length; i += 3)
            {
                string value = string.Empty;
                switch (firstNumber.Substring(i, 3))
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


                StringBuilder result = new StringBuilder();
                for (int i = 0; i < c.Length; i++)
                {
                    switch (c[i])
                    {
                        case '0': result.Append("cad"); break;
                        case '1': result.Append("xoz"); break;
                        case '2': result.Append("nop"); break;
                        case '3': result.Append("cyk"); break;
                        case '4': result.Append("min"); break;
                        case '5': result.Append("mar"); break;
                        case '6': result.Append("kon"); break;
                        case '7': result.Append("iva"); break;
                        case '8': result.Append("ogi"); break;
                        case '9': result.Append("yan"); break;
                    }
                }
                Console.WriteLine(result);
            }
            else
            {

                BigInteger a = BigInteger.Parse(firstNumberNumeric);
                BigInteger b = BigInteger.Parse(secondNumberNumeric);
                BigInteger c = BigInteger.Subtract(a, b);
                string resultt = c.ToString();
                char[] d = resultt.ToString().ToCharArray();
                Array.Reverse(d);
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < d.Length; i++)
                {
                    switch (d[i])
                    {
                        case '0': result.Insert(0, "cad"); break;
                        case '1': result.Insert(0, "xoz"); break;
                        case '2': result.Insert(0, "nop"); break;
                        case '3': result.Insert(0, "cyk"); break;
                        case '4': result.Insert(0, "min"); break;
                        case '5': result.Insert(0, "mar"); break;
                        case '6': result.Insert(0, "kon"); break;
                        case '7': result.Insert(0, "iva"); break;
                        case '8': result.Insert(0, "ogi"); break;
                        case '9': result.Insert(0, "yan"); break;
                    }
                }
                Console.WriteLine(result);
            }



        }
    }
}