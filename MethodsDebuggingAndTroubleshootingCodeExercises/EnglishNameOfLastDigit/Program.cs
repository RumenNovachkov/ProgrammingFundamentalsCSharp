using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            GetLastDigitOnEnglish(number);
        }

        static void GetLastDigitOnEnglish(long number)
        {
            var resultDigit = Math.Abs(number) % 10;
            if (resultDigit == 1) Console.WriteLine("one");
            else if (resultDigit == 2) Console.WriteLine("two");
            else if (resultDigit == 3) Console.WriteLine("three");
            else if (resultDigit == 4) Console.WriteLine("four");
            else if (resultDigit == 5) Console.WriteLine("five");
            else if (resultDigit == 6) Console.WriteLine("six");
            else if (resultDigit == 7) Console.WriteLine("seven");
            else if (resultDigit == 8) Console.WriteLine("eight");
            else if (resultDigit == 9) Console.WriteLine("nine");
            else if (resultDigit == 0) Console.WriteLine("zero");
        }
    }
}
