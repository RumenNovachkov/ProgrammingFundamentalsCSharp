using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = new Regex(@"(>)(?<strength>[0-9])+(?<string>[a-zA-Z]+)?\b");
            var line = Console.ReadLine();
            var prevPunch = 0;
            var punchesMatched = pattern.Matches(line);
            foreach (Match punch in punchesMatched)
            {
                var punchStrength = int.Parse(punch.Groups["strength"].ToString());
                var punchLength = (punch.Groups["strength"].ToString() + punch.Groups["string"].ToString()).Length;
                var punchPosition = line.IndexOf(punch.Groups["strength"].ToString());
                if (prevPunch > 0)
                {
                    punchStrength += prevPunch;
                    prevPunch = 0;
                }
                if (punchStrength < punchLength)
                {
                    line = line.Remove(punchPosition, punchStrength);
                }
                else if (punchStrength == punchLength)
                {
                    line = line.Remove(punchPosition, punchLength);
                }
                else
                {
                    line = line.Remove(punchPosition, punchLength);
                    prevPunch = punchStrength - punchLength;
                }
            }
            Console.WriteLine(line);
        }
    }
}
