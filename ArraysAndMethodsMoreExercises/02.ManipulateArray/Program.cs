using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
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
                    arr = newArr;
                }
                else if (newCommands == "Replace")
                {
                    arr[int.Parse(commands[1])] = commands[2];
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
