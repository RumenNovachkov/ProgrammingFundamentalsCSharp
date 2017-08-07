using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double num = Convert.ToDouble(input);

            if (num % 1 == 0)
            {
                BigInteger number = (BigInteger)num;
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue) Console.WriteLine("Sunny");
                else if (number >= int.MinValue && number <= int.MaxValue) Console.WriteLine("Cloudy");
                else if (number >= long.MinValue && number <= long.MaxValue) Console.WriteLine("Windy");
            }
            else Console.WriteLine("Rainy");
        }
    }
}
