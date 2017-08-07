using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = Console.ReadLine();
            if (variable == "int")          Console.WriteLine(GetMaxInt(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            else if (variable == "char")    Console.WriteLine(GetMaxChar(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
            else if (variable == "string")  Console.WriteLine(GetMaxString(Console.ReadLine(), Console.ReadLine()));
        }

        private static int GetMaxInt(int v1, int v2)
        {
            if (v1 > v2) return v1;
            else return v2;
        }
        private static char GetMaxChar(char v1, char v2)
        {
            if (v1 > v2) return v1;
            else return v2;
        }

        private static string GetMaxString(string v1, string v2)
        {
            if (v1.CompareTo(v2) >= 0) return v1;
            else return v2;
        }
    }
}
