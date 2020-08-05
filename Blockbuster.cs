using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        List<Movie> Movies = new List<Movie>()
        {

            new DVD("Shrek 4: Shrek shows up", "Comedy", 180, new List<string>{ "shrek be shrekin", "shrek sings all star", "shrek gets paid"})
        };

        public virtual void PrintMovies()
        {
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(movie);
            }

        }
        public virtual void CheckOut()
        {
            PrintMovies();
            Console.WriteLine("What movie would you like to watch?");
        }
    }
}
