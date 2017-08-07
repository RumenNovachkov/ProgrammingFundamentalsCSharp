using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var tolken = Console.ReadLine().Split().ToArray();
            var sum = 0;
            string firstWord = tolken[0];
            string secondWord = tolken[1];
            var minLength = Math.Min(firstWord.Length, secondWord.Length);
            var firstSubstring = firstWord.Substring(0, minLength);
            var secondSubstring = secondWord.Substring(0, minLength);
            //Console.WriteLine(firstSubstring);
            //Console.WriteLine(secondSubstring);
            var firstLeft = firstWord.Substring(minLength);
            var secondLeft = secondWord.Substring(minLength);
            //Console.WriteLine(firstLeft);
            //Console.WriteLine(secondLeft);
            for (int i = 0; i < minLength; i++)
            {
                sum += (int)firstSubstring[i] * (int)secondSubstring[i];
            };
            if (firstWord.Length != secondWord.Length)
            {
                foreach (var item in firstLeft)
                {
                    sum += (int)item;
                }
                foreach (var item in secondLeft)
                {
                    sum += (int)item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
