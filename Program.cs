namespace hw_29_06_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("второе задание");
            List<string> actors = new List<string>
            {
                "actor1",
                "actor2",
                "actor2"
            };

            using (Perfomance perfomance = new Perfomance("crow", "National", " Drama", 3, actors))
            {
                perfomance.DisplayInfo();
            }

            try
            {
                using (Perfomance performance = new Perfomance("Macbeth", "National Theater", "Tragedy", 2, actors))
                {
                    performance.DisplayInfo();
                }
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine(ex.Message);
            }








            Console.WriteLine("первое задание");
            Console.WriteLine("=============================================");
            

            List<string> FilmName = new List<string>
            {
                "film1",
                "film2",
                "film3"
            };

            foreach (var filmName in FilmName)
            {
                Console.WriteLine($"-  {filmName}");
            }
            using (Film name = new Film(FilmName, "mystudio", "genre", 4, 1955))
            {
                name.ToString();
            }

            using (Film name = new Film(FilmName, "mys", "gen", 2, 1935))
            {
                name.ToString();
            }

        }
    }
}
