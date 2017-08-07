using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            string primeNum = "";
            primeNum += Convert.ToString(FindPrimesInRange(startNum, endNum));

        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var prime = (startNum > 1);
            for (int i = startNum; i <= Math.Sqrt(endNum); i++)
            {
                if (endNum % i != 0)
                {
                    return i;
                }

            }
            
        }
    }
}
