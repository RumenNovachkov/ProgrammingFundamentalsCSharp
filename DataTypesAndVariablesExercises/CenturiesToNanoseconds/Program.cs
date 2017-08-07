using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes = 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000 microseconds = 3155673600000000000 nanoseconds
            var centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            decimal days = years * 365.2422m;
            uint hours = (uint)days * 24;
            long minutes = (long)hours * 60;
            long seconds = minutes * 60;
            ulong milliseconds = (ulong)seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {Math.Floor(days)} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            //Console.WriteLine(years);
            //Console.WriteLine(days);
            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);
            //Console.WriteLine(seconds);
            //Console.WriteLine(milliseconds);
            //Console.WriteLine(microseconds);
            //Console.WriteLine(nanoseconds);
        }
    }
}
