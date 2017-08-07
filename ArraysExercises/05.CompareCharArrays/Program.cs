using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            var shorterArrIs = Math.Min(arr1.Length, arr2.Length); 

            for (int i = 0; i < shorterArrIs; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    if (i == shorterArrIs - 1 && arr1.Length == arr2.Length)
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                    }
                    else if (i == shorterArrIs - 1 && arr1.Length < arr2.Length)
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                    }
                    else if (i == shorterArrIs - 1 && arr1.Length > arr2.Length)
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                    }
                    continue;
                }
                else if (char.Parse(arr1[i]) < char.Parse(arr2[i]))
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    return;
                }
                else if (char.Parse(arr2[i]) < char.Parse(arr1[i]))
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    return;
                }
                
            }
        }
    }
}
