using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var mentorsDates = new SortedDictionary<string, List<DateTime>>();
            var mentorsComments = new Dictionary<string, List<string>>();

            var datesInput = Console.ReadLine();

            while (datesInput != "end of dates")
            {
                if (datesInput != "end of dates")
                {
                    var datasInputEdit = datesInput.Split(' ').ToArray();
                    var name = datasInputEdit[0];
                    if (datasInputEdit.Length > 1)
                    {

                        var datesList = datasInputEdit[1].Split(',').Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                        if (!mentorsDates.ContainsKey(name))
                        {
                            mentorsDates[name] = new List<DateTime>();
                        }
                        foreach (var date in datesList)
                        {
                            mentorsDates[name].Add(date);
                        }
                    }
                    else
                    {
                        if (!mentorsDates.ContainsKey(name))
                        {
                            mentorsDates[name] = new List<DateTime>();
                        }
                    }


                }
                datesInput = Console.ReadLine();
            }

            var commentsInput = Console.ReadLine();

            while (commentsInput != "end of comments")
            {
                if (commentsInput != "end of comments")
                {
                    var commentsInputEdit = commentsInput.Split('-').ToArray();
                    var name = commentsInputEdit[0];
                    var comment = commentsInputEdit[1];

                    if (!mentorsComments.ContainsKey(name))
                    {
                        mentorsComments[name] = new List<string>();
                    }
                    mentorsComments[name].Add(comment);
                }
                commentsInput = Console.ReadLine();
            }

            foreach (var mentor in mentorsDates)
            {
                Console.WriteLine(mentor.Key);
                Console.WriteLine("Comments:");
                foreach (var mentorComment in mentorsComments)
                {
                    if (mentorComment.Key == mentor.Key)
                        foreach (var comment in mentorComment.Value)
                        {
                            Console.WriteLine($"- {comment}");
                        }
                }
                Console.WriteLine("Dates attended:");
                foreach (var mentorDate in mentor.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {mentorDate.Day:d2}/{mentorDate.Month:d2}/{mentorDate.Year}");
                }
            }
        }
    }
}
