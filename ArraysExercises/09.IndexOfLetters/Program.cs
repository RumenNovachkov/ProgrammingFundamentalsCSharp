using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] eachLetter = text.ToCharArray();

            int[] nums = new int[eachLetter.Length];

            for (int i = 0; i < eachLetter.Length; i++)
            {
                nums[i] = Convert.ToInt32(eachLetter[i]) - 97;
            }

            for (int i = 0; i < eachLetter.Length; i++)
            {
                Console.WriteLine($"{eachLetter[i]} -> {nums[i]}");
            }
        }
    }
}
