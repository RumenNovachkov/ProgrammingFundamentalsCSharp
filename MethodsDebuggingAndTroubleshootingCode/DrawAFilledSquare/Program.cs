using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeaderFooter(n);
            PrintBody(n);
            PrintHeaderFooter(n);
        }
        static void PrintBody(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < number - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
        static void PrintHeaderFooter(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}
