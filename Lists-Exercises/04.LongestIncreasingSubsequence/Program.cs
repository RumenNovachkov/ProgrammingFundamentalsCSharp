using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] length = new int[input.Count];
            int[] prev = new int[input.Count];
            var bestLength = 0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < input.Count; anchor++)
            {
                length[anchor] = 1;
                prev[anchor] = -1;
                var anchorNum = input[anchor];
                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = input[i];
                    if (currentNum < anchorNum && length[i] + 1 > length[anchor])
                    {
                        length[anchor] = length[i] + 1;
                        prev[anchor] = i;
                    }
                }
                if (length[anchor] > bestLength)
                {
                    bestLength = length[anchor];
                    lastIndex = anchor;
                }
            }
            var longestIncreasingSequence = new List<int>();

            while (lastIndex != -1)
            {
                longestIncreasingSequence.Add(input[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestIncreasingSequence.Reverse();
            Console.WriteLine(string.Join(" ", longestIncreasingSequence));

        }
    }
}
