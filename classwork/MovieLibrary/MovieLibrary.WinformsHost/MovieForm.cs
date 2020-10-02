/*
 * ITSE 1430
 * Donald Helaire
 * Classwork
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hierarchical namesapces
namespace MovieLibrary.WinformsHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        //Method - function inside a class
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        //Event handler - handles an event
        //  This method is handling the button's Click event
        //     void identifier ( object sender, EventArgs e )
        private void OnSave ( object sender, EventArgs e )
        {
            // I want the button that was clicked
            //Type casting
            // WRONG: var button = (Button)sender;  // C-style cast - crashes if wrong
            //var str = (string)10;
            // CORRECT: var button = sender as Button;  // as operator - always safe
            var button = sender as Button;
            if (button == null)
                return;

            var movie = new Movie();
            movie.Name = _txtName.Text;
            movie.Description = _txtDescription.Text;
            movie.Rating = _comboRating.SelectedText;
            movie.IsClassic = _chkIsClassic.Checked;

            movie.RunLength = ReadAsInt32(_txtRunLength);  //this.ReadAsInt32
            movie.ReleaseYear = ReadAsInt32(_txtReleaseYear);
            //var nameLength1 = 50;

            //TODO: Fix validation
            //var error = movie.Validate();
            //if (!String.IsNullOrEmpty(error))
            //{
                //Show error message - use for standard messages
                //MessageBox.Show(this, error, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //DialogResult = DialogResult.None;
                //return;
            //};
            Close();
            //TODO: Return movie

        }

        private int ReadAsInt32 ( Control control )
        {
            var text = control.Text;

            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }
    }
}


//namespace OtherNamespace
//{
//    public class MainForm
//    {
//    }
//}