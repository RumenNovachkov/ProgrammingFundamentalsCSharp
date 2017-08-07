using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            long max = 0;
            long min = 0;

            switch (idType)
            {
                case "sbyte": max = sbyte.MinValue; min = sbyte.MaxValue; break;
                case "int": max = int.MinValue; min = int.MaxValue; break;
                case "long": max = long.MinValue; min = long.MaxValue; break;
                default: break;
            }

            for (int numID = 0; numID < n; numID++)
            {
                long identNum = long.Parse(Console.ReadLine());
                if (identNum >= max && identNum <= min) max = identNum;
            }
            double count = 0;

            if (max > 0) count = ((double)max / sbyte.MaxValue);
            else count = ((double)max / sbyte.MinValue);

            count = Math.Abs(count);
            count = Math.Ceiling(count);

            if (count > 1) Console.WriteLine($"Prisoner with id {max} is sentenced to {count} years");
            else Console.WriteLine($"Prisoner with id {max} is sentenced to {count} year");

        }
    }
}
