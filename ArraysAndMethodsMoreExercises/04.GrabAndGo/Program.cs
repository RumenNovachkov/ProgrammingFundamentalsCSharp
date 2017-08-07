using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            int position = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == n)
                {
                    position = i;
                    break;
                }
            }
            if (position == -1)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }
            //Console.WriteLine(position);

            Array.Resize(ref arr, position);

            //Console.WriteLine(string.Join(" ", arr));

            long sum = FindSum(arr);
            Console.WriteLine(sum);
        }

        static long FindSum(long[] arr)
        {
            long sum = 0;
            for (long i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
