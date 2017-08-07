using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var sum = 0;
            var value = arr[0];
            sum += value;
            var position = 0;

            while (true)
            {
                if (value < (arr.Length - position))
                {
                    position += value;
                    value = arr[position];
                    sum += value;
                }
                else if (value < position)
                {
                    position -= value;
                    value = arr[position];
                    sum += value;
                }
                else
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
