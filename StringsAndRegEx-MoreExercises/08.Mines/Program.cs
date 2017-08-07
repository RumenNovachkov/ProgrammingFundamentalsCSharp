using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();
            int startIndex = 0;
            int endIndex = 0;

            while (((startIndex = path.IndexOf("<", startIndex)) != -1) &&
                ((endIndex = path.IndexOf(">", startIndex)) != -1))
            {
                string bombChars = path.Substring(startIndex + 1, 3);
                int mineStrength = CalculateMineStrength(bombChars);
                var leftFromTheBomb = Math.Max(0, startIndex - mineStrength);
                var rightFromTheBomb = Math.Min(path.Length - 1, endIndex + mineStrength);

                var sb = new StringBuilder(path);

                for (int i = leftFromTheBomb; i <= rightFromTheBomb; i++)
                {
                    sb[i] = '_';
                }

                path = sb.ToString();
            }
            Console.WriteLine(path);
        }

        private static int CalculateMineStrength(string bombChars)
        {
            var charsToArray = bombChars.ToCharArray();
            var firstChar = Convert.ToInt32(charsToArray[0]);
            var secondChar = Convert.ToInt32(charsToArray[1]);
            var strength = Math.Abs(firstChar - secondChar);
            return strength;
        }
    }
}
