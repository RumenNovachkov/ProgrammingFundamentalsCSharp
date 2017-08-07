using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var regex = ("(\\b)(?<text>(") + word + (")?([\\w-!@#$%^&*(){} ,:;'`~=+\"|\\[\\]/]+) (") + word + (")* ([\\w- !@#$%^&*(){}';:`~=+|\\\"/\\[\\]]+))([!.?])");
            var text = Console.ReadLine();

            var matches = Regex.Matches(text, regex)
                .Cast<Match>()
                .Select(x => x.Groups["text"])
                .ToArray();

            foreach (var sentence in matches)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
