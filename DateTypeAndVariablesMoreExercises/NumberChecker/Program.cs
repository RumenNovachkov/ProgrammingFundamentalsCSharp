using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var conver = Convert.ToDouble(input);
            //Console.WriteLine(conver);
            if (conver % 1 == 0) Console.WriteLine("integer");
            else Console.WriteLine("floating-point");
        }
    }
}
