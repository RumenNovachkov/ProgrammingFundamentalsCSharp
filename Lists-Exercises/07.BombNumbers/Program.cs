using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var specNumPow = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                var specialNum = -1;
                specialNum = nums.IndexOf(specNumPow[0]);
                var power = specNumPow[1];
                if (specialNum == -1) break;

                var start = 0;
                var finish = 0;
                if (specialNum - power >= 0) start = specialNum - power;
                if (specialNum + power <= nums.Count - 1) finish = specialNum + power;
                else finish = nums.Count - 1;

                for (int i = start; i <= finish; i++)
                {
                    nums.RemoveAt(start);
                }
                
            }
            

            Console.WriteLine(nums.Sum());

        }
    }
}
