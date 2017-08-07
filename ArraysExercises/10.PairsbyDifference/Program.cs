using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsbyDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var diff = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int a = 0; a < sequence.Length; a++)
            {
                for (int b = 0; b < sequence.Length; b++)
                {
                    if (sequence[a] - sequence[b] == diff)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
