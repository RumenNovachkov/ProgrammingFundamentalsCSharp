using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            length = Math.Abs(length);
            string parameter = Console.ReadLine().ToLower();
            var result = 0.0;
            if (parameter == "face") result = GetFaceDiagonals(length);
            else if (parameter == "space") result = GetSpaceDiagonals(length);
            else if (parameter == "volume") result = GetVolume(length);
            else if (parameter == "area") result = GetArea(length);

            Console.WriteLine($"{result:f2}");
        }

        private static double GetArea(double length)
        {
            var result = 6 * Math.Pow(length, 2);
            return result;
        }

        private static double GetVolume(double length)
        {
            var result = Math.Pow(length, 3);
            return result;
        }

        private static double GetSpaceDiagonals(double length)
        {
            var result = Math.Sqrt(3 * Math.Pow(length, 2));
            return result;
        }

        private static double GetFaceDiagonals(double length)
        {
            var result = Math.Sqrt(2 * Math.Pow(length, 2));
            return result;
        }
    }
}
