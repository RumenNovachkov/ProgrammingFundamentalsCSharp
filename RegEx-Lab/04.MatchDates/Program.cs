using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})\2(\d{4})\b";

            var datesString = Console.ReadLine();

            var dates = Regex.Matches(datesString, regex);

            foreach (Match item in dates)
            {
                var day = item.Groups["1"].Value;
                var month = item.Groups["3"].Value;
                var year = item.Groups["4"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
