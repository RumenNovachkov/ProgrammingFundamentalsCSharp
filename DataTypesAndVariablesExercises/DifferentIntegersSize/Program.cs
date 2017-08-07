using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            bool isSbyte = (-128 <= input) && (input <= 127);
            bool isByte = (0 <= input) && (input <= 255);
            bool isShort = (-32768 <= input) && (input <= 32767);
            bool isUshort = (0 <= input) && (input <= 65535);
            bool isInt = (-2147483648 <= input) && (input <= 2147483647);
            bool isUint = (0 <= input) && (input <= 4294967295);
            bool isLong = (-9223372036854775808 <= input) && (input <= 9223372036854775807);

            if (isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong)
            {
                Console.WriteLine("{0} can fit in:", input);
                if (isSbyte)    Console.WriteLine("* sbyte");
                if (isByte)     Console.WriteLine("* byte");
                if (isShort)    Console.WriteLine("* short");
                if (isUshort)   Console.WriteLine("* ushort");
                if (isInt)      Console.WriteLine("* int");
                if (isUint)     Console.WriteLine("* uint");
                if (isLong)     Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }

            //(sbyte -> -128 to 127)-
            //(byte -> 0 to 255)-
            //(short -> -32,768 to 32,767)-
            //(ushort -> 0 to 65,535)-
            //(int -> -2,147,483,648 to 2,147,483,647)-
            //(uint -> 0 to 4,294,967,295)-
            //(long -> -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)-
            //(ulong -> 0 to 18,446,744,073,709,551,615)*
        }
    }
}
