using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var charList = input.ToCharArray();

            var numbList = charList.Where(x => x == '0' || x == '1' || x == '2' || x == '3' || x == '4' || x == '5' || x == '6' || x == '7' || x == '8' || x == '9').ToList();

            var textList = charList.Where(x => x != '0' && x != '1' && x != '2' && x != '3' && x != '4' && x != '5' && x != '6' && x != '7' && x != '8' && x != '9').ToList();

            var takeList = new List<int>();
            var skipList = new List<int>();
            for (int i = 0; i < numbList.Count; i++)
            {
                if (i % 2 == 0) takeList.Add(numbList[i] - 48);

                else skipList.Add(numbList[i] - 48);
            }

            var result = new StringBuilder();
            var skipTotal = 0;

            for (int i = 0; i < skipList.Count; i++)
            {
                result.Append(string.Concat(textList.Skip(skipTotal).Take(takeList[i])));
                skipTotal += takeList[i] + skipList[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
