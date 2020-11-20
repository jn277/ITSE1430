/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;

namespace MovieLibrary
{
    public interface IMovieDatabase
    {
        Movie Add ( Movie movie );
        void Delete ( int id );
        Movie Get ( int id );
        IEnumerable<Movie> GetAll ();
        void Update ( int id, Movie movie );
    }
}