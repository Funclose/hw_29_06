using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_29_06_1
{
    internal class Film : IDisposable
    {
        public List<string> FilmNames {  get; set; }
        public string NameStudio { get; set; }
        public string Genre { get; set; }
        public int DurationHour { get; set; }
        public int Year { get; set; }

        private bool _disposed = false;
        public Film(List<string> fileName, string nameStudio, string genre, int durationHour, int year)
        {
            FilmNames = fileName;
            NameStudio = nameStudio;
            Genre = genre;
            DurationHour = durationHour;
            Year = year;
        }

        public override string ToString() => $"Film: {FilmNames}, NameStudio: {NameStudio}, Genre: {Genre}, Duration: {DurationHour}, Year: {Year}";
        
            
        
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
                    FilmNames.Clear();
                }
            }
        }

        ~Film() 
        {
            Dispose(false);
        }
                    
                    
        
    }
}
