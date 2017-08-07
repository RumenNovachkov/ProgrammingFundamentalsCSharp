using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[A-F0-9a-f]+\b";


            var numbersString = Console.ReadLine();
            var numbers = Regex.Matches(numbersString, regex)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
