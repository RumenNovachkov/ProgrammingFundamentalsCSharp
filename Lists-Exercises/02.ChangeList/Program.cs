using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var interaction = Console.ReadLine().Split(' ').ToList();
                var firstValue = 0;
                var secondValue = 0;
                if (interaction.Count > 1) firstValue = int.Parse(interaction[1]);
                if (interaction.Count > 2) secondValue = int.Parse(interaction[2]);
                if (interaction[0] == "Delete")
                {
                    nums = RemoveAllELements(nums, firstValue);
                }
                else if (interaction[0] == "Insert")
                {
                    nums = InsertAtPosition(nums, firstValue, secondValue);
                }
                else if (interaction[0] == "Even")
                {
                    Even(nums);
                    return;
                }
                else if (interaction[0] == "Odd")
                {
                    Odd(nums);
                    return;
                }
            }
        }

        private static void Odd(List<int> nums)
        {
            var newList = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {

                if (nums[i] % 2 != 0)
                {
                    newList.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", newList));
        }

        private static void Even(List<int> nums)
        {
            var newList = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                
                if (nums[i] % 2 == 0)
                {
                    newList.Add(nums[i]);
                } 
            }
            Console.WriteLine(string.Join(" ", newList));
        }

        private static List<int> InsertAtPosition(List<int> nums, int firstValue, int secondValue)
        {
            nums.Insert(secondValue, firstValue);
            List<int> newNums = nums;
            return newNums;
        }

        private static List<int> RemoveAllELements(List<int> nums, int firstValue)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == firstValue)
                {
                    nums.Remove(firstValue);
                    i = 0;
                }
            }
            return nums;
        }
    }
}
