using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleSurfByTwoSidesAndAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", Triangle.CalculateArea(sideA, sideB, angle));

        }
    }

    public static class Triangle
    {
        public static double CalculateArea(double sideA, double sideB, double angle)
        {
            double area = 0;
            double sin = Math.Sin(rad(angle));
            area = (sideA * sideB * sin) / 2;
            return area;
        }
        public static double rad(double deg)
        {
            return deg * Math.PI / 180;
        }


    }
}