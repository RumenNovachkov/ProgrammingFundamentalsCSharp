using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());
            
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text.Contains("p"))
                {
                    hasMatch = true;
                }
                else
                {
                    Console.WriteLine("no");
                    return;
                }
                if (text[i] == 112)
                {
                    int endIndex = jump;

                    if (endIndex < text.Length - i)
                    {
                        endIndex = jump + 1;
                    }
                    else endIndex = text.Length - i;


                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += endIndex - 1;
                }
                else i+= 0;

            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
