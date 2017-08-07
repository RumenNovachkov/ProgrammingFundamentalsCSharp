using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintFibonachiNumber(n));
        }
        static int PrintFibonachiNumber(int n)
        {
            var fibonachiZero = 1;
            var fibonachiFirst = 0;

            for (int i = 0; i < n; i++)
            {
                var currentFibonachi = fibonachiZero + fibonachiFirst;
                fibonachiFirst = fibonachiZero;
                fibonachiZero = currentFibonachi;
                //Console.WriteLine(currentFibonachi); 
            }
            if (n == 0) fibonachiZero = 1;
            return fibonachiZero;
        }
    }
}
