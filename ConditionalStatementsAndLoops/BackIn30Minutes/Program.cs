using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalTime = hours * 60 + minutes + 30;

            if (totalTime < 60) Console.WriteLine($"0:{totalTime}");
            else if (totalTime < 1440) Console.WriteLine("{0}:{1:D2}", (totalTime / 60), (totalTime % 60));
            else Console.WriteLine("0:{0:D2}", totalTime % 60);
        }
    }
}
