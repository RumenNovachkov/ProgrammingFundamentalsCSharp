using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            newList.Sort();

            Console.WriteLine(string.Join(" <= ", newList));
        }
    }
}
