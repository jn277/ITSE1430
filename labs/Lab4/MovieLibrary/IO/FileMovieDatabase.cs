/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace MovieLibrary.IO
{
    public class FileMovieDatabase : MovieDatabase
    {
        public FileMovieDatabase ( string filename )
        {
            _filename = filename;
        }

        private readonly string _filename;

        /// <inheritdoc />
        protected override Movie AddCore ( Movie movie )
        {
            var movies = GetAllCore();

            var items = new List<Movie>(movies);

            var lastId = 0;
            foreach (var item in items)
            {
                if (item.Id > lastId)
                    lastId = item.Id;
            };
            movie.Id = ++lastId;
            items.Add(movie);

            SaveMovies(items);
            return movie;
        }

        protected override void DeleteCore ( int id )
        {
            var tempFilename = _filename + ".bak";

            using (Stream stream = File.OpenRead(_filename))
            using (var reader = new StreamReader(stream))
            {
                using (var writer = new StreamWriter(tempFilename, false))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var movie = LoadMovie(line);

                        if (movie?.Id != id)
                            writer.WriteLine(line);
                    };
                }; 
            };  

            File.Copy(tempFilename, _filename, true);
            File.Delete(tempFilename);
        }
        protected override IEnumerable<Movie> GetAllCore ()
        {
            if (File.Exists(_filename))
            {
                string[] lines = File.ReadAllLines(_filename);
                foreach (var line in lines)
                {
                    var movie = LoadMovie(line);
                    if (movie != null)
                        yield return movie;
                };
            };
        }
        protected override Movie GetByIdCore ( int id )
        {
            return FindById(id);
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
            var items = new List<Movie>(GetAllCore());
            foreach (var item in items)
            {
                if (item.Id == id)
                {
                    items.Remove(item);
                    break;
                };
            };
            movie.Id = id;
            items.Add(movie);
            SaveMovies(items);
        }

        private Movie FindById ( int id )
        {
            Stream stream = File.OpenRead(_filename);  

            try
            {
                StreamReader reader = new StreamReader(stream); 

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var movie = LoadMovie(line);
                    if (movie?.Id == id)
                        return movie;
                };
                return null;
            }  
            finally
            {
                stream.Close();
            };
        }

        private Movie LoadMovie ( string line )
        {
            string[] tokens = line.Split(',');
            if (tokens.Length != 7)
                return null;

            var movie = new Movie() {
                Id = Int32.Parse(tokens[0]),
                Name = RemoveQuotes(tokens[1]),
                Description = RemoveQuotes(tokens[2]),
                Rating = RemoveQuotes(tokens[3]),
                RunLength = Int32.Parse(tokens[4]),
                ReleaseYear = Int32.Parse(tokens[5]),
                IsClassic = Int32.Parse(tokens[6]) != 0,
            };

            return movie;
        }

        private string EncloseQuotes ( string value )
        {
            return "\"" + value + "\"";
        }

        private string RemoveQuotes ( string value )
        {
            return value.Trim('"');
        }

        private void SaveMovies ( IEnumerable<Movie> movies )
        {
            var lines = new List<string>();
            foreach (var movie in movies)
                lines.Add(SaveMovie(movie));

            File.WriteAllLines(_filename, lines);
        }

        private string SaveMovie ( Movie movie )
        {
            var builder = new System.Text.StringBuilder();

            builder.AppendFormat($"{movie.Id},");
            builder.AppendFormat($"{EncloseQuotes(movie.Name)},");
            builder.AppendFormat($"{EncloseQuotes(movie.Description)},");
            builder.AppendFormat($"{EncloseQuotes(movie.Rating)},");
            builder.AppendFormat($"{movie.RunLength},");
            builder.AppendFormat($"{movie.ReleaseYear},");
            builder.AppendFormat($"{(movie.IsClassic ? 1 : 0)}");

            return builder.ToString();
        }
    }
}

