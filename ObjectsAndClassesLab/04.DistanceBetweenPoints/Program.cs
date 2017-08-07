using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToArray();

            var p2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToArray();

            var result = Math.Sqrt(Math.Pow((p1[0] - p2[0]), 2) + Math.Pow((p1[1] - p2[1]), 2));
            Console.WriteLine($"{result:f3}");
        }
    }
}
