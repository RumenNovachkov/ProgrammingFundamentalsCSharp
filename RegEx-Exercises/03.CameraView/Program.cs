using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var skip = int.Parse(numbers[0]);
            var take = int.Parse(numbers[1]);
            var input = Regex.Matches(Console.ReadLine(), @"\|<[\\w]{" + $"{skip}" + @"}(?<town>[\w]{" + $"{take}" + @"})|\|<[\w]{" + $"{skip}" + @"}(?<town>[\w]+)").Cast<Match>().Select(a => a.Groups["town"].Value).ToArray();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
