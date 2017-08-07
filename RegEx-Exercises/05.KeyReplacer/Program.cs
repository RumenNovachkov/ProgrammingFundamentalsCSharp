using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindingKeyStrings
            var keyString = Console.ReadLine();
            var regexKey = new Regex(@"(?<startKey>[A-Za-z]+)([\|\\\<])(.*?)([\|\\\<])(?<endKey>[a-zA-Z]+)");
            var matchedKeys = regexKey.Match(keyString);
            var startKey = matchedKeys.Groups["startKey"];
            var endKey = matchedKeys.Groups["endKey"];

            //FindingTextStrings
            var regexText = new Regex($"({startKey})(?<text>[A-Za-z]*?)({endKey})");
            var textString = Console.ReadLine();

            var matchedText = regexText.Matches(textString).Cast<Match>().Select(x => x.Groups["text"]);

            var result = new StringBuilder();

            foreach (var text in matchedText)
            {
                result.Append(text);
            }
            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else Console.WriteLine(result.ToString());
        }
    }
}
