using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            var arrayLength = arr.Length - 1;

            do
            {
                string newCommands = string.Empty;
                string[] commands = Console.ReadLine().Split(' ');

                newCommands = commands[0];

                if (newCommands == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (newCommands == "Distinct")
                {
                    string[] newArr = arr.Distinct().ToArray();
                    arrayLength = newArr.Length - 1;
                    arr = newArr;
                    
                }
                else if (newCommands == "Replace")
                {
                    int position = int.Parse(commands[1]);
                    if (position < 0 || position > arrayLength)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }

                    else arr[int.Parse(commands[1])] = commands[2];
                }
                else if (newCommands == "END")
                {
                    Console.WriteLine(string.Join(", ", arr));
                    break;
                }
                else Console.WriteLine("Invalid input!");

            } while (true);

            
        }
    }
}
