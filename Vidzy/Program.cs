using System;
using System.Data.Entity;
using System.Linq;

namespace ChangingData
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            var videos = context.Videos.Include(v => v.Genre).ToList();

            foreach (var video in videos)
            {
                Console.WriteLine(video.Name);
                Console.WriteLine("\t" + video.Genre.Name);
            }

            Console.ReadLine();
        }
    }
}
