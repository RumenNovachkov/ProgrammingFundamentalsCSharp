using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string sequence = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            string text = "";

            if (sequence == "even")
            {
                for (int i = 1; i <= n; i++)
                {
                    string word = Console.ReadLine();
                    if (i % 2 == 0)
                    {
                        text += word + Convert.ToString(delimiter);
                    }
                }
            }
            if (sequence == "odd")
            {
                for (int i = 1; i <= n; i++)
                {
                    string word = Console.ReadLine();
                    if (i % 2 != 0)
                    {
                        text += word + Convert.ToString(delimiter);
                    }
                }
            }

            text = text.Remove(text.Length -1);
            Console.WriteLine(text);
        }
    }
}
