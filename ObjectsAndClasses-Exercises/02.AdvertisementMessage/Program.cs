using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of its category.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can’t live without this product.";

            string[] events = new string[7];
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles.";
            events[3] = "I am happy of the results!";
            events[4] = "I cannot believe but now I feel awesome.";
            events[5] = "Try it yourself, I am very satisfied.";
            events[6] = "I feel great!";

            string[] authors = new string[8];
            authors[0] = "Diana";
            authors[1] = "Petya";
            authors[2] = "Stella";
            authors[3] = "Elena";
            authors[4] = "Katya";
            authors[5] = "Iva";
            authors[6] = "Annie";
            authors[7] = "Eva";

            string[] cities = new string[5];
            cities[0] = "Burgas";
            cities[1] = "Sofia";
            cities[2] = "Plovdiv";
            cities[3] = "Varna";
            cities[4] = "Ruse";

            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                var phrasesRandom = random.Next(0, 6);
                var eventsRandom = random.Next(0, 7);
                var authorRandom = random.Next(0, 8);
                var citiesRandom = random.Next(0, 5);

                Console.WriteLine($"{phrases[phrasesRandom]} {events[eventsRandom]} {authors[authorRandom]} - {cities[citiesRandom]}");
            }
        }
    }
}
