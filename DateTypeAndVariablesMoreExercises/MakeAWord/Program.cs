using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word += Convert.ToString(symbol);
            }
            Console.WriteLine($"The word is: " + word);
        }
    }
}
