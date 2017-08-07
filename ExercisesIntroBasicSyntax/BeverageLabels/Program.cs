using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var diff = (double)volume / 100;
            var totalEnergyContent = diff * energyContent;
            var totalSugarContent = diff * sugarContent;

            Console.Write($"{volume}ml");
            Console.WriteLine($" {name}:");
            Console.Write($"{totalEnergyContent}kcal, ");
            Console.WriteLine($"{totalSugarContent}g sugars");
        }
    }
}
