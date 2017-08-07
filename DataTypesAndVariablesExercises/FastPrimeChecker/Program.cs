using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitNum = int.Parse(Console.ReadLine());
            for (int num = 2; num <= limitNum; num++)
            {
                bool checkIfPrime = true;
                for (int check = 2; check <= Math.Sqrt(num); check++)
                {
                    if (num % check == 0)
                    {
                        checkIfPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {checkIfPrime}");
            }

        }
    }
}
