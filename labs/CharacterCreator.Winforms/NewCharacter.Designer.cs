namespace CharacterCreator.Winforms
{
    partial class NewCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelProfession = new System.Windows.Forms.Label();
            this.LabelRace = new System.Windows.Forms.Label();
            this.LabelAttributes = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this._txtCharacterName = new System.Windows.Forms.TextBox();
            this._txtAttributes = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(25, 27);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // LabelProfession
            // 
            this.LabelProfession.AutoSize = true;
            this.LabelProfession.Location = new System.Drawing.Point(24, 74);
            this.LabelProfession.Name = "LabelProfession";
            this.LabelProfession.Size = new System.Drawing.Size(56, 13);
            this.LabelProfession.TabIndex = 1;
            this.LabelProfession.Text = "Profession";
            // 
            // LabelRace
            // 
            this.LabelRace.AutoSize = true;
            this.LabelRace.Location = new System.Drawing.Point(23, 164);
            this.LabelRace.Name = "LabelRace";
            this.LabelRace.Size = new System.Drawing.Size(33, 13);
            this.LabelRace.TabIndex = 2;
            this.LabelRace.Text = "Race";
            // 
            // LabelAttributes
            // 
            this.LabelAttributes.AutoSize = true;
            this.LabelAttributes.Location = new System.Drawing.Point(22, 262);
            this.LabelAttributes.Name = "LabelAttributes";
            this.LabelAttributes.Size = new System.Drawing.Size(51, 13);
            this.LabelAttributes.TabIndex = 3;
            this.LabelAttributes.Text = "Attributes";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(21, 298);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(60, 13);
            this.LabelDescription.TabIndex = 4;
            this.LabelDescription.Text = "Description";
            // 
            // _comboProfession
            // 
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._comboProfession.Location = new System.Drawing.Point(148, 71);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(121, 21);
            this._comboProfession.TabIndex = 1;
            // 
            // _comboRace
            // 
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Half Elf",
            "Gnome",
            "Human"});
            this._comboRace.Location = new System.Drawing.Point(147, 164);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(121, 21);
            this._comboRace.TabIndex = 2;
            // 
            // _txtCharacterName
            // 
            this._txtCharacterName.Location = new System.Drawing.Point(148, 27);
            this._txtCharacterName.Name = "_txtCharacterName";
            this._txtCharacterName.Size = new System.Drawing.Size(120, 20);
            this._txtCharacterName.TabIndex = 0;
            // 
            // _txtAttributes
            // 
            this._txtAttributes.Location = new System.Drawing.Point(149, 259);
            this._txtAttributes.Name = "_txtAttributes";
            this._txtAttributes.Size = new System.Drawing.Size(120, 20);
            this._txtAttributes.TabIndex = 3;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(149, 295);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(290, 20);
            this._txtDescription.TabIndex = 4;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(287, 385);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 5;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(384, 384);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 6;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtAttributes);
            this.Controls.Add(this._txtCharacterName);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelAttributes);
            this.Controls.Add(this.LabelRace);
            this.Controls.Add(this.LabelProfession);
            this.Controls.Add(this.LabelName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelProfession;
        private System.Windows.Forms.Label LabelRace;
        private System.Windows.Forms.Label LabelAttributes;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.TextBox _txtCharacterName;
        private System.Windows.Forms.TextBox _txtAttributes;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
    }
}