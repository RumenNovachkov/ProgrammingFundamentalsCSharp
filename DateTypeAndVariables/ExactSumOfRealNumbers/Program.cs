﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                sum += (decimal)num;
            }
            Console.WriteLine(sum);
        }
    }
}
