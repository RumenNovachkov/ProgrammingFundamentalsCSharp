using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(number, 16);
            Console.WriteLine(hex.ToUpper());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
        }
    }
}
