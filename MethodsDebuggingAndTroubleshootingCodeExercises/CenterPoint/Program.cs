using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(GetCloserPoint(x1, y1, x2, y2));
        }

        static string GetCloserPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt((x1 * x1) + (y1 * y1)) <= Math.Sqrt((x2 * x2) + (y2 * y2))) return ($"({x1}, {y1})");
            else return ($"({x2}, {y2})");
        }
    }
}
