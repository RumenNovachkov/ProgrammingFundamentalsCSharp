using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintArea(width, height));
        }

        private static double PrintArea(double width, double height)
        {
            var result = width * height / 2;
            return result;
        }
    }
}
