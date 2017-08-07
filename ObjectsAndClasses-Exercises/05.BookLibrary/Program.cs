using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
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

            var authorsList = new Dictionary<string, double>();

            foreach (var book in books)
            {
                if (!authorsList.ContainsKey(book.Author))
                {
                    authorsList[book.Author] = book.Price;
                }
                else
                {
                    authorsList[book.Author] += book.Price;
                }
            }

            foreach (var author in authorsList.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
