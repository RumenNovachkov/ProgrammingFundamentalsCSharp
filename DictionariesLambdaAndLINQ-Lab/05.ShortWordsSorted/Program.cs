using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                                .ToLower()
                                .Split(
                                new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?' },
                                StringSplitOptions.RemoveEmptyEntries)
                                .Distinct()
                                .Where(w => w.Length < 5)
                                .OrderBy(w => w)
                                .ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
