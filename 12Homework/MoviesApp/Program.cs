using MoviesApp.Entities;
using MoviesApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = MovieHelper.Top10Movies();
            //*1 Find all movies that their titles starts with "L"
            var moviesStartingWithL = movies.Where(movie => movie.Title.StartsWith('L')).ToList();

            if (moviesStartingWithL.Count > 0)
            {
                Console.WriteLine("Movies starting with L are:");
                foreach (var movie in moviesStartingWithL)
                {
                    Console.WriteLine(movie.Title);
                }

            }
            else
                Console.WriteLine("Sorry, There are no movies starting with L.\n");
            //*2 Find the NUMBER of movies that have rating higher than 7.5

            var moviesWithHigerRating = movies.Where(movie => movie.Rating > 7.5).ToList().Count();
            Console.WriteLine($"There are {moviesWithHigerRating} movies with a rating higher than 7.5.");

            //*3 Find all movies TITLES with year of production before 2005
            var oldMovies = movies.Where(movie => movie.Year < 2005).Select(movie => movie.Title).ToList();
            Console.WriteLine("\nOlder than 2005 are:");
            foreach (var movie in oldMovies)
            {
                Console.WriteLine(movie);
            }



            //*4 Find all movies TITLES and RATING that have rating higher then 8.0
            var titlesAndRatingsMovies = movies.Where(movie => movie.Rating > 8).Select(movie => new { movie.Title, movie.Rating }).ToList();
            Console.WriteLine("\nHigher than 8 rating:");
            foreach (var movie in titlesAndRatingsMovies)
            {
                Console.WriteLine(movie);
            }

            //*5 Find first 5 movies that have duration time longer then 2 hours
            var firstFiveLobgerThanTwo = movies.Where(movie => movie.Duration > 120).Take(5).ToList();
            Console.WriteLine("\nThe first fove movies that a longer than 2 hours are:");
            foreach (var movie in firstFiveLobgerThanTwo)
            {
                Console.WriteLine(movie.Title);
            }


            //*6 Find last 3 movies TITLES and DURATION that have duration less then 2 hours

            var shortmOVIES = movies.Where(MOVIE => MOVIE.Duration < 120).Select(movie => new { movie.Title, movie.Duration}).TakeLast(3).ToList();
            Console.WriteLine("\nThe last 3 movies with less than 120 minutes duration are:");
            shortmOVIES.ForEach(movie => Console.WriteLine(movie));


          
            //*7 Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed
            var orderedMoviesDUr = movies.OrderByDescending(duration => duration.Duration).Select(movie => new { movie.Title, movie.Rating }).ToList();
            Console.WriteLine("\nDesendig durastion:");
            orderedMoviesDUr.ForEach(movie => Console.WriteLine(movie));
           
            

            //8 *Find all movies with TITLES that don't start with A and TITLES include more than 7 characters
            var allMoviesWithA = movies.Where(movie => !movie.Title.StartsWith('A')).Where(movie => movie.Title.Count() > 7).Select(movie => new {movie.Title, movie.Duration, movie.Rating, movie.Year }).ToList();
            Console.WriteLine("\n888Dont start with A:");
            allMoviesWithA.ForEach(movie => Console.WriteLine(movie));

            //9* Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour
            //  and 50min

            var iNeedSleep = movies.Where(movie => movie.Rating > 7.2 && movie.Duration < 110).Select(movie => movie.Rating).ToList();
            Console.WriteLine("\nFind all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour");
            iNeedSleep.ForEach(movieRating => Console.WriteLine(movieRating));

            //10 *Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            //  longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)


            var lastAllMovies = movies.Where(movie => movie.Title.Length < 10)
                .Where(movie => movie.Duration > 60)
                .Where(movie => movie.Rating > 6.7)
                .Select(movie => new { movie.Title, movie.Rating })
                .OrderBy(title => title)
                .ToList();
            Console.WriteLine("\nLetssee:");
            lastAllMovies.ForEach(movie => Console.WriteLine(movie));
            Console.WriteLine("greetings");
            Console.ReadLine();
        }
    }
}
