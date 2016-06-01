using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TriangleSurfaceByThreeSides
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());


            Triangle tri = new Triangle(sideA, sideB, sideC);
            Console.WriteLine("{0:F2}", tri.CalculateArea());

        }
    }

    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;


        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double p = (this.sideA + this.sideB + this.sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return area;
        }

    }
}