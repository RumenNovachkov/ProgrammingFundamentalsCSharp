using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSym = int.Parse(Console.ReadLine());
            var secondSym = int.Parse(Console.ReadLine());

            char firstChar = Convert.ToChar(firstSym);
            char secondChar = Convert.ToChar(secondSym);

            for (char i = firstChar; i <= secondChar; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
