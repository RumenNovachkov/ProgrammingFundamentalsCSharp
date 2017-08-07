using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestIndex = 0;
            var bestLength = 0;

            var currentIndex = 0;
            var currentLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestIndex = currentIndex;
                        bestLength = currentLength;
                    }
                }

                else
                {
                    currentIndex = i;
                    currentLength = 1;
                }
            }

            for (int i = bestIndex; i < bestLength + bestIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
