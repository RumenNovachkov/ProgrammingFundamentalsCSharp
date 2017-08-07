using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                bool isPalindrom = CheckForPalindrom(i);
                bool sumOfDigits = FindTheSumOfDigitsBy7(i);
                bool hasEvenDigit = FindEvenDigit(i);
                if (isPalindrom == true && sumOfDigits == true && hasEvenDigit == true)
                {
                    Console.WriteLine(i);
                }
            }  
        }

        static bool FindEvenDigit(int i)
        {
            int currentDigit = 0;
            while (i > 0)
            {
                currentDigit = i % 10;
                if (currentDigit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
            
        }

        static bool FindTheSumOfDigitsBy7(int i)
        {
            short sum = 0;
            while (i > 0)
            {
                sum += (short)(i % 10);
                i /= 10;
            }
            if (sum % 7 == 0) return true;
            else return false;
        }

        static bool CheckForPalindrom(int i)
        {
            //Turning to Char taking too much memory, not my code!
            string str = i.ToString();
            if (str.Length < 4 && str[0] == str[str.Length - 1])
            {
                return true;
            }
            else if (str.Length < 6 &&
                (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]))
            {
                return true;
            }
            else if (str.Length < 8 &&
               (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]
               && str[2] == str[str.Length - 3]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
