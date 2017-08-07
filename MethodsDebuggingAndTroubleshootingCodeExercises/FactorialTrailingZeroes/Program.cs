using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = GetFactorial(n);
            //string str = Convert.ToString(result);
            int zeroes = FindZeroes(result);
            Console.WriteLine(zeroes);
        }
        private static BigInteger GetFactorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static int FindZeroes(BigInteger result)
        {
            int zeroes = 0;
            BigInteger currentNum = result;
            while (result > 0)
            {
                currentNum = result % 10;
                if (currentNum % 10 == 0)
                {
                    zeroes++;
                }
                else if (currentNum % 10 != 0)
                {
                    return zeroes;
                }
                result /= 10;
            }
            return zeroes;
        }
            
    }
}
