/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace characterLibrary.Sql
{
    public class SQLCharactorDatabase : CharacterDatabase
    {
        public SQLCharactorDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        /// <inheritdoc />
        protected override character AddCore ( character character )
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override void DeleteCore ( int id )
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override IEnumerable<character> GetAllCore ()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
            };

            return Enumerable.Empty<character>();
        }
        protected override character GetByIdCore ( int id )
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override character GetByName ( string name )
        {
            throw new NotImplementedException();
        }
        protected override void UpdateCore ( int id, character character )
        {
            throw new NotImplementedException();
        }

        private character FindById ( int id )
        {
            throw new NotImplementedException();
        }
    }
}

