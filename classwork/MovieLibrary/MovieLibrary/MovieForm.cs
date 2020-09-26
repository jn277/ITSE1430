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
//namespace MovieLibrary
//{
//    namespace WinformsHost
//    {
//    }
//}
//namespace Company.Product.<area>
//namespace Microsoft.Office.Word
//namespace Microsoft.Office.Excel

namespace MovieLibrary.WinformsHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
            // Type = Movie
            // Variable = movie
            // Value = instance or an objecteLibrary 0

            Movie movie;
            movie = new Movie();   //Create an instance ::=  new T()

            //label2.Text = "A label";

            //var movie2 = new Movie();  //New instance

            //member access operator ::=   E . M
            movie.Name = "Bond";
            //var str = movie.description;
        }

    }
}

//namespace OtherNamespace
//{
//    public class MainForm
//    {
//    }
//}