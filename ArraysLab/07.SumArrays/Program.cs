using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ').ToArray();
            var secondArr = Console.ReadLine().Split(' ').ToArray();
            var maxLength = 0;
            if (firstArr.Length > secondArr.Length) maxLength = firstArr.Length;
            else maxLength = secondArr.Length;
            var sum = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                sum[i] = int.Parse(firstArr[i % firstArr.Length]) + int.Parse(secondArr[i % secondArr.Length]);
                Console.Write($"{sum[i]} ");
            }
        }
    }
}
