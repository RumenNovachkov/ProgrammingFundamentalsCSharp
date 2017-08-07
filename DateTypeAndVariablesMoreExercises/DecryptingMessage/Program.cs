using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                symbol += (Char)key;
                message += Convert.ToString(symbol);
            }
            Console.WriteLine(message);
        }
    }
}
