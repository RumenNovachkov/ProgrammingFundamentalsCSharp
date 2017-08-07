using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxnumbers = 0;
            int count = 1;
            int maxcount = 1;
            int position = 0;
            while (position < numbers.Count - 1)
            {

                if (numbers[position] == numbers[position + 1])
                {
                    count++;

                    if (count > maxcount)
                    {
                        maxcount = count;
                        maxnumbers = numbers[position];
                    }
                }
                else
                {
                    count = 1;
                }
                position++;
                if (maxcount == 1)
                {
                    maxnumbers = numbers[0];
                }
            }
            for (int i = 0; i < maxcount; i++)
            {
                Console.Write(maxnumbers);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
