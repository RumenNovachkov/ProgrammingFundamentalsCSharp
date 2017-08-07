using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<username>[a-zA-Z]{5,})@(?<domain>(([a-z]{3,})\.((org)|(bg)|(com))))\b");
            var n = int.Parse(Console.ReadLine());
            var domainsList = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                var email = Console.ReadLine();
                var matchEmail = regex.Match(email);
                var domain = matchEmail.Groups["domain"].ToString();
                var user = matchEmail.Groups["username"].ToString();
                if (domain != string.Empty)
                {
                    if (!domainsList.ContainsKey(domain))
                    {
                        domainsList[domain] = new HashSet<string>();
                    }
                    domainsList[domain].Add(user);
                }

            }
            foreach (var domain in domainsList.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");
                foreach (var mail in domain.Value)
                {
                    Console.WriteLine($"### {mail}");
                }
            }
        }
    }
}
