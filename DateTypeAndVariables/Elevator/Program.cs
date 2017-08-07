using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfPeople = int.Parse(Console.ReadLine());
            var capacityOfTheLift = int.Parse(Console.ReadLine());
            var courses = 0;

            courses = (numOfPeople / capacityOfTheLift);
            if (numOfPeople % capacityOfTheLift != 0) courses += 1;
            else courses = courses;
            Console.WriteLine(courses);

        }
    }
}
