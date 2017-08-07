using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var mostFreqFind = (from items in arr group items by items into g orderby g.Count() descending select g.Key).First();

            Console.WriteLine(mostFreqFind);
        }
    }
}
