using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertFromBase_10toBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var @base = int.Parse(input[0]);
            var n = BigInteger.Parse(input[1]);

            var drd = new List<BigInteger>();

            while (n != 0)
            {
                drd.Add(n % @base);
                n /= @base;
            }
            drd.Reverse();
            Console.WriteLine(string.Join("", drd));
        }
    }
}
