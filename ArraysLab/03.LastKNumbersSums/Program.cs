﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var array = new long[n];
            array[0] = 1;

            for (int current = 1; current < n; current++)
            {
                var start = Math.Max(0, current - k);
                var end = current - 1;
                long sum = 0L;
                for (int i = start; i < n; i++)
                {
                    sum += array[i];
                }
                array[current] = sum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
