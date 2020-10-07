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

            //toolStripMenuItem2.Click += OnFileExit;
            //toolStripMenuItem4.Click += OnHelpAoout;
        }
        
    }

    //private void OnFileExit(object sender, EventArgs e)
    //{
        //var form = new MainForm();

        //var result = form.ShowDialog(this);
        //if(result == DialogResult.Cancel)
            //return;
        //MessageBox.Show("Exiting the menu.");
        
    //}
}
