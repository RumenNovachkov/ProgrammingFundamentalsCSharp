using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = string.Empty;
            decimal result = 0;
            List<decimal> output = new List<decimal>();
            while (opCode != "END")
            {
                if (opCode != string.Empty)
                {
                    string[] codeArgs = opCode.Split(' ');
                    switch (codeArgs[0])
                    {
                        case "INC":
                            {
                                result = decimal.Parse(codeArgs[1]);
                                result++;
                                break;
                            }
                        case "DEC":
                            {
                                result = decimal.Parse(codeArgs[1]);
                                result--;
                                break;
                            }
                        case "ADD":
                            {
                                decimal operandOne = decimal.Parse(codeArgs[1]);
                                decimal operandTwo = decimal.Parse(codeArgs[2]);
                                result = operandOne + operandTwo;
                                break;
                            }
                        case "MLA":
                            {
                                decimal operandOne = decimal.Parse(codeArgs[1]);
                                decimal operandTwo = decimal.Parse(codeArgs[2]);
                                result = operandOne * operandTwo;
                                break;
                            }
                    }
                    output.Add(result);
                }
                opCode = Console.ReadLine();
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}