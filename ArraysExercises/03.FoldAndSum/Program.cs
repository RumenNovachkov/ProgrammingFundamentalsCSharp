using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrey = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstPartArrey = new int[arrey.Length / 4];
            var lastPartArrey = new int[arrey.Length / 4];
            var newArrray = new int[arrey.Length / 2];

            for (int i = 0; i < firstPartArrey.Length; i++)
            {
                firstPartArrey[i] = arrey[i];

                lastPartArrey[lastPartArrey.Length - 1 - i] = arrey[arrey.Length - 1 - i]; 

            }

            for (int i = 0; i < newArrray.Length; i++)
            {
                newArrray[i] = arrey[(firstPartArrey.Length) + i];
            }

            Reverse(firstPartArrey);
            Reverse(lastPartArrey);

            for (int i = 0; i < lastPartArrey.Length; i++)
            {
                newArrray[i] += firstPartArrey[i];
                newArrray[newArrray.Length - 1 - i] += lastPartArrey[lastPartArrey.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", newArrray));
            
        }

        private static void Reverse(int[] firstPartArrey)
        {
            Array.Reverse(firstPartArrey);
        }
    }
}
