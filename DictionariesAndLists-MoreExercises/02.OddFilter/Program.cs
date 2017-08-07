using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .Where(x => x % 2 == 0)
                                .ToList();

            var average = input.Average();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= average)    input[i]--;

                else                        input[i]++;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
