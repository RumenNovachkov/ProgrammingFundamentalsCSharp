using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rotate = int.Parse(Console.ReadLine());

            var sumArr = new int[arr.Length];

            for (int i = 0; i < rotate; i++)
            {
                RotateArrey(arr);

                for (int j = 0; j < arr.Length; j++)
                {
                    sumArr[j] += arr[j];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }

        private static void RotateArrey(int[] arr)
        {
            var lastElement = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = lastElement;
        }
    }
}
