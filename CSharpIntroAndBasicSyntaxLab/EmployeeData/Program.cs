using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var identificationNumber = int.Parse(Console.ReadLine());
            var sallary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {identificationNumber:D8}");
            Console.WriteLine("Salary: {0:f2}", sallary);
        }
    }
}
