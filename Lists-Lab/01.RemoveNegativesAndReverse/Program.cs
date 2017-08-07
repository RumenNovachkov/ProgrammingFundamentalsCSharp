using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] < 0)
                {
                    newList.Remove(newList[i]);
                    i = -1;
                }
            }
            newList.Reverse();
            if (newList.Count > 0) Console.WriteLine(string.Join(" ", newList));
            else Console.WriteLine("empty");
        }
    }
}
