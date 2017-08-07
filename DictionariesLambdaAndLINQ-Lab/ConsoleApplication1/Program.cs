using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();

            var upperCase = new List<string>();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].All(char.IsLower)) lowerCase.Add(list[i]);
                else if (list[i].All(char.IsUpper)) upperCase.Add(list[i]);
                else mixedCase.Add(list[i]);
            }


        }
    }
}
