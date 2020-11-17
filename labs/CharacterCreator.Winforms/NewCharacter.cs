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

            public virtual NewCharacter character { get; set; }
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

                NewCharacter.CharacterName = _txtCharacterName.Text;
                NewCharacter.Profession = _comboProfession.SelectedText;
                NewCharacter.Race = _comboRace.SelectedText;
                NewCharacter.Attributes = _txtAttributes.Text;
                NewCharacter.Description = _txtDescription.Text;

                
                var character = new NewCharacter.TryValidateFullObject(this.character);
                if (character.Count() > 0)
                {
                    var builder = new System.Text.StringBuilder();
                    foreach (var result in NewCharacter.CharacterRoster)
                    {
                        builder.AppendLine(result.ToString());
                    };

                    MessageBox.Show(this, builder.ToString(), "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                };
                Close();
            }
            private void OnValidateCharacterName ( object sender, CancelEventArgs e )
            {
                var control = sender as TextBox;

                if (String.IsNullOrEmpty(control.Text))
                {
                _errors.Equals(control, "Name is required");
                    e.Cancel = true;  
                } else
                {
                    _errors.Equals(control, "");
                };
            }

            private void OnValidateProfession ( object sender, CancelEventArgs e )
            {
                var control = sender as TextBox;

                if (String.IsNullOrEmpty(control.Text))
                {
                    _errors.Equals(control, "Profession is required");
                    e.Cancel = true; 
                } else
                {
                    _errors.Equals(control, "");
                };
            }
            private void OnValidateRace ( object sender, CancelEventArgs e )
            {
                var control = sender as TextBox;

                if (String.IsNullOrEmpty(control.Text))
                {
                    _errors.Equals(control, "Race is required");
                    e.Cancel = true; 
                } else
                {
                    _errors.Equals(control, "");
                };
            }
            private void OnValidateAttributes ( object sender, CancelEventArgs e )
            {
                var control = sender as TextBox;

                if (String.IsNullOrEmpty(control.Text))
                {
                    _errors.Equals(control, "Attribute is required");
                    e.Cancel = true; 
                } else
                {
                    _errors.Equals(control, "");
                };
            }

            private void OnValidateDescription ( object sender, CancelEventArgs e )
            {
                var control = sender as TextBox;

                if (String.IsNullOrEmpty(control.Text))
                {
                    _errors.Equals(control, "Description is required");
                    e.Cancel = true; 
                } else
                {
                    _errors.Equals(control, "");
                };
            }

        private class TryValidateFullObject
        {
            private NewCharacter character;

            public TryValidateFullObject ( NewCharacter character )
            {
                this.character=character;
            }

            internal int Count ()
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class _errors
    {
    }

    internal class ObjectValidator
    {
        public ObjectValidator ()
        {
        }

        internal object TryValidateFullObject ( NewCharacter character )
        {
            throw new NotImplementedException();
        }
    }
}

    
