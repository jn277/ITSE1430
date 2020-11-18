/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;

namespace CharacterCreator.Memory
{
    public class MemoryCharacterDatabase : CharacterDatabase
    {
        protected override Movie AddCore ( Movie movie )
        {
            var item = CloneMovie(movie);

            item.Id = _id++;

            _movies.Add(item);

            movie.Id = item.Id;
            return movie;
        }

        protected override void DeleteCore ( int id )
        {
            var movie = FindById(id);
            if (movie != null)
            {
                _movies.Remove(movie);
            };

        }
        protected override IEnumerable<Movie> GetAllCore ()
        {
            foreach (var movie in _movies)   
                yield return CloneMovie(movie);
        protected override Movie GetByIdCore ( int id )
        {
            var movie = FindById(id);

            return (movie != null) ? CloneMovie(movie) : null;
        }
        protected override Movie GetByName ( string name )
        {
            foreach (var movie in _movies)
            {
                if (String.Compare(movie.Name, name, true) == 0)
                    return CloneMovie(movie);
            };

            return null;
        }
        protected override void UpdateCore ( int id, Movie movie )
        {
            var existing = FindById(id);

            CopyMovie(existing, movie);

        private Movie CloneMovie ( Movie movie )
        {
            var item = new Movie();
            item.Id = movie.Id;

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

        private Movie FindById ( int id )
        {
            foreach (var movie in _movies)
            {
                if (movie?.Id == id)                 
                    return movie;
            };

            return null;
        }

        private List<Movie> _movies = new List<Movie>(); 
        private int _id = 1;
    }
}
