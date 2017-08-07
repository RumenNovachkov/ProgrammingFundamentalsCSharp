using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PersonalException
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var n = uint.Parse(Console.ReadLine());
                    Console.WriteLine(n);
                }
                catch
                {
                    Console.WriteLine("My first exception is awesome!!!");
                    return;
                }
            }
        }
    }
}
