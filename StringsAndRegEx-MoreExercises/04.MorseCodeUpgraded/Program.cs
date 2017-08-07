using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var secretMessage = Console.ReadLine().Split('|').ToArray();
            var decriptedMessage = new StringBuilder();
            var sum = 0;
            foreach (var group in secretMessage)
            {
                var reg0 = new Regex(@"(?<zero>[0]+)");
                var reg1 = new Regex(@"(?<zero>[1]+)");
                var ZeroMatch = reg0.Matches(group);
                foreach (Match zeroes in ZeroMatch)
                {
                    sum += zeroes.Length * 3;
                    if (zeroes.Length > 1) sum += zeroes.Length;
                }
                var OneMatch = reg1.Matches(group);
                foreach (Match ones in OneMatch)
                {
                    sum += ones.Length * 5;
                    if (ones.Length > 1) sum += ones.Length;
                }

                var letter = Convert.ToChar(sum);
                decriptedMessage.Append(letter);
                sum = 0;
            }
            Console.WriteLine(decriptedMessage);
        }
    }
}
