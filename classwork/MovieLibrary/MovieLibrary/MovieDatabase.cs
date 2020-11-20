/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieLibrary
{
    public abstract class MovieDatabase : IMovieDatabase
    {
        public Movie Add ( Movie movie )
        {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));   
                ObjectValidator.ValidateFullObject(movie);

                var existing = GetByName(movie.Name);
            if (existing != null)
                throw new InvalidOperationException("Movie must be unique");
            try
            {
                return AddCore(movie);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Add Failed", e);
            };
        }
        public void Delete ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");      
            try
            {
                DeleteCore(id);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Delete Failed", e);
            };
        }
        public IEnumerable<Movie> GetAll ()
        {
            try
            {
                return GetAllCore();
            } catch (Exception e)
            {
                throw new InvalidOperationException("GetAll Failed", e);
            };
        }
        public Movie Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            try
            {
                return GetByIdCore(id);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Get Failed", e);
            };
        }
        public void Update ( int id, Movie movie )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            if (movie == null)
                throw new ArgumentNullException(nameof(movie));         
                ObjectValidator.ValidateFullObject(movie);
                var existing = GetByName(movie.Name);

            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Movie must be unique");          
            try
            {
                UpdateCore(id, movie);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Update Failed", e);
            };
        }
        protected abstract Movie AddCore ( Movie movie );

        protected abstract void DeleteCore ( int id );
        protected virtual Movie GetByName ( string name )
        {
            foreach (var movie in GetAll())
            {
                if (String.Compare(movie.Name, name, true) == 0)
                    return movie;
            };

            return null;
        }

        protected abstract IEnumerable<Movie> GetAllCore ();

        protected abstract Movie GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, Movie movie );
    }
}

