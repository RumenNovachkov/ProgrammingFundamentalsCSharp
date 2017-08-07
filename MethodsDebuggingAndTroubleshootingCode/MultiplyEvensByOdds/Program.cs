using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(n)); 
            
        }
        static int GetMultipleOfEvensAndOdds(int n)
        {
            var evenSum = EvenSum(n);
            var oddSum = OddSum(n);
            return evenSum * oddSum;
        }
        static int EvenSum(int n)
        {
            var evenSum = 0;
            var currentNumber = 0;
            while (n > 0)
            {
                currentNumber = n % 10;
                n /= 10;
                if (currentNumber % 2 == 0) evenSum += currentNumber;
            }
            return evenSum;

        }
        static int OddSum(int n)
        {
            var oddSum = 0;
            var currentNumber = 0;
            while (n > 0)
            {
                currentNumber = n % 10;
                n /= 10;
                if (currentNumber % 2 != 0) oddSum += currentNumber;
            }
            return oddSum;

        }
    }
}
