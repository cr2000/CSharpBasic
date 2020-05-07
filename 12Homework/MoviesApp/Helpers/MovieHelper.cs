using MoviesApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesApp.Helpers
{
    public class MovieHelper
    {
        public static List<Movie> Top10Movies()
        {
            return new List<Movie>()
            {
                new Movie(){Title = "The Lord of the Rings: The Return of the King", Year = 2003, Rating = 8.9f, Duration = 201},
                new Movie(){Title = "The Matrix", Year = 1999, Rating = 8.7f, Duration = 136},
                new Movie(){Title = "Fight Club ", Year = 1999, Rating = 8.8f, Duration = 139},
                new Movie(){Title = "Interstellar ", Year = 2014, Rating = 8.6f, Duration = 169},
                new Movie(){Title = "The Prestige", Year = 2006, Rating = 8.5f, Duration = 130},
                new Movie(){Title = "The Usual Suspects", Year = 1995, Rating = 8.5f, Duration = 106},
                new Movie(){Title = "Alien", Year = 1976, Rating = 8.4f, Duration = 117},
                new Movie(){Title = "Eternal Sunshine of the Spotless Mind", Year = 2004, Rating = 8.3f, Duration = 108},
                new Movie(){Title = "American Beauty", Year = 1999, Rating = 8.3f, Duration = 122},
                new Movie(){Title = "Three Billboards Outside Ebbing, Missouri ", Year = 2017, Rating = 8.2f, Duration = 115}

            };
        }
    }
}
