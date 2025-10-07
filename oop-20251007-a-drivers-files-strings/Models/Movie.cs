using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20251007_a_drivers_files_strings.Models
{
    public class Movie
    {
        // Attributes (fields or properties)
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        // Constructor
        public Movie(string title, string director, int releaseYear, string genre, double rating)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        // Override ToString() to format the movie details
        public override string ToString()
        {
            return $"Title: {Title}\nDirector: {Director}\nYear: {ReleaseYear}\nGenre: {Genre}\nRating: {Rating}/10\n";
        }
    }
}
