using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPractice
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            Triangle tri = new Triangle(side, altitude);
            Console.WriteLine("{0:F2}", tri.CalculateArea());
        }
    }

    class Triangle
    {
        private double side;
        private double altitude;

        public Triangle(double side, double altitude)
        {
            this.altitude = altitude;
            this.side = side;
        }

        public double CalculateArea()
        {
            double area = this.side * this.altitude / 2;
            return area;
        }

    }
}
