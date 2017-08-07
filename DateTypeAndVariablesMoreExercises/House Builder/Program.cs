using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstPrice = long.Parse(Console.ReadLine());
            long secondPrice = long.Parse(Console.ReadLine());
            long roof = 0;
            long walls = 0;

            if (firstPrice > sbyte.MaxValue)
            {
                roof = 4 * secondPrice;
                walls = 10 * firstPrice;
            }
            else 
            {
                roof = 4 * firstPrice;
                walls = 10 * secondPrice;
            }

            Console.WriteLine(roof + walls);
        }
    }
}
