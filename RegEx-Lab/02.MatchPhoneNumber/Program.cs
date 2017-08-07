using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"((\+359) (2) ([0-9]{3}) ([0-9]{4})\b)|((\+359)\-(2)\-([0-9]{3})\-([0-9]{4})\b)";

            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var phonesMatched = phoneMatches
                .Cast<Match>()
                .Select(p => p.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", phonesMatched));
        }
    }
}
