using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestStartIndex = 0;
            var bestLength = 0;

            var currentStartIndex = 0;
            var currentLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] >= 1)
                {
                    
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestStartIndex = currentStartIndex;
                        bestLength = currentLength;
                    }
                }
                else
                {
                    currentStartIndex = i;
                    currentLength = 1;
                }
            }

            for (int i = bestStartIndex; i < bestLength + bestStartIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
