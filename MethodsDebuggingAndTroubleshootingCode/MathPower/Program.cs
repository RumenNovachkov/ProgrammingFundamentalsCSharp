using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            Console.WriteLine(PoweringNum(number, power));
        }

        private static double PoweringNum(double number, int power)
        {
            var result = Math.Pow(number, power);
            return result;
        }
    }
}
