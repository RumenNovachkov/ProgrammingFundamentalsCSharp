using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(x => x.Length == 2).ToList();
            var drdrdr = new List<string>();
            foreach (var item in input)
            {
                var drd = item.ToCharArray();
                var secondDig = drd[0];
                var firstDig = drd[1];
                string rdr = string.Concat(firstDig, secondDig);
                drdrdr.Add(rdr);
            }
            for (int i = 0; i < drdrdr.Count; i++)
            {
                input[i] = drdrdr[i];
            }
            input.Reverse();
            var decimalInput = new List<int>();
            foreach (var item in input)
            {
                decimalInput.Add(int.Parse(item, System.Globalization.NumberStyles.HexNumber));
            }
            string word = string.Empty;
            foreach (var item in decimalInput)
            {
                word += ((char)item);
            }
            Console.WriteLine(word);
        }
    }
}
