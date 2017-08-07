using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                var num = nums[i];
                List<char> digits = Convert.ToString(num).ToCharArray().ToList();
                digits.Reverse();
                nums[i] = int.Parse(String.Join("", digits));
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
