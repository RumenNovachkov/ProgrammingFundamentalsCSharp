using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] result = new int[1000];

            foreach (var num in nums)
            {
                result[num] += 1;
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0) Console.WriteLine($"{i} -> {result[i]}");
            }
        }
    }
}
