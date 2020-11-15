/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;    //DO NOT DELETE
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using MovieLibrary.Memory;


namespace MovieLibrary.WinformsHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

            Movie movie;
            movie = new Movie();   

            movie.Name = "Jaws";
            movie.Description = "Shark movie";

            _miMovieAdd.Click += OnMovieAdd;
            _miMovieEdit.Click += OnMovieEdit;
            _miMovieDelete.Click += OnMovieDelete;
            _miHelpAbout.Click += OnHelpAbout;
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            int count = RefreshUI();
            if (count == 0)
            {
                if (MessageBox.Show(this, "No movies found. Do you want to add some example movies?", "Database Empty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                    _movies.Seed();

                    RefreshUI();
                };
            };
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog(this);
        }

        private IMovieDatabase _movies = new Sql.SqlMovieDatabase(_connectionString);

        private const string _connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=MovieDb;Integrated Security=True;";

        private void AddMovie ( Movie movie )
        {
            _movies.Add(movie);

            RefreshUI();
        }

        private void DeleteMovie ( int id )
        {
            _movies.Delete(id);
            RefreshUI();
        }

        private void EditMovie ( int id, Movie movie )
        {
            _movies.Update(id, movie);
            RefreshUI();
        }

        private Movie GetSelectedMovie ()
        {
            return _lstMovies.SelectedItem as Movie;
        }

        private int RefreshUI ()
        {
            System.Collections.Generic.IEnumerable<Movie> movies = _movies.GetAll();

            var items = movies.ToArray();

            _lstMovies.DataSource  = items;           

            return items.Length;
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm();

            do
            {
                var result = form.ShowDialog(this);  
                if (result == DialogResult.Cancel)
                    return;           
                try
                {
                    AddMovie(form.Movie);
                    return;
                } catch (InvalidOperationException ex)
                {
                    MessageBox.Show(this, ex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (ArgumentException ex)
                {
                    MessageBox.Show(this, ex.Message, "Bad Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex) 
                {
                    MessageBox.Show(this, ex.Message, "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                };
            } while (true);
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            switch (MessageBox.Show(this, $"Are you sure you want to delete '{movie.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return;
            };

            try
            {
                DeleteMovie(movie.Id);
            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            var form = new MovieForm(movie, "Edit Movie");

            var result = form.ShowDialog(this); 
            if (result == DialogResult.Cancel)
                return;

            try
            {
                EditMovie(movie.Id, form.Movie);
            } catch (InvalidOperationException ex)
            {
                MessageBox.Show(this, ex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ArgumentException ex)
            {
                MessageBox.Show(this, ex.Message, "Bad Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            };
        }
    }
}

//namespace OtherNamespace
//{
//    public class MainForm
//    {
//    }
//}