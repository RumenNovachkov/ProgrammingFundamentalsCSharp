﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
