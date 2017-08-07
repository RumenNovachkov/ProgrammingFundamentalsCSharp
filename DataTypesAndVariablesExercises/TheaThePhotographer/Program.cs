using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var allPhotos = int.Parse(Console.ReadLine());
            var editingTimeEach = int.Parse(Console.ReadLine());
            var percentsGoodPhotos = int.Parse(Console.ReadLine());
            var uploadingTimeEach = int.Parse(Console.ReadLine());

            var photosEditing = Math.Ceiling((double)percentsGoodPhotos * allPhotos / 100);
            //Console.WriteLine("Photos Editig: " + photosEditing);
            long totalSeconds = ((long)photosEditing * uploadingTimeEach) + ((long)editingTimeEach * allPhotos);
            //long totalSecondsFrom = totalSeconds;
            //Console.WriteLine("totalSeconds: " + totalSeconds);
            //days:24Hours:60Minutes:60Seconds
            long neededDays = totalSeconds / 86400;
            //Console.WriteLine("neededDays: " + neededDays);
            totalSeconds -= (neededDays * 86400);
            //Console.WriteLine("totalSeconds: " + totalSeconds);
            long neededHours = totalSeconds / 3600;
            //Console.WriteLine("neededHours: " + neededHours);
            totalSeconds -= (neededHours * 3600);
            //Console.WriteLine("totalSeconds: " + totalSeconds);
            long neededMinute = totalSeconds / 60;
            //Console.WriteLine("neededMinutes: " + neededMinute);
            totalSeconds -= (neededMinute * 60);
            //Console.WriteLine("totalSeconds: " + totalSeconds);
            long neededSeconds = totalSeconds;
            //Console.WriteLine("neededSeconds: " + neededSeconds);

            Console.WriteLine($"{neededDays}:{neededHours:d2}:{neededMinute:d2}:{neededSeconds:d2}");

            //TimeSpan time = TimeSpan.FromSeconds(totalSecondsFrom);
            //string neededTime = time.ToString(@"d\:hh\:mm\:ss");
            //Console.WriteLine(neededTime);

        }
    }
}
