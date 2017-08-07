using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string numsString = Console.ReadLine();
            var numbers = Regex.Matches(numsString, regex);
            foreach (Match num in numbers)
            {
                Console.Write(num.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
