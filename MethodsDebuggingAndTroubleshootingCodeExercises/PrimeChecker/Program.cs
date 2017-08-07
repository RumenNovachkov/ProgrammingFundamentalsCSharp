using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            IsPrime(n);
        }
        static void IsPrime(long number)
        {
            
            var prime = (number > 1);
            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }

            }
            if (prime) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
