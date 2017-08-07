using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double area = 0;
            if (figure == "triangle") area = GetTrinangleArea();
            else if (figure == "square") area = GetSquareArea();
            else if (figure == "rectangle") area = GetRectangleArea();
            else if (figure == "circle") area = GetCircleArea();

            Console.WriteLine($"{area:f2}");
        }

        private static double GetCircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = radius * radius * Math.PI;
            return area;
        }

        private static double GetRectangleArea()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;
            return area;
        }

        static double GetSquareArea()
        {
            var side = double.Parse(Console.ReadLine());
            var area = side * side;
            return area;
        }

        static double GetTrinangleArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = side * height / 2;
            return area;
        }
    }
}
