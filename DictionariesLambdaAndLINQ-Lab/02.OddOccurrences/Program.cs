using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                            .ToLower()
                            .Split(' ')
                            .ToList();

            var words = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (!words.ContainsKey(word))
                {
                    words[word] = 0;
                }

                words[word]++;
            }

            var newList = new List<string>();

            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    newList.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
