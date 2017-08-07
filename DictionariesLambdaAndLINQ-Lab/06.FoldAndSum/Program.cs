using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            var firstPart = input.Take(k).Reverse().ToArray();
            var lastPart = input.Reverse().Take(k).ToArray();
            var upperRow = firstPart.Concat(lastPart).ToArray();
            var lowerRow = input.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < lowerRow.Length; i++) lowerRow[i] += upperRow[i];

            Console.WriteLine(string.Join(" ", lowerRow));
        }
    }
}
