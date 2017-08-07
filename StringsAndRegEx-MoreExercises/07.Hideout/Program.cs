using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = Console.ReadLine();
            var i = 0;

            while (i != 3)
            {
                var tolken = Console.ReadLine().Split(' ').ToArray();
                var symbolToChar = Convert.ToChar(tolken[0]);
                var lengthOfTolken = int.Parse(tolken[1]);
                var regex = (((@"\b(?<string>(\") + tolken[0] + ("{") + tolken[1] + (@",9999}))\b")));

                var matchClue = Regex.Match(map, regex);

                if (matchClue.Success)
                {
                    var stringLength = matchClue.Groups["string"].ToString().Length;
                    Console.WriteLine($"Hideout found at index {map.IndexOf(new string(symbolToChar, lengthOfTolken))} and it is with size {stringLength}!");
                    break;
                }
                else
                {
                    i = 1;
                }
                i++;
            }
        }
    }
}
