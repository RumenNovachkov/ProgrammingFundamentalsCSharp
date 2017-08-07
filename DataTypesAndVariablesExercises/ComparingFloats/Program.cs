using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if ((Math.Abs((Math.Abs(firstNum)) - (Math.Abs(secondNum)))) >= eps)  Console.WriteLine("False");
            else Console.WriteLine("True");
        }
    }
}
