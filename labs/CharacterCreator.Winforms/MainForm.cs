/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
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

using CharacterCreator.Winforms;
namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        private string _lstCharacterName;
        public MainForm()
        {
            InitializeComponent();

            _miFileExit.Click +=_miFileExit_Click; 
            _miHelpAbout.Click += _miHelpAoout_Click;
            _miCharacterNew.Click += _miCharacterNew_Click;
            _miCharacterEdit.Click += _miCharacterEdit_Click;
            _miCharacterDelete.Click += _miCharacterDelete_Click;
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            int count = RefreshUI();
            if (count == 0)
            {
                if (MessageBox.Show(this, "No characters found. Do you want to add some example characters?", "Database Empty", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //_lstCharacters.Seed();

                    //RefreshUI();
                };
            };
        }

        private void _miFileExit_Click ( object sender, EventArgs e )
        {
            Close();
        } 
        private void _miHelpAoout_Click ( object sender, EventArgs e )
        {
            var form = new AboutBox1();
            var result = form.ShowDialog(this);

                return;
        }
        private void _miCharacterNew_Click ( object sender, EventArgs e )
        {
            var form = new NewCharacter();
            var result = form.ShowDialog(this);

            if (result == DialogResult.OK)
                return;
            else
            Close();
        }

        private void _miCharacterEdit_Click ( object sender, EventArgs e )
        {
            var form = new NewCharacter();
            var result = form.ShowDialog(this);

            if (result == DialogResult.OK)
                return;
            else
                Close();
        }

        private void _miCharacterDelete_Click ( object sender, EventArgs e )
        {
            var form = new NewCharacter();
            var result = form.ShowDialog(this);

            MessageBox.Show("Do you want to delete this character?,", _lstCharacterName);
            if (result == DialogResult.OK)
                //public void Delete ( int id );
                return;
            else
            Close();
        }

        private int RefreshUI ()
        {
            var selectedItem = _lstCharacters.SelectedItem;
            System.Collections.Generic.IEnumerable<NewCharacter> newCharacters = (IEnumerable<NewCharacter>)_lstCharacters;

            var items = newCharacters.ToArray();

            _lstCharacters.DataSource  = items;

            return items.Length;

        }

    }
}
