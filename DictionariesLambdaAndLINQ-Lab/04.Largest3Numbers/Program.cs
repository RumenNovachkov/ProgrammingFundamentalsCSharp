using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .OrderByDescending(n => n)
                            .Take(3);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
