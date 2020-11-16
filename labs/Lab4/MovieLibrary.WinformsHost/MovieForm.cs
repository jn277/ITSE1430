/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace MovieLibrary.WinformsHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        public MovieForm ( Movie movie ) : this(movie, null)
        {

        }
        public MovieForm ( Movie movie, string title ) : this()
        {
            Movie = movie;
            Text = title ?? "Add Movie";
        }
        public virtual Movie Movie { get; set; }
        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            if (Movie != null)
            {
                _txtName.Text = Movie.Name;
                _txtDescription.Text = Movie.Description;
                _comboRating.SelectedText = Movie.Rating;
                _chkIsClassic.Checked = Movie.IsClassic;
                _txtRunLength.Text = Movie.RunLength.ToString();
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
            };

            ValidateChildren();
        }
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            };

            var button = sender as Button;
            if (button == null)
                return;

            var movie = new Movie();
            movie.Name = _txtName.Text;
            movie.Description = _txtDescription.Text;
            movie.Rating = _comboRating.SelectedText;
            movie.IsClassic = _chkIsClassic.Checked;

            movie.RunLength = ReadAsInt32(_txtRunLength);
            movie.ReleaseYear = ReadAsInt32(_txtReleaseYear);

            var descriptionLength = movie.MaximumDescriptionLength;

            var validationResults = ObjectValidator.TryValidateFullObject(movie);
            if (validationResults.Count() > 0)
            {
                var builder = new System.Text.StringBuilder();
                foreach (var result in validationResults)
                {
                    builder.AppendLine(result.ErrorMessage);
                };
                MessageBox.Show(this, builder.ToString(), "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            };
            Movie = movie;
            Close();
        }

        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidateRunLength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            if (value < 0)
            {
                _errors.SetError(control, "Run length must be >= 0");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidateReleaseYear ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            if (value < 1900)
            {
                _errors.SetError(control, "Release Year must be >= 1900");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private int ReadAsInt32 ( Control control )
        {
            var text = control.Text;

            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }

        private void PlayWithObjects ( object value )
        {
            var str = 10.ToString();
            var form = new Form();
            form.ToString();

            string stringValue = (string)value;

            stringValue = value as string;
            if (stringValue  != null)
            {
            }

            var isString = value is string;
            if (isString)
            {
                stringValue = (string)value;
            }

            if (value is string sValue)
            {
            }
            stringValue = stringValue ?? "";
            stringValue = stringValue?.ToString() ?? "";
        }
    }
}



