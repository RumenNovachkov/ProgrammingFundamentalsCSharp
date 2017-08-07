using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var times = input.Split(' ')
                            .OrderBy(x => x)
                            .ToList();

            Console.WriteLine(string.Join(", ", times));
        }
    }
}
