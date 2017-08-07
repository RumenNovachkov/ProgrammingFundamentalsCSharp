using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] actions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var newList = new List<int>();

            for (int i = 0; i < actions[0]; i++)
            {
                newList.Add(nums[i]);
            }

            for (int i = actions[1] - 1; i >= 0 ; i--)
            {
                newList.RemoveAt(i);
            }

            bool present = false;
            foreach (var item in newList)
            {
                if (item == actions[2])
                {
                    present = true;
                }
            }

            if (present == true)    Console.WriteLine("YES!");
            else                    Console.WriteLine("NO!");
        }
    }
}
