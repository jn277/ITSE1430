/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MovieLibrary.Sql
{
    public class SqlMovieDatabase : MovieDatabase
    {
        public SqlMovieDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;
        protected override Movie AddCore ( Movie movie )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "AddMovie";
                command.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter("@name", movie.Name);
                command.Parameters.Add(parmName);

                var parmDescription = command.CreateParameter();
                parmDescription.ParameterName = "@description";
                parmDescription.Value = movie.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parmDescription);

                command.Parameters.AddWithValue("@rating", movie.Rating);
                command.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                command.Parameters.AddWithValue("@runLength", movie.RunLength);
                command.Parameters.AddWithValue("@isClassic", movie.IsClassic);

                object result = command.ExecuteScalar();
                var id = Convert.ToInt32(result);

                movie.Id = id;
                return movie;
            };
        }
        protected override void DeleteCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "DeleteMovie";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            };
        }
        protected override IEnumerable<Movie> GetAllCore ()
        {
            var ds = new DataSet();

            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("GetMovies", connection);
                command.CommandType = CommandType.StoredProcedure;
             
                var da = new SqlDataAdapter() {
                    SelectCommand = command
                };
                da.Fill(ds);
            };

            var table = ds.Tables.Count > 0 ? ds.Tables[0] : null;
            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    yield return new Movie() {
                        Id = Convert.ToInt32(row[0]),
                        Name = row["name"].ToString(),

                        Description = row.Field<string>("description"),
                        Rating = row.Field<string>("Rating"),

                        ReleaseYear = row.Field<int>("ReleaseYear"),
                        RunLength = row.Field<int>("RunLength"),
                        IsClassic = row.Field<bool>("IsClassic"),
                    };
                };
            };
        }

        protected override Movie GetByIdCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "GetMovie";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var movieId = reader.GetInt32(0);
                        if (movieId == id)
                        {
                            return new Movie() {
                                Id = movieId,
                                Name = reader.GetString(1),
                                Description = reader.GetString(2),
                                Rating = reader.GetFieldValue<string>(3),
                                ReleaseYear = reader.GetFieldValue<int>(4),
                                RunLength = reader.GetFieldValue<int>(5),
                                IsClassic = reader.GetFieldValue<bool>(6)
                            };
                        };
                    };
                };
            };

            return null;
        }
        protected override Movie GetByName ( string name )
        {
            var movies = GetAllCore();
            foreach (var movie in movies)
            {
                if (String.Compare(movie.Name, name, true) == 0)
                    return movie;
            };

            return null;
        }
        protected override void UpdateCore ( int id, Movie movie )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "UpdateMovie";
                command.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter("@name", movie.Name);
                command.Parameters.Add(parmName);

                var parmDescription = command.CreateParameter();

                parmDescription.ParameterName = "@description";
                parmDescription.Value = movie.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;

                command.Parameters.Add(parmDescription);
                command.Parameters.AddWithValue("@rating", movie.Rating);
                command.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                command.Parameters.AddWithValue("@runLength", movie.RunLength);
                command.Parameters.AddWithValue("@isClassic", movie.IsClassic);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            };
        }

        private SqlConnection OpenConnection ()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}


