using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Program
    {
        public class Students
        {
            public string Name { get; set; }
            public List<double> Grade { get; set; }

            public double Average()
            {
                return Grade.Average();
            }
            public string PrintStudentsInfo()
            {
                return $"{Name} -> {Average():f2}";
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                var studentInput = Console.ReadLine().Split(' ');
                var studentName = studentInput[0];
                var studentGrade = studentInput.Skip(1).Select(double.Parse).ToList();

                var currentStudent = new Students();
                currentStudent.Name = studentName;
                currentStudent.Grade = studentGrade;

                students.Add(currentStudent);
            }

            foreach (var student in students.OrderBy(x => x.Name).ThenByDescending(x => x.Average()))
            {
                if (student.Average() >= 5)
                {
                    Console.WriteLine(student.PrintStudentsInfo());
                }
            }
        }
    }
}
