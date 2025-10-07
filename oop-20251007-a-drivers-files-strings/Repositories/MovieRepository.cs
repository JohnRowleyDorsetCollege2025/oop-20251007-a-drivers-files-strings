using oop_20251007_a_drivers_files_strings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings.Repositories
{
    public static class MovieRepository
    {
      
        public static List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Inception", "Christopher Nolan", 2010, "Sci-Fi", 8.8),
                new Movie("The Shawshank Redemption", "Frank Darabont", 1994, "Drama", 9.3),
                new Movie("The Dark Knight", "Christopher Nolan", 2008, "Action", 9.0),
                new Movie("Interstellar", "Christopher Nolan", 2014, "Sci-Fi", 8.6),
                new Movie("The Godfather", "Francis Ford Coppola", 1972, "Crime", 9.2)
            };

            return movies;
        }
    }
}
