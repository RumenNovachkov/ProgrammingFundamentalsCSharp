using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0) Console.WriteLine($"The number {number} is positive.");
            else if (number < 0) Console.WriteLine($"The number {number} is negative.");
            else Console.WriteLine($"The number {number} is zero.");
        }
        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }
    }
}
