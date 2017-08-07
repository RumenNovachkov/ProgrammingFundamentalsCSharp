using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int tankLevel = 0;

            int numOfPouring = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfPouring; i++)
            {
                int input = int.Parse(Console.ReadLine());
                tankLevel += input;

                if (tankLevel > tankCapacity)
                {
                    tankLevel -= input;
                    Console.WriteLine("Insufficient capacity!");
                }

                if (i == numOfPouring) Console.WriteLine(tankLevel);
            }
        }
    }
}
