using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sales = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(' ').ToArray();

                if (!sales.ContainsKey(entry[0]))
                {
                    sales[entry[0]] = double.Parse(entry[2]) * double.Parse(entry[3]);
                }
                else
                {
                    sales[entry[0]] += double.Parse(entry[2]) * double.Parse(entry[3]);
                }
            }

            foreach (var sale in sales)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }
    }
}
