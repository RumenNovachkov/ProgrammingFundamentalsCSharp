using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = arr.Length;
            if (n == 1) Console.WriteLine($"{{ {arr[0]} }}");
            else if (n % 2 == 0)
            {
                Console.WriteLine($"{{ {arr[(arr.Length / 2) - 1]}, {arr[(arr.Length / 2)]} }}");
            }
            else Console.WriteLine($"{{ {arr[(arr.Length / 2) - 1]}, {arr[arr.Length / 2]}, {arr[(arr.Length / 2) + 1]} }}");
        }
    }
}
