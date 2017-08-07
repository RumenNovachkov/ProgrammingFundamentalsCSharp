using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var price = 0;

            if (typeDay == "Weekday")
            {
                if (age <= 18) price = 12;
                else if (age <= 64) price = 18;
                else if (age <= 122) price = 12;
            }
            else if (typeDay == "Weekend")
            {
                if (age <= 18) price = 15;
                else if (age <= 64) price = 20;
                else if (age <= 122) price = 15;
            }
            else if (typeDay == "Holiday")
            {
                if (age <= 18) price = 5;
                else if (age <= 64) price = 12;
                else if (age <= 122) price = 10;
            }

            if (age < 0 || age > 122) Console.WriteLine("Error!");
            else Console.WriteLine($"{price}$");
        }
    }
}
