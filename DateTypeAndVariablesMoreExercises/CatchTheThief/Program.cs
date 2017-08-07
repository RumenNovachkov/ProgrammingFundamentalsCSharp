using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            BigInteger max = 0;
            BigInteger min = 0;

            switch (idType)
            {
                case "sbyte": max = sbyte.MinValue; min = sbyte.MaxValue; break;
                case "int": max = int.MinValue; min = int.MaxValue; break;
                case "long": max = long.MinValue; min = long.MaxValue; break;
                default: break;
            }

            for (int numID = 0; numID < n; numID++)
            {
                BigInteger identNum = BigInteger.Parse(Console.ReadLine());
                if (identNum >= max && identNum <= min)     max = identNum;
            }

            Console.WriteLine(max);   
        }
    }
}
