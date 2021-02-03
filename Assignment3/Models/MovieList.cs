using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public static class MovieList
    {
        private static List<NewMovieResponse> movies = new List<NewMovieResponse>();

        //Enumerate a list
        public static IEnumerable<NewMovieResponse> Movies => movies;
        
        public static void AddMovie(NewMovieResponse movie)
        {
            movies.Add(movie);
        }
    }
}
