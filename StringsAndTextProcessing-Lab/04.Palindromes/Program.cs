using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new[] { ' ', '!', '.', ',', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var palindroms = new List<string>();

            foreach (var word in text)
            {
                if (word == string.Join("", word.ToCharArray().Reverse()))
                {
                    palindroms.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindroms.OrderBy(x => x).Distinct()));
        }
    }
}
