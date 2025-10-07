using oop_20251007_a_drivers_files_strings.Models;
using oop_20251007_a_drivers_files_strings.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings.RunDemos
{
    public static class MovieDriver
    {
        public static void Run()
        {
            Console.WriteLine("MovieDriver.Run() called");
            ShowMovieData();
        }

        public static void ShowMovieData()
        {
          
            List<Movie> movies = MovieRepository.GetAllMovies();
            // Display the list of movies
            Console.WriteLine("=== Movie List ===\n");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

    }
}
