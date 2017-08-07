using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                int drn = rnd.Next(words.Length);
                var tempWord = words[drn];
                words[i] = tempWord;
                words[drn] = currentWord;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
