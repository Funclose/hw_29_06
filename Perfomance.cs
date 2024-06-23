using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_29_06_1
{
    internal class Perfomance : IDisposable
    {
        public string Title {  get; set; }
        public string TheaterName { get; set; }

        public string Genre { get; set; }
        public int Duration { get; set; }
        public List<string> Actors { get; set; }


        private bool _disposed = false;

        public Perfomance(string title, string theaterName, string genre, int duration, List<string> actors)
        {
            Title = title;
            TheaterName = theaterName;
            Genre = genre;
            Duration = duration;
            Actors = actors;
            
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Theater Name: {TheaterName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {Duration}");
            Console.WriteLine("Actors: ");
            foreach (var actor in Actors)
            {
                Console.WriteLine($" - {actor}");
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Actors.Clear();
                }
            }
        }
        ~Perfomance() { Dispose(false); }
    }
}
