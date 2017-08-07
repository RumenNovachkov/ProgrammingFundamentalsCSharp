using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var jewelsPrice = prices[0];
            var goldPrice = prices[1];
            long jewelsCount = 0L;
            long goldCount = 0L;
            long expences = 0L;

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[1] != "Time")
                {
                    long eachExpence = long.Parse(input[1]);
                    if (input[0].Contains('%') || input[0].Contains('$'))
                    {
                        jewelsCount += CountTheLoot(input[0], '%');
                        goldCount += CountTheLoot(input[0], '$');
                        expences += eachExpence;
                    }
                    
                    else expences += eachExpence;
                }
                else if (input[0] == "Jail" && input[1] == "Time")
                {
                    break;
                }
            }
            var totalWon = (jewelsCount * jewelsPrice) + (goldCount * goldPrice);

            if (totalWon >= expences) Console.WriteLine($"Heists will continue. Total earnings: {totalWon - expences}.");
            else Console.WriteLine($"Have to find another job. Lost: {expences - totalWon}.");
        }

        static int CountTheLoot(string input, char symbol)
        {
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == symbol) count++;
            }
            return count;
        }
    }
}
