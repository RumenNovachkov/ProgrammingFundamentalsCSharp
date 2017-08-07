using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPrices = int.Parse(Console.ReadLine());
            double limits = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPrices - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double difference = CalcPercents(last, price);
                bool isSignificantDifference = CheckForDifference(difference, limits);
                Console.WriteLine(PrintMessage(price, last, difference, isSignificantDifference));
                last = price;
            }
        }
        private static string PrintMessage(double price, double last, double difference, bool etherTrueOrFalse)
        {
            string to = "";
            if (difference == 0)                                to = string.Format("NO CHANGE: {0}", price);
            else if (!etherTrueOrFalse)                         to = string.Format("MINOR CHANGE: {0} to {1} ({2:f2}%)", last, price, difference * 100);
            else if (etherTrueOrFalse && (difference > 0))      to = string.Format("PRICE UP: {0} to {1} ({2:f2}%)", last, price, difference * 100);
            else if (etherTrueOrFalse && (difference < 0))      to = string.Format("PRICE DOWN: {0} to {1} ({2:f2}%)", last, price, difference * 100);
            return to;
        }
        private static bool CheckForDifference(double granica, double isDiff)
        {
            if (Math.Abs(granica) >= isDiff) return true;
            return false;
        }
        private static double CalcPercents(double last, double price)
        {
            double res = (price - last) / last;
            return res;
        }
    }
}
