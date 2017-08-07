using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        public class Letters
        {
            public string FirstWordLetters { get; set; }

            public string SecondWordLetters { get; set; }
        }
        static void Main(string[] args)
        {
            var tolken = Console.ReadLine().Split().ToArray();
            var newCharList = new Dictionary<char, char>();
            var sideWord1 = string.Empty;
            var sideWord2 = string.Empty;
            var firstWord = tolken[0];
            var secondWord = tolken[1];

            var minLength = Math.Min(firstWord.Length, secondWord.Length);

            var longestWordLeft = firstWord.Length > secondWord.Length ? firstWord.Substring(minLength) : secondWord.Substring(minLength);
            var longestWord = string.Empty;
            if (firstWord.Length > secondWord.Length) longestWord = firstWord;
            else longestWord = secondWord;
            //Console.WriteLine(longestWord);
            //Console.WriteLine(longestWordLeft);

            var eachCouple = new Letters();

            for (int i = 0; i < minLength; i++)
            {
                eachCouple.FirstWordLetters += firstWord[i];
                eachCouple.SecondWordLetters += secondWord[i];
                newCharList[firstWord[i]] = secondWord[i];
            }
            sideWord1 = string.Join("", newCharList.Keys);
            sideWord2 = string.Join("", newCharList.Values);

            if (eachCouple.FirstWordLetters.IndexOf(sideWord1) >= 0 && eachCouple.SecondWordLetters.IndexOf(sideWord2) >= 0)
            {
                if (firstWord.Length != secondWord.Length)
                {
                    int a = longestWord.Replace(longestWordLeft, string.Empty).Length;
                    int b = longestWord.Distinct().Count();
                    //Console.WriteLine(a - b);
                    if (a == b)
                    {
                        Console.WriteLine("true");
                    }
                    else Console.WriteLine("false");
                }
                else Console.WriteLine("true");
            }
            else Console.WriteLine("false");
        }
    }
}
