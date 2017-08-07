using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool drd = Convert.ToBoolean(word);
            if (drd == true) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
