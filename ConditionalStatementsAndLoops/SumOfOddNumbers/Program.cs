using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 1;
            for (int i = 1; i <= 1000000; i++)
            {
                if (i % 2 != 0 && counter <= n)
                {
                    counter++;
                    Console.WriteLine(i);
                    sum += i;
                }
                               
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
