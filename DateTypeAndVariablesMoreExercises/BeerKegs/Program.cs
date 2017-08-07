using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var volume = 0.0;
            string winner = "";
            double max = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                volume = Math.PI * radius * radius * height;
                if (volume > max)
                {
                    max = volume;
                    winner = name;
                }
            }

            Console.WriteLine(winner);
        }
    }
}
