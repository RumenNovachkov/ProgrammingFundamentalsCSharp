using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = float.Parse(Console.ReadLine());
            var height = float.Parse(Console.ReadLine());
            var result = width * height;

            Console.WriteLine($"{result:f2}");
        }
    }
}
