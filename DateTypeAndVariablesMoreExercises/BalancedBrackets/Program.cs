using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var bracketCounter = 0;
            bool result;
            bool closed = true;
            char bracket = '0';

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                result = Char.TryParse(input, out bracket);
                if (result == true)
                {
                    if (bracket == 40 || bracket == 41)     bracketCounter += Convert.ToInt32(bracket);
                    if (bracket == 40) closed = false;
                    else if (bracket == 41) closed = true;
                }
            }
            if (bracketCounter % 81 == 0 && closed == true) Console.WriteLine("BALANCED");
            else Console.WriteLine("UNBALANCED");
            
        }
    }
}
