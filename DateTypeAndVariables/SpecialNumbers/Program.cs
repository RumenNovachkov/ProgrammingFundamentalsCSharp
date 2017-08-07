using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var specialNumSum = 0;
            var temporaryNum = 0;
            bool counter = true;


            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} -> ");
                specialNumSum = (i % 10) + ((i / 10) % 10) + ((i / 100) / 10);
                if (specialNumSum == 5 || specialNumSum == 7 || specialNumSum == 11) Console.WriteLine("True");
                else                                                                 Console.WriteLine("False");   
            }
        }
    }
}
