using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var namePrice = new Dictionary<string, double>();
            var nameQuantity = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "stocked")
            {
                string[] takeInput = input.Split(' ').ToArray();
                string name = takeInput[0];
                double price = double.Parse(takeInput[1]);
                int quantity = int.Parse(takeInput[2]);

                if (!namePrice.ContainsKey(name) && !nameQuantity.ContainsKey(name))
                {
                    namePrice[name] = price;
                    nameQuantity[name] = quantity;
                }
                else
                {
                    namePrice[name] = price;
                    nameQuantity[name] += quantity;
                }
                input = Console.ReadLine();
            }
            var nameTotal = new Dictionary<string, double>();
            foreach (var item in namePrice)
            {
                nameTotal[item.Key] = Math.Round((item.Value * nameQuantity[item.Key]), 2);
            }
            var total = 0.0;
            foreach (var item in nameTotal)
            {
                total += item.Value;
            }

            foreach (var item in namePrice)
            {
                Console.WriteLine($"{item.Key}: ${item.Value:f2} * {nameQuantity[item.Key]} = ${nameTotal[item.Key]:f2}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
