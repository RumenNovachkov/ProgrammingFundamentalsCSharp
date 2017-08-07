using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertFromBase_NtoBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var @base = int.Parse(input[0]);
            var num = input[1].Reverse().ToArray();

            var sum = new BigInteger();

            for (int power = 0; power < num.Length; power++)
            {
                var currentNum = int.Parse(num[power].ToString());
                sum += currentNum * BigInteger.Pow(@base, power);
            };
            Console.WriteLine(sum);
        }
    }
}
