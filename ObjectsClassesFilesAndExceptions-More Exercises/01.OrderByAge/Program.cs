using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OrderByAge
{
    class Program
    {
        public class Persons
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var dataInput = Console.ReadLine();

            var newPersons = new List<Persons>();

            while (dataInput != "End")
            {
                if (dataInput != "End")
                {
                    var infoSplit = dataInput.Split().ToArray();
                    var name = infoSplit[0];
                    var idNumber = infoSplit[1];
                    var age = int.Parse(infoSplit[2]);
                    Persons eachPerson = new Persons();
                    eachPerson.Name = name;
                    eachPerson.ID = idNumber;
                    eachPerson.Age = age;

                    newPersons.Add(eachPerson);
                }

                dataInput = Console.ReadLine();
            }

            foreach (var person in newPersons.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
