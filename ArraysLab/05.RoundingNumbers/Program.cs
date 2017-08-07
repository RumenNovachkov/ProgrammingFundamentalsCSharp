using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = ReadNumbers();
            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} -> {roundedNums[i]}");
            }
        }

        static double[] ReadNumbers()
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            return nums;
        }
    }
}
