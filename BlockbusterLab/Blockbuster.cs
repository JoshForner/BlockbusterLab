using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {

        
        public static List<Movie> movie = new List<Movie>()
        {
            new VHS("The Sandlot", "Drama", 90),
            new VHS("Bambi", "Romance", 85),
            new VHS("The Shining", "Horror", 130),
            new DVD("Dumb and Dumber", "Comedy", 80),
            new DVD("Finding Nemo", "Drama", 120),
            new DVD("Die Hard", "Action", 95)
        };

        public static void PrintMovies()
        {
            for (int i = 0; i < movie.Count; i++)
            {
                Console.WriteLine($"{ i + 1}. {movie[i].Title}");
            }
        }

        public static int CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Select the number of the movie you would like to watch");
            int choice = int.Parse(Console.ReadLine());
            movie[choice-1].PrintInfo();
            return choice;
        }
    }

    
}
