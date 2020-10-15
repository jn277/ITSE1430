using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public class MovieDatabase
    {
        public Movie Add ( Movie movie, out string error )
        {
            error = "";
            //Find first empty spot in array
            // for ( EI; EC; EU ) S;
            //     EI ::= initializer expression (runs once before loop executes)
            //     EC ::= conditional expression => boolean (executes before loop statement is run, aborts if condition is false
            //     EU ::= update expression (runs at end of current iteration)
            // Length -> int (# of rows in the array)
            for (var index = 0; index < _movies.Length; ++index)
            {
                // Array element access ::=  V[int]
                if (_movies[index] == null)
                {
                    var item = CloneMovie(movie);
                    //Set a unique ID
                    item.Id = _id++;

                    //Add movie to array
                    _movies[index] = item;

                    //Set ID on original object and return
                    movie.Id = item.Id;
                    return movie;
                };
            };
            error = "No more room";
            return null;
            //TODO: No more room
        }

        public void Delete ( int id )
        {
            for (var index = 0; index < _movies.Length; ++index)
            {
                // Array element access ::=  V[int]
                //if (_movies[index] != null && _movies[index].Id == id)
                if (_movies[index]?.Id == id)  // null conditional ?. if instance != null access the member
                {
                    _movies[index] = null;
                    return;
                };
            };
        }

        public Movie[] GetAll ()
        {
            return _movies;
        }

        public Movie Get ( int id )
        {
            // foreach (var id in array) S
            //for (var index = 0; index < _movies.Length; ++index)
            foreach (var movie in _movies)
            {
                //movie == _movies[index]
                // Restrictions:
                //   1. movie is readonly   // movie = new Movie();
                //   2. _movies cannot change, immutable 
                if (movie?.Id == id)  // null conditional ?. if instance != null access the member                
                    return CloneMovie(movie);
            };
            return null;

        }
        public string Update ( int id, Movie movie )
        {
            //TODO: Validate Id
            // Movie exists
            var existing = Get(id);
            if (existing == null)
                return "Movie not found";

            for (var index = 0; index < _movies.Length; ++index)
            {
                if (_movies[index]?.Id == id)  // null conditional ?. if instance != null access the member
                {
                    //Clone it so we separate our value from argument
                    var item = CloneMovie(movie);

                    item.Id = id;
                    _movies[index] = item;
                    return "";
                };
            };
            // Cannot find movie
            return "";
            //TODO: Cannot find movie
        }

        private Movie CloneMovie ( Movie movie )
        {
            var item = new Movie();
            item.Id = movie.Id;
            item.Name = movie.Name;
            item.Rating = movie.Rating;
            item.ReleaseYear = movie.ReleaseYear;
            item.RunLength = movie.RunLength;
            item.IsClassic = movie.IsClassic;
            item.Description = movie.Description;

            return item;
        }

        private Movie[] _movies = new Movie[100];  //0..99
        private int _id = 1;
    }
}
