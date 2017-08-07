using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            while (text != "end")
            {
                var regex = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replacment = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, regex, replacment);
                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
