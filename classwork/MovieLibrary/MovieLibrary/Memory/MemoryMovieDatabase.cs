using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        //Default constructor to seed database

        public Movie Add ( Movie movie, out string error )
        {
            error = "";

            //Clone so argument can be modified without impacting our array
            var item = CloneMovie(movie);

            //Set a unique ID
            item.Id = _id++;

            //Add movie to array
            //_movies[index] = item;
            _movies.Add(item);

            //Set ID on original object and return
            movie.Id = item.Id;
            return movie;
            //return null;
            //TODO: No more room
        }

        public void Delete ( int id )
        {
            var movie = GetById(id);
            if (movie != null)
            {
                //Must use the same instance that is stored in the list so ref equality works
                _movies.Remove(movie);
            };
            //for (var index = 0; index < _movies.Length; ++index)
            //{
            // Array element access ::=  V[int]
            //if (_movies[index] != null && _movies[index].Id == id)
            //if (_movies[index]?.Id == id)  // null conditional ?. if instance != null access the member
            //{
            //_movies[index] = null;
            //return;
            //};
            //};
        }

        //Use IEnumerable<T> for readonly lists of items
        //public Movie[] GetAll ()
        public IEnumerable<Movie> GetAll ()
        {
            //TODO: Determine how many movies we're storing
            //For each one create a cloned copy
            //return _movies;
            //var items = new Movie[_movies.Count];
            //var index = 0;

            //iterator IEnumerable<T>
            //  yield return T
            foreach (var movie in _movies) // relies on IEnumerator<T>
                //items[index++] = CloneMovie(movie);
                yield return CloneMovie(movie);

            //return items;
        }


        public Movie Get ( int id )
        {
            var movie = GetById(id);

            //Clone movie if we found it
            return (movie != null) ? CloneMovie(movie) : null;
        }

        private Movie GetById ( int id )
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
                    return movie;
            };

            return null;
        }
        public string Update ( int id, Movie movie )
        {
            //TODO: Validate Id
            // Movie exists
            var existing = GetById(id);
            if (existing == null)
                return "Movie not found";

            // updated movie is valid
            // updated movie name is unique
            CopyMovie(existing, movie);

            //for (var index = 0; index < _movies.Length; ++index)
            //{
            //    if (_movies[index]?.Id == id)  // null conditional ?. if instance != null access the member
            //    {
            //        //Clone it so we separate our value from argument
            //        var item = CloneMovie(movie);

            //        item.Id = id;
            //        _movies[index] = item;
            //        return "";
            //    };
            //};
            return "";
        }

        private Movie CloneMovie ( Movie movie )
        {
            var item = new Movie();

            CopyMovie(item, movie);

            return item;
        }

        private void CopyMovie ( Movie target, Movie source )
        {
            target.Name = source.Name;
            target.Rating = source.Rating;
            target.ReleaseYear = source.ReleaseYear;
            target.RunLength = source.RunLength;
            target.IsClassic = source.IsClassic;
            target.Description = source.Description;
        }
        private List<Movie> _movies = new List<Movie>();  //Generic list of Movies, use for fields
        //private Collection<Movie> _temp;                  //Public read-writable lists
        private int _id = 1;
    }
}
