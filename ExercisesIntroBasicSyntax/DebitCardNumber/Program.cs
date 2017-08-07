using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPart = int.Parse(Console.ReadLine());
            var secondPart = int.Parse(Console.ReadLine());
            var thirdPart = int.Parse(Console.ReadLine());
            var forthPart = int.Parse(Console.ReadLine());

            Console.Write($"{firstPart:D4}");
            Console.Write($" {secondPart:D4}");
            Console.Write($" {thirdPart:D4}");
            Console.WriteLine($" {forthPart:D4}");
        }
    }
}
