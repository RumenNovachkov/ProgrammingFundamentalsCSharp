using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();


            while (true)
            {
                string[] inputProduct = Console.ReadLine().Split();
                
                int productPosition = FindProductPosition(inputProduct, products);
                if (productPosition == -1 || inputProduct[0] == "done")
                {
                    break;
                }
                else if (productPosition >= quantity.Length)
                {
                    Console.WriteLine($"We do not have enough {products[productPosition]}");
                }

                else
                {
                    if (quantity[productPosition] >= long.Parse(inputProduct[1]))
                    {
                        Console.WriteLine($"{inputProduct[0]} x {inputProduct[1]} costs {(decimal.Parse(inputProduct[1]) * prices[productPosition]):f2}");
                        quantity[productPosition] -= long.Parse(inputProduct[1]);
                    }
                    else Console.WriteLine($"We do not have enough {inputProduct[0]}");

                }
            }
        }

        static int FindProductPosition(string[] inputProduct, string[] products)
        {
            var position = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (inputProduct[0] == products[i])
                {
                    return position = i;
                }

            }
            return position = -1;
        }
    }
}
