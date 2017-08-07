using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;   
            while (true)
            {
                try
                {
                    n = Math.Abs(int.Parse(Console.ReadLine()));
                }
                catch
                {
                    n = 0;
                }
                if (n % 2 == 1)
                    break;
                Console.WriteLine("Please write an odd number.");
            }
            Console.WriteLine("The number is: " + n);
        }
    }
}
