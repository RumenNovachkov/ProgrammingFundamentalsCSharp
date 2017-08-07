using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int rows = 1; rows <= initialNumber; rows++)
            {
                int currentNumber = rows;
                while (rows > 0)
                {
                    sum += rows % 10;
                    rows = rows / 10;
                }
                bool statement = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {statement}");
                sum = 0;
                rows = currentNumber;
            }

        }
    }
}
