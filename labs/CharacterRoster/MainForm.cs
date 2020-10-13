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
        public MainForm()
        {
            InitializeComponent();

            _miFileExit.Click +=_miFileExit_Click; 
            _miHelpAbout.Click += _miHelpAoout_Click;
            _miCharacterNew.Click += _miCharacterNew_Click;

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
            else
            MessageBox.Show("About closed");
            Close();
        }

        private void _miCharacterNew_Click ( object sender, EventArgs e )
        {
            var form = new _newCharacter();

            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
                return;
            else
            Close();
        }
    }
}
