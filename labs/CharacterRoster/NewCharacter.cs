using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class _newCharacter : Form
    {
        public _newCharacter ()
        {
            InitializeComponent();
            //_txtCharacterName
            //_comboProfession
            //_comboRace
            //_txtAttributes
            //_txtDescription
            //_btnSave
            //_btnCancel
        }

        public _newCharacter ( Character character ) : this()
        {

        }

        //protected override void OnLoad ( EventArgs e )
        //{
            //Call the base member            
            //this.OnLoad(e);
            //base.OnLoad(e);

            //if (!= null)
            //{
            //_txtCharacterName = Movie.Name;
            //_txtDescription.Text = Movie.Description;
            //_comboRating.SelectedText = Movie.Rating;
            //_chkIsClassic.Checked = Movie.IsClassic;
            //_txtRunLength.Text = Movie.RunLength.ToString();
            //_txtReleaseYear.Text = Movie.ReleaseYear.ToString();
            //};
        //}
      }
 }
