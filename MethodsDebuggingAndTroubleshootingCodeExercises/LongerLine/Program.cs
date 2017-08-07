using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());
            bool firstCoupleLonger = GetCloserLine(x1, y1, x2, y2, x3, y3, x4, y4);
            if (firstCoupleLonger == true) Console.WriteLine(GetCloserPoint(x1, y1, x2, y2));
            else if (firstCoupleLonger == false) Console.WriteLine(GetCloserPoint(x3, y3, x4, y4));
        }

        static bool GetCloserLine(double x1, double y1, double x2, double y2,
                                    double x3, double y3, double x4, double y4)
        {
            bool firstLineLonger;
            if (Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2)) >=
                Math.Sqrt(Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2)))
            {
                firstLineLonger = true;
                return firstLineLonger;
            }
            else
            {
                firstLineLonger = false;
                return firstLineLonger;
            }
        }
        static string GetCloserPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt((x1 * x1) + (y1 * y1)) <= Math.Sqrt((x2 * x2) + (y2 * y2))) return ($"({x1}, {y1})({x2}, {y2})");
            else return ($"({x2}, {y2})({x1}, {y1})");
        }


    }
}
