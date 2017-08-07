using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            GetMax(firstNum, secondNum, thirdNum);
        }

        static void GetMax(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum >= secondNum && firstNum >= thirdNum) Console.WriteLine(firstNum);
            else if (secondNum >= firstNum && secondNum >= thirdNum) Console.WriteLine(secondNum);
            else if (thirdNum >= firstNum && thirdNum >= secondNum) Console.WriteLine(thirdNum);
        }
    }
}
