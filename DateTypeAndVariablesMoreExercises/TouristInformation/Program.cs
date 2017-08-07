using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine().ToLower();
            double input = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles": Console.WriteLine($"{input} {unit} = {(input * 1.6):f2} kilometers"); break;
                case "inches": Console.WriteLine($"{input} {unit} = {(input * 2.54):f2} centimeters"); break;
                case "feet": Console.WriteLine($"{input} {unit} = {(input * 30):f2} centimeters"); break;
                case "yards": Console.WriteLine($"{input} {unit} = {(input * 0.91):f2} meters"); break;
                case "gallons": Console.WriteLine($"{input} {unit} = {(input * 3.8):f2} liters"); break;
                default: break;
            }

        }
    }
}
