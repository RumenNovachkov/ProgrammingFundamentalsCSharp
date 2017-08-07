using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var numberCount = new SortedDictionary<double, double>();

            foreach (var number in input)
            {
                if (!numberCount.ContainsKey(number))
                {
                    numberCount[number] = 0;
                }

                numberCount[number]++;
            }

            foreach (var number in numberCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
