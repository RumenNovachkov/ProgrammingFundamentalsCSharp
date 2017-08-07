using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _06.BookLibraryModification
{
    class Program
    {
        public class Library
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime Date { get; set; }
            public long ISBN { get; set; }
            public double Price { get; set; }
        }
        static void Main(string[] args)
        {
            var numOfInputs = int.Parse(Console.ReadLine());

            var books = new List<Library>();

            for (int i = 0; i < numOfInputs; i++)
            {
                var initialData = Console.ReadLine().Split(' ').ToArray();

                var cuurentBook = new Library();
                cuurentBook.Title = initialData[0];
                cuurentBook.Author = initialData[1];
                cuurentBook.Publisher = initialData[2];
                cuurentBook.Date = DateTime.ParseExact(initialData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                cuurentBook.ISBN = long.Parse(initialData[4]);
                cuurentBook.Price = double.Parse(initialData[5]);

                books.Add(cuurentBook);
            }

            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var RelesedDate = new Dictionary<string, DateTime>();

            foreach (var book in books)
            {
                if (book.Date > data)
                {
                    RelesedDate[book.Title] = book.Date;
                }
            }

            foreach (var book in RelesedDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                string format = "dd/MM/yyyy";
                Console.WriteLine("{0} -> {1}.{2:d2}.{3}", book.Key, book.Value.Day, book.Value.Month, book.Value.Year);
            }
        }
    }
}
