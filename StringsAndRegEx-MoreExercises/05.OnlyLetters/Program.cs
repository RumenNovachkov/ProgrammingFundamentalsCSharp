using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = new Regex(@"(?<num>[0-9]+)(?<letter>[a-zA-Z])");
            var message = Console.ReadLine();

            var matchedNums = pattern.Matches(message);
            foreach (Match set in matchedNums)
            {
                var num = set.Groups["num"].ToString();
                var letter = set.Groups["letter"].ToString();
                message = message.Replace(num, letter);
            }
            Console.WriteLine(message);
        }
    }
}
