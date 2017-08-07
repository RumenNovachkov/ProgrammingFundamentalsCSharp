using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWord = Console.ReadLine();
            var text = Console.ReadLine();

            if (text.Contains(bannedWord))
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                Console.WriteLine(text);
            }
        }
    }
}
