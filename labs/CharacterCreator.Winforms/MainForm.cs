/*
 * ITSE 1430
 * Donald Helaire
 * Lab3
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
        private void _miFileExit_Click ( object sender, EventArgs e )
        {
            Close();
        } 
        private void _miHelpAoout_Click ( object sender, EventArgs e )
        {
            var form = new _about();

            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
                return;
            //else
            //MessageBox.Show("About closed");
            //Close();
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
            if (result == DialogResult.OK)
                return;
            else
                MessageBox.Show("Do you want to delete this character?,", _lstCharacterName);
            Close();
        }
    }
}
