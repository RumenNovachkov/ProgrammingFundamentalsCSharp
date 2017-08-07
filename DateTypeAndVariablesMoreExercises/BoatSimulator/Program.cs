using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startFirstBoat = char.Parse(Console.ReadLine());
            char startSecondBoat = char.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var firstBoat = 0;
            var seconBoat = 0;
            bool drd = true;

            for (int i = 1; i <= n; i++)
            {
                string move = Console.ReadLine();
                if (move == "UPGRADE")
                {
                    startFirstBoat += (char)3;
                    startSecondBoat += (char)3;
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        firstBoat += move.Length;
                        if (firstBoat >= 50)
                        {
                            Console.WriteLine(startFirstBoat);
                            break;
                        }
                    }
                    else if (i % 2 == 0)
                    {
                        seconBoat += move.Length;
                        if (seconBoat >= 50)
                        {
                            Console.WriteLine(startSecondBoat);
                            break;
                        }
                    }
                }
                if (firstBoat < 50 && seconBoat < 50 && i == n) drd = false;
            }
            if (drd == false)
            {
                if (firstBoat > seconBoat) Console.WriteLine(startFirstBoat);
                else Console.WriteLine(startSecondBoat);
            }
        }
    }
}
