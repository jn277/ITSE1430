﻿using System;
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
    public partial class NewCharacter : Form
    {
        private static string CharacterName;
        private static string Profession;
        private static string Race;
        private static string Attributes;
        private static string Description;
        private static string CharacterRoster;
        private object _lstCharacters;

        public NewCharacter ()
        {
            InitializeComponent();
        }

        public NewCharacter ( NewCharacter character ) : this()
        {
            
        }

        public NewCharacter character { get; set; }
        protected override void OnLoad ( EventArgs e )
        {       
            base.OnLoad(e);

            if (character!= null)
            {
                _txtCharacterName.Text = NewCharacter.CharacterName;
                _comboProfession.SelectedText = NewCharacter.Profession;
                _comboRace.SelectedText = NewCharacter.Race;
                _txtAttributes.Text = NewCharacter.Attributes;
                _txtDescription.Text = NewCharacter.Description;
                _lstCharacters = NewCharacter.CharacterRoster;
            };
        }
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnSave ( object sender, EventArgs e )
        {

        }

        private static void Validate ( object sender, CancelEventArgs e, bool error )
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                error.ToString();
                e.Cancel=true;
            } else
            { 
                var dialogResult = MessageBox.Show("Save Failed");
            }
        }

     }
 }
    
