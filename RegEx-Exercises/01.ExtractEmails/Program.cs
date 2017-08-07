using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";
            var textInput = Console.ReadLine();
            var emails = Regex.Matches(textInput, regex);

            var matchedEmails = emails
                .Cast<Match>()
                .Select(em => em.Value.Trim())
                .ToArray();

            foreach (var email in matchedEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
