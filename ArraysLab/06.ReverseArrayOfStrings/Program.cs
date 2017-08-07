using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < nums.Length / 2; i++)
            {
                SwipeElements(nums, i, nums.Length - 1 - i);
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        private static void SwipeElements(string[] nums, int i, int j)
        {
            var oldElement = nums[i];
            nums[i] = nums[j];
            nums[j] = oldElement;
        }
    }
}
