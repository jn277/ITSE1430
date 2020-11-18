/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MovieLibrary.Sql
{
    public class SQLCharactorDatabase : CharacterDatabase
    {
        public SQLCharactorDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        /// <inheritdoc />
        protected override Movie AddCore ( Movie movie )
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override void DeleteCore ( int id )
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override IEnumerable<Movie> GetAllCore ()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
            };

            return Enumerable.Empty<Movie>();
        }
        protected override Movie GetByIdCore ( int id )
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override Movie GetByName ( string name )
        {
            throw new NotImplementedException();
        }
        protected override void UpdateCore ( int id, Movie movie )
        {
            throw new NotImplementedException();
        }

        private Movie FindById ( int id )
        {
            throw new NotImplementedException();
        }
    }
}

