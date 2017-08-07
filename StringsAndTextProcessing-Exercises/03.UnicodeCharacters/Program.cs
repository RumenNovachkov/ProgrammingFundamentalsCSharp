using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            var unicode = new List<string>();
            foreach (var @char in text)
            {
                unicode.Add(GetEscapeSequence(@char).ToLower());
            }
            Console.WriteLine(string.Join("", unicode));
        }

        private static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
